using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemRewardTreasureItem
public class ItemRewardTreasureItem // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Anim", UIFieldType.ObjectRef),
        new("RewardItem", UIFieldType.ObjectRef),
        new("Treasurebox", UIFieldType.ObjectRef),
        new("RewardRankImage", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
