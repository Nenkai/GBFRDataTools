using BCnEncoder.Encoder;
using BCnEncoder.ImageSharp;
using BCnEncoder.Shared;

using GBFRDataTools.Hashing;

using NenTools.Textures;
using NenTools.Textures.Dxgi;
using NenTools.Textures.PS3;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.PixelFormats;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.Textures;

public class TextureBuilder
{
    private Dictionary<string, TextureTask> _queue = [];
    public IReadOnlyDictionary<string, TextureTask> Textures => _queue;

    public void AddImage(string name, string path, DXGI_FORMAT format = DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM)
    {
        if (Path.GetExtension(path) != ".dds" && Path.GetExtension(path) != ".gnf") // GNF = PS4
        {
            var image = Image.Load<Rgba32>(path);
            AddImage(name, image, format);
        }
        else
        {
            // Grab DDS/GNF headers directly.
            byte[] bytes = File.ReadAllBytes(path);

            _queue.Add(name, new TextureTask()
            {
                Name = name,
                Data = bytes,
            });
        }
    }

    public void AddImage(string name, Image<Rgba32> image, DXGI_FORMAT format = DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM)
    {
        byte[] bytes;
        int pixelsPerBlock = (int)DxgiUtils.PixelsPerBlock(format);
        int bpp = (int)DxgiUtils.BitsPerPixel(format);
        int blockSize = pixelsPerBlock == 1 ? bpp / 8 : bpp * 2;

        if (DxgiUtils.IsBCnFormat(format)) // Encode to DXT/BCN
        {
            // BCnEncoder.NET gives us a nice way to just create a dds.
            // Nevermind, don't use BcEncoder. It's way too slow for Bc7. texconv will give us a way to use Gpu based compression.

            /*
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
            */

            bytes = TexConvConvert(image, format);
        }
        else if (format == DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM)
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
        else
            throw new NotSupportedException($"{format} not yet supported");

        _queue.Add(name, new TextureTask()
        {
            Name = name,
            Data = bytes,
        });
    }

    private static byte[] TexConvConvert(Image<Rgba32> image, DXGI_FORMAT format)
    {
        // We use texconv mainly because BCnEncoder.NET is attrociously slow with Bc7. It's expected with Bc7, but software encoding takes literal minutes
        // TexConv will use DirectCompute, so we'll let it do its thing
        // Plus we get a proper dds header at least.
        // Sorry linux users!

        if (!File.Exists("Binaries/texconv.exe"))
            throw new FileNotFoundException("TexConv is missing in the Binaries folder.");

        byte[] bytes;
        Directory.CreateDirectory("temp");
        image.SaveAsPng("temp/temp.png");


        string arguments = $"temp/temp.png";
        arguments += $" -f {format.ToString().Replace("DXGI_FORMAT_", string.Empty)}";

        arguments += " -y"      // Overwrite if it exists
                  + " -nologo"  // No copyright logo
                  + " -srgb"    // Auto correct gamma
                  + $" -o temp"; // Set directory to file input's directory

        Process converter = Process.Start(Path.Combine(Directory.GetCurrentDirectory(), "Binaries/texconv.exe"), arguments);
        converter.WaitForExit();

        if (converter.ExitCode != 0)
        {
            CleanupTemp();
            throw new IOException("texconv failed to convert file to dds.");
        }

        bytes = File.ReadAllBytes("temp/temp.dds");

        CleanupTemp();

        return bytes;
    }

    private static void CleanupTemp()
    {
        File.Delete("temp/temp.png");
        File.Delete("temp/temp.dds");
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
