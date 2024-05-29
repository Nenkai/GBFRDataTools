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
         new("IconMask", FieldType.ObjectRef),
         new("CharaIcon", FieldType.ObjectRef),
         new("WeaponIcon", FieldType.ObjectRef),
         new("GemIcon", FieldType.ObjectRef),
         new("RemoveObj", FieldType.ObjectRef),
         new("ListTexts", FieldType.ObjectRefVector),
         new("UpdateIcon", FieldType.ObjectRef),
         new("Elements", FieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
