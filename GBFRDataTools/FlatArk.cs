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

using GBFRDataTools.Entities;
using Syroot.BinaryData;

namespace GBFRDataTools;

public class FlatArk
{
    public FlatArkIndexFile Index { get; private set; }
    public Dictionary<string, int> ExternalFilesHashTable = [];
    public Dictionary<string, int> ArchiveFilesHashTable = [];
    public Dictionary<ulong, string> HashToArchiveFile = [];

    private string _dir;
    private Stream[] _archiveStreams;

    public void Open(string indexFile)
    {
        Console.WriteLine($"Opening flatark archive index '{indexFile}'");

        _dir = Path.GetDirectoryName(Path.GetFullPath(indexFile));

        Index = new FlatArkIndexFile();
        Index.Read(indexFile);

        _archiveStreams = new Stream[Index.NumArchives];

        Console.WriteLine($"- Code Name: {Index.Codename}");
        Console.WriteLine($"- XXHash Seed: {Index.XXHashSeed}");
        Console.WriteLine($"- Num Archives: {Index.NumArchives}");

        using var reader = new StreamReader("filelist.txt");
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();

            byte[] hashBytes = XxHash64.Hash(Encoding.ASCII.GetBytes(line), 0);
            ulong hash = BinaryPrimitives.ReadUInt64BigEndian(hashBytes);

            int fileIdx = Index.ExternalFilesHashTable.BinarySearch(hash);
            if (fileIdx >= 0)
            {
                ExternalFilesHashTable.TryAdd(line, fileIdx);
            }
            else
            {
                fileIdx = Index.ArchiveFilesHashTable.BinarySearch(hash);
                if (fileIdx >= 0)
                {
                    ArchiveFilesHashTable.TryAdd(line, fileIdx);
                    HashToArchiveFile.TryAdd(hash, line);
                }
            }
        }

        Console.WriteLine($"- External Files Hashes: {ExternalFilesHashTable.Count}/{Index.ExternalFilesHashTable.Count}");
        Console.WriteLine($"- Archive Files Hashes: {ArchiveFilesHashTable.Count}/{Index.ArchiveFilesHashTable.Count}");
        DebugList();
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

                FlatArkFileToChunkIndexer chunkIndexer = Index.FileToChunkIndex[i];
                sw.WriteLine($"{name} - Chunk {chunkIndexer.ChunkEntryIndex}, FileSize: {chunkIndexer.FileSize:X8}, DecOffset {chunkIndexer.OffsetIntoDecompressedChunk:X8}");
            }
        }

        using (StreamWriter sw = File.CreateText(Path.Combine(_dir, "debug", "chunks.txt")))
        {
            for (int i = 0; i < Index.ChunkEntries.Count; i++)
            {
                FlatArkChunkEntry entry = Index.ChunkEntries[i];
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

    public void Extract(string fileName)
    {
        if (ExternalFilesHashTable.TryGetValue(fileName, out _))
            throw new ArgumentException("This file is external, it is already extracted.");

        if (!ArchiveFilesHashTable.TryGetValue(fileName, out int index))
            throw new FileNotFoundException("File was not found in archive.");

        FlatArkFileToChunkIndexer fileToChunkIndex = Index.FileToChunkIndex[index];
        ExtractInternal(fileToChunkIndex, fileName);
    }

    private void ExtractInternal(FlatArkFileToChunkIndexer indexer, string outputFileName)
    {
        Console.WriteLine($"Extracting: {outputFileName}");

        if (indexer.ChunkEntryIndex == -1)
        {
            Console.WriteLine($"Skipping: {indexer.ChunkEntryIndex} (empty)");
            return;
        }

        FlatArkChunkEntry chunkEntry = Index.ChunkEntries[indexer.ChunkEntryIndex];
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
}
