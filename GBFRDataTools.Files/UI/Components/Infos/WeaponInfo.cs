using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::WeaponInfo
public class WeaponInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Hides { get; set; }
    public List<UIObjectRef> MirageSets { get; set; }
    public List<UIObjectRef> CanAwakenSets { get; set; }
    public List<UIObjectRef> CannotAwakenSets { get; set; }
    public List<UIObjectRef> AwakenCompleteSets { get; set; }
    public List<UIObjectRef> AwakenNotCompleteSets { get; set; }
    public List<UIObjectRef> AwakedSets { get; set; }
    public List<UIObjectRef> NotAwakedSets { get; set; }
    public List<UIObjectRef> HideImages { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef Glow { get; set; }
    public UIObjectRef GlowNew { get; set; }
    public List<UIObjectRef> Icons { get; set; }
    public List<UIObjectRef> Names { get; set; }
    public List<UIObjectRef> Plus { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
    public List<UIObjectRef> Levels { get; set; }
    public List<UIObjectRef> MaxLevels { get; set; }
    public List<UIObjectRef> UnitMarks { get; set; }
    public UIObjectRef Level { get; set; }
    public List<UIObjectRef> Hps { get; set; }
    public List<UIObjectRef> Attacks { get; set; }
    public List<UIObjectRef> Criticals { get; set; }
    public List<UIObjectRef> Breaks { get; set; }
    public List<UIObjectRef> Bonuss { get; set; }
    public UIObjectRef Star { get; set; }
    public List<UIObjectRef> Crafteds { get; set; }
    public List<UIObjectRef> HideCrafteds { get; set; }
    public List<UIObjectRef> Skills { get; set; }
    public UIObjectRef SkillLevel { get; set; }
    public bool PendulumSkillObj { get; set; }
    public bool SkillListPendulumEntry { get; set; }
    public List<UIObjectRef> PendulumSkills { get; set; }
    public List<UIObjectRef> PendulumNames { get; set; }
    public UIObjectRef ComparedHp { get; set; }
    public UIObjectRef ComparedAttack { get; set; }
    public UIObjectRef ComparedCritical { get; set; }
    public UIObjectRef ComparedBreak { get; set; }
    public UIObjectRef ComparedBonus { get; set; }
    public UIObjectRef ComparedLevel { get; set; }
    public UIObjectRef ComparedMaxLevel { get; set; }
    public UIObjectRef ComparedItemLevel { get; set; }
    public UIObjectRef ComparedName { get; set; }
    public UIObjectRef ComparedHpObj { get; set; }
    public UIObjectRef ComparedAttackObj { get; set; }
    public UIObjectRef ComparedCriticalObj { get; set; }
    public UIObjectRef ComparedBreakObj { get; set; }
    public UIObjectRef ComparedBonusObj { get; set; }
    public UIObjectRef ComparedLevelObj { get; set; }
    public List<UIObjectRef> ComparedAfterHpObjs { get; set; }
    public List<UIObjectRef> ComparedAfterAttackObjs { get; set; }
    public List<UIObjectRef> ComparedAfterCriticalObjs { get; set; }
    public List<UIObjectRef> ComparedAfterBreakObjs { get; set; }
    public List<UIObjectRef> ComparedAfterBonusObjs { get; set; }
    public List<UIObjectRef> ComparedAfterLevelObjs { get; set; }
    public UIObjectRef DiffHp { get; set; }
    public UIObjectRef DiffAttack { get; set; }
    public UIObjectRef DiffCritical { get; set; }
    public UIObjectRef DiffBreak { get; set; }
    public UIObjectRef DiffLevel { get; set; }
    public List<UIObjectRef> LvUnit { get; set; }
    public UIObjectRef CanvasGroup { get; set; }
    public UIObjectRef BgIcon { get; set; }
    public UIObjectRef BgImageSetter { get; set; }
    public List<UIObjectRef> EmptyTexts { get; set; }
    public UIObjectRef AwakeWeaponInfo { get; set; }
    public UIObjectRef AwakeWeaponBar { get; set; }
    public UIObjectRef WeaponSkinText { get; set; }
    public UIObjectRef TypeText { get; set; }
    public UIObjectRef WeaponImageObj { get; set; }
    public bool IsAngleFix { get; set; }
    public bool _5E4124B3 { get; set; }
}
