using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Result.Reward;

// ui::component::ControllerResultReward
public class ControllerResultReward // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("MenuDataList", UIFieldType.ObjectRefVector),
        new("RetryMemberLineObject", UIFieldType.ObjectRefVector),
        new("Anim", UIFieldType.ObjectRef),
        new("MenuRewardsTreasure", UIFieldType.ObjectRef),
        new("Reward01", UIFieldType.ObjectRef),
        new("Reward02", UIFieldType.ObjectRef),
        new("Reward03", UIFieldType.ObjectRef),
        new("RewardInfoItem", UIFieldType.ObjectRef),
        new("RewardInfoWeapon", UIFieldType.ObjectRef),
        new("RewardInfoGem", UIFieldType.ObjectRef),
        new("RewardInfoPendulum", UIFieldType.ObjectRef),
        new("MenuResultRewardMember", UIFieldType.ObjectRef),
        new("MoneyText", UIFieldType.ObjectRef),
        new("MaskTopObject", UIFieldType.ObjectRef),
        new("ScrollBarParent", UIFieldType.ObjectRef),
        new("ScrollBarBaseObject", UIFieldType.ObjectRef),
        new("ScrollBarPartsObject", UIFieldType.ObjectRef),
        new("VoteButton", UIFieldType.ObjectRef),
        new("FixButton", UIFieldType.ObjectRef),
        new("CancelButton", UIFieldType.ObjectRef),
        new("FavoriteButton", UIFieldType.ObjectRef),
        new("GoodjobRootObject", UIFieldType.ObjectRef),
        new("GoodjobData", UIFieldType.ObjectRef),
        new("MspText", UIFieldType.ObjectRef),
        new("MspObject", UIFieldType.ObjectRef),
        new("CharaWeaponObject", UIFieldType.ObjectRef),
        new("CharaWeaponText", UIFieldType.ObjectRef),
        new("CharaWeaponIconSetter", UIFieldType.ObjectRef),
        new("NoRewardTextObject", UIFieldType.ObjectRef),
        new("TreasureAnimDelay", UIFieldType.F32),
        new("TreasureAnimInterval", UIFieldType.F32),
        new("ItemAnimStartDelay", UIFieldType.U32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
