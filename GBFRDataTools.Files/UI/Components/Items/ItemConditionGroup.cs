using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemConditionGroup
public class ItemConditionGroup : Component
{
    public UIObjectRef Animator { get; set; }
    public UIObjectRef Time { get; set; }
    public UIObjectRef Normal { get; set; }
    public UIObjectRef Count { get; set; }
    public UIObjectRef CheckBox { get; set; }
    public UIObjectRef Gauge { get; set; }
}
