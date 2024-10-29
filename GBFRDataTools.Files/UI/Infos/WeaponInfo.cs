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
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("Hides", UIFieldType.ObjectRefVector),
        new("MirageSets", UIFieldType.ObjectRefVector),
        new("CanAwakenSets", UIFieldType.ObjectRefVector),
        new("CannotAwakenSets", UIFieldType.ObjectRefVector),
        new("AwakenCompleteSets", UIFieldType.ObjectRefVector),
        new("AwakenNotCompleteSets", UIFieldType.ObjectRefVector),
        new("AwakedSets", UIFieldType.ObjectRefVector),
        new("NotAwakedSets", UIFieldType.ObjectRefVector),
        new("HideImages", UIFieldType.ObjectRefVector),
        new("Icon", UIFieldType.ObjectRef),
        new("Glow", UIFieldType.ObjectRef),
        new("GlowNew", UIFieldType.ObjectRef),
        new("Icons", UIFieldType.ObjectRefVector),
        new("Names", UIFieldType.ObjectRefVector),
        new("Plus", UIFieldType.ObjectRefVector),
        new("UpdateIcon", UIFieldType.ObjectRef),
        new("Levels", UIFieldType.ObjectRefVector),
        new("MaxLevels", UIFieldType.ObjectRefVector),
        new("UnitMarks", UIFieldType.ObjectRefVector),
        new("Level", UIFieldType.ObjectRef),
        new("Hps", UIFieldType.ObjectRefVector),
        new("Attacks", UIFieldType.ObjectRefVector),
        new("Criticals", UIFieldType.ObjectRefVector),
        new("Breaks", UIFieldType.ObjectRefVector),
        new("Bonuss", UIFieldType.ObjectRefVector),
        new("Star", UIFieldType.ObjectRef),
        new("Crafteds", UIFieldType.ObjectRefVector),
        new("HideCrafteds", UIFieldType.ObjectRefVector),
        new("Skills", UIFieldType.ObjectRefVector),
        new("SkillLevel", UIFieldType.ObjectRef),
        new("PendulumSkillObj", UIFieldType.Bool),
        new("SkillListPendulumEntry", UIFieldType.Bool),
        new("PendulumSkills", UIFieldType.ObjectRefVector),
        new("PendulumNames", UIFieldType.ObjectRefVector),
        new("ComparedHp", UIFieldType.ObjectRef),
        new("ComparedAttack", UIFieldType.ObjectRef),
        new("ComparedCritical", UIFieldType.ObjectRef),
        new("ComparedBreak", UIFieldType.ObjectRef),
        new("ComparedBonus", UIFieldType.ObjectRef),
        new("ComparedLevel", UIFieldType.ObjectRef),
        new("ComparedMaxLevel", UIFieldType.ObjectRef),
        new("ComparedItemLevel", UIFieldType.ObjectRef),
        new("ComparedName", UIFieldType.ObjectRef),
        new("ComparedHpObj", UIFieldType.ObjectRef),
        new("ComparedAttackObj", UIFieldType.ObjectRef),
        new("ComparedCriticalObj", UIFieldType.ObjectRef),
        new("ComparedBreakObj", UIFieldType.ObjectRef),
        new("ComparedBonusObj", UIFieldType.ObjectRef),
        new("ComparedLevelObj", UIFieldType.ObjectRef),
        new("ComparedAfterHpObjs", UIFieldType.ObjectRefVector),
        new("ComparedAfterAttackObjs", UIFieldType.ObjectRefVector),
        new("ComparedAfterCriticalObjs", UIFieldType.ObjectRefVector),
        new("ComparedAfterBreakObjs", UIFieldType.ObjectRefVector),
        new("ComparedAfterBonusObjs", UIFieldType.ObjectRefVector),
        new("ComparedAfterLevelObjs", UIFieldType.ObjectRefVector),
        new("DiffHp", UIFieldType.ObjectRef),
        new("DiffAttack", UIFieldType.ObjectRef),
        new("DiffCritical", UIFieldType.ObjectRef),
        new("DiffBreak", UIFieldType.ObjectRef),
        new("DiffLevel", UIFieldType.ObjectRef),
        new("LvUnit", UIFieldType.ObjectRefVector),
        new("CanvasGroup", UIFieldType.ObjectRef),
        new("BgIcon", UIFieldType.ObjectRef),
        new("BgImageSetter", UIFieldType.ObjectRef),
        new("EmptyTexts", UIFieldType.ObjectRefVector),
        new("AwakeWeaponInfo", UIFieldType.ObjectRef),
        new("AwakeWeaponBar", UIFieldType.ObjectRef),
        new("WeaponSkinText", UIFieldType.ObjectRef),
        new("TypeText", UIFieldType.ObjectRef),
        new("WeaponImageObj", UIFieldType.ObjectRef),
        new("IsAngleFix", UIFieldType.Bool),
        new(0x5E4124B3, UIFieldType.Bool),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
