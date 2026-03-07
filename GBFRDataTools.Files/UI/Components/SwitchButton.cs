using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SwitchButton
public class SwitchButton : Component
{
    public UIObjectRef Button { get; set; }
    public UIObjectRef Lb { get; set; }
    public UIObjectRef Rb { get; set; }
    public UIObjectRef Cancel { get; set; }
    public UIObjectRef Fix { get; set; }
    public UIObjectRef SoundContainer { get; set; }
    public UIObjectRef Animator { get; set; }
    public UIObjectRef ChildButton { get; set; }
}
