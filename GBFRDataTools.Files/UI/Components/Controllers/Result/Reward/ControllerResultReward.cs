using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Result.Reward;

// ui::component::ControllerResultReward
public class ControllerResultReward : Controller
{
    public List<UIObjectRef> MenuDataList { get; set; }
    public List<UIObjectRef> RetryMemberLineObject { get; set; }
    public UIObjectRef Anim { get; set; }
    public UIObjectRef MenuRewardsTreasure { get; set; }
    public UIObjectRef Reward01 { get; set; }
    public UIObjectRef Reward02 { get; set; }
    public UIObjectRef Reward03 { get; set; }
    public UIObjectRef RewardInfoItem { get; set; }
    public UIObjectRef RewardInfoWeapon { get; set; }
    public UIObjectRef RewardInfoGem { get; set; }
    public UIObjectRef RewardInfoPendulum { get; set; }
    public UIObjectRef MenuResultRewardMember { get; set; }
    public UIObjectRef MoneyText { get; set; }
    public UIObjectRef MaskTopObject { get; set; }
    public UIObjectRef ScrollBarParent { get; set; }
    public UIObjectRef ScrollBarBaseObject { get; set; }
    public UIObjectRef ScrollBarPartsObject { get; set; }
    public UIObjectRef VoteButton { get; set; }
    public UIObjectRef FixButton { get; set; }
    public UIObjectRef CancelButton { get; set; }
    public UIObjectRef FavoriteButton { get; set; }
    public UIObjectRef GoodjobRootObject { get; set; }
    public UIObjectRef GoodjobData { get; set; }
    public UIObjectRef MspText { get; set; }
    public UIObjectRef MspObject { get; set; }
    public UIObjectRef CharaWeaponObject { get; set; }
    public UIObjectRef CharaWeaponText { get; set; }
    public UIObjectRef CharaWeaponIconSetter { get; set; }
    public UIObjectRef NoRewardTextObject { get; set; }
    public float TreasureAnimDelay { get; set; }
    public float TreasureAnimInterval { get; set; }
    public uint ItemAnimStartDelay { get; set; }
}
