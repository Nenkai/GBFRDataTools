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
public class SummonStickRotateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonStickRotateAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.1f;

    [JsonPropertyName("maxTurnAngle_")]
    public float MaxTurnAngle { get; set; } = 30f;

    [JsonPropertyName("isEnableTurnBySeqFlag_")]
    public bool IsEnableTurnBySeqFlag { get; set; } = false;

    [JsonPropertyName("isBackControlFlag_")]
    public bool IsBackControlFlag { get; set; } = false;

    [JsonPropertyName("isStickInclinationFlag_")]
    public bool IsStickInclinationFlag { get; set; } = false;

    [JsonPropertyName("isTurnLimitFlag_")]
    public bool IsTurnLimitFlag { get; set; } = false;

    [JsonPropertyName("isUseOffsetAngle_")]
    public bool IsUseOffsetAngle { get; set; } = false;

    [JsonPropertyName("camOffsetAngle_")]
    public float CamOffsetAngle { get; set; } = 0f;

    [JsonPropertyName("isUseSquaredCurve_")]
    public bool IsUseSquaredCurve { get; set; } = false;

    [JsonPropertyName("isEscalateTurnRate_")]
    public bool IsEscalateTurnRate { get; set; } = false;

    [JsonPropertyName("escalateTurnRate_")]
    public float EscalateTurnRate { get; set; } = 0f;

    [JsonPropertyName("maxEscalateTurnRate_")]
    public float MaxEscalateTurnRate { get; set; } = 0f;

    [JsonPropertyName("disableRotationDuringLockOn_")]
    public bool DisableRotationDuringLockOn { get; set; } = false;

    [JsonPropertyName("turnLimitAngle_")]
    public float TurnLimitAngle { get; set; } = 0f;
}
