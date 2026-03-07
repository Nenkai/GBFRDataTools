using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerSubList
public class ControllerSubList : Controller
{
    public UIObjectRef Menu { get; set; }
    public UIObjectRef CurrentEquip { get; set; }
    public UIObjectRef R3 { get; set; }
    public List<UIObjectRef> Resizes { get; set; }
}
