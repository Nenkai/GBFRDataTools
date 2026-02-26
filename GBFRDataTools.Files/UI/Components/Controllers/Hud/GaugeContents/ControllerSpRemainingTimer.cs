using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.GaugeContents;

// ui::component::ControllerSpRemainingTimer
public class ControllerSpRemainingTimer : Controller
{
    public UIObjectRef TimerGauge { get; set; }
    public UIObjectRef RequirementText { get; set; }
    public UIObjectRef RemainingTimeNumText { get; set; }
    public UIObjectRef Root { get; set; }
}
