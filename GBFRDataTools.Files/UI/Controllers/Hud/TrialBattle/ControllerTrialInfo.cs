using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.TrialBattle;

// ui::component::ControllerTrialInfo
public class ControllerTrialInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", UIFieldType.ObjectRef),
        new("Type", UIFieldType.S32),
        new("Icon", UIFieldType.ObjectRef),
        new("Title", UIFieldType.ObjectRef),
        new("TimeTitle", UIFieldType.ObjectRef),
        new("Minutes", UIFieldType.ObjectRef),
        new("Mark", UIFieldType.ObjectRef),
        new("Seconds", UIFieldType.ObjectRef),
        new("TimeNone", UIFieldType.ObjectRef),
        new("DamageTitle", UIFieldType.ObjectRef),
        new("DamageValue", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
