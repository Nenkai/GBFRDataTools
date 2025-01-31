using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Frame;

// ui::component::ControllerFrameHeader
public class ControllerFrameHeader // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Title", UIFieldType.ObjectRef),
        new("Info", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
