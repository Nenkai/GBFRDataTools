using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.GuideAbility;

// ui::component::ControllerGuideContinuouslyAbility
public class ControllerGuideContinuouslyAbility : Controller
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef Ibs { get; set; }
    public UIObjectRef BigIcon { get; set; }
    public List<UIObjectRef> CountIcons { get; set; }
}
