using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::PivotScaleSetter
public class PivotScaleSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Scale", UIFieldType.CVec2),
        new("Offset", UIFieldType.CVec2),
        new("Pivot", UIFieldType.CVec2),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
