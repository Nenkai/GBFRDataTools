using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Pause.Item;

// ui::component::ControllerInventoryInfo
public class ControllerInventoryInfo : Controller
{
    public UIObjectRef Info { get; set; }
    public List<UIObjectRef> Plates { get; set; }
    public UIObjectRef Empty { get; set; }
    public UIObjectRef EmptyText { get; set; }
    public UIObjectRef Y { get; set; }
    public bool SkillGuide { get; set; }
}
