using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::PadAssignTextSetter
public class PadAssignTextSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new(0xA8DC98EA, UIFieldType.ObjectRef),
        new(0x0AE64496, UIFieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
