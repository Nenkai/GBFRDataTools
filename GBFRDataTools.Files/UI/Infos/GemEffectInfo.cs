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
        new("Eff01", UIFieldType.ObjectRefVector),
        new("Eff02", UIFieldType.ObjectRefVector),
        new("Eff03", UIFieldType.ObjectRefVector),
        new("Eff04", UIFieldType.ObjectRefVector),
        new("Eff05", UIFieldType.ObjectRefVector),
        new("Eff06", UIFieldType.ObjectRefVector),
        new("Eff07", UIFieldType.ObjectRefVector),
        new("Body01", UIFieldType.ObjectRefVector),
        new("Body01Add", UIFieldType.ObjectRefVector),
        new("Body02", UIFieldType.ObjectRefVector),
        new("Ring01", UIFieldType.ObjectRefVector),
        new("Ring02", UIFieldType.ObjectRefVector),
        new("Ring03", UIFieldType.ObjectRefVector),
        new("Back01", UIFieldType.ObjectRefVector),
        new("Back01Add", UIFieldType.ObjectRefVector),
        new(0x309E98D5, UIFieldType.ObjectRefVector),
        new(0xA64FFDB6, UIFieldType.ObjectRefVector),
        new(0xD294EB5E, UIFieldType.ObjectRef),

    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
