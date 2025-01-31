using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemResultRewardMember
public class ItemResultRewardMember // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new(0x314A0304, UIFieldType.ObjectRefVector),
        new("Anim", UIFieldType.ObjectRef),
        new("CheckBox", UIFieldType.ObjectRef),
        new(0x1600EDB2, UIFieldType.ObjectRef),
        new(0x48D87A79, UIFieldType.ObjectRef),
        new("CharName", UIFieldType.ObjectRef),
        new(0xC09F961, UIFieldType.ObjectRef),
        new(0xD029D446, UIFieldType.ObjectRef),
        new("SoundContainer", UIFieldType.ObjectRef),
        new("CharaIcon", UIFieldType.ObjectRef),
        new(0x76EE7AD, UIFieldType.ObjectRef),
        new(0x64FF7341, UIFieldType.ObjectRef),
        new(0xF3C653DD, UIFieldType.ObjectRef),
        new(0x8719C3A8, UIFieldType.ObjectRef),
        new(0xC2F87F99, UIFieldType.ObjectRef),
        new(0xADAB584, UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
