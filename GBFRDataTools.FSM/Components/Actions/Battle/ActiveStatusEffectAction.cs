using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ActiveStatusEffectAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ActiveStatusEffectAction);

    [JsonPropertyName("targetType_")]
    [Description("Unknown, 0 or 1")]
    public int TargetType { get; set; } = 0;

    [JsonPropertyName("statusType_")]
    [Description("Buff/Status Id")]
    public int StatusType { get; set; } = 0;

    [JsonPropertyName("statusEffectAreaRadius_")]
    public float StatusEffectAreaRadius { get; set; } = 50f;

    [JsonPropertyName("statusEffectTime_")]
    public float StatusEffectTime { get; set; } = 0f;

    [JsonPropertyName("statusEffectValue_")]
    public float StatusEffectValue { get; set; } = 0f;

    [JsonPropertyName("statusEffectValue02_")]
    public float StatusEffectValue02 { get; set; } = 0f;
}
