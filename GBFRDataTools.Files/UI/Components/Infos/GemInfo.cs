using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::GemInfo
public class GemInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> HideImages { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef Common { get; set; }
    public UIObjectRef Uncommon { get; set; }
    public UIObjectRef Rare { get; set; }
    public UIObjectRef Epic { get; set; }
    public UIObjectRef Legend { get; set; }
    public UIObjectRef Rarity { get; set; }
    public List<UIObjectRef> Names { get; set; }
    public List<UIObjectRef> Levels { get; set; }
    public List<UIObjectRef> SkillLevels { get; set; }
    public List<UIObjectRef> UnitMarks { get; set; }
    public UIObjectRef Level { get; set; }
    public List<UIObjectRef> Skills { get; set; }
    public UIObjectRef SkillList { get; set; }
    public UIObjectRef Protection { get; set; }
    public UIObjectRef ProtectionFav { get; set; }
    public UIObjectRef Ticket { get; set; }
    public UIObjectRef ComparedLevel { get; set; }
    public List<UIObjectRef> ComparedLevelObjs { get; set; }
    public List<UIObjectRef> LvUnit { get; set; }
    public UIObjectRef CanvasGroup { get; set; }
    public UIObjectRef BgIcon { get; set; }
    public UIObjectRef BgImageSetter { get; set; }
    public List<UIObjectRef> EmptyTexts { get; set; }
    public UIObjectRef RupiInfo { get; set; }
    public UIObjectRef UpdateCharaIcon { get; set; }
    public UIObjectRef CautionIcon { get; set; }
    public UIObjectRef Lucifer { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
}
