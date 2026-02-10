using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

using BCnEncoder.Decoder;
using BCnEncoder.ImageSharp;

using GBFRDataTools.Files.UI;
using GBFRDataTools.Files.UI.Files;
using GBFRDataTools.Files.UI.YamlConverters;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace GBFRDataTools.Files.Textures.Atlas;

/* Usage:
   var a = new TextureAtlasBuilder();
   a.BuildFromDirectory(@"<path with images>");
   a.SaveTexture("<wtb file>");
   a.SaveTextureBin("<tex.texb file", alsoSaveYaml: true);
*/

/// <summary>
/// Texture atlas (.tex.texb + .wtb) builder.
/// </summary>
public class TextureAtlasBuilder
{
    public int AtlasSize { get; set; } = 4096;
    public int PaddingBetweenImages { get; set; } = 0;

    private Packer _packer;
    private TextureAtlasBuilderOptions _options;
    public bool _built = false;

    public void BuildFromTexBinary(string path)
    {
        // TODO
    }

    /// <summary>
    /// Builds a texture atlas from images from the specified directory.
    /// </summary>
    /// <param name="dir">Directory containing images.</param>
    public void BuildFromDirectory(string dir, TextureAtlasBuilderOptions? options = default)
    {
        _options = options ?? new TextureAtlasBuilderOptions();

        _packer = new Packer(AtlasSize, AtlasSize, PaddingBetweenImages);

        List<PackerBitmap> bitmaps = [];
        foreach (var imagePath in Directory.GetFiles(dir))
        {
            Image<Rgba32> image;
            if (imagePath.EndsWith(".dds"))
            {
                using var fs = File.OpenRead(imagePath);
                var decoder = new BcDecoder();
                image = decoder.DecodeToImageRgba32(fs);
            }
            else
            {
                image = Image.Load<Rgba32>(imagePath);
            }

            var bitmapThing = new PackerBitmap(image, Path.GetFileNameWithoutExtension(imagePath), false, false);
            bitmaps.Add(bitmapThing);
        }

        // Sort from biggest to smallest
        bitmaps.Sort();

        _packer.Pack(bitmaps, verbose: true, unique: false, rotate: false);
        _built = true;
    }

    /// <summary>
    /// Saves the texture atlas after it has been built to the specified path.
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="alsoSavePng">Whether to also save it in png form.</param>
    public void SaveTexture(string filePath, bool alsoSavePng = false)
    {
        CheckBuilt();

        using Image<Rgba32> textureImage = _packer.GetTexture();

        // Uv is flipped, so flip the image
        textureImage.Mutate(e => e.Flip(FlipMode.Vertical));

        if (alsoSavePng)
        {
            textureImage.Save(Path.ChangeExtension(filePath, ".png"));
        }

        var textures = new TextureBuilder();
        textures.AddImage(Path.GetFileNameWithoutExtension(filePath), textureImage);

        TextureBin textureBin = textures.Build();

        using FileStream fs = File.Create(filePath);
        textureBin.Write(fs);
    }

    /// <summary>
    /// Saves the texture metadata/binary to the specified path.
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="alsoSaveYaml">Whether to also save it in yaml form.</param>
    public void SaveTextureBin(string filePath, bool alsoSaveYaml = false)
    {
        CheckBuilt();

        var texture = new TextureBinary
        {
            Filter = _options.Filter,
            Wrap = _options.Wrap,
            Size = new Vector2(_packer.Width, _packer.Height)
        };

        for (int i = 0; i < _packer.Bitmaps.Count; i++)
        {
            var sprite = new Sprite();
            var bitmap = _packer.Bitmaps[i];
            int x = _packer.Points[i].x;
            int y = _packer.Points[i].y;

            sprite.Name = bitmap.Name;
            sprite.Rect = new Vector4(0, 0, bitmap.Width, bitmap.Height);
            sprite.Uv = new Vector4(
                (float)x / _packer.Width, 
                (float)y / _packer.Height, 
                (float)(x + bitmap.Width) / _packer.Width, 
                (float)(y + bitmap.Height) / _packer.Height
            );

            texture.Sprites.Add(sprite);
        }

        var serializer = new SerializerBuilder()
           .WithNamingConvention(PascalCaseNamingConvention.Instance)
           .WithTypeConverter(new Vector2ArrayYamlTypeConverter())
           .WithTypeConverter(new Vector4ArrayYamlTypeConverter())
           .Build();

        using var ms = new MemoryStream();
        var sw = new StreamWriter(ms);
        serializer.Serialize(sw, texture);
        sw.Flush();

        if (alsoSaveYaml)
        {
            File.WriteAllBytes(Path.Combine(Path.GetDirectoryName(filePath), Path.GetFileNameWithoutExtension(filePath) + ".yaml"), ms.ToArray());
        }

        ms.Position = 0;
        StreamReader sr = new StreamReader(ms);
        var yamlStream = new YamlStream();
        yamlStream.Load(sr);

        var bulkWriter = new BulkWriter();
        bulkWriter.Write(filePath, yamlStream.Documents[0].RootNode);
    }

    private void CheckBuilt()
    {
        if (!_built)
            throw new InvalidOperationException("Texture atlas is not built yet.");
    }
}

public class TextureAtlasBuilderOptions
{
    public bool Wrap { get; set; } = true;
    public bool Filter { get; set; } = true;
}


