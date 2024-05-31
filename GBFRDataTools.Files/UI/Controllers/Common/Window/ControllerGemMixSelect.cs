using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerGemMixSelect
public class ControllerGemMixSelect // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x0280195C, FieldType.ObjectRefVector),
        new("Menu", FieldType.ObjectRef),
        new(0x1CB56ED7, FieldType.ObjectRef),
        new(0x229F83F6, FieldType.ObjectRef),
        new(0x34267E0E, FieldType.ObjectRefVector),
        new(0x47C72359, FieldType.ObjectRefVector),
        new(0x55C5D513, FieldType.ObjectRef),
        new("Gem", FieldType.ObjectRef),
        new("FilterSortInfo", FieldType.ObjectRef),
        new(0xB3D783E0, FieldType.ObjectRef),
        new(0xD054B863, FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
