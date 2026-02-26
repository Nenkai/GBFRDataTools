using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemBadgeOne
public class ItemBadgeOne : Component
{
    public UIObjectRef BadgeInfo { get; set; }
    public List<UIObjectRef> TitleTexts { get; set; }
}
