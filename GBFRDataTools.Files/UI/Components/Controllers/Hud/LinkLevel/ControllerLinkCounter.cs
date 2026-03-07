using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.LinkLevel;

// ui::component::ControllerLinkCounter
public class ControllerLinkCounter : Controller
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef LinkTimeGauge { get; set; }
    public UIObjectRef TextCondition { get; set; }
    public UIObjectRef TextConditionA { get; set; }
    public List<UIObjectRef> LinkCounterLog { get; set; }
    public List<UIObjectRef> LinkTimeChance { get; set; }
    public UIObjectRef LinkTimeEff { get; set; }
    public UIObjectRef LinkNum001 { get; set; }
    public UIObjectRef LinkNum001a { get; set; }
    public UIObjectRef LinkNum010 { get; set; }
    public UIObjectRef LinkNum010a { get; set; }
    public UIObjectRef LinkNum100 { get; set; }
    public UIObjectRef LinkNum100a { get; set; }
}
