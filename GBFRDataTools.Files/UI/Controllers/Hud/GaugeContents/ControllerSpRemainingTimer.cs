using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerSpRemainingTimer
public class ControllerSpRemainingTimer // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("TimerGauge", UIFieldType.ObjectRef),
        new("RequirementText", UIFieldType.ObjectRef),
        new("RemainingTimeNumText", UIFieldType.ObjectRef),
        new("Root", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
