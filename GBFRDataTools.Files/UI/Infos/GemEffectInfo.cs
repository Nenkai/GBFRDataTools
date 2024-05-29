using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::GemEffectInfo
public class GemEffectInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Eff01", FieldType.ObjectRefVector),
        new("Eff02", FieldType.ObjectRefVector),
        new("Eff03", FieldType.ObjectRefVector),
        new("Eff04", FieldType.ObjectRefVector),
        new("Eff05", FieldType.ObjectRefVector),
        new("Eff06", FieldType.ObjectRefVector),
        new("Eff07", FieldType.ObjectRefVector),
        new("Body01", FieldType.ObjectRefVector),
        new("Body01Add", FieldType.ObjectRefVector),
        new("Body02", FieldType.ObjectRefVector),
        new("Ring01", FieldType.ObjectRefVector),
        new("Ring02", FieldType.ObjectRefVector),
        new("Ring03", FieldType.ObjectRefVector),
        new("Back01", FieldType.ObjectRefVector),
        new("Back01Add", FieldType.ObjectRefVector),
        new(0x309E98D5, FieldType.ObjectRefVector),
        new(0xA64FFDB6, FieldType.ObjectRefVector),
        new(0xD294EB5E, FieldType.ObjectRef),

    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
