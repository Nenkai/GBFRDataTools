using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerGemMixResult
public class ControllerGemMixResult // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", FieldType.ObjectRef),
        new(0x58D9CC66, FieldType.ObjectRef),
        new(0x6570B05D, FieldType.ObjectRef),
        new(0x887CD4C6, FieldType.ObjectRef),
        new(0x929AC963, FieldType.ObjectRefVector),
        new("Mode", FieldType.S32),
        new("ChangeSkillDispMode", FieldType.ObjectRef),
        new("New", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
