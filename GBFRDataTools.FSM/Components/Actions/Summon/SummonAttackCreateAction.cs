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
public class SummonAttackCreateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonAttackCreateAction);

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("size_")]
    public Vector4 Size { get; set; } = Vector4.One;

    [JsonPropertyName("degreeX_")]
    public float DegreeX { get; set; } = 0f;

    [JsonPropertyName("degreeY_")]
    public float DegreeY { get; set; } = 0f;

    [JsonPropertyName("degreeZ_")]
    public float DegreeZ { get; set; } = 0f;

    [JsonPropertyName("shape_")]
    public int Shape { get; set; } = 0;

    [JsonPropertyName("summonDirection_")]
    public int SummonDirection { get; set; } = 0;

    [JsonPropertyName("summonTarget_")]
    public int SummonTarget { get; set; } = 0;

    [JsonPropertyName("summonOverWriteParamType_")]
    public int SummonOverWriteParamType { get; set; } = 0;

    [JsonPropertyName("summonGlobalType_")]
    public int SummonGlobalType { get; set; } = 0;

    [JsonPropertyName("summonType_")]
    public int SummonType { get; set; } = 0;

    [JsonPropertyName("summonReaction_")]
    public int SummonReaction { get; set; } = 0;

    [JsonPropertyName("summonHitFlag_")]
    public ulong SummonHitFlag { get; set; }

    [JsonPropertyName("summonCategoryFlag_")]
    public int SummonCategoryFlag { get; set; } = 0;

    [JsonPropertyName("summonElement_")]
    public int SummonElement { get; set; } = 0;

    [JsonPropertyName("summonAttackRate_")]
    public float SummonAttackRate { get; set; } = 1f;

    [JsonPropertyName("summonBreakRate_")]
    public float SummonBreakRate { get; set; } = 1f;

    [JsonPropertyName("summonSpArtsRate_")]
    public float SummonSpArtsRate { get; set; } = 1f;

    [JsonPropertyName("summonHitStopSecond_")]
    public float SummonHitStopSecond { get; set; } = 0f;

    [JsonPropertyName("summonHitVibrationType_")]
    public int SummonHitVibrationType { get; set; } = 0;

    [JsonPropertyName("summonLifeSecond_")]
    public float SummonLifeSecond { get; set; } = 0f;

    [JsonPropertyName("summonMultiHitIntervalSecond_")]
    public float SummonMultiHitIntervalSecond { get; set; } = 0f;

    [JsonPropertyName("summonMultiHitLimit_")]
    public int SummonMultiHitLimit { get; set; } = 0;

    [JsonPropertyName("summonKnockBackRate_")]
    public float SummonKnockBackRate { get; set; } = 1f;

    [JsonPropertyName("summonDamageMovementRate_")]
    public float SummonDamageMovementRate { get; set; } = 1f;

    [JsonPropertyName("summonDamageMovementRateY_")]
    public float SummonDamageMovementRateY { get; set; } = 1f;

    [JsonPropertyName("isSummonHitOnce_")]
    public bool IsSummonHitOnce { get; set; } = true;

    [JsonPropertyName("isSummonMoveToHitPos_")]
    public bool IsSummonMoveToHitPos { get; set; } = false;

    [JsonPropertyName("isSummonSetAttackerPos_")]
    public bool IsSummonSetAttackerPos { get; set; } = false;

    [JsonPropertyName("isSummonSetAttackerHitList_")]
    public bool IsSummonSetAttackerHitList { get; set; } = false;

    [JsonPropertyName("isSummonClearHitList_")]
    public bool IsSummonClearHitList { get; set; } = true;

    [JsonPropertyName("summonAttackClearTime_")]
    public float SummonAttackClearTime { get; set; } = 0f;

    [JsonPropertyName("summonAppropriStartDist")]
    public float SummonAppropriStartDist { get; set; } = -1f;

    [JsonPropertyName("summonAppropriEndDist")]
    public float SummonAppropriEndDist { get; set; } = 0f;

    [JsonPropertyName("summonNotAppropriDistAtkRate_")]
    public float SummonNotAppropriDistAtkRate { get; set; } = 0f;

    [JsonPropertyName("isSummonTakeOverAppropriDist_")]
    public bool IsSummonTakeOverAppropriDist { get; set; } = false;

    [JsonPropertyName("isSummonAlreadyHitClearEachEntity_")]
    public bool IsSummonAlreadyHitClearEachEntity { get; set; } = false;

    [JsonPropertyName("isSummonHitOnlyHormingTarget_")]
    public bool IsSummonHitOnlyHormingTarget { get; set; } = false;

    [JsonPropertyName("debuffList_")]
    public BindingList<DebuffData> DebuffList { get; set; } = [];

    [JsonPropertyName("isAttackScale_")]
    public bool IsAttackScale { get; set; } = false;

    [JsonPropertyName("scaleSeconds_")]
    public float ScaleSeconds { get; set; } = 1f;

    [JsonPropertyName("scaleSize_")]
    public Vector4 ScaleSize { get; set; } = Vector4.One;

    [JsonPropertyName("pullOffsetZ_")]
    public float PullOffsetZ { get; set; } = 0f;
}
