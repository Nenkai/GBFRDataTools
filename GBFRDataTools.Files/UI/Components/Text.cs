using System.Numerics;

using YamlDotNet.Serialization;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Text
public class Text : Component
{
    [YamlMember(Alias = "Text")]
    public string Text_ { get; set; }

    public string FontPath { get; set; }
    public string MaterialPath { get; set; }
    public float FontSize { get; set; }
    public Vector4 Color { get; set; }
    public Vector4 Margin { get; set; }
    public bool IsGradient { get; set; }
    public sbyte ColorMode { get; set; }
    public Vector4 ColorTL { get; set; }
    public Vector4 ColorTR { get; set; }
    public Vector4 ColorBL { get; set; }
    public Vector4 ColorBR { get; set; }
    public float CharacterSpacing { get; set; }
    public float LineSpacing { get; set; }
    public short Alignment { get; set; }
}
