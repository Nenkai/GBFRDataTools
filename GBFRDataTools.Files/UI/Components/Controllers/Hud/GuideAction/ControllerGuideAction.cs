using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.GuideAction;

// ui::component::ControllerGuideAction
public class ControllerGuideAction : Controller
{
    public UIObjectRef KeyImg { get; set; }
    public UIObjectRef Button { get; set; }
    public UIObjectRef ButtonImage { get; set; }
    public UIObjectRef Highlight { get; set; }
    public List<UIObjectRef> Texts { get; set; }
}
