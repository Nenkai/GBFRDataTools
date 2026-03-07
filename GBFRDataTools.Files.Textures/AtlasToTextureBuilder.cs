using System;
using System.Collections.Generic;
using System.Text;

using BCnEncoder.Decoder;
using BCnEncoder.ImageSharp;

using GBFRDataTools.Files.UI.Serialization;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace GBFRDataTools.Files.Textures;

public class AtlasToTextureBuilder
{
    private Files.UI.Assets.Texture _texture;
    private Image<Rgba32> _textureAtlasImage;

    public void AddFromTextureAtlasDefinition(string inputYamlPath)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(inputYamlPath, nameof(inputYamlPath));

        string folder = inputYamlPath.TrimEnd(".tex.yaml").ToString();
        if (!Directory.Exists(folder))
            throw new FileNotFoundException($"ERROR: .tex.yaml conversion must have a matching folder containing textures");

        var serializer = YamlSerializer.GetDeserializer();

        _texture = serializer.Deserialize<Files.UI.Assets.Texture>(File.ReadAllText(inputYamlPath));
        _textureAtlasImage = new Image<Rgba32>((int)_texture.Size.X, (int)_texture.Size.Y);

        for (int i = 0; i < _texture.Sprites.Count; i++)
        {
            var sprite = _texture.Sprites[i];

            string path = Path.Combine(folder, sprite.Name);
            AddImage(sprite, path);
        }
    }

    private void AddImage(UI.Assets.Sprite sprite, string path)
    {
        Image<Rgba32> spriteImage;
        if (File.Exists(path + ".dds"))
        {
            BcDecoder decoder = new BcDecoder();
            using var fs = File.OpenRead(path + ".dds");
            spriteImage = decoder.DecodeToImageRgba32(fs);
        }
        else if (File.Exists(path + ".png"))
        {
            spriteImage = Image.Load<Rgba32>(path + ".png");
        }
        else
            throw new NotSupportedException();

        var uv = sprite.Uv;
        float x1 = _texture.Size.X * uv.X;
        float y1 = _texture.Size.Y - (_texture.Size.Y * uv.Y);
        float x2 = _texture.Size.X * uv.Z;
        float y2 = _texture.Size.Y - (_texture.Size.Y * uv.W);
        (y2, y1) = (y1, y2);

        _textureAtlasImage.Mutate(e =>
        {
            e.DrawImage(spriteImage, new Point((int)x1, (int)y1), 1.0f);
        });
    }

    public void BuildAndSave(string outPath, string name)
    {
        if (_textureAtlasImage is null)
            throw new InvalidOperationException($"No texture atlas, did you call {nameof(AddFromTextureAtlasDefinition)}?");

        _textureAtlasImage.Mutate(e => e.Flip(FlipMode.Vertical));

        var builder = new TextureBuilder();
        builder.AddImage(name, _textureAtlasImage, withMipmaps: false); // UI Textures don't normally need mipmaps.
        TextureBin bin = builder.Build();

        using var fs = File.Create(outPath);
        bin.Write(fs);

        _textureAtlasImage?.Dispose();

        // Write .tex.texb
        BulkWriter writer = new BulkWriter();
        writer.Write(Path.ChangeExtension(outPath, ".tex.texb"), _texture);
    }
}
