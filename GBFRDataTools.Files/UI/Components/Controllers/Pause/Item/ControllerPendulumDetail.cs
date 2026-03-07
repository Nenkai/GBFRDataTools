using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Pause.Item;

// ui::component::ControllerPendulumDetail
public class ControllerPendulumDetail : Controller
{
    public UIObjectRef Pendulum { get; set; }
    public List<UIObjectRef> Visibles { get; set; }
    public List<UIObjectRef> Hides { get; set; }
    public UIObjectRef Soldout { get; set; }
    public UIObjectRef SoldoutCanvas { get; set; }
    public UIObjectRef AnimationEvent { get; set; }
}
