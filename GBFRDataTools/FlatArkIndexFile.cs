using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBFRDataTools.Entities;
using Syroot.BinaryData;

namespace GBFRDataTools;

using GBFRDataTools.Packing;

/// <summary>
/// Represents a data.i file.
/// </summary>
public class FlatArkIndexFile
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

    public List<FlatArkFileToChunkIndexer> FileToChunkIndexerTable = [];

    /// <summary>
    /// Chhunk entries (for chunks inside the archive).
    /// </summary>
    public List<FlatArkChunkEntry> ChunkEntries = [];

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

    private void ReadInternal(BinaryStream bs)
    {
        uint fieldTableOffset = bs.ReadUInt32();
        bs.Position += 6;

        ushort fieldOffsetTableSize = bs.ReadUInt16();
        ushort[] fieldOffsets = bs.ReadUInt16s((fieldOffsetTableSize - 2) / sizeof(ushort));

        if (fieldOffsets[1] != 0)
            ReadCodenameField(bs, fieldTableOffset, fieldOffsets[1]);

        if (fieldOffsets[2] != 0)
            ReadNumArchivesField(bs, fieldTableOffset, fieldOffsets[2]);

        if (fieldOffsets[3] != 0)
            ReadXXHashSeedField(bs, fieldTableOffset, fieldOffsets[3]);

        if (fieldOffsets[4] != 0)
            ReadArchiveFilesHashTableField(bs, fieldTableOffset, fieldOffsets[4]);

        if (fieldOffsets[5] != 0)
            ReadFileToChunkIndicesTableField(bs, fieldTableOffset, fieldOffsets[5]);

        if (fieldOffsets[6] != 0)
            ReadChunkEntryTableField(bs, fieldTableOffset, fieldOffsets[6]);

        if (fieldOffsets[7] != 0)
            ReadExternalFilesHashTableField(bs, fieldTableOffset, fieldOffsets[7]);

        if (fieldOffsets[8] != 0)
            ReadExternalFilesSizesTableField(bs, fieldTableOffset, fieldOffsets[8]);

        if (fieldOffsets[9] != 0)
            ReadCachedChunkIndicesTableField(bs, fieldTableOffset, fieldOffsets[9]);
    }

    private void ReadCachedChunkIndicesTableField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
            CachedChunksIndices.Add(bs.ReadUInt32());
    }

    private void ReadExternalFilesSizesTableField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
            ExternalFilesSizes.Add(bs.ReadUInt64());
    }

    private void ReadExternalFilesHashTableField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
            ExternalFilesHashTable.Add(bs.ReadUInt64());
    }

    private void ReadChunkEntryTableField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
        {
            var entry = new FlatArkChunkEntry();
            entry.Read(bs);
            ChunkEntries.Add(entry);
        }
    }

    private void ReadArchiveFilesHashTableField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
            ArchiveFilesHashTable.Add(bs.ReadUInt64());
    }

    private void ReadFileToChunkIndicesTableField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
        {
            var entry = new FlatArkFileToChunkIndexer();
            entry.Read(bs);
            FileToChunkIndexerTable.Add(entry);
        }
    }

    private void ReadXXHashSeedField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        XXHashSeed = bs.ReadUInt16();
    }

    private void ReadNumArchivesField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        NumArchives = bs.ReadUInt16();
    }

    private void ReadCodenameField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        uint strOffset = bs.ReadUInt32();
        bs.Position += strOffset - sizeof(uint);
        Codename = bs.ReadString(StringCoding.Int32CharCount);
    }

    public void Write(Stream stream)
    {
        var writer = new FlatArkIndexWriter(this);
        writer.Write(stream);
    }
}
