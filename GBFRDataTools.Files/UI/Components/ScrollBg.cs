using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ScrollBg
public class ScrollBg : Component
{
    public UIObjectRef Target { get; set; }
    public UIObjectRef Bg { get; set; }
    public UIObjectRef Bar { get; set; }
    public int Reverse { get; set; }
    public int Operation { get; set; }
    public int Repeat { get; set; }
}
