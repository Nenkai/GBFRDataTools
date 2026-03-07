using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerSubListGem
public class ControllerSubListGem : Controller
{
    public UIObjectRef Menu { get; set; }
    public UIObjectRef CurrentEquip { get; set; }
    public UIObjectRef SelectButton { get; set; }
    public UIObjectRef R3 { get; set; }
    public UIObjectRef SortText { get; set; }
    public UIObjectRef Badge { get; set; }
    public UIObjectRef FilterCount { get; set; }
    public UIObjectRef EmptyResult { get; set; }
    public UIObjectRef EmptyText { get; set; }
    public List<UIObjectRef> Resizes { get; set; }
}
