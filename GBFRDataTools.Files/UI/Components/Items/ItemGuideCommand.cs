using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemGuideCommand
public class ItemGuideCommand : Component
{
    public UIObjectRef Shortcut { get; set; }
    public UIObjectRef Text { get; set; }
    public UIObjectRef TextPush { get; set; }
    public UIObjectRef AbilityLPush { get; set; }
    public UIObjectRef AbilityRPush { get; set; }
    public UIObjectRef Command { get; set; }
    public UIObjectRef CommandPush { get; set; }
    public UIObjectRef CommandCharge { get; set; }
}
