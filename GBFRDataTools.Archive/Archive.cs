using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Hashing;
using System.Buffers.Binary;

using K4os.Compression.LZ4;
using FlatSharp;

using GBFRDataTools.FlatBuffers;

using System.Buffers;

namespace GBFRDataTools.Archive;

public class DataArchive : IDisposable
{
    public IndexFile Index { get; private set; }
    public Dictionary<string, int> ExternalFilesHashTable { get; } = [];
    public Dictionary<string, int> ArchiveFilesHashTable { get; } = [];
    public Dictionary<ulong, string> HashToArchiveFile { get; } = [];

    private string _dir;
    private Stream[] _archiveStreams;

    /// <summary>
    /// Initializes the archive.
    /// </summary>
    /// <param name="indexFile"></param>
    public bool Init(string indexFile)
    {
        Console.WriteLine($"Opening archive index '{indexFile}'");

        _dir = Path.GetDirectoryName(Path.GetFullPath(indexFile));

        byte[] indexBuf = File.ReadAllBytes(indexFile);
        Index = IndexFile.Serializer.Parse(indexBuf);

        _archiveStreams = new Stream[Index.NumArchives];

        string fileListPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "filelist.txt");
        if (!File.Exists(fileListPath))
        {
            Console.WriteLine("filelist.txt is missing.");
            return false;
        }

        using (var reader = new StreamReader(fileListPath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine().Trim();
                RegisterFileIfValid(line);
            }
        }

        /*
#if DEBUG
        Console.WriteLine("Bruteforcing a few files..");
        var brute = new ArchiveBruteforcer(this);
        brute.Bruteforce();
#endif
        */

        Console.WriteLine("Archive loaded.");
        Console.WriteLine($"- Code Name: {Index.Codename}");
        Console.WriteLine($"- XXHash Seed: {Index.XXHashSeed}");
        Console.WriteLine($"- Num Archives: {Index.NumArchives}");
        Console.WriteLine($"- Known External Files Hashes: {ExternalFilesHashTable.Count}/{Index.ExternalFileHashes.Count}");
        Console.WriteLine($"- Known Archive Files Hashes: {ArchiveFilesHashTable.Count}/{Index.ArchiveFileHashes.Count} " +
            $"({(double)ArchiveFilesHashTable.Count / Index.ArchiveFileHashes.Count * 100:0.##}%)");
        Console.WriteLine();

        return true;
    }

    public string GetDirectory()
    {
        return _dir;
    }

    public bool RegisterFileIfValid(string file)
    {
        file = file.ToLower().Replace('\\', '/');
        byte[] hashBytes = XxHash64.Hash(Encoding.ASCII.GetBytes(file), 0);
        ulong hash = BinaryPrimitives.ReadUInt64BigEndian(hashBytes);

        int fileIdx = Index.ExternalFileHashes.BinarySearch(hash);
        if (fileIdx >= 0)
        {
            ExternalFilesHashTable.TryAdd(file, fileIdx);
            return true;
        }
        else
        {
            fileIdx = Index.ArchiveFileHashes.BinarySearch(hash);
            if (fileIdx >= 0)
            {
                ArchiveFilesHashTable.TryAdd(file, fileIdx);
                HashToArchiveFile.TryAdd(hash, file);
                return true;
            }
        }

        return false;
    }

    // debug
    private void WriteFileList(string path)
    {
        using var sw = new StreamWriter(path);
        foreach (var f in ArchiveFilesHashTable.Keys)
            sw.WriteLine(f);

        foreach (var f in ExternalFilesHashTable.Keys)
            sw.WriteLine(f);
    }

    public void DebugList()
    {
        Directory.CreateDirectory(Path.Combine(_dir, "debug"));
        using (StreamWriter sw = File.CreateText(Path.Combine(_dir, "debug", "archive_files.txt")))
        {
            for (int i = 0; i < Index.ArchiveFileHashes.Count; i++)
            {
                ulong hash = Index.ArchiveFileHashes[i];
                if (!HashToArchiveFile.TryGetValue(hash, out string name))
                    name = $"[X] Unknown {hash:X16}";

                FileToChunkIndexer chunkIndexer = Index.FileToChunkIndexers[i];
                sw.WriteLine($"{name} - Chunk {chunkIndexer.ChunkEntryIndex}, FileSize: {chunkIndexer.FileSize:X8}, DecOffset {chunkIndexer.OffsetIntoDecompressedChunk:X8}");
            }
        }

        using (StreamWriter sw = File.CreateText(Path.Combine(_dir, "debug", "chunks.txt")))
        {
            for (int i = 0; i < Index.Chunks.Count; i++)
            {
                DataChunk entry = Index.Chunks[i];
                sw.WriteLine($"[{i}] - data.{entry.DataFileNumber} - Offset:{entry.FileOffset:X16}, ZSize:{entry.Size:X8}, Size: {entry.UncompressedSize:X8}, Align:{entry.AllocAlignment:X8}, Bool:{entry.UnkBool}");
            }
        }

        using (StreamWriter sw = File.CreateText(Path.Combine(_dir, "debug", "cached_chunks.txt")))
        {
            for (int i = 0; i < Index.CachedChunkIndices.Count; i++)
            {
                uint idx = Index.CachedChunkIndices[i];
                sw.WriteLine($"[{i}] {idx}");
            }
        }
    }

    /// <summary>
    /// Extracts a file by path.
    /// </summary>
    /// <param name="fileName"></param>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="FileNotFoundException"></exception>
    public void ExtractFile(string fileName, string outputFolder)
    {
        ulong hash = HashPath(fileName);
        ExtractFile(hash, outputFolder, fileName);
    }

    /// <summary>
    /// Extracts a file by hash.
    /// </summary>
    /// <param name="hash"></param>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="FileNotFoundException"></exception>
    public void ExtractFile(ulong hash, string outputFolder, string? fileName = null)
    {
        int index = Index.ExternalFileHashes.BinarySearch(hash);
        if (index > 0)
            throw new ArgumentException("This file is external, it is already extracted.");

        index = Index.ArchiveFileHashes.BinarySearch(hash);
        if (index < 0)
            throw new FileNotFoundException("File was not found in archive.");

        FileToChunkIndexer fileToChunkIndex = Index.FileToChunkIndexers[index];

        if (string.IsNullOrEmpty(fileName))
            fileName = $"Unk_{hash:X16}";

        ExtractInternal(fileToChunkIndex, fileName, outputFolder);
    }

    private void ExtractInternal(FileToChunkIndexer indexer, string outputFileName, string outputFolder)
    {
        if (indexer.ChunkEntryIndex == -1)
        {
            Console.WriteLine($"Skipping: {outputFileName} - ChunkEntryIndex = {indexer.ChunkEntryIndex} (empty)");
            return;
        }

        DataChunk chunkEntry = Index.Chunks[(int)indexer.ChunkEntryIndex];
        if (_archiveStreams[chunkEntry.DataFileNumber] is null)
        {
            if (chunkEntry.DataFileNumber > Index.NumArchives)
                throw new Exception("Data file number above number of archives");

            string archivePath = Path.Combine(_dir, $"data.{chunkEntry.DataFileNumber}");
            if (!File.Exists(archivePath))
                throw new FileNotFoundException($"Archive file {archivePath} does not exist.");

            _archiveStreams[chunkEntry.DataFileNumber] = new FileStream(archivePath, FileMode.Open);
        }

        Stream stream = _archiveStreams[chunkEntry.DataFileNumber];
        stream.Position = (long)chunkEntry.FileOffset;

        byte[] chunk = ArrayPool<byte>.Shared.Rent((int)chunkEntry.Size);
        byte[] decompressedChunk = ArrayPool<byte>.Shared.Rent((int)chunkEntry.UncompressedSize);

        try
        {
            stream.Read(chunk, 0, (int)chunkEntry.Size);

            Span<byte> fileData;
            if (chunkEntry.Size != chunkEntry.UncompressedSize)
            {
                int decoded = LZ4Codec.Decode(chunk, 0, (int)chunkEntry.Size, decompressedChunk, 0, (int)chunkEntry.UncompressedSize);
                if (decoded != chunkEntry.UncompressedSize)
                    throw new Exception("Failed to decompress fully");

                fileData = decompressedChunk.AsSpan((int)indexer.OffsetIntoDecompressedChunk, (int)indexer.FileSize);
            }
            else
                fileData = chunk.AsSpan((int)indexer.OffsetIntoDecompressedChunk, (int)indexer.FileSize);

            string outputFile;
            if (outputFileName.StartsWith("Unk_"))
            {
                outputFile = Path.Combine(outputFolder, ".unmapped", outputFileName);

                if (fileData.Length > 4)
                {
                    uint magic = BinaryPrimitives.ReadUInt32LittleEndian(fileData);
                    if (magic == 0x425457)
                        outputFile += ".wtb";
                    else if (magic == 0x4B504B41)
                        outputFile += ".pck";
                    else if (magic == 0x324C4F43)
                        outputFile += ".col";
                    else if (magic == 0x544156)
                        outputFile += ".vat";
                    else if (magic == 0x464645)
                        outputFile += ".est";
                    else if (fileData[0] == 0xDF)
                        outputFile += ".msg";
                    else if (magic == 0x43425844)
                        outputFile += ".pso";
                    else if (magic == 0x7630701)
                        outputFile += ".mot";
                    else if (magic == 0x5000536)
                        outputFile += ".bxm";
                    else if (fileData.Length > 0x1C)
                    {
                        bool found = true;
                        for (int i = 0x04; i < 0x18; i++)
                        {
                            if (fileData[i] != 0)
                            {
                                found = false;
                                break;
                            }
                        }

                        if (found && fileData[0x1A] != 0)
                            outputFile += ".lip";
                    }
                }
                
            }
            else
                outputFile = Path.Combine(outputFolder, outputFileName);

            
            Directory.CreateDirectory(Path.GetDirectoryName(outputFile));

            using var writeStream = File.Create(outputFile);
            writeStream.Write(fileData);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(chunk);
            ArrayPool<byte>.Shared.Return(decompressedChunk);
        }
    }

    public bool FileExistsInArchive(string path)
    {
        ulong hash = HashPath(path);
        int index = Index.ExternalFileHashes.BinarySearch(hash);
        if (index >= 0)
            return true;

        index = Index.ArchiveFileHashes.BinarySearch(hash);
        if (index >= 0)
            return true;

        return false;
    }

    public ulong HashPath(string path)
    {
        byte[] hashBytes = XxHash64.Hash(Encoding.ASCII.GetBytes(path), 0);
        ulong hash = BinaryPrimitives.ReadUInt64BigEndian(hashBytes);
        return hash;
    }

    public void AddExternalFiles(string folder)
    {
        Console.WriteLine($"Scanning '{folder}' for files...");

        string[] files = Directory.GetFiles(folder, "*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            string str = file[(folder.Length + 1)..].Replace('\\', '/');

            byte[] hashBytes = XxHash64.Hash(Encoding.ASCII.GetBytes(str), 0);
            ulong hash = BinaryPrimitives.ReadUInt64BigEndian(hashBytes);

            long fileSize = new FileInfo(file).Length;
            if (AddOrUpdateExternalFile(hash, (ulong)fileSize))
                Console.WriteLine($"- Index: Added {str} as new external file");
            else
                Console.WriteLine($"- Index: Updated {str} external file");
            RemoveArchiveFile(hash);
        }

        Console.WriteLine();
        Console.WriteLine($"-> {files.Length} files have been added or updated to the external file list.");
    }

    private bool AddOrUpdateExternalFile(ulong hash, ulong fileSize)
    {
        bool added = false;
        int idx = Index.ExternalFileHashes.BinarySearch(hash);
        if (idx < 0)
        {
            idx = Index.ExternalFileHashes.AddSorted(hash);
            added = true;
            Index.ExternalFileSizes.Insert(idx, fileSize);
        }
        else
        {
            Index.ExternalFileHashes[idx] = hash;
        }

        return added;
    }
    
    private void RemoveArchiveFile(ulong hash)
    {
        int idx = Index.ArchiveFileHashes.BinarySearch(hash);
        if (idx > -1)
        {
            Index.ArchiveFileHashes.RemoveAt(idx);
            Index.FileToChunkIndexers.RemoveAt(idx);
        }
    }
    
    public void SaveIndex(string fileName)
    {
        byte[] outBuf = new byte[IndexFile.Serializer.GetMaxSize(Index)];
        IndexFile.Serializer.Write(outBuf, Index);
        File.WriteAllBytes(fileName, outBuf);
    }

    /// <summary>
    /// Disposes of all the split archives.
    /// </summary>
    public void Dispose()
    {
        if (_archiveStreams is null)
            return;

        foreach (Stream stream in _archiveStreams)
            stream?.Dispose();
    }
}
