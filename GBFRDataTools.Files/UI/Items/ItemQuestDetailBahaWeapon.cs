using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemQuestDetailBahaWeapon
public class ItemQuestDetailBahaWeapon // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("WeaponSkills", UIFieldType.ObjectRefVector),
         new(0x4DDEA1F2, UIFieldType.ObjectRefVector),
         new("Charas", UIFieldType.ObjectRefVector),
         new("Animator", UIFieldType.ObjectRef),
         new("WeaponRootObj", UIFieldType.ObjectRef),
         new("WeaponTitle", UIFieldType.ObjectRef),
         new("WeaponLevel", UIFieldType.ObjectRef),
         new("WeaponLimit", UIFieldType.ObjectRef),
         new("HasAllWeaponObj", UIFieldType.ObjectRef),
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
