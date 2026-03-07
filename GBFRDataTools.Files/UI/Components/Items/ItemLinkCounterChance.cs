using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemLinkCounterChance
public class ItemLinkCounterChance : Component
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef Animator { get; set; }
    public UIObjectRef CharaInfo { get; set; }
    public List<UIObjectRef> CharaIcons { get; set; }
}
