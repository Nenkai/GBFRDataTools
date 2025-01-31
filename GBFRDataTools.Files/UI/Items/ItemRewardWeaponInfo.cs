using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemRewardWeaponInfo
public class ItemRewardWeaponInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new(0x929AC963, UIFieldType.ObjectRefVector),
        new("Item", UIFieldType.ObjectRef),
        new("ButtonGuide", UIFieldType.ObjectRef),
        new("Anim", UIFieldType.ObjectRef),
        new("ChangeSkillDispMode", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
