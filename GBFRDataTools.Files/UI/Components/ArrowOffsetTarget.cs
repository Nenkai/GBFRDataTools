using GBFRDataTools.Files.UI;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ArrowOffsetTarget
public class ArrowOffsetTarget // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("ArrowID", FieldType.String),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
