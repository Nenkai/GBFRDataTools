using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ScrollBg
public class ScrollBg // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Target", FieldType.ObjectRef),
        new("Bg", FieldType.ObjectRef),
        new("Bar", FieldType.ObjectRef),
        new("Reverse", FieldType.S32),
        new("Operation", FieldType.S32),
        new("Repeat", FieldType.S32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
