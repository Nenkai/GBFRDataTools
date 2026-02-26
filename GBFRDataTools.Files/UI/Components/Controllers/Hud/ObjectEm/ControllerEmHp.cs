using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.ObjectEm;

// ui::component::ControllerEmHp
public class ControllerEmHp : Controller
{
    public UIObjectRef Unit { get; set; }
    public UIObjectRef LevelText { get; set; }
    public UIObjectRef Level { get; set; }
    public UIObjectRef Name { get; set; }
    public UIObjectRef StatusGauge { get; set; }
    public UIObjectRef HpGauge { get; set; }
    public UIObjectRef StunGauge { get; set; }
    public UIObjectRef StatusIcon { get; set; }
    public UIObjectRef Element { get; set; }
    public UIObjectRef Root { get; set; }
}
