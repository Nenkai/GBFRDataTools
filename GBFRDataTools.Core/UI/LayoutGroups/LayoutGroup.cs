using GBFRDataTools.Core.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.LayoutGroups;

// ui::component::LayoutGroup
public class LayoutGroup // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new UIPropertyTypeDef("Padding", FieldType.CVec4),
        new UIPropertyTypeDef("Spacing", FieldType.F32),
        new UIPropertyTypeDef("ChildAlignment", FieldType.S32),
        new UIPropertyTypeDef("ChildControlWidth", FieldType.Bool),
        new UIPropertyTypeDef("ChildControlHeight", FieldType.Bool),
        new UIPropertyTypeDef("ChildScaleWidth", FieldType.Bool),
        new UIPropertyTypeDef("ChildScaleHeight", FieldType.Bool),
        new UIPropertyTypeDef("ChildForceExpandWidth", FieldType.Bool),
        new UIPropertyTypeDef("ChildForceExpandHeight", FieldType.Bool),
    ];

    public static List<UIPropertyTypeDef> GetProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
