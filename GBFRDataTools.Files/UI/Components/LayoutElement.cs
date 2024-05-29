using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::LayoutElement
public class LayoutElement // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new("IgnoreLayout", FieldType.Bool),
         new("MinWidth", FieldType.F32),
         new("MinHeight", FieldType.F32),
         new("PreferredWidth", FieldType.F32),
         new("PreferredHeight", FieldType.F32),
         new("LayoutPriority", FieldType.S32),
         new(0x6DEA1A08, FieldType.F32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
