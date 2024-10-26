using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemListShopText
public class ItemListShopText // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Name", UIFieldType.ObjectRefVector),
         new("Tag01", UIFieldType.ObjectRef),
         new("Value01", UIFieldType.ObjectRef),
         new("Icon", UIFieldType.ObjectRef),
         new("Tag02", UIFieldType.ObjectRef),
         new("Value02", UIFieldType.ObjectRef),   
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
