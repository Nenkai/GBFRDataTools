using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::QuestInfo
public class QuestInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("QuestClearedObjects", UIFieldType.ObjectRefVector),
        new("QuestNotClearedObjects", UIFieldType.ObjectRefVector),
        new("OrderedSets", UIFieldType.ObjectRefVector),
        new("RequestedSets", UIFieldType.ObjectRefVector),
        new("QuestNames", UIFieldType.ObjectRefVector),
        new("QuestReleaseConditionTexts", UIFieldType.ObjectRefVector),
        new("PurposeTexts", UIFieldType.ObjectRefVector),
        new("FailureConditionTexts", UIFieldType.ObjectRefVector),
        new("SubmissionTexts", UIFieldType.ObjectRefVector),
        new("EnemyNameTexts", UIFieldType.ObjectRefVector),
        new("LocationTexts", UIFieldType.ObjectRefVector),
        new("ChallengeMissionIcons", UIFieldType.ObjectRefVector),
        new("MultiQuestTypeIcons", UIFieldType.ObjectRefVector),
        new("QuestRankInfos", UIFieldType.ObjectRefVector),
        new("QuestRankInfos2", UIFieldType.ObjectRefVector),
        new("QuestClearRankImages", UIFieldType.ObjectRefVector),
        new("PickUpItemMaterials", UIFieldType.ObjectRefVector),
        new("QuestName", UIFieldType.ObjectRef),
        new("IslandInfo", UIFieldType.ObjectRef),
        new("Client", UIFieldType.ObjectRef),
        new("OrderDetailText", UIFieldType.ObjectRef),
        new("DifficultyText", UIFieldType.ObjectRef),
        new("QuestType", UIFieldType.ObjectRef),
        new("LimitTime", UIFieldType.ObjectRef),
        new("RankColorSetter", UIFieldType.ObjectRef),
        new("OccurrenceIsland", UIFieldType.ObjectRef),
        new("SuggestPower", UIFieldType.ObjectRef),
        new("GameCateInfo", UIFieldType.ObjectRef),
        new("PickupRootObject", UIFieldType.ObjectRef),
        new("PickupGem", UIFieldType.ObjectRef),
        new("PickupItem", UIFieldType.ObjectRef),
        new("UpdateIconOnly", UIFieldType.ObjectRef),
        new("LocationIcon", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
