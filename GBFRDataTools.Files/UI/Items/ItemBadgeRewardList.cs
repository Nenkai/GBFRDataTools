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
         new("Sets", FieldType.ObjectRefVector),
         new("Empties", FieldType.ObjectRefVector),
         new("ConfirmationObjs", FieldType.ObjectRefVector),
         new("CompletedObjs", FieldType.ObjectRefVector),
         new("MaterialInfo", FieldType.ObjectRef),
         new("ValueInfo", FieldType.ObjectRef),
         new("PendulumInfo", FieldType.ObjectRef),
         new("GemInfo", FieldType.ObjectRef),
         new("CharaColorInfo", FieldType.ObjectRef),
         new("StampInfo", FieldType.ObjectRef),
         new(0xDA06E0ED, FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
