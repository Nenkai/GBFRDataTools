using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Syroot.BinaryData;
using System.Reflection.Metadata;
using NenTools.IO.Streams;
using CommunityToolkit.HighPerformance;
using GBFRDataTools.Hashing;

namespace GBFRDataTools.Files.Textures;

public class TextureBin
{
    public Dictionary<uint, Texture> Textures { get; set; } = [];

    /// <summary>
    /// Reads a texture binary from file.
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static TextureBin FromFile(string fileName)
    {
        using var fs = File.OpenRead(fileName);
        return FromStream(fs);
    }

    /// <summary>
    /// Reads a texture binary from stream.
    /// </summary>
    /// <param name="stream"></param>
    /// <returns></returns>
    /// <exception cref="InvalidDataException"></exception>
    public static TextureBin FromStream(Stream stream)
    {
        long basePos = stream.Position;
        var bs = new BinaryStream(stream, ByteConverter.Little);

        int headerSize = Unsafe.SizeOf<TextureBinHeader>();
        if (bs.Length < headerSize)
            throw new InvalidDataException($"Stream length is too small to read TextureBin header.");

        Span<byte> headerBytes = new byte[Unsafe.SizeOf<TextureBinHeader>()];
        bs.ReadExactly(headerBytes);

        TextureBinHeader header = MemoryMarshal.Cast<byte, TextureBinHeader>(headerBytes)[0];
        if (header.m_Magic != TextureBinHeader.MAGIC)
            throw new InvalidDataException($"Invalid TextureBin magic. Expected {TextureBinHeader.MAGIC:X8}.");

        TextureBin texBin = new TextureBin();
        for (int i = 0; i < header.m_nTex; i++)
        {
            bs.Position = basePos + header.m_OfsOfs + (i * sizeof(int));
            uint dxBaseTexOfs = bs.ReadUInt32();
            Debug.Assert(dxBaseTexOfs <= bs.Length, $"Texture {i} past stream length.");

            bs.Position = basePos + header.m_SizeOfs + (i * sizeof(int));
            uint textureSize = bs.ReadUInt32();

            bs.Position = basePos + header.m_FlgOfs + (i * sizeof(int));
            TEXTURE_FLAG textureFlag = (TEXTURE_FLAG)bs.ReadUInt32();

            bs.Position = basePos + header.m_HashOfs + (i * sizeof(int));
            uint textureHash = bs.ReadUInt32();

            var texture = new Texture();
            bs.Position = dxBaseTexOfs;
            texture.SetData(bs.ReadBytes((int)textureSize));
            texture.Flag = textureFlag;
            texture.Hash = textureHash;
            texBin.Textures.Add(texture.Hash, texture);
        }

        return texBin;
    }

    public void Write(Stream stream)
    {
        long basePos = stream.Position;

        var bs = new SmartBinaryStream(stream);

        long textureOffsetsOffset = basePos + 0x20;
        long textureSizesOffset = AlignValue(textureOffsetsOffset + ((uint)Textures.Count * sizeof(int)), 0x20);
        long textureFlagsOffset = AlignValue(textureSizesOffset + ((uint)Textures.Count * sizeof(int)), 0x20);
        long textureNameHashesOffset = AlignValue(textureFlagsOffset + ((uint)Textures.Count * sizeof(int)), 0x20);
        long dataOffset = AlignValue(textureNameHashesOffset + ((uint)Textures.Count * sizeof(int)), 0x1000);

        List<uint> dataOffsets = [];
        stream.Position = dataOffset;
        foreach (var texture in Textures.Values)
        {
            dataOffsets.Add((uint)(stream.Position - basePos));
            bs.Write(texture.GetData());
            bs.Align(0x1000, grow: true);
        }
        long endPos = stream.Position;

        bs.Position = textureOffsetsOffset;
        foreach (uint textureDataOffset in dataOffsets)
        {
            bs.Write(textureDataOffset);
        }

        bs.Position = textureSizesOffset;
        foreach (var texture in Textures.Values)
        {
            bs.Write(texture.GetData().Length);
        }

        bs.Position = textureFlagsOffset;
        foreach (var texture in Textures.Values)
        {
            bs.Write(texture.Flag);
        }

        bs.Position = textureNameHashesOffset;
        foreach (var texture in Textures.Values)
        {
            bs.Write(texture.Hash);
        }

        bs.Position = basePos;

        var header = new TextureBinHeader()
        {
            m_Magic = TextureBinHeader.MAGIC,
            m_Version = 1,
            m_nTex = (uint)Textures.Count,
            m_OfsOfs = (uint)(textureOffsetsOffset - basePos),
            m_SizeOfs = (uint)(textureSizesOffset - basePos),
            m_FlgOfs = (uint)(textureFlagsOffset - basePos),
            m_HashOfs = (uint)(textureNameHashesOffset - basePos),
        };
        bs.Write<TextureBinHeader>(header);

        bs.Position = endPos;
    }

    public static long AlignValue(long x, uint alignment)
    {
        long mask = ~(alignment - 1);
        return (x + (alignment - 1)) & mask;
    }

    /// <summary>
    /// Gets the number of textures in the texture bin.
    /// </summary>
    /// <returns></returns>
    public int GetNumTextures()
    {
        return Textures.Count;
    }

    /// <summary>
    /// Gets a texture by hash (crc32) in the texture bin.
    /// </summary>
    /// <param name="hash"></param>
    /// <returns></returns>
    public Texture GetByHash(uint hash)
    {
        return Textures[hash];
    }

    /// <summary>
    /// Gets a texture by name (by hashing it) in the texture bin.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public Texture GetByName(string name)
    {
        return Textures[CRC32.crc32_0x77073096(name)];
    }

    /// <summary>
    /// Gets a texture by index in the texture bin.
    /// </summary>
    /// <param name="index"></param>
    /// <returns>null if not found.</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Texture? GetByIndex(int index)
    {
        if (index >= Textures.Count)
            throw new ArgumentOutOfRangeException($"Texture index is out of range. (num textures: {Textures.Count}, index: {index})");

        int i = 0;
        foreach (var tex in Textures)
        {
            if (i == index)
                return tex.Value;

            i++;
        }

        return null;
    }
}
