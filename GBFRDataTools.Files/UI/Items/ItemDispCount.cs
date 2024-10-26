using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemDispCount
public class ItemDispCount // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("CompareSets", UIFieldType.ObjectRefVector),
         new("CompareEmpties", UIFieldType.ObjectRefVector),
         new("IconSets", UIFieldType.ObjectRefVector),
         new("IconEmpties", UIFieldType.ObjectRefVector),
         new("BeforeCount", UIFieldType.ObjectRef),
         new("AfterCount", UIFieldType.ObjectRef),
         new("Icon", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
