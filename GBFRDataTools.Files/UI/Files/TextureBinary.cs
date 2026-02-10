using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GBFRDataTools.Files.UI.Files;

public class TextureBinary
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
