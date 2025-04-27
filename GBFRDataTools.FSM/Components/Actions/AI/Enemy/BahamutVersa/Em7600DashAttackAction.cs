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
    public float LoopTime { get; set; } = 10f; // Offset 0x34

    [JsonPropertyName("rotSpeed_")]
    public float RotSpeed { get; set; } = 0.9f; // Offset 0x54

    [JsonPropertyName("centerRotSpeed_")]
    public float CenterRotSpeed { get; set; } = 0.8f; // Offset 0x58

    [JsonPropertyName("centerSpeed_")]
    public float CenterSpeed { get; set; } = 3f; // Offset 0x5C

    [JsonPropertyName("spreadTimer_")]
    public float SpreadTimer { get; set; } = 3f; // Offset 0x38

    [JsonPropertyName("createWaveTimeMax_")]
    public float CreateWaveTimeMax { get; set; } = 5f; // Offset 0x68

    [JsonPropertyName("createWaveTimeMin_")]
    public float CreateWaveTimeMin { get; set; } = 3f; // Offset 0x6C

    [JsonPropertyName("speedWaveTimeMax_")]
    public float SpeedWaveTimeMax { get; set; } = 2f; // Offset 0x70

    [JsonPropertyName("speedWaveTimeMin_")]
    public float SpeedWaveTimeMin { get; set; } = 1f; // Offset 0x74

    public Em7600DashAttackAction()
    {
    }
}

