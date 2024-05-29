using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::GachaFeverInfo
public class GachaFeverInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", FieldType.ObjectRefVector),
        new(0xA736CEA9, FieldType.ObjectRef),
        new(0xD31D1E55, FieldType.ObjectRefVector),
        new("Gauge", FieldType.ObjectRef),
        new(0x7DE930F6, FieldType.ObjectRefVector),
        new(0x7F512816, FieldType.ObjectRef),
        new(0xD0605437, FieldType.ObjectRef),
        new(0x74B5DE0E, FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
