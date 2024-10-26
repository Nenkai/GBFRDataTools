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
         new("IgnoreLayout", UIFieldType.Bool),
         new("MinWidth", UIFieldType.F32),
         new("MinHeight", UIFieldType.F32),
         new("PreferredWidth", UIFieldType.F32),
         new("PreferredHeight", UIFieldType.F32),
         new("LayoutPriority", UIFieldType.S32),
         new(0x6DEA1A08, UIFieldType.F32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
