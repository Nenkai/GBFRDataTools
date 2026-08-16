using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkSunAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkSunAction);

    [JsonPropertyName("warpTime_")]
    public float WarpTime { get; set; } = 0.2f;

    [JsonPropertyName("rouletteSignTime_")]
    public float RouletteSignTime { get; set; } = 0.8f;

    [JsonPropertyName("waveSignTime_")]
    public float WaveSignTime { get; set; } = 1.5f;

    [JsonPropertyName("rouletteTime_")]
    public float RouletteTime { get; set; } = 3f;

    [JsonPropertyName("rouletteMaxSpeed_")]
    public float RouletteMaxSpeed { get; set; } = 3.1415927f;

    [JsonPropertyName("rouletteTimeSecond_")]
    public float RouletteTimeSecond { get; set; } = 2f;

    [JsonPropertyName("rouletteTimeThird_")]
    public float RouletteTimeThird { get; set; } = 2f;

    [JsonPropertyName("rouletteMaxSpeedSecondMin_")]
    public float RouletteMaxSpeedSecondMin { get; set; } = 2.3561945f;

    [JsonPropertyName("rouletteMaxSpeedSecondMax_")]
    public float RouletteMaxSpeedSecondMax { get; set; } = 3.926991f;

    [JsonPropertyName("rouletteMaxSpeedThirdMin_")]
    public float RouletteMaxSpeedThirdMin { get; set; } = 2.3561945f;

    [JsonPropertyName("rouletteMaxSpeedThirdMax_")]
    public float RouletteMaxSpeedThirdMax { get; set; } = 3.926991f;

    [JsonPropertyName("isPowerup_")]
    public bool IsPowerup { get; set; } = false;

    [JsonPropertyName("windTime_")]
    public float WindTime { get; set; } = 1f;
}