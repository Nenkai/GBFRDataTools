using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::LayoutElement
public class LayoutElement // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new UIPropertyTypeDef("IgnoreLayout", FieldType.Bool),
         new UIPropertyTypeDef("MinWidth", FieldType.F32),
         new UIPropertyTypeDef("MinHeight", FieldType.F32),
         new UIPropertyTypeDef("PreferredWidth", FieldType.F32),
         new UIPropertyTypeDef("PreferredHeight", FieldType.F32),
         new UIPropertyTypeDef("LayoutPriority", FieldType.S32),
         new UIPropertyTypeDef(0x6DEA1A08, FieldType.F32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
