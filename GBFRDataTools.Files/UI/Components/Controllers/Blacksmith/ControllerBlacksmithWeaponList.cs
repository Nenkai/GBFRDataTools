using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Blacksmith;

// ui::component::ControllerBlacksmithResult
public class ControllerBlacksmithWeaponList : Controller
{
    public UIObjectRef WeaponList { get; set; }
    public UIObjectRef Empty { get; set; }
    public UIObjectRef TitleText { get; set; }
    public UIObjectRef ScrollArrowUp { get; set; }
    public UIObjectRef ScrollArrowDown { get; set; }
    public List<UIObjectRef> MenuItemAnimators { get; set; }
}
