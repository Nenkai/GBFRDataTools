using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.LayoutGroups;

// ui::component::LayoutGroup
public class LayoutGroup // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Padding", UIFieldType.CVec4),
        new("Spacing", UIFieldType.F32),
        new("ChildAlignment", UIFieldType.S32),
        new("ChildControlWidth", UIFieldType.Bool),
        new("ChildControlHeight", UIFieldType.Bool),
        new("ChildScaleWidth", UIFieldType.Bool),
        new("ChildScaleHeight", UIFieldType.Bool),
        new("ChildForceExpandWidth", UIFieldType.Bool),
        new("ChildForceExpandHeight", UIFieldType.Bool),
    ];

    public static List<UIPropertyTypeDef> GetProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
