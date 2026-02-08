using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using NenTools.Textures;
using NenTools.Textures.Dxgi;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.PixelFormats;

using BCnEncoder.Encoder;
using BCnEncoder.Shared;
using BCnEncoder.ImageSharp;

using GBFRDataTools.Hashing;

namespace GBFRDataTools.Files.Textures;

public class TextureBuilder
{
    private Dictionary<string, TextureTask> _queue = [];
    public IReadOnlyDictionary<string, TextureTask> Textures => _queue;

    public void AddImage(string name, string path, DXGI_FORMAT format = DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM)
    {
        byte[] bytes;
        if (Path.GetExtension(path) != ".dds" && Path.GetExtension(path) != ".gnf") // GNF = PS4
        {
            var image = Image.Load<Rgba32>(path);

            int pixelsPerBlock = (int)DxgiUtils.PixelsPerBlock(format);
            int bpp = (int)DxgiUtils.BitsPerPixel(format);
            int blockSize = pixelsPerBlock == 1 ? bpp / 8 : bpp * 2;


            if (DxgiUtils.IsBCnFormat(format)) // Encode to DXT/BCN
            {
                // BCnEncoder.NET gives us a nice way to just create a dds.
                BcEncoder encoder = new BcEncoder();

                encoder.OutputOptions.GenerateMipMaps = true;
                encoder.OutputOptions.Quality = CompressionQuality.Balanced;
                encoder.OutputOptions.FileFormat = OutputFileFormat.Dds;

                encoder.OutputOptions.Format = format switch
                {
                    DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM => CompressionFormat.Bc7,
                    DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM => CompressionFormat.Bc5,
                    DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM => CompressionFormat.Bc3,
                    DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM => CompressionFormat.Bc1,
                    _ => throw new NotImplementedException("TODO: Implement other BC format encoding"),
                };

                Console.WriteLine($"Encoding to {format}...");

                using var ddsHeaderStream = new MemoryStream();
                encoder.EncodeToStream(image, ddsHeaderStream);

                bytes = ddsHeaderStream.ToArray();
            }
            else
            {
                // RGBA32
                DxgiUtils.ComputePitch(format, (uint)image.Width, (uint)image.Height, out ulong rowPitch, out ulong slicePitch, out ulong alignedSlicePitch);

                byte[] buffer = new byte[slicePitch];
                for (int y = 0; y < image.Height; y++)
                {
                    var pixels = image.DangerousGetPixelRowMemory(y);
                    ReadOnlySpan<byte> rowBytes = MemoryMarshal.Cast<Rgba32, byte>(pixels.Span);
                    rowBytes.CopyTo(buffer.AsSpan(y * (int)rowPitch));
                }

                var flags = DDSHeaderFlags.TEXTURE | DDSHeaderFlags.LINEARSIZE;
                var ddsHeader = new DdsHeader()
                {
                    Flags = flags,
                    Width = image.Width,
                    Height = image.Height,
                    FormatFlags = DDSPixelFormatFlags.DDPF_FOURCC,
                    Depth = 1,
                    LastMipmapLevel = 1,
                    FourCCName = "DX10",
                    PitchOrLinearSize = (int)slicePitch,
                    DxgiFormat = format,
                };

                using var ddsHeaderStream = new MemoryStream();
                ddsHeader.Write(ddsHeaderStream, new MemoryStream(buffer));

                bytes = ddsHeaderStream.ToArray();
            }
        }
        else
        {
            // Grab DDS/GNF headers directly.
            bytes = File.ReadAllBytes(path);
        }

        _queue.Add(name, new TextureTask()
        {
            Name = name,
            Data = bytes,
        });
    }

    public TextureBin Build()
    {
        var bin = new TextureBin();
        foreach (var i in _queue)
        {
            uint hash = CRC32.crc32_0x77073096(i.Key);

            var texture = new Texture()
            {
                Hash = hash,
                Flag = TEXTURE_FLAG.TEXTURE_FLAG_UNK_0x20 | TEXTURE_FLAG.TEXTURE_FLAG_ALPHA,
            };
            texture.SetData(i.Value.Data);

            bin.Textures.Add(CRC32.crc32_0x77073096(i.Key), texture);
        }

        return bin;
    }

    public class TextureTask
    {
        public string Name { get; internal set; }
        public byte[] Data { get; internal set; }
    }
}
