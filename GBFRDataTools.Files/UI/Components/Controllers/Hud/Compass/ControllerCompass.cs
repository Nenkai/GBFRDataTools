using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.Compass;

// ui::component::ControllerCompass
public class ControllerCompass : Controller
{
    public UIObjectRef Root { get; set; }
    public List<UIObjectRef> ObjIndicators { get; set; }
    public List<UIObjectRef> IconFacility { get; set; }
    public List<UIObjectRef> IconDestination { get; set; }
    public List<UIObjectRef> IconSideQuest { get; set; }
    public float CompassWidthHalf { get; set; }
    public List<float> DistanceLimitFacility { get; set; }
    public List<float> DistanceLimitSideQuest { get; set; }
}
