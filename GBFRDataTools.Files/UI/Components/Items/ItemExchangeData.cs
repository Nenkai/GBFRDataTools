using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemExchangeData
public class ItemExchangeData : Component
{
    public List<UIObjectRef> TitleTexts { get; set; }
    public List<UIObjectRef> ButtonGuides { get; set; }
    public List<UIObjectRef> ButtonActiveOwners { get; set; }
    public List<UIObjectRef> NowSetSignObj { get; set; }
    public List<UIObjectRef> NowSetSignText { get; set; }
    public UIObjectRef IconMask { get; set; }
    public UIObjectRef WeaponInfo { get; set; }
    public UIObjectRef EmotionInfo { get; set; }
    public UIObjectRef FixedPhraseInfo { get; set; }
    public UIObjectRef AutoFixedPhraseInfo { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef IconImage { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
}
