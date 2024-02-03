using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syroot.BinaryData;

namespace GBFRDataTools.Entities;

/// <summary>
/// Represents a file in the flatark, which will point to a (de)compressed chunk.
/// </summary>
public class FlatArkFileToChunkIndexer
{
    public int ChunkEntryIndex { get; set; }
    public int FileSize { get; set; }
    public int OffsetIntoDecompressedChunk { get; set; }

    public void Read(BinaryStream bs)
    {
        ChunkEntryIndex = bs.ReadInt32();
        FileSize = bs.ReadInt32();
        OffsetIntoDecompressedChunk = bs.ReadInt32();
    }

    public void Write(BinaryStream bs)
    {
        bs.WriteInt32(ChunkEntryIndex);
        bs.WriteInt32(FileSize);
        bs.WriteInt32(OffsetIntoDecompressedChunk);
    }
}
