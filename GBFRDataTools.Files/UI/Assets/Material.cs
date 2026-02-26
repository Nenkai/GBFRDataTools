using System.Numerics;

namespace GBFRDataTools.Files.UI.Assets;

// matb - ui::asset::Material
// (thanks file 0C009F42BA90B0DD for having a list of most properties as a .msg file)
public class Material
{
    public float Blend { get; set; }
    public float ScaleRatioA { get; set; }
    public float ScaleRatioB { get; set; }
    public float ScaleRatioC { get; set; }
    public float GradiantScale { get; set; }
    public Vector4 FaceColor { get; set; }
    public float FaceDilate { get; set; }
    public Vector3 OutlineColor { get; set; }
    public float OutlineWidth { get; set; }
    public float OutlineSoftness { get; set; }
    public bool UnderlayEnable { get; set; }
    public Vector4 UnderlayColor { get; set; }
    public float UnderlayOffsetX { get; set; }
    public float UnderlayOffsetY { get; set; }
    public float UnderlayDilate { get; set; }
    public float UnderlaySoftness { get; set; }
    public bool GlowEnable { get; set; }
    public Vector4 GlowColor { get; set; }
    public float GlowInner { get; set; }
    public float GlowOffset { get; set; }
    public float GlowOuter { get; set; }
    public float GlowPower { get; set; }
    public string ShaderPath { get; set; }
    public float _259D1272 { get; set; }
}