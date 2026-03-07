using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.GuideAbility;

// ui::component::ControllerGuideAbility
public class ControllerGuideAbility : Controller
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef Gauge { get; set; }
    public UIObjectRef GaugeImg { get; set; }
    public UIObjectRef GaugeLoc { get; set; }
    public UIObjectRef GaugeFrame { get; set; }
    public UIObjectRef GaugeEff { get; set; }
    public UIObjectRef ButtonLoc { get; set; }
    public UIObjectRef ButtonHoldEff { get; set; }
    public UIObjectRef ImgButtonSetter01 { get; set; }
    public UIObjectRef ImgButtonSetter02 { get; set; }
}
