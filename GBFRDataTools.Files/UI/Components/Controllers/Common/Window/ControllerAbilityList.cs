using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerAbilityList
public class ControllerAbilityList : Controller
{
    public UIObjectRef Menu { get; set; }
    public UIObjectRef CurrentAbility { get; set; }
    public List<UIObjectRef> Resizes { get; set; }
}
