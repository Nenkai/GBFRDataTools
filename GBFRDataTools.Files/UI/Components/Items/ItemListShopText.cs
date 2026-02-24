using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemListShopText
public class ItemListShopText : Component
{
    public List<UIObjectRef> Name { get; set; }
    public UIObjectRef Tag01 { get; set; }
    public UIObjectRef Value01 { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef Tag02 { get; set; }
    public UIObjectRef Value02 { get; set; }
}
