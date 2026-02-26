using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Pause.Item;

// ui::component::ControllerWeaponDetail
public class ControllerWeaponDetail : Controller
{
    public UIObjectRef Weapon { get; set; }
    public UIObjectRef Chara { get; set; }
    public UIObjectRef CharaName { get; set; }
    public List<UIObjectRef> Visibles { get; set; }
    public List<UIObjectRef> Hides { get; set; }
}
