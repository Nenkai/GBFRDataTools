using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.ObjectEm;

// ui::component::ControllerEmHp
public class ControllerEmHp // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Unit", UIFieldType.ObjectRef),
        new("LevelText", UIFieldType.ObjectRef),
        new("Level", UIFieldType.ObjectRef),
        new("Name", UIFieldType.ObjectRef),
        new("StatusGauge", UIFieldType.ObjectRef),
        new("HpGauge", UIFieldType.ObjectRef),
        new("StunGauge", UIFieldType.ObjectRef),
        new("StatusIcon", UIFieldType.ObjectRef),
        new("Element", UIFieldType.ObjectRef),
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
