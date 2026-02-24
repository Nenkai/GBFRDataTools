using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Pause.Equip;

// ui::component::ControllerEquipWeaponInfo
public class ControllerEquipWeaponInfo : Controller
{
    public UIObjectRef Weapon { get; set; }
    public UIObjectRef Soldout { get; set; }
    public UIObjectRef SoldoutCanvas { get; set; }
    public UIObjectRef AwakeWeaponInfo { get; set; }
    public List<UIObjectRef> ArrowAnims { get; set; }
}
