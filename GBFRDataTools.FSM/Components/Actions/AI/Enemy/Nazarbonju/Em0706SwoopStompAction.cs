using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0706SwoopStompAction : Em0706BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706SwoopStompAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0xD8

    [JsonPropertyName("flyHeightMax_")]
    public float FlyHeightMax { get; set; } = 10f; // Offset 0xDC

    [JsonPropertyName("flyLoopEndHeightDiff_")]
    public float FlyLoopEndHeightDiff { get; set; } = 1f; // Offset 0xE0

    [JsonPropertyName("fallTargetPosSpd_")]
    public float FallTargetPosSpd { get; set; } = 1.5f; // Offset 0xE4

    [JsonPropertyName("flyupSec_")]
    public float FlyupSec { get; set; } = 1.5f; // Offset 0xE8

    [JsonPropertyName("flyMoveSec_")]
    public float FlyMoveSec { get; set; } = 3f; // Offset 0xEC

    [JsonPropertyName("fallWaitSec_")]
    public float FallWaitSec { get; set; } = 0.2f; // Offset 0xF0

    [JsonPropertyName("flyMoveStopRangeXZ_")]
    public float FlyMoveStopRangeXZ { get; set; } = 0.5f; // Offset 0xF4

    [JsonPropertyName("flyRetrackingRangeXZ_")]
    public float FlyRetrackingRangeXZ { get; set; } = 4.5f; // Offset 0xF8

    [JsonPropertyName("flyMoveSpdXZ_")]
    public float FlyMoveSpdXZ { get; set; } = 0.25f; // Offset 0xFC

    [JsonPropertyName("flyMoveSpdY_")]
    public float FlyMoveSpdY { get; set; } = 0.5f; // Offset 0x100

    [JsonPropertyName("fallAttackAreaScale_")]
    public float FallAttackAreaScale { get; set; } = 0.8f; // Offset 0x104

    [JsonPropertyName("attackSignSec_")]
    public float AttackSignSec { get; set; } = 2.2f; // Offset 0x120

    [JsonPropertyName("attackAreaOffset_")]
    public Vector4 AttackAreaOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x110

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } = 2.5f; // Offset 0x128

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } = 2.5f; // Offset 0x12C

    [JsonPropertyName("attackSize_")]
    public float AttackSize { get; set; } = 3.9f; // Offset 0x130

    [JsonPropertyName("attackSec_")]
    public float AttackSec { get; set; } = 0.7f; // Offset 0x134

    [JsonPropertyName("attackWaveSignDelay_")]
    public float AttackWaveSignDelay { get; set; } = 0.4f; // Offset 0x124

    [JsonPropertyName("isTerminateWaves_")]
    public bool IsTerminateWaves { get; set; } = true; // Offset 0x138

    [JsonPropertyName("attackWaveSignScale_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float AttackWaveSignScale { get; set; }

    public Em0706SwoopStompAction()
    {
    }
}