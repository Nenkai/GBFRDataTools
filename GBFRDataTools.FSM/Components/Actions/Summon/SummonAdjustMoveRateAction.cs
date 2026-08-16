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
public class SummonAdjustMoveRateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonAdjustMoveRateAction);

    [JsonPropertyName("isUseEntityHandle_")]
    public bool IsUseEntityHandle { get; set; } = false;

    [JsonPropertyName("isSequenceLookAtOnly_")]
    public bool IsSequenceLookAtOnly { get; set; } = false;

    [JsonPropertyName("isSequenceOnly_")]
    public bool IsSequenceOnly { get; set; } = false;

    [JsonPropertyName("isLookAtTarget_")]
    public bool IsLookAtTarget { get; set; } = true;

    [JsonPropertyName("targetValidAngle_")]
    public float TargetValidAngle { get; set; } = 120f;

    [JsonPropertyName("baseMoveAmount_")]
    public float BaseMoveAmount { get; set; } = 0f;

    [JsonPropertyName("minRate_")]
    public float MinRate { get; set; } = 0.25f;

    [JsonPropertyName("maxRate_")]
    public float MaxRate { get; set; } = 2f;

    [JsonPropertyName("targetRangeType_")]
    public int TargetRangeType { get; set; } = 0;

    [JsonPropertyName("isUpdateAdjust_")]
    public bool IsUpdateAdjust { get; set; } = false;
}
