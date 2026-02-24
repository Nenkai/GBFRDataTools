using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemChallengeMissionProgress
public class ItemChallengeMissionProgress : Component
{
    public List<UIObjectRef> Names { get; set; }
    public List<UIObjectRef> NowCounts { get; set; }
    public List<UIObjectRef> TargetCounts { get; set; }
    public UIObjectRef MaterialInfo { get; set; }
    public List<UIObjectRef> Icons { get; set; }
    public UIObjectRef CompleteIcon { get; set; }
    public List<UIObjectRef> ClearTexts { get; set; }
    public UIObjectRef Animator { get; set; }
}
