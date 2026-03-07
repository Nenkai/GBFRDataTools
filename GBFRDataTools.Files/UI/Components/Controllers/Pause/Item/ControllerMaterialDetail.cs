using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Pause.Item;

// ui::component::ControllerMaterialDetail
public class ControllerMaterialDetail : Controller
{
    public List<UIObjectRef> Visibles { get; set; }
    public List<UIObjectRef> Hides { get; set; }
    public List<UIObjectRef> MenuLocation { get; set; }
    public UIObjectRef Material { get; set; }
    public UIObjectRef LocationTitle { get; set; }
    public UIObjectRef LocationTitleText { get; set; }
}
