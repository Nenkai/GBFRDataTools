using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Pause.Equip;

// ui::component::ControllerEquipGemInfo
public class ControllerEquipGemInfo : Controller
{
    public UIObjectRef Gem { get; set; }
    public UIObjectRef Soldout { get; set; }
    public UIObjectRef SoldoutCanvas { get; set; }
    public UIObjectRef CharaRoot { get; set; }
    public UIObjectRef AnimationEvent { get; set; }
    public List<UIObjectRef> Charas { get; set; }
}
