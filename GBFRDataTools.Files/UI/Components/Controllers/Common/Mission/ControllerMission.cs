using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Mission;

// ui::component::ControllerMission
public class ControllerMission : Controller
{
    public int Type { get; set; }
    public UIObjectRef Root { get; set; }
    public UIObjectRef Title { get; set; }
    public List<UIObjectRef> Contents { get; set; }
    public UIObjectRef Bg { get; set; }
}
