using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Entrance;

// ui::component::ControllerTrialTop
public class ControllerTrialTop // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", FieldType.ObjectRef),
        new("SetupEntrance", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
