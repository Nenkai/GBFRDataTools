using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::PadAssignObjSetter
public class PadAssignObjSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Objs", UIFieldType.ObjectRefVector),
        new(0x260CF9E, UIFieldType.U32),
        new(0x94E13841, UIFieldType.S8),
        new(0x65E08B2D, UIFieldType.S8),
        new(0x100ED8FE, UIFieldType.S8),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
