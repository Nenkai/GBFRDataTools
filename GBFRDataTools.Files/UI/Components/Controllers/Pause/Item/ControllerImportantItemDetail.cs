using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Pause.Item;

// ui::component::ControllerImportantItemDetail
public class ControllerImportantItemDetail : Controller
{
    public UIObjectRef Material { get; set; }
    public UIObjectRef IconGlow { get; set; }
    public UIObjectRef Icon { get; set; }
    public List<UIObjectRef> Visibles { get; set; }
    public List<UIObjectRef> Hides { get; set; }
}
