using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::ShopSellInfo
public class ShopSellInfo : Component
{
    public int Mode { get; set; }
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> MaterialSets { get; set; }
    public List<UIObjectRef> GemSets { get; set; }
    public List<UIObjectRef> PendulumSets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> ListTexts { get; set; }
    public List<UIObjectRef> PriceTexts { get; set; }
    public List<UIObjectRef> ItemTexts { get; set; }
    public List<UIObjectRef> NeedCountTexts { get; set; }
    public List<UIObjectRef> SellCountTexts { get; set; }
    public List<UIObjectRef> PositionCountTexts { get; set; }
    public List<UIObjectRef> LvTexts { get; set; }
    public List<UIObjectRef> ItemIcons { get; set; }
    public List<UIObjectRef> GemIcons { get; set; }
    public List<UIObjectRef> SkillIcons { get; set; }
    public List<UIObjectRef> ItemImageSets { get; set; }
    public UIObjectRef MenuDial { get; set; }
    public UIObjectRef CheckButton { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
    public UIObjectRef UpdateCharaIcon { get; set; }
    public UIObjectRef SkillHorizontalLayoutGroup { get; set; }
}
