using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonAddStatusAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonAddStatusAction);

    [JsonPropertyName("targetType_")]
    public int TargetType { get; set; } = 0;

    [JsonPropertyName("statusType_")]
    public int StatusType { get; set; } = 0;

    [JsonPropertyName("statusEffectTime_")]
    public float StatusEffectTime { get; set; } = 0f;

    [JsonPropertyName("statusEffectValue_")]
    public float StatusEffectValue { get; set; } = 0f;

    [JsonPropertyName("statusEffectValue2_")]
    public float StatusEffectValue2 { get; set; } = 0f;

    [JsonPropertyName("excludeSummoner_")]
    public bool ExcludeSummoner { get; set; } = false;
}
