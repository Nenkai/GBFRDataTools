using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Fate;

public class FateEpisodeCheckOccurrence : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FateEpisodeCheckOccurrence);

    [JsonPropertyName("checkType_")]
    public EnumString<FateEpisodeCheckOccurrenceCheckType> CheckType { get; set; } // Offset 0x38

    [JsonPropertyName("useSelectedFateID_")]
    public bool UseSelectedFateID { get; set; } = true; // Offset 0x68

    [JsonPropertyName("fateID_")]
    public string FateID { get; set; } // Offset 0x70

}

public enum FateEpisodeCheckOccurrenceCheckType
{
    // 報酬発生チェック = 0,
    // クエスト発生チェック = 1,
    // アーカイブ報酬チェック = 2,
    // 読了発生チェック = 3,
    RewardOccurenceCheck = 0,
    QuestOccurenceCheck = 1,
    ArchiveRewardCheck = 2,
    ReadingOccurenceCheck = 3,
}
