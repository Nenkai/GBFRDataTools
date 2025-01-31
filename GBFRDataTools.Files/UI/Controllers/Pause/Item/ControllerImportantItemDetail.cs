using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Item;

// ui::component::ControllerImportantItemDetail
public class ControllerImportantItemDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Material", UIFieldType.ObjectRef),
        new("IconGlow", UIFieldType.ObjectRef),
        new("Icon", UIFieldType.ObjectRef),
        new("Visibles", UIFieldType.ObjectRefVector),
        new("Hides", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
