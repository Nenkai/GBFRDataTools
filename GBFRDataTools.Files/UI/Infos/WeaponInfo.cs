using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::WeaponInfo
public class WeaponInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new UIPropertyTypeDef("Sets", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Empties", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Hides", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("MirageSets", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("CanAwakenSets", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("CannotAwakenSets", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("AwakenCompleteSets", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("AwakenNotCompleteSets", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("AwakedSets", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("NotAwakedSets", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("HideImages", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Icon", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("Glow", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("GlowNew", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("Icons", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Names", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Plus", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("UpdateIcon", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("Levels", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("MaxLevels", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("UnitMarks", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Level", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("Hps", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Attacks", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Criticals", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Breaks", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Bonuss", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Star", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("Crafteds", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("HideCrafteds", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Skills", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("SkillLevel", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("PendulumSkillObj", UIFieldType.Bool),
        new UIPropertyTypeDef("SkillListPendulumEntry", UIFieldType.Bool),
        new UIPropertyTypeDef("PendulumSkills", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("PendulumNames", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedHp", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedAttack", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedCritical", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedBreak", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedBonus", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedLevel", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedMaxLevel", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedItemLevel", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedName", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedHpObj", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedAttackObj", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedCriticalObj", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedBreakObj", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedBonusObj", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedLevelObj", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedAfterHpObjs", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedAfterAttackObjs", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedAfterCriticalObjs", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedAfterBreakObjs", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedAfterBonusObjs", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedAfterLevelObjs", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("DiffHp", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("DiffAttack", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("DiffCritical", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("DiffBreak", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("DiffLevel", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("LvUnit", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("CanvasGroup", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("BgIcon", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("BgImageSetter", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("EmptyTexts", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("AwakeWeaponInfo", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("AwakeWeaponBar", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("WeaponSkinText", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("TypeText", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("WeaponImageObj", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("IsAngleFix", UIFieldType.Bool),
        new UIPropertyTypeDef(0x5E4124B3, UIFieldType.Bool),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
