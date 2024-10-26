using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.TrialBattle;

// ui::component::ControllerTrialSettingList
public class ControllerTrialSettingList // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", UIFieldType.ObjectRef),
        new("MenuTab", UIFieldType.ObjectRef),
        new("MenuSetting", UIFieldType.ObjectRef),
        new("MenuChoice", UIFieldType.ObjectRef),
        new("Info", UIFieldType.ObjectRef),
        new("Reset", UIFieldType.ObjectRef),
        new("Left", UIFieldType.ObjectRef),
        new("Right", UIFieldType.ObjectRef),
        new("Badges", UIFieldType.ObjectRefVector),
        new("BadgeTexts", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
