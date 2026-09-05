using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.BahamutVersa;

public class Em7600DashAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600DashAttackAction);

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 10f;

    [JsonPropertyName("rotSpeed_")]
    public float RotSpeed { get; set; } = 0.9f;

    [JsonPropertyName("centerRotSpeed_")]
    public float CenterRotSpeed { get; set; } = 0.8f;

    [JsonPropertyName("centerSpeed_")]
    public float CenterSpeed { get; set; } = 3f;

    [JsonPropertyName("spreadTimer_")]
    public float SpreadTimer { get; set; } = 3f;

    [JsonPropertyName("createWaveTimeMax_")]
    public float CreateWaveTimeMax { get; set; } = 5f;

    [JsonPropertyName("createWaveTimeMin_")]
    public float CreateWaveTimeMin { get; set; } = 3f;

    [JsonPropertyName("speedWaveTimeMax_")]
    public float SpeedWaveTimeMax { get; set; } = 2f;

    [JsonPropertyName("speedWaveTimeMin_")]
    public float SpeedWaveTimeMin { get; set; } = 1f;

    [JsonPropertyName("chaosRandomTimeMax_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public float ChaosRandomTimeMax { get; set; } = 4f;

    [JsonPropertyName("chaosRandomTimeMin_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public float ChaosRandomTimeMin { get; set; } = 2f;

    [JsonPropertyName("chaosRotSpeedMax_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public float ChaosRotSpeedMax { get; set; } = 1f;

    [JsonPropertyName("chaosRotSpeedMin_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public float ChaosRotSpeedMin { get; set; } = 0.6f;

    [JsonPropertyName("speedMaxTime_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Rangarok.")]
    public float SpeedMaxTime { get; set; } = 2f;
}

