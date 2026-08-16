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

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonTurnHomingTargetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonTurnHomingTargetAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f;

    [JsonPropertyName("maxTurnAngle_")]
    public float MaxTurnAngle { get; set; } = 30f;

    [JsonPropertyName("farDist_")]
    public float FarDist { get; set; } = 10f;

    [JsonPropertyName("nearestDist_")]
    public float NearestDist { get; set; } = 3f;

    [JsonPropertyName("isEnableTurnBySeqFlag_")]
    public bool IsEnableTurnBySeqFlag { get; set; } = false;

    [JsonPropertyName("isNearestDistEnd_")]
    public bool IsNearestDistEnd { get; set; } = false;

    [JsonPropertyName("isUseEntityHandle_")]
    public bool IsUseEntityHandle { get; set; } = false;

    [JsonPropertyName("isDisableTurnByLockon_")]
    public bool IsDisableTurnByLockon { get; set; } = false;

    [JsonPropertyName("isDisableTurnByLstick_")]
    public bool IsDisableTurnByLstick { get; set; } = false;

    [JsonPropertyName("isUseExternalTargetPos_")]
    public bool IsUseExternalTargetPos { get; set; } = false;

    [JsonPropertyName("targetRangeType_")]
    public int TargetRangeType { get; set; } = 3;

    [JsonPropertyName("targetPosBBName_")]
    public string TargetPosBBName { get; set; }

    [JsonPropertyName("targetPosResultBBName_")]
    public string TargetPosResultBBName { get; set; }

    [JsonPropertyName("externalTargetPosBBName_")]
    public string ExternalTargetPosBBName { get; set; }

    [JsonPropertyName("isTurnRotX_")]
    public bool IsTurnRotX { get; set; } = false;

    [JsonPropertyName("isUseTargetLockOnInfo_")]
    public bool IsUseTargetLockOnInfo { get; set; } = false;
}
