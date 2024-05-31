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
         new("CompareSets", FieldType.ObjectRefVector),
         new("CompareEmpties", FieldType.ObjectRefVector),
         new("IconSets", FieldType.ObjectRefVector),
         new("IconEmpties", FieldType.ObjectRefVector),
         new("BeforeCount", FieldType.ObjectRef),
         new("AfterCount", FieldType.ObjectRef),
         new("Icon", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
