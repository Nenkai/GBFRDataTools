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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.PyetA;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So4600RushAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So4600RushAttackAction);

    [JsonPropertyName("rushSignStartDelay_")]
    public float RushSignStartDelay { get; set; } = 1f;

    [JsonPropertyName("rushSignScaleY_")]
    public float RushSignScaleY { get; set; } = 1f;

    [JsonPropertyName("rushSizeLX_")]
    public float RushSizeLX { get; set; } = 0f;

    [JsonPropertyName("rushSizeRX_")]
    public float RushSizeRX { get; set; } = 0f;

    [JsonPropertyName("rushDist_")]
    public float RushDist { get; set; } = 10f;

    [JsonPropertyName("rushSpeed_")]
    public float RushSpeed { get; set; } = 1f;

    [JsonPropertyName("rushLoopTimeMin_")]
    public float RushLoopTimeMin { get; set; } = 0.1f;

    [JsonPropertyName("rushLoopTimeMax_")]
    public float RushLoopTimeMax { get; set; } = 1f;

    [JsonPropertyName("wallCheckDist_")]
    public float WallCheckDist { get; set; } = 0f;

    [JsonPropertyName("wallCheckHeight_")]
    public float WallCheckHeight { get; set; } = 1f;

    [JsonPropertyName("groundCheckHeight_")]
    public float GroundCheckHeight { get; set; } = 10f;

    [JsonPropertyName("rushReadyInterTime_")]
    public float RushReadyInterTime { get; set; } = 0.1f;

    [JsonPropertyName("turnAngle_")]
    public float TurnAngle { get; set; } = 90f;

    [JsonPropertyName("lockOnTurnRate_")]
    public float LockOnTurnRate { get; set; } = 0.3f;

    [JsonPropertyName("fallAttackStartPosDistMax_")]
    public float FallAttackStartPosDistMax { get; set; } = 60f;

    [JsonPropertyName("lsInputRequiredTime_")]
    public float LsInputRequiredTime { get; set; } = 0.2f;

    [JsonPropertyName("rushSignTurnLimit_")]
    public float RushSignTurnLimit { get; set; } = 90f;

    [JsonPropertyName("rushSignTurnAdjustLength_")]
    public float RushSignTurnAdjustLength { get; set; } = 2f;

    [JsonPropertyName("turnCancelRushInterTime_")]
    public float TurnCancelRushInterTime { get; set; } = 0.1f;

    [JsonPropertyName("wallCheckRushEndDelay_")]
    public float WallCheckRushEndDelay { get; set; } = 0.075f;
}