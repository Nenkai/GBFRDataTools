using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Pause.Frame;

// ui::component::ControllerFrameFooter
public class ControllerFrameFooter : Controller
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef Bg { get; set; }
    public List<UIObjectRef> Guides { get; set; }
}
