using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemLinkCounterChance
public class ItemLinkCounterChance // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Root", UIFieldType.ObjectRef),
         new("Animator", UIFieldType.ObjectRef),
         new("CharaInfo", UIFieldType.ObjectRef),
         new("CharaIcons", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
