using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Window
public class Window : Component
{
    public UIObjectRef Button { get; set; }
    public UIObjectRef SoundContainer { get; set; }
    public UIObjectRef Animator { get; set; }
    public UIObjectRef AssistIcon { get; set; }
    public UIObjectRef ChildButton { get; set; }
    public List<UIObjectRef> OptionLRCursors { get; set; }
}
