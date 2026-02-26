using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.GuideCommand;

// ui::component::ControllerSubGuide
public class ControllerSubGuide: Controller
{
    public List<UIObjectRef> Shortcuts { get; set; }
    public UIObjectRef Root { get; set; }
    public List<UIObjectRef> Buttons { get; set; }
    public List<UIObjectRef> NaviAnimators { get; set; }
    public List<UIObjectRef> NaviGuides { get; set; }
}
