using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.GuideCommand;

// ui::component::ControllerSubGuide
public class ControllerSubGuide // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Shortcuts", UIFieldType.ObjectRefVector),
        new("Root", UIFieldType.ObjectRef),
        new("Buttons", UIFieldType.ObjectRefVector),
        new("NaviAnimators", UIFieldType.ObjectRefVector),
        new("NaviGuides", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
