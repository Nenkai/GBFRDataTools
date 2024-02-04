using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Syroot.BinaryData;

using GBFRDataTools.FlatArk;

namespace GBFRDataTools.Archive;

/// <summary>
/// Represents a data.i file.
/// </summary>
public class IndexFile
{
    /// <summary>
    /// Code name.
    /// </summary>
    public string Codename { get; set; }

    /// <summary>
    /// XX Hash seed. Default to zero.
    /// </summary>
    public ushort XXHashSeed { get; set; } = 0;

    /// <summary>
    /// Number of split archive files.
    /// </summary>
    public ushort NumArchives { get; set; }


    /// <summary>
    /// Hashes of paths for files inside the archive.
    /// </summary>
    public List<ulong> ArchiveFilesHashTable = [];

    public List<FileToChunkIndexer> FileToChunkIndexerTable = [];

    /// <summary>
    /// Chhunk entries (for chunks inside the archive).
    /// </summary>
    public List<ChunkEntry> ChunkEntries = [];

    /// <summary>
    /// Hashes of paths for the external files.
    /// </summary>
    public List<ulong> ExternalFilesHashTable = [];

    /// <summary>
    /// Sizes of external files (present in data/).
    /// </summary>
    public List<ulong> ExternalFilesSizes = [];

    /// <summary>
    /// Chunks that should be cached on boot.
    /// </summary>
    public List<uint> CachedChunksIndices = [];

    public void Read(string fileName)
    {
        using var fs = new FileStream(fileName, FileMode.Open);
        using var bs = new BinaryStream(fs);
        ReadInternal(bs);
    }

    public bool AddOrUpdateExternalFile(ulong hash, ulong fileSize)
    {
        bool added = false;
        int idx = ExternalFilesHashTable.BinarySearch(hash);
        if (idx < 0)
        {
            idx = AddSorted<ulong>(ExternalFilesHashTable, hash);
            added = true;

            ExternalFilesSizes.Insert(idx, fileSize);
        }
        else
        {
            ExternalFilesSizes[idx] = fileSize;
        }
        
        return added;
    }

    public static int AddSorted<T>(List<T> list, T value)
    {
        int x = list.BinarySearch(value);
        int newIdx = (x >= 0) ? x : ~x;
        list.Insert(newIdx, value);

        return newIdx;
    }

    private void ReadInternal(BinaryStream bs)
    {
        var header = new FlatArkHeader();
        header.Read(bs);

        if (header.IsValidEntry(1))
            ReadCodenameField(bs, header.GetFieldDataOffset(1));

        if (header.IsValidEntry(2))
            ReadNumArchivesField(bs, header.GetFieldDataOffset(2));

        if (header.IsValidEntry(3))
            ReadXXHashSeedField(bs, header.GetFieldDataOffset(3));

        if (header.IsValidEntry(4))
            ReadArchiveFilesHashTableField(bs, header.GetFieldDataOffset(4));

        if (header.IsValidEntry(5))
            ReadFileToChunkIndicesTableField(bs, header.GetFieldDataOffset(5));

        if (header.IsValidEntry(6))
            ReadChunkEntryTableField(bs, header.GetFieldDataOffset(6));

        if (header.IsValidEntry(7))
            ReadExternalFilesHashTableField(bs, header.GetFieldDataOffset(7));

        if (header.IsValidEntry(8))
            ReadExternalFilesSizesTableField(bs, header.GetFieldDataOffset(8));

        if (header.IsValidEntry(9))
            ReadCachedChunkIndicesTableField(bs, header.GetFieldDataOffset(9));
    }

    private void ReadCachedChunkIndicesTableField(BinaryStream bs, uint fieldOffset)
    {
        bs.Position = fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
            CachedChunksIndices.Add(bs.ReadUInt32());
    }

    private void ReadExternalFilesSizesTableField(BinaryStream bs, uint fieldOffset)
    {
        bs.Position = fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
            ExternalFilesSizes.Add(bs.ReadUInt64());
    }

    private void ReadExternalFilesHashTableField(BinaryStream bs, uint fieldOffset)
    {
        bs.Position = fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
            ExternalFilesHashTable.Add(bs.ReadUInt64());
    }

    private void ReadChunkEntryTableField(BinaryStream bs, uint fieldOffset)
    {
        bs.Position = fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
        {
            var entry = new ChunkEntry();
            entry.Read(bs);
            ChunkEntries.Add(entry);
        }
    }

    private void ReadArchiveFilesHashTableField(BinaryStream bs, uint fieldOffset)
    {
        bs.Position = fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
            ArchiveFilesHashTable.Add(bs.ReadUInt64());
    }

    private void ReadFileToChunkIndicesTableField(BinaryStream bs, uint fieldOffset)
    {
        bs.Position = fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
        {
            var entry = new FileToChunkIndexer();
            entry.Read(bs);
            FileToChunkIndexerTable.Add(entry);
        }
    }

    private void ReadXXHashSeedField(BinaryStream bs, uint fieldOffset)
    {
        bs.Position = fieldOffset;
        XXHashSeed = bs.ReadUInt16();
    }

    private void ReadNumArchivesField(BinaryStream bs, uint fieldOffset)
    {
        bs.Position = fieldOffset;
        NumArchives = bs.ReadUInt16();
    }

    private void ReadCodenameField(BinaryStream bs, uint fieldOffset)
    {
        bs.Position = fieldOffset;
        uint strOffset = bs.ReadUInt32();
        bs.Position += strOffset - sizeof(uint);
        Codename = bs.ReadString(StringCoding.Int32CharCount);
    }

    public void Write(Stream stream)
    {
        List<FlatArkField> fields =
        [
            new FlatArkField(Codename, sizeof(uint), FlatArkWriter.WriteString),
            new FlatArkField(NumArchives, sizeof(ushort), FlatArkWriter.WriteUInt16),
            new FlatArkField(XXHashSeed, sizeof(ushort), FlatArkWriter.WriteUInt16),
            new FlatArkField(ArchiveFilesHashTable, sizeof(uint), WriteUInt64Table),
            new FlatArkField(FileToChunkIndexerTable, sizeof(uint), WriteFileToChunkIndexerTable),
            new FlatArkField(ChunkEntries, sizeof(uint), WriteChunkEntries),
            new FlatArkField(ExternalFilesHashTable, sizeof(uint), WriteUInt64Table),
            new FlatArkField(ExternalFilesSizes, sizeof(uint), WriteUInt64Table),
            new FlatArkField(CachedChunksIndices, sizeof(uint), WriteCachedChunkIndices),
        ];

        var writer = new FlatArkWriter(fields);
        writer.Write(stream);
    }

    private bool WriteFileToChunkIndexerTable(BinaryStream stream, long fieldOffset, object obj)
    {
        long lastPos = stream.Position;

        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(lastPos - fieldOffset));
        stream.Position = lastPos;

        List<FileToChunkIndexer> entries = (List<FileToChunkIndexer>)obj;
        stream.WriteUInt32((uint)entries.Count);

        for (int i = 0; i < entries.Count; i++)
            entries[i].Write(stream);

        return true;
    }

    private bool WriteChunkEntries(BinaryStream stream, long fieldOffset, object obj)
    {
        long lastPos = stream.Position;

        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(lastPos - fieldOffset));
        stream.Position = lastPos;

        List<ChunkEntry> chunkEntries = (List<ChunkEntry>)obj;
        stream.WriteUInt32((uint)chunkEntries.Count);

        long startPos = stream.Position; // bit different here
        for (int i = 0; i < chunkEntries.Count; i++)
            chunkEntries[i].Write(stream);

        stream.Position += (stream.Position - startPos) % 0x08;
        return true;
    }

    private bool WriteUInt64Table(BinaryStream stream, long fieldOffset, object obj)
    {
        long lastPos = stream.Position;

        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(lastPos - fieldOffset));
        stream.Position = lastPos;

        long startPos = stream.Position;
        List<ulong> hashTable = (List<ulong>)obj;
        stream.WriteUInt32((uint)hashTable.Count);

        for (int i = 0; i < hashTable.Count; i++)
            stream.WriteUInt64(hashTable[i]);
        stream.Position += (stream.Position - startPos) % 0x08;

        return true;
    }

    private bool WriteExternalFileSizes(BinaryStream stream, long fieldOffset, object obj)
    {
        long lastPos = stream.Position;

        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(lastPos - fieldOffset));
        stream.Position = lastPos;

        long startPos = stream.Position;
        List<ulong> externalFileSizes = (List<ulong>)obj;
        stream.WriteUInt32((uint)externalFileSizes.Count);

        for (int i = 0; i < externalFileSizes.Count; i++)
            stream.WriteUInt64(externalFileSizes[i]);
        stream.Position += (stream.Position - startPos) % 0x08;
        return true;
    }

    private bool WriteCachedChunkIndices(BinaryStream stream, long fieldOffset, object obj)
    {
        long lastPos = stream.Position;

        stream.Position = fieldOffset;
        stream.WriteUInt32((uint)(lastPos - fieldOffset));
        stream.Position = lastPos;

        List<uint> cachedIndices = (List<uint>)obj;
        stream.WriteUInt32((uint)cachedIndices.Count);

        for (int i = 0; i < cachedIndices.Count; i++)
            stream.WriteUInt32(cachedIndices[i]);

        return true;
    }

}
