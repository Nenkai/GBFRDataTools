using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemStatusUpNum
public class ItemStatusUpNum // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("HpObj", UIFieldType.ObjectRef),
        new("AfterNum", UIFieldType.ObjectRef),
        new("BeforeNum", UIFieldType.ObjectRef),
        new("LvObj", UIFieldType.ObjectRef),
        new("AtkObj", UIFieldType.ObjectRef),
        new("PlusObj", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
