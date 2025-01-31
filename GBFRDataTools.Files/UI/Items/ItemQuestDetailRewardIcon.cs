using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemQuestDetailRewardIcon
public class ItemQuestDetailRewardIcon // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("IconObjs", UIFieldType.ObjectRefVector),
        new("BahaIcons", UIFieldType.ObjectRefVector),
        new("QuestDetailHideObjs", UIFieldType.ObjectRefVector),
        new("RewardTypeText", UIFieldType.ObjectRef),
        new("MaterialInfo", UIFieldType.ObjectRef),
        new("WeaponInfo", UIFieldType.ObjectRef),
        new("GemInfo", UIFieldType.ObjectRef),
        new("PendulumInfo", UIFieldType.ObjectRef),
        new("RupiInfo", UIFieldType.ObjectRef),
        new("Count", UIFieldType.ObjectRef),
        new("Animator", UIFieldType.ObjectRef),
        new("FavoriteIcon", UIFieldType.ObjectRef),
        new("WarningIcon", UIFieldType.ObjectRef),
        new("DisableObj", UIFieldType.ObjectRef),
        new("BgIcon", UIFieldType.ObjectRef),
        new("CheckIcon", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
