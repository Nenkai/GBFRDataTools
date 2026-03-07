using System.Numerics;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::TextRuby
public class TextRuby : Component
{
    public string Text { get; set; }
    public string Material { get; set; }
    public int FontSize { get; set; }
    public int Spacing { get; set; }
    public Vector4 Color { get; set; }
}
