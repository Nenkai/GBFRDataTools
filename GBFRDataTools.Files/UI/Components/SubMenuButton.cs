using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SubMenuButton
public class SubMenuButton : Component
{
    public UIObjectRef ItemName { get; set; }
    public UIObjectRef OpenSubmenuShortcut { get; set; }
    public UIObjectRef SoundContainer { get; set; }
    public UIObjectRef Animator { get; set; }
    public UIObjectRef ChildButton { get; set; }
    public UIObjectRef OptionLRCursors { get; set; }
}
