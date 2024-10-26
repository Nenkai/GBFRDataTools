using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemList
public class ItemList // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("IconMask", UIFieldType.ObjectRef),
         new("CharaIcon", UIFieldType.ObjectRef),
         new("WeaponIcon", UIFieldType.ObjectRef),
         new("GemIcon", UIFieldType.ObjectRef),
         new("RemoveObj", UIFieldType.ObjectRef),
         new("ListTexts", UIFieldType.ObjectRefVector),
         new("UpdateIcon", UIFieldType.ObjectRef),
         new("Elements", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
