using GBFRDataTools.Files.UI.Types;

using System.Numerics;

namespace GBFRDataTools.Files.UI.Assets;

// ui::asset::List
public class Texture
{
    public bool Wrap { get; set; }
    public bool Filter { get; set; }
    public Vector2 Size { get; set; }
    public List<Sprite> Sprites { get; set; } = [];
}

public class Sprite
{
    public string Name { get; set; }
    public Vector4 Rect { get; set; }
    public Vector4 Border { get; set; }
    public Vector4 Padding { get; set; }
    public Vector4 Uv { get; set; }
    public Vector2 MinSize { get; set; }
}

// ui::SpriteRef
public class SpriteRef
{
    public string TexturePath { get; set; }
    public CyanStringHash SpriteName { get; set; }
}
