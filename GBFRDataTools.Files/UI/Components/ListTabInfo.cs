using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ListTabInfo
public class ListTabInfo : Component
{
    public List<UIObjectRef> Button { get; set; }
    public List<UIObjectRef> ButtonImage { get; set; }
    public List<UIObjectRef> SingleDisables { get; set; }
    public List<UIObjectRef> UpdateIcons { get; set; }
    public UIObjectRef TabAnim { get; set; }
    public UIObjectRef TabTitle { get; set; }
    public UIObjectRef LeftText { get; set; }
    public UIObjectRef RightText { get; set; }
}
