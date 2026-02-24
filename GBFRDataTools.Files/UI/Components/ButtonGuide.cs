using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ButtonGuide
public class ButtonGuide : Component
{
    public List<UIObjectRef> Buttons { get; set; }
    public List<UIObjectRef> Texts { get; set; }
    public string ButtonGuideType { get; set; }
    public List<UIObjectRef> Shortcuts { get; set; }
    public UIObjectRef SlashRoot { get; set; }
    public UIObjectRef SlashShadow { get; set; }
    public UIObjectRef Button2Root { get; set; }
    public UIObjectRef ItemButton { get; set; }
    public List<UIObjectRef> Button2S { get; set; }
    public bool Dark { get; set; }
}
