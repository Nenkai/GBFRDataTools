using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemIconStatus
public class ItemIconStatus : Component
{
    public UIObjectRef Status { get; set; }
    public UIObjectRef StatusMask { get; set; }
    public UIObjectRef StatusEffect { get; set; }
    public UIObjectRef Animator { get; set; }
}
