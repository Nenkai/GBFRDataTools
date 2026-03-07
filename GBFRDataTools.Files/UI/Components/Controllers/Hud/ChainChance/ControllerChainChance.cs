using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.ChainChance;

// ui::component::ControllerChainChance
public class ControllerChainChance : Controller
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef Point { get; set; }
    public List<UIObjectRef> Gauges { get; set; }
}
