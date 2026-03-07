using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::QuestInfo
public class QuestInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> QuestClearedObjects { get; set; }
    public List<UIObjectRef> QuestNotClearedObjects { get; set; }
    public List<UIObjectRef> OrderedSets { get; set; }
    public List<UIObjectRef> RequestedSets { get; set; }
    public List<UIObjectRef> QuestNames { get; set; }
    public List<UIObjectRef> QuestReleaseConditionTexts { get; set; }
    public List<UIObjectRef> PurposeTexts { get; set; }
    public List<UIObjectRef> FailureConditionTexts { get; set; }
    public List<UIObjectRef> SubmissionTexts { get; set; }
    public List<UIObjectRef> EnemyNameTexts { get; set; }
    public List<UIObjectRef> LocationTexts { get; set; }
    public List<UIObjectRef> ChallengeMissionIcons { get; set; }
    public List<UIObjectRef> MultiQuestTypeIcons { get; set; }
    public List<UIObjectRef> QuestRankInfos { get; set; }
    public List<UIObjectRef> QuestRankInfos2 { get; set; }
    public List<UIObjectRef> QuestClearRankImages { get; set; }
    public List<UIObjectRef> PickUpItemMaterials { get; set; }
    public UIObjectRef QuestName { get; set; }
    public UIObjectRef IslandInfo { get; set; }
    public UIObjectRef Client { get; set; }
    public UIObjectRef OrderDetailText { get; set; }
    public UIObjectRef DifficultyText { get; set; }
    public UIObjectRef QuestType { get; set; }
    public UIObjectRef LimitTime { get; set; }
    public UIObjectRef RankColorSetter { get; set; }
    public UIObjectRef OccurrenceIsland { get; set; }
    public UIObjectRef SuggestPower { get; set; }
    public UIObjectRef GameCateInfo { get; set; }
    public UIObjectRef PickupRootObject { get; set; }
    public UIObjectRef PickupGem { get; set; }
    public UIObjectRef PickupItem { get; set; }
    public UIObjectRef UpdateIconOnly { get; set; }
    public UIObjectRef LocationIcon { get; set; }
}
