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
        new("Target", UIFieldType.ObjectRef),
        new("Bg", UIFieldType.ObjectRef),
        new("Bar", UIFieldType.ObjectRef),
        new("Reverse", UIFieldType.S32),
        new("Operation", UIFieldType.S32),
        new("Repeat", UIFieldType.S32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
