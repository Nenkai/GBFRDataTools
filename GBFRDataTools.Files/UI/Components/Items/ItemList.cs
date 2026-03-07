using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemList
public class ItemList : Component
{
    public UIObjectRef IconMask { get; set; }
    public UIObjectRef CharaIcon { get; set; }
    public UIObjectRef WeaponIcon { get; set; }
    public UIObjectRef GemIcon { get; set; }
    public UIObjectRef RemoveObj { get; set; }
    public List<UIObjectRef> ListTexts { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
    public List<UIObjectRef> Elements { get; set; }
}
