using GBFRDataTools.Files.UI.Assets;

using System.Numerics;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Image
public class Image : Component
{
    public Vector4 Color { get; set; }
    public SpriteRef Sprite { get; set; }
    public int Type { get; set; }
    public string MaterialPath { get; set; }
    public bool FillCenter { get; set; }
    public int FillMethod { get; set; }
    public int FillOrigin { get; set; }
    public float FillAmount { get; set; }
    public Vector4 UvRect { get; set; }
    public bool RawImage { get; set; }
    public bool Clockwise { get; set; }
    public bool PreserveAspect { get; set; }
    public sbyte _E3ED5266 { get; set; }
}
