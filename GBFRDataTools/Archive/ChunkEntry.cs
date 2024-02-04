using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syroot.BinaryData;

namespace GBFRDataTools.Archive;

/// <summary>
/// Represents a data chunk in the flatark archive.
/// </summary>
public class ChunkEntry
{
    public ulong FileOffset { get; set; }
    public uint UncompressedSize { get; set; }
    public uint Size { get; set; }
    public uint AllocAlignment { get; set; }
    public bool UnkBool { get; set; }
    public byte DataFileNumber { get; set; }

    public void Read(BinaryStream bs)
    {
        FileOffset = bs.ReadUInt64();
        Size = bs.ReadUInt32();
        UncompressedSize = bs.ReadUInt32();
        AllocAlignment = bs.ReadUInt32();
        UnkBool = bs.ReadBoolean();
        bs.Read1Byte();
        DataFileNumber = bs.Read1Byte();
        bs.Read1Byte();
    }

    public void Write(BinaryStream bs)
    {
        bs.WriteUInt64(FileOffset);
        bs.WriteUInt32(Size);
        bs.WriteUInt32(UncompressedSize);
        bs.WriteUInt32(AllocAlignment);
        bs.WriteBoolean(UnkBool);
        bs.WriteByte(0);
        bs.WriteByte(DataFileNumber);
        bs.WriteByte(0);
    }
}
