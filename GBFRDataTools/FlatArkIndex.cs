using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Syroot.BinaryData;

namespace GBFRDataTools;

public class FlatArkIndex
{
    /// <summary>
    /// Code name.
    /// </summary>
    public string Codename { get; set; }

    /// <summary>
    /// XX Hash seed. Default to zero.
    /// </summary>
    public ulong XXHashSeed { get; set; } = 0;

    /// <summary>
    /// Number of split archive files.
    /// </summary>
    public ushort NumArchives { get; set; }


    /// <summary>
    /// Hashes of paths for files inside the archive.
    /// </summary>
    public List<ulong> ArchiveFilesHashTable = [];

    public List<FlatArkFileIndexer> FileIndices = [];

    /// <summary>
    /// File entries (for files inside the archive).
    /// </summary>
    public List<FlatArkFileEntry> FileEntries = [];

    /// <summary>
    /// Hashes of paths for the external files.
    /// </summary>
    public List<ulong> ExternalFilesHashTable = [];

    /// <summary>
    /// Sizes of external files (present in data/).
    /// </summary>
    public List<ulong> ExternalFilesSizes = [];

    /// <summary>
    /// Files that should be loaded on boot. Critical files.
    /// </summary>
    public List<uint> BootFilesIndices = [];

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
            ReadIndicesField(bs, fieldTableOffset, fieldOffsets[5]);

        if (fieldOffsets[6] != 0)
            ReadFileEntriesField(bs, fieldTableOffset, fieldOffsets[6]);

        if (fieldOffsets[7] != 0)
            ReadExternalFilesHashTableField(bs, fieldTableOffset, fieldOffsets[7]);

        if (fieldOffsets[8] != 0)
            ReadExternalFilesSizesTableField(bs, fieldTableOffset, fieldOffsets[8]);

        if (fieldOffsets[9] != 0)
            ReadTable1Field(bs, fieldTableOffset, fieldOffsets[9]);
    }

    private void ReadTable1Field(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
            BootFilesIndices.Add(bs.ReadUInt32());
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

    private void ReadFileEntriesField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
        {
            var entry = new FlatArkFileEntry();
            entry.Read(bs);
            FileEntries.Add(entry);
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

    private void ReadIndicesField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        uint tableOffset = bs.ReadUInt32();
        bs.Position += tableOffset - sizeof(uint);

        uint entriesCount = bs.ReadUInt32();
        for (int i = 0; i < entriesCount; i++)
        {
            var entry = new FlatArkFileIndexer();
            entry.Read(bs);
            FileIndices.Add(entry);
        }
    }

    private void ReadXXHashSeedField(BinaryStream bs, uint fieldTableOffset, ushort fieldOffset)
    {
        bs.Position = fieldTableOffset + fieldOffset;
        XXHashSeed = bs.ReadUInt64();
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
}
