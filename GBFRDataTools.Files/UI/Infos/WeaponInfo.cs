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
        new UIPropertyTypeDef("Sets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Empties", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Hides", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("MirageSets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("CanAwakenSets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("CannotAwakenSets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("AwakenCompleteSets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("AwakenNotCompleteSets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("AwakedSets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("NotAwakedSets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("HideImages", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Icon", FieldType.ObjectRef),
        new UIPropertyTypeDef("Glow", FieldType.ObjectRef),
        new UIPropertyTypeDef("GlowNew", FieldType.ObjectRef),
        new UIPropertyTypeDef("Icons", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Names", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Plus", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("UpdateIcon", FieldType.ObjectRef),
        new UIPropertyTypeDef("Levels", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("MaxLevels", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("UnitMarks", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Level", FieldType.ObjectRef),
        new UIPropertyTypeDef("Hps", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Attacks", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Criticals", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Breaks", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Bonuss", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Star", FieldType.ObjectRef),
        new UIPropertyTypeDef("Crafteds", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("HideCrafteds", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Skills", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("SkillLevel", FieldType.ObjectRef),
        new UIPropertyTypeDef("PendulumSkillObj", FieldType.Bool),
        new UIPropertyTypeDef("SkillListPendulumEntry", FieldType.Bool),
        new UIPropertyTypeDef("PendulumSkills", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("PendulumNames", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedHp", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedAttack", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedCritical", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedBreak", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedBonus", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedLevel", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedMaxLevel", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedItemLevel", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedName", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedHpObj", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedAttackObj", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedCriticalObj", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedBreakObj", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedBonusObj", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedLevelObj", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedAfterHpObjs", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedAfterAttackObjs", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedAfterCriticalObjs", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedAfterBreakObjs", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedAfterBonusObjs", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("ComparedAfterLevelObjs", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("DiffHp", FieldType.ObjectRef),
        new UIPropertyTypeDef("DiffAttack", FieldType.ObjectRef),
        new UIPropertyTypeDef("DiffCritical", FieldType.ObjectRef),
        new UIPropertyTypeDef("DiffBreak", FieldType.ObjectRef),
        new UIPropertyTypeDef("DiffLevel", FieldType.ObjectRef),
        new UIPropertyTypeDef("LvUnit", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("CanvasGroup", FieldType.ObjectRef),
        new UIPropertyTypeDef("BgIcon", FieldType.ObjectRef),
        new UIPropertyTypeDef("BgImageSetter", FieldType.ObjectRef),
        new UIPropertyTypeDef("EmptyTexts", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("AwakeWeaponInfo", FieldType.ObjectRef),
        new UIPropertyTypeDef("AwakeWeaponBar", FieldType.ObjectRef),
        new UIPropertyTypeDef("WeaponSkinText", FieldType.ObjectRef),
        new UIPropertyTypeDef("TypeText", FieldType.ObjectRef),
        new UIPropertyTypeDef("WeaponImageObj", FieldType.ObjectRef),
        new UIPropertyTypeDef("IsAngleFix", FieldType.Bool),
        new UIPropertyTypeDef(0x5E4124B3, FieldType.Bool),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
