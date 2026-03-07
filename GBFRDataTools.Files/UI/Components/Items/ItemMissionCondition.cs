using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemMissionCondition
public class ItemMissionCondition : Component
{
    public UIObjectRef Icon { get; set; }
    public UIObjectRef Title { get; set; }
    public UIObjectRef NowCount { get; set; }
    public UIObjectRef TargetCount { get; set; }
    public List<UIObjectRef> SafeTime { get; set; }
    public List<UIObjectRef> WarnTime { get; set; }
    public List<UIObjectRef> AddTimelus { get; set; }
    public UIObjectRef Animator { get; set; }
}
