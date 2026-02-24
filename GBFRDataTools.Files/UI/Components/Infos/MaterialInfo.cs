using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::MaterialInfo
public class MaterialInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> SetImages { get; set; }
    public List<UIObjectRef> RaritySets { get; set; }
    public List<UIObjectRef> Icons { get; set; }
    public List<UIObjectRef> Names { get; set; }
    public List<UIObjectRef> Counts { get; set; }
    public List<UIObjectRef> UnitMarks { get; set; }
    public List<UIObjectRef> Infos { get; set; }
    public List<UIObjectRef> EmptyTexts { get; set; }
    public List<UIObjectRef> MaxCounts { get; set; }
    public List<UIObjectRef> MaterialNumTextRootObjs { get; set; }
    public List<UIObjectRef> NeedCounts { get; set; }
    public List<UIObjectRef> NeedCountTextRootObjs { get; set; }
    public List<UIObjectRef> HaveCountTextRootObjs { get; set; }
    public UIObjectRef Favorite { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef Ticket { get; set; }
    public UIObjectRef BgIcon { get; set; }
    public UIObjectRef BgImageSetter { get; set; }
    public UIObjectRef RupiInfo { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
    public UIObjectRef Rarity { get; set; }
    public UIObjectRef UseItem { get; set; }
    public UIObjectRef UseItemText { get; set; }
}
