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

namespace GBFRDataTools.Files.Textures;

public class TextureBin
{
    private Dictionary<uint, Texture> _textures { get; set; } = [];

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
        bs.Read(headerBytes);

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
            uint textureFlag = bs.ReadUInt32();

            bs.Position = basePos + header.m_HashOfs + (i * sizeof(int));
            uint textureHash = bs.ReadUInt32();

            var texture = new Texture();
            bs.Position = dxBaseTexOfs;
            texture.SetDDS(bs.ReadBytes((int)textureSize));
            texture.Flag = textureFlag;
            texture.Hash = textureHash;
            texBin._textures.Add(texture.Hash, texture);
        }

        return texBin;
    }

    /// <summary>
    /// Gets the number of textures in the texture bin.
    /// </summary>
    /// <returns></returns>
    public int GetNumTextures()
    {
        return _textures.Count;
    }

    /// <summary>
    /// Gets a texture by hash (crc32) in the texture bin.
    /// </summary>
    /// <param name="hash"></param>
    /// <returns></returns>
    public Texture GetByHash(uint hash)
    {
        return _textures[hash];
    }

    /// <summary>
    /// Gets a texture by name (by hashing it) in the texture bin.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public Texture GetByName(string name)
    {
        uint hash = 0;
        return _textures[hash];
    }

    /// <summary>
    /// Gets a texture by index in the texture bin.
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Texture GetByIndex(int index)
    {
        if (index >= _textures.Count)
            throw new ArgumentOutOfRangeException($"Texture index is out of range. (num textures: {_textures.Count}, index: {index})");

        int i = 0;
        foreach (var tex in _textures)
        {
            if (i == index)
                return tex.Value;

            i++;
        }

        return null;
    }
}
