using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Pause.Item;

// ui::component::ControllerGeenDetail
public class ControllerGeenDetail : Controller
{
    public UIObjectRef Geen { get; set; }
    public UIObjectRef PersonalInfo { get; set; }
    public List<UIObjectRef> Charas { get; set; }
    public List<UIObjectRef> Visibles { get; set; }
    public List<UIObjectRef> Hides { get; set; }
}
