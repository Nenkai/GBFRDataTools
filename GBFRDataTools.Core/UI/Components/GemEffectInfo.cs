using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::GemEffectInfo
public class GemEffectInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new UIPropertyTypeDef("Eff01", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Eff02", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Eff03", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Eff04", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Eff05", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Eff06", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Eff07", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Body01", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Body01Add", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Body02", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Ring01", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Ring02", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Ring03", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Back01", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Back01Add", FieldType.ObjectRefVector),
        new UIPropertyTypeDef(0x309E98D5, FieldType.ObjectRefVector),
        new UIPropertyTypeDef(0xA64FFDB6, FieldType.ObjectRefVector),

    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
