using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.GuideAbility;

// ui::component::ControllerGuideAbility
public class ControllerGuideAbility // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", UIFieldType.ObjectRef),
        new("Gauge", UIFieldType.ObjectRef),
        new("GaugeImg", UIFieldType.ObjectRef),
        new("GaugeLoc", UIFieldType.ObjectRef),
        new("GaugeFrame", UIFieldType.ObjectRef),
        new("GaugeEff", UIFieldType.ObjectRef),
        new("ButtonLoc", UIFieldType.ObjectRef),
        new("ButtonHoldEff", UIFieldType.ObjectRef),
        new("ImgButtonSetter01", UIFieldType.ObjectRef),
        new("ImgButtonSetter02", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
