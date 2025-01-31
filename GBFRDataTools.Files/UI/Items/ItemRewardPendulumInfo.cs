using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemRewardPendulumInfo
public class ItemRewardPendulumInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new(0x929AC963, UIFieldType.ObjectRefVector),
        new("Item", UIFieldType.ObjectRef), // E6B859BA
        new("ButtonGuide", UIFieldType.ObjectRef), // 51BDB018
        new("Anim", UIFieldType.ObjectRef), // C16D7C98
        new("ChangeSkillDispMode", UIFieldType.ObjectRef), // CE59164A
        new("Protect", UIFieldType.ObjectRef), // 6B1E898A
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
