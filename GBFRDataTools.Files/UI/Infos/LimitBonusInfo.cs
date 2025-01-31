using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::LimitBonusInfo
public class LimitBonusInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Sets", UIFieldType.ObjectRefVector),
         new("Empties", UIFieldType.ObjectRefVector),
         new("Icons", UIFieldType.ObjectRefVector),
         new("NotReleaseObjs", UIFieldType.ObjectRefVector),
         new("Level0Objs", UIFieldType.ObjectRefVector),
         new("NotLevel0Objs", UIFieldType.ObjectRefVector),
         new("AbilityIcons", UIFieldType.ObjectRefVector),
         new("AbilityFrames", UIFieldType.ObjectRefVector),
         new("LevelTexts", UIFieldType.ObjectRefVector),
         new("LevelImages", UIFieldType.ObjectRefVector),
         new("MeditationIcons", UIFieldType.ObjectRefVector),
         new("MeditationStars", UIFieldType.ObjectRefVector),
         new("AbilityInfoTypes", UIFieldType.ObjectRefVector),
         new("Name", UIFieldType.ObjectRef),
         new("EffectText01", UIFieldType.ObjectRef),
         new("EffectText02", UIFieldType.ObjectRef),
         new("EffectText03", UIFieldType.ObjectRef),
         new("NowCountEffectText", UIFieldType.ObjectRef),
         new("EffectTitleText", UIFieldType.ObjectRef),
         new("CurrentEffectValueText", UIFieldType.ObjectRef),
         new("Star", UIFieldType.ObjectRef),
         new("UpdateIcon", UIFieldType.ObjectRef),
         new("NowLevelText", UIFieldType.ObjectRef),
         new("DenominatorLevelText", UIFieldType.ObjectRef),
         new("EffectValText", UIFieldType.ObjectRef),
         new("PercentObj", UIFieldType.ObjectRef),
         new("Element", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
