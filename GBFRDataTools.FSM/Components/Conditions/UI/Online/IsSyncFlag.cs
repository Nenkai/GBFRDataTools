using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

[Description("Seems to go hand in hand with SetNetworkSyncFlag")]
public class IsSyncFlag : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsSyncFlag);

    [JsonPropertyName("flagType_")]
    public EnumString<IsSyncFlagType> FlagType { get; set; } = new();

    [JsonPropertyName("checkType_")]
    public EnumString<IsSyncFlagCheckType> CheckType { get; set; } = new();

    [JsonPropertyName("isClear_")]
    public bool IsClear { get; set; } = false; 

    [JsonPropertyName("checkFlag_")]
    public bool CheckFlag { get; set; } = true; 
}

public enum IsSyncFlagType
{
    // マッチングキャンセル = 2,
    // カットシーンスキップ = 6,
    Type0 = 0,
    Type1 = 1,
    MatchingCancel = 2,
    Type3 = 3,
    Type4 = 4,
    Type5 = 5,
    CutsceneSkip = 6,
    Type7 = 7,
}

public enum IsSyncFlagCheckType
{
    // 完全同期 = 0,
    // 誰かが合致 = 2,
    FullySynced = 0,
    Type1 = 1,
    SomeoneMatched = 2,
    Type3 = 3,
    Type4 = 4,
}
