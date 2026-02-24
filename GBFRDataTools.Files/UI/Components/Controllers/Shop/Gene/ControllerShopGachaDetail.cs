using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Shop.Gene;

// ui::component::ControllerShopGachaDetail
public class ControllerShopGachaDetail : Controller
{
    public UIObjectRef Info { get; set; }
    public UIObjectRef Prev { get; set; }
    public UIObjectRef Next { get; set; }
    public UIObjectRef Page { get; set; }
    public UIObjectRef PageMax { get; set; }
    public UIObjectRef Gem { get; set; }
    public UIObjectRef Pendulum { get; set; }
    public UIObjectRef GemAnimator { get; set; }
    public UIObjectRef PendulumAnimator { get; set; }
}
