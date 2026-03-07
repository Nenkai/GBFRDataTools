using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemWinCutWordlist
public class ItemWinCutWordlist : Component
{
    public UIObjectRef ButtonObj { get; set; }
    public UIObjectRef Animator { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef CursorSelect { get; set; }
    public UIObjectRef CursorFixed { get; set; }
    public List<UIObjectRef> Texts { get; set; }
}
