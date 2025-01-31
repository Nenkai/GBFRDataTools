using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::PadAssignButtonSetter
public class PadAssignButtonSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new(0x276AB50B, UIFieldType.S32),
        new(0x9B63ACA0, UIFieldType.S32),
        new(0x6ECD2B67, UIFieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
