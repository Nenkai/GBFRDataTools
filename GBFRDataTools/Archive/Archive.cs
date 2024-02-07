using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Hashing;
using System.Buffers.Binary;

using K4os.Compression.LZ4;
using K4os.Compression.LZ4.Streams;

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

        Index = new IndexFile();
        Index.Read(indexFile);

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

                // remove fhd for 4k assets
                //RegisterFileIfValid(line.Replace("/fhd", ""));
            }
        }

        Console.WriteLine("Archive loaded.");
        Console.WriteLine($"- Code Name: {Index.Codename}");
        Console.WriteLine($"- XXHash Seed: {Index.XXHashSeed}");
        Console.WriteLine($"- Num Archives: {Index.NumArchives}");
        Console.WriteLine($"- Known External Files Hashes: {ExternalFilesHashTable.Count}/{Index.ExternalFilesHashTable.Count}");
        Console.WriteLine($"- Known Archive Files Hashes: {ArchiveFilesHashTable.Count}/{Index.ArchiveFilesHashTable.Count} " +
            $"({(double)ArchiveFilesHashTable.Count / Index.ArchiveFilesHashTable.Count * 100:0.##}%)");
        Console.WriteLine();

        WriteFileList(fileListPath);
        return true;
    }

    private void RegisterFileIfValid(string file)
    {
        file = file.ToLower().Replace('\\', '/');
        byte[] hashBytes = XxHash64.Hash(Encoding.ASCII.GetBytes(file), 0);
        ulong hash = BinaryPrimitives.ReadUInt64BigEndian(hashBytes);

        int fileIdx = Index.ExternalFilesHashTable.BinarySearch(hash);
        if (fileIdx >= 0)
        {
            ExternalFilesHashTable.TryAdd(file, fileIdx);
        }
        else
        {
            fileIdx = Index.ArchiveFilesHashTable.BinarySearch(hash);
            if (fileIdx >= 0)
            {
                ArchiveFilesHashTable.TryAdd(file, fileIdx);
                HashToArchiveFile.TryAdd(hash, file);
            }
        }
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
            for (int i = 0; i < Index.ArchiveFilesHashTable.Count; i++)
            {
                ulong hash = Index.ArchiveFilesHashTable[i];
                if (!HashToArchiveFile.TryGetValue(hash, out string name))
                    name = $"[X] Unknown {hash:X16}";

                FileToChunkIndexer chunkIndexer = Index.FileToChunkIndexerTable[i];
                sw.WriteLine($"{name} - Chunk {chunkIndexer.ChunkEntryIndex}, FileSize: {chunkIndexer.FileSize:X8}, DecOffset {chunkIndexer.OffsetIntoDecompressedChunk:X8}");
            }
        }

        using (StreamWriter sw = File.CreateText(Path.Combine(_dir, "debug", "chunks.txt")))
        {
            for (int i = 0; i < Index.ChunkEntries.Count; i++)
            {
                ChunkEntry entry = Index.ChunkEntries[i];
                sw.WriteLine($"[{i}] - data.{entry.DataFileNumber} - Offset:{entry.FileOffset:X16}, ZSize:{entry.Size:X8}, Size: {entry.UncompressedSize:X8}, Align:{entry.AllocAlignment:X8}, Bool:{entry.UnkBool}");
            }
        }

        using (StreamWriter sw = File.CreateText(Path.Combine(_dir, "debug", "cached_chunks.txt")))
        {
            for (int i = 0; i < Index.CachedChunksIndices.Count; i++)
            {
                uint idx = Index.CachedChunksIndices[i];
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
    public void ExtractFile(string fileName)
    {
        ulong hash = HashPath(fileName);
        ExtractFile(hash, fileName);
    }

    /// <summary>
    /// Extracts a file by hash.
    /// </summary>
    /// <param name="hash"></param>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="FileNotFoundException"></exception>
    public void ExtractFile(ulong hash, string? fileName = null)
    {
        int index = Index.ExternalFilesHashTable.BinarySearch(hash);
        if (index > 0)
            throw new ArgumentException("This file is external, it is already extracted.");

        index = Index.ArchiveFilesHashTable.BinarySearch(hash);
        if (index < 0)
            throw new FileNotFoundException("File was not found in archive.");

        FileToChunkIndexer fileToChunkIndex = Index.FileToChunkIndexerTable[index];

        if (string.IsNullOrEmpty(fileName))
            fileName = $"Unk_{index:X16}";

        ExtractInternal(fileToChunkIndex, fileName);
    }

    private void ExtractInternal(FileToChunkIndexer indexer, string outputFileName)
    {
        Console.WriteLine($"Extracting: {outputFileName}");

        if (indexer.ChunkEntryIndex == -1)
        {
            Console.WriteLine($"Skipping: {indexer.ChunkEntryIndex} (empty)");
            return;
        }

        ChunkEntry chunkEntry = Index.ChunkEntries[indexer.ChunkEntryIndex];
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

                fileData = decompressedChunk.AsSpan(indexer.OffsetIntoDecompressedChunk, indexer.FileSize);
            }
            else
                fileData = chunk.AsSpan(indexer.OffsetIntoDecompressedChunk, indexer.FileSize);

            string outputFile = Path.Combine(_dir, "data", outputFileName);
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
        int index = Index.ExternalFilesHashTable.BinarySearch(hash);
        if (index >= 0)
            return true;

        index = Index.ArchiveFilesHashTable.BinarySearch(hash);
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
            if (Index.AddOrUpdateExternalFile(hash, (ulong)fileSize))
                Console.WriteLine($"- Index: Added {str} as new external file");
            else
                Console.WriteLine($"- Index: Updated {str} external file");
        }

        Console.WriteLine();
        Console.WriteLine($"-> {files.Length} files have been added or updated to the external file list.");
    }

    public void SaveIndex(string fileName)
    {
        using var stream = File.Create(fileName);
        Index.Write(stream);
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
