using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemQuestDetailRewardIcon
public class ItemQuestDetailRewardIcon : Component
{
    public List<UIObjectRef> IconObjs { get; set; }
    public List<UIObjectRef> BahaIcons { get; set; }
    public List<UIObjectRef> QuestDetailHideObjs { get; set; }
    public UIObjectRef RewardTypeText { get; set; }
    public UIObjectRef MaterialInfo { get; set; }
    public UIObjectRef WeaponInfo { get; set; }
    public UIObjectRef GemInfo { get; set; }
    public UIObjectRef PendulumInfo { get; set; }
    public UIObjectRef RupiInfo { get; set; }
    public UIObjectRef Count { get; set; }
    public UIObjectRef Animator { get; set; }
    public UIObjectRef FavoriteIcon { get; set; }
    public UIObjectRef WarningIcon { get; set; }
    public UIObjectRef DisableObj { get; set; }
    public UIObjectRef BgIcon { get; set; }
    public UIObjectRef CheckIcon { get; set; }
}
