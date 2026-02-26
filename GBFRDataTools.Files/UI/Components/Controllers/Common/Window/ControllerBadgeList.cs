using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerBadgeList
public class ControllerBadgeList : Controller
{
    public UIObjectRef SrcBadgeInfo { get; set; }
    public UIObjectRef BadgeList { get; set; }
    public UIObjectRef ImageButtonSetter { get; set; }
    public UIObjectRef SortShortCutBtn { get; set; }
    public UIObjectRef InitShortCutBtn { get; set; }
    public UIObjectRef FilterSortInfo { get; set; }
    public List<UIObjectRef> EmptyDrawObjects { get; set; }
    public List<UIObjectRef> AdjustResizeObjs { get; set; }
    public List<UIObjectRef> InitButtonGuideOwners { get; set; }
}
