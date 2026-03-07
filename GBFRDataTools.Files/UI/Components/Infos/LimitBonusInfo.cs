using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::LimitBonusInfo
public class LimitBonusInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> Icons { get; set; }
    public List<UIObjectRef> NotReleaseObjs { get; set; }
    public List<UIObjectRef> Level0Objs { get; set; }
    public List<UIObjectRef> NotLevel0Objs { get; set; }
    public List<UIObjectRef> AbilityIcons { get; set; }
    public List<UIObjectRef> AbilityFrames { get; set; }
    public List<UIObjectRef> LevelTexts { get; set; }
    public List<UIObjectRef> LevelImages { get; set; }
    public List<UIObjectRef> MeditationIcons { get; set; }
    public List<UIObjectRef> MeditationStars { get; set; }
    public List<UIObjectRef> AbilityInfoTypes { get; set; }
    public UIObjectRef Name { get; set; }
    public UIObjectRef EffectText01 { get; set; }
    public UIObjectRef EffectText02 { get; set; }
    public UIObjectRef EffectText03 { get; set; }
    public UIObjectRef NowCountEffectText { get; set; }
    public UIObjectRef EffectTitleText { get; set; }
    public UIObjectRef CurrentEffectValueText { get; set; }
    public UIObjectRef Star { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
    public UIObjectRef NowLevelText { get; set; }
    public UIObjectRef DenominatorLevelText { get; set; }
    public UIObjectRef EffectValText { get; set; }
    public UIObjectRef PercentObj { get; set; }
    public UIObjectRef Element { get; set; }
}
