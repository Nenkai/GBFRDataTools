using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Controller_;

// ui::component::ControllerSystemTab
public class ControllerSystemTab // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("L1", UIFieldType.ObjectRef),
        new("R1", UIFieldType.ObjectRef),
        new("ButtonL", UIFieldType.ObjectRef),
        new("ButtonR", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controllers.Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
