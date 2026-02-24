using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.ObjectEm;

// ui::component::ControllerEmStun
public class ControllerEmStun : Controller
{
    public UIObjectRef StunGauge { get; set; }
    public UIObjectRef Root { get; set; }
    public int Mode { get; set; }
}
