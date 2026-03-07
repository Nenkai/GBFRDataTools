using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ButtonSwap
public class ButtonSwap : Component
{
    public string ButtonGuideType { get; set; }
    public UIObjectRef ButtonGuide { get; set; }
    public UIObjectRef ButtonGuideShortcut { get; set; }
}
