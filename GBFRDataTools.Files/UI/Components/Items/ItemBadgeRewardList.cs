using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemBadgeRewardList
public class ItemBadgeRewardList : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> ConfirmationObjs { get; set; }
    public List<UIObjectRef> CompletedObjs { get; set; }
    public UIObjectRef MaterialInfo { get; set; }
    public UIObjectRef ValueInfo { get; set; }
    public UIObjectRef PendulumInfo { get; set; }
    public UIObjectRef GemInfo { get; set; }
    public UIObjectRef CharaColorInfo { get; set; }
    public UIObjectRef StampInfo { get; set; }
    public UIObjectRef _DA06E0ED { get; set; }
}
