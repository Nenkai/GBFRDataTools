using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.GuideCommand;

// ui::component::ControllerBelowSubGuide
public class ControllerBelowSubGuide : Controller
{
    public UIObjectRef Base { get; set; }
    public UIObjectRef Root { get; set; }
    public List<UIObjectRef> Guides { get; set; }
}
