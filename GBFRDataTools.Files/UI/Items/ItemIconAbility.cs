using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemIconAbility
public class ItemIconAbility // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Animator", UIFieldType.ObjectRef),
        new("Frame", UIFieldType.ObjectRef),
        new("Icon", UIFieldType.ObjectRef),
        new("IconImage", UIFieldType.ObjectRef),
        new("Invalid", UIFieldType.ObjectRef),
        new("Effect", UIFieldType.ObjectRef),
        new("Mask", UIFieldType.ObjectRef),
        new("Command", UIFieldType.ObjectRef),
        new(0xB2968EA9, UIFieldType.S32),
        new(0xE3A8D99F, UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
