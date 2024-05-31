using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::GaugeFill
public class GaugeFill // : Gauge
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Image", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Gauge.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
