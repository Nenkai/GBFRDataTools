using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em1700ExAttack2Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700ExAttack2Action);

    [JsonPropertyName("isLeftAttack_")]
    public bool IsLeftAttack { get; set; } = false;

    [JsonPropertyName("closeTargetDist_")]
    public float CloseTargetDist { get; set; } = 3f;

    [JsonPropertyName("normalDist_")]
    public float NormalDist { get; set; } = 1f;

    [JsonPropertyName("minDist_")]
    public float MinDist { get; set; } = 1f;

    [JsonPropertyName("maxDist_")]
    public float MaxDist { get; set; } = 1f;

    [JsonPropertyName("offsetDist_")]
    public float OffsetDist { get; set; } = 9f;

    [JsonPropertyName("setTime_")]
    public float SetTime { get; set; } = 0f;

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 0f;
}
