using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreAtkBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreAtkBreathAction);

    [JsonPropertyName("preWaitTime_")]
    public float PreWaitTime { get; set; } = 0.5f;

    [JsonPropertyName("attackTime_")]
    public float AttackTime { get; set; } = 1f;

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 1f;

    [JsonPropertyName("isLaser_")]
    public bool IsLaser { get; set; } = false;

    [JsonPropertyName("isUseMotion_")]
    public bool IsUseMotion { get; set; } = false;

    [JsonPropertyName("isStraight_")]
    public bool IsStraight { get; set; } = false;

    [JsonPropertyName("isCancelMotion_")]
    public bool IsCancelMotion { get; set; } = false;
}
