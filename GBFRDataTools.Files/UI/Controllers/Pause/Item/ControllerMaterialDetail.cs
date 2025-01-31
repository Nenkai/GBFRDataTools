using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Item;

// ui::component::ControllerMaterialDetail
public class ControllerMaterialDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Visibles", UIFieldType.ObjectRefVector),
        new("Hides", UIFieldType.ObjectRefVector),
        new("MenuLocation", UIFieldType.ObjectRefVector),
        new("Material", UIFieldType.ObjectRef),
        new("LocationTitle", UIFieldType.ObjectRef),
        new("LocationTitleText", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
