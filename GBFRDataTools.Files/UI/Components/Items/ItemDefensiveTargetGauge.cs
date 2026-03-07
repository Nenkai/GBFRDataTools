using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemDefensiveTargetGauge
public class ItemDefensiveTargetGauge : Component
{
    public UIObjectRef Icon { get; set; }
    public UIObjectRef HpStatusMask { get; set; }
    public UIObjectRef HpGaugeMask { get; set; }
    public UIObjectRef Animator { get; set; }
}
