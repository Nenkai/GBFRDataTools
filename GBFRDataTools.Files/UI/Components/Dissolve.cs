using GBFRDataTools.Files.UI.Assets;

using System.Numerics;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Dissolve
public class Dissolve : Component
{
    public SpriteRef DissolveTexture { get; set; }
    public float Cutoff { get; set; }
    public bool AddColor1Enabled { get; set; }
    public Vector4 AddColor1 { get; set; }
    public float BorderWidth1 { get; set; }
    public bool AddColor2Enabled { get; set; }
    public Vector4 AddColor2 { get; set; }
    public float BorderWidth2 { get; set; }
    public bool TrailEnabled { get; set; }
    public float TrailWidth { get; set; }
    public int RenderType { get; set; }
}
