using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemShopGachaTotalResultDetail
public class ItemShopGachaTotalResultDetail // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new(0x929AC963, UIFieldType.ObjectRefVector),
        new(0xDEA105DC, UIFieldType.ObjectRef),
        new("Animator", UIFieldType.ObjectRef),
        new("ChangeSkillDispMode", UIFieldType.ObjectRef),
        new("Protect", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
