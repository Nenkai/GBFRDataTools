using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.TrialBattle;

// ui::component::ControllerTrialInfo
public class ControllerTrialInfo : Controller
{
    public UIObjectRef Root { get; set; }
    public int Type { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef Title { get; set; }
    public UIObjectRef TimeTitle { get; set; }
    public UIObjectRef Minutes { get; set; }
    public UIObjectRef Mark { get; set; }
    public UIObjectRef Seconds { get; set; }
    public UIObjectRef TimeNone { get; set; }
    public UIObjectRef DamageTitle { get; set; }
    public UIObjectRef DamageValue { get; set; }
}
