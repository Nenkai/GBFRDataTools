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
        new(0x0280195C, UIFieldType.ObjectRefVector),
        new("Menu", UIFieldType.ObjectRef),
        new(0x1CB56ED7, UIFieldType.ObjectRef),
        new(0x229F83F6, UIFieldType.ObjectRef),
        new(0x34267E0E, UIFieldType.ObjectRefVector),
        new(0x47C72359, UIFieldType.ObjectRefVector),
        new(0x55C5D513, UIFieldType.ObjectRef),
        new("Gem", UIFieldType.ObjectRef),
        new("FilterSortInfo", UIFieldType.ObjectRef),
        new(0xB3D783E0, UIFieldType.ObjectRef),
        new(0xD054B863, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
