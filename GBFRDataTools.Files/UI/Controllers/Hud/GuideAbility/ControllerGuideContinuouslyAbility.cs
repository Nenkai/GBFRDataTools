using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.GuideAbility;

// ui::component::ControllerGuideContinuouslyAbility
public class ControllerGuideContinuouslyAbility // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", UIFieldType.ObjectRef),
        new("Ibs", UIFieldType.ObjectRef),
        new("BigIcon", UIFieldType.ObjectRef),
        new("CountIcons", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
