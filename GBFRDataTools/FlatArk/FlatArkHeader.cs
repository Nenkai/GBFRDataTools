using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Syroot.BinaryData;

namespace GBFRDataTools.FlatArk;

/// <summary>
/// Flat Ark header.
/// Table of offsets for a list of file fields.
/// </summary>
public class FlatArkHeader
{
    public uint FieldsTableOffset { get; set; }
    public ushort FieldOffsetTableSize { get; set; }
    public ushort[] OffsetsToFields { get; set; }

    public void Read(Stream stream)
    {
        BinaryStream bs = new BinaryStream(stream);
        FieldsTableOffset = bs.ReadUInt32();
        bs.Position += 6;

        FieldOffsetTableSize = bs.ReadUInt16();
        OffsetsToFields = bs.ReadUInt16s((FieldOffsetTableSize - 2) / sizeof(ushort));
    }

    public uint GetFieldDataOffset(int index)
    {
        if (index == 0)
            throw new ArgumentException("Must be 1 indexed.");

        return FieldsTableOffset + OffsetsToFields[index];
    }

    public bool IsValidEntry(int index)
    {
        if (index == 0)
            return false;

        return OffsetsToFields[index] != 0;
    }

    public uint NumEntries()
    {
        return (uint)(OffsetsToFields.Length - 1);
    }
}
