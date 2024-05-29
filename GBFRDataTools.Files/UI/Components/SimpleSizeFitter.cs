using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SimpleSizeFitter
public class SimpleSizeFitter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Target", FieldType.ObjectRef),
        new("IgnoreX", FieldType.Bool),
        new("IgnoreY", FieldType.Bool),
        new("Padding", FieldType.CVec2),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
