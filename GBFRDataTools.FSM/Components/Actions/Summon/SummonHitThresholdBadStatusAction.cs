using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Conditions.AI;

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
public class SummonHitThresholdBadStatusAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonHitThresholdBadStatusAction);

    [JsonPropertyName("badStatusThreshold_")]
    public int BadStatusThreshold { get; set; } = 1;

    [JsonPropertyName("badStatusData_")]
    public DebuffData BadStatusData { get; set; } = new();

    [JsonPropertyName("hitCountResetTime_")]
    public float HitCountResetTime { get; set; } = 0f;

    [JsonPropertyName("hitCountDecrementTime_")]
    public float HitCountDecrementTime { get; set; } = 0f;
}
