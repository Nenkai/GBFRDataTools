using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.GuideAction;

// ui::component::ControllerGuideAction
public class ControllerGuideAction // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x5283A679, UIFieldType.ObjectRef),
        new("Button", UIFieldType.ObjectRef),
        new("ButtonImage", UIFieldType.ObjectRef),
        new("Highlight", UIFieldType.ObjectRef),
        new("Texts", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
