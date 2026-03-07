using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.Bonus;

// ui::component::ControllerBonusHud
public class ControllerBonusHud : Controller
{
    public UIObjectRef Root { get; set; }
    public List<UIObjectRef> BonusLoc { get; set; }
    public List<UIObjectRef> NumText { get; set; }
}
