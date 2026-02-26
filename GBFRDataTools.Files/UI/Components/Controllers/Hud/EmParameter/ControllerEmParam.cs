using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.EmParameter;

// ui::component::ControllerEmParam
public class ControllerEmParam : Controller
{
    public UIObjectRef Name { get; set; }
    public UIObjectRef Level { get; set; }
    public UIObjectRef HpValue { get; set; }
    public UIObjectRef HpGauge { get; set; }
    public UIObjectRef HpStatusGauge { get; set; }
    public UIObjectRef HpStatusDamageGauge { get; set; }
    public UIObjectRef ModeGauge { get; set; }
    public UIObjectRef IconStatusSet { get; set; }
    public UIObjectRef GaugeEffectObj { get; set; }
    public UIObjectRef Root { get; set; }
    public float GaugeEffectPosXMin { get; set; }
    public float GaugeEffectPosXMax { get; set; }
    public UIObjectRef Element { get; set; }
}
