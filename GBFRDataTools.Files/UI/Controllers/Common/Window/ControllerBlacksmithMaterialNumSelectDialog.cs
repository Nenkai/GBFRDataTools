using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerBlacksmithMaterialNumSelectDialog
public class ControllerBlacksmithMaterialNumSelectDialog // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", UIFieldType.ObjectRef),
        new("Choice", UIFieldType.ObjectRef),
        new("Change", UIFieldType.ObjectRef),
        new("Recommend", UIFieldType.ObjectRef),
        new("Guide", UIFieldType.ObjectRef),
        new("TitleText", UIFieldType.ObjectRef),
        new("InfoText", UIFieldType.ObjectRef),
        new("RupiText", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
