using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemBlacksmithSubMenu
public class ItemBlacksmithSubMenu // : ItemButtonText
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Icon", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(ItemButtonText.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
