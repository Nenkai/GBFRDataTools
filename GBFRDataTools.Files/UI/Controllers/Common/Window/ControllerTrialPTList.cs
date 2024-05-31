using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerTrialPTList
public class ControllerTrialPTList // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", FieldType.ObjectRef),
        new(0x54531EEF, FieldType.ObjectRef),
        new(0x8B7C2B20, FieldType.ObjectRef),
        new(0x9ED79434, FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
