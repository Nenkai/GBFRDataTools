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
    public float HomingAngle { get; set; } = 10f; 

    [JsonPropertyName("flyHeightMax_")]
    public float FlyHeightMax { get; set; } = 10f; 

    [JsonPropertyName("flyLoopEndHeightDiff_")]
    public float FlyLoopEndHeightDiff { get; set; } = 1f; 

    [JsonPropertyName("fallTargetPosSpd_")]
    public float FallTargetPosSpd { get; set; } = 1.5f; 

    [JsonPropertyName("flyupSec_")]
    public float FlyupSec { get; set; } = 1.5f; 

    [JsonPropertyName("flyMoveSec_")]
    public float FlyMoveSec { get; set; } = 3f; 

    [JsonPropertyName("fallWaitSec_")]
    public float FallWaitSec { get; set; } = 0.2f; 

    [JsonPropertyName("flyMoveStopRangeXZ_")]
    public float FlyMoveStopRangeXZ { get; set; } = 0.5f; 

    [JsonPropertyName("flyRetrackingRangeXZ_")]
    public float FlyRetrackingRangeXZ { get; set; } = 4.5f; 

    [JsonPropertyName("flyMoveSpdXZ_")]
    public float FlyMoveSpdXZ { get; set; } = 0.25f; 

    [JsonPropertyName("flyMoveSpdY_")]
    public float FlyMoveSpdY { get; set; } = 0.5f; 

    [JsonPropertyName("fallAttackAreaScale_")]
    public float FallAttackAreaScale { get; set; } = 0.8f; 

    [JsonPropertyName("attackSignSec_")]
    public float AttackSignSec { get; set; } = 2.2f; 

    [JsonPropertyName("attackAreaOffset_")]
    public Vector4 AttackAreaOffset { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } = 2.5f; 

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } = 2.5f; 

    [JsonPropertyName("attackSize_")]
    public float AttackSize { get; set; } = 3.9f; 

    [JsonPropertyName("attackSec_")]
    public float AttackSec { get; set; } = 0.7f; 

    [JsonPropertyName("attackWaveSignDelay_")]
    public float AttackWaveSignDelay { get; set; } = 0.4f; 

    [JsonPropertyName("isTerminateWaves_")]
    public bool IsTerminateWaves { get; set; } = true; 

    [JsonPropertyName("attackWaveSignScale_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float AttackWaveSignScale { get; set; }
}