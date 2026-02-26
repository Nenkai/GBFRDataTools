using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.Mission;

// ui::component::ControllerDefenseHp
public class ControllerDefenseHp : Controller
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef Name { get; set; }
    public UIObjectRef HpGaugeMask { get; set; }
    public UIObjectRef HpLiningMask { get; set; }
}
