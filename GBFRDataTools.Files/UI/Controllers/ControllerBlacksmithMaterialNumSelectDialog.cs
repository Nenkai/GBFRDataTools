using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerBlacksmithMaterialNumSelectDialog
public class ControllerBlacksmithMaterialNumSelectDialog // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", FieldType.ObjectRef),
        new("Choice", FieldType.ObjectRef),
        new("Change", FieldType.ObjectRef),
        new("Recommend", FieldType.ObjectRef),
        new("Guide", FieldType.ObjectRef),
        new("TitleText", FieldType.ObjectRef),
        new("InfoText", FieldType.ObjectRef),
        new("RupiText", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
