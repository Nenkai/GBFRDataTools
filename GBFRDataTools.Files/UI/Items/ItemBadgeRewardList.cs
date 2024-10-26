using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemBadgeRewardList
public class ItemBadgeRewardList // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Sets", UIFieldType.ObjectRefVector),
         new("Empties", UIFieldType.ObjectRefVector),
         new("ConfirmationObjs", UIFieldType.ObjectRefVector),
         new("CompletedObjs", UIFieldType.ObjectRefVector),
         new("MaterialInfo", UIFieldType.ObjectRef),
         new("ValueInfo", UIFieldType.ObjectRef),
         new("PendulumInfo", UIFieldType.ObjectRef),
         new("GemInfo", UIFieldType.ObjectRef),
         new("CharaColorInfo", UIFieldType.ObjectRef),
         new("StampInfo", UIFieldType.ObjectRef),
         new(0xDA06E0ED, UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
