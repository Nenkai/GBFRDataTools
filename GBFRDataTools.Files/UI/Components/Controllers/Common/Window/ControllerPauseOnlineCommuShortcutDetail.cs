using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerPauseOnlineCommuShortcutDetail
public class ControllerPauseOnlineCommuShortcutDetail : Controller
{
    public List<UIObjectRef> Resizes { get; set; }
    public List<UIObjectRef> StampResizes { get; set; }
    public UIObjectRef MenuStamp { get; set; }
    public UIObjectRef MenuFixedPhrase { get; set; }
    public UIObjectRef MenuEmotion { get; set; }
    public UIObjectRef Gauss { get; set; }
}
