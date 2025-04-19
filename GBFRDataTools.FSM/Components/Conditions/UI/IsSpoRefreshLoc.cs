using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.UI;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IsSpoRefreshLoc : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsSpoRefreshLoc);

    [JsonPropertyName("modeEnum_")]
    public BindingList<SpoRefreshCheckerMode> ModeEnum { get; set; } = []; // Offset 0x38

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; // Offset 0x50

    [JsonPropertyName("isNot_")]
    public bool IsNot { get; set; } = false; // Offset 0x54

    [JsonPropertyName("isQuestFlow_")]
    public EnumString<IsSpoRefreshLocQuestFlow> IsQuestFlow { get; set; } // Offset 0x58

    [JsonPropertyName("isNotFlow_")]
    public bool IsNotFlow { get; set; } = false; // Offset 0x88

    [JsonPropertyName("isCheckAny_")]
    public bool IsCheckAny { get; set; } = false; // Offset 0x89
}

public enum IsSpoRefreshLocQuestFlow
{
    // 選択中と自身のクエストが破棄 = 1,
    // 選択中のクエストが破棄 = 2,
    // 自分のクエストが破棄 = 3,
    // 他人のリクエストが破棄 = 4,
    // クエストが変化 = 5,
    SelectedQuestAndOwnQuestAreDiscarded = 1,
    SelectedQuestIsDiscarded = 2,
    MyQuestIsAbandoned = 3,
    OtherPeopleRequestsArerejected = 4,
    QuestChanges = 5,
}