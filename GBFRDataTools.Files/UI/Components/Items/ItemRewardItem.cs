using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemRewardItem
public class ItemRewardItem : Component
{
    public UIObjectRef Anim { get; set; }
    public UIObjectRef MaterialInfo { get; set; }
    public UIObjectRef WeaponInfo { get; set; }
    public UIObjectRef GemInfo { get; set; }
    public UIObjectRef RupiInfo { get; set; }
    public UIObjectRef PendulumInfo { get; set; }
    public UIObjectRef NeedMaterialInfo { get; set; }
    public UIObjectRef ItemIconSetter { get; set; }
    public UIObjectRef ItemNumText01 { get; set; }
    public UIObjectRef ItemNumText02 { get; set; }
    public UIObjectRef ParentTreasureItem { get; set; }
    public UIObjectRef IconEffect { get; set; }
    public UIObjectRef NewItemAnim { get; set; }
    public UIObjectRef ItemCount { get; set; }
    public List<UIObjectRef> FavoriteObjList { get; set; }
    public List<UIObjectRef> PartsBreakObjList { get; set; }
    public List<UIObjectRef> NewItemObjList { get; set; }
    public List<UIObjectRef> PrevSkillLotObjList { get; set; }
    public List<UIObjectRef> PostSkillLotObjList { get; set; }
    public List<UIObjectRef> PostSkillLotLevelObjList { get; set; }
}
