using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::ScrollBar
public class ScrollBar // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new UIPropertyTypeDef("Base", FieldType.ObjectRef),
        new UIPropertyTypeDef("Bar", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
