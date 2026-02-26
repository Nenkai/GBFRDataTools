using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemRewardInfo
public class ItemRewardInfo : Component
{
    public UIObjectRef Item { get; set; }
    public UIObjectRef ButtonGuide { get; set; }
    public UIObjectRef Anim { get; set; }
    public UIObjectRef FavoriteIconObject { get; set; }
    public UIObjectRef NewIconObject { get; set; }
    public UIObjectRef SoundContainer { get; set; }
    public List<UIObjectRef> NumImageBGs { get; set; }
    public List<UIObjectRef> NumTextParentObjs { get; set; }
    public List<UIObjectRef> NumTexts { get; set; }
    public List<UIObjectRef> FavoriteNGTexts { get; set; }
    public int BgType { get; set; }
}
