using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotAttackAction : ShotHitBaseAction
{
    [JsonPropertyName("direction_")]
    public int Direction { get; set; } = 0;

    [JsonPropertyName("target_")]
    public int Target { get; set; } = 0;

    [JsonPropertyName("globalType_")]
    public int GlobalType { get; set; } = 0;

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("reaction_")]
    public int Reaction { get; set; } = 0;

    [JsonPropertyName("hitFlag_")]
    public ulong HitFlag { get; set; } = 0;

    [JsonPropertyName("categoryFlag_")]
    public int CategoryFlag { get; set; } = 0;

    [JsonPropertyName("element_")]
    public int Element { get; set; } = 0;

    [Obsolete("Not read by the game")]
    [JsonPropertyName("badStatus_")]
    public int BadStatus { get; set; }

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } = 1.0f;

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } = 1.0f;

    [JsonPropertyName("spArtsRate_")]
    public float SpArtsRate { get; set; } = 1.0f;

    [JsonPropertyName("hitStopSecond_")]
    public float HitStopSecond { get; set; }

    [JsonPropertyName("hitVibrationType_")]
    public int HitVibrationType { get; set; }

    [JsonPropertyName("lifeSecond_")]
    public float LifeSecond { get; set; } = 0;

    [JsonPropertyName("multiHitIntervalSecond_")]
    public float MultiHitIntervalSecond { get; set; } = 0.0f;

    [JsonPropertyName("knockBackRate_")]
    public float KnockBackRate { get; set; } = 1.0f;

    [JsonPropertyName("damageMovementRate_")]
    public float DamageMovementRate { get; set; } = 1.0f;

    [JsonPropertyName("damageMovementRateY_")]
    public float DamageMovementRateY { get; set; } = 1.0f;

    [JsonPropertyName("isHitOnce_")]
    public bool IsHitOnce { get; set; } = true;

    [JsonPropertyName("isMoveToHitPos_")]
    public bool IsMoveToHitPos { get; set; }

    [JsonPropertyName("isSetAttackerPos_")]
    public bool IsSetAttackerPos { get; set; } = false;

    [JsonPropertyName("isSetAttackerHitList_")]
    public bool IsSetAttackerHitList { get; set; }

    [JsonPropertyName("isClearHitList_")]
    public bool IsClearHitList { get; set; } = true;

    [JsonPropertyName("multiHitLimit_")]
    public int MultiHitLimit { get; set; } = 0;

    [JsonPropertyName("isSwept_")]
    public bool IsSwept { get; set; } = false;

    [JsonPropertyName("debuffList_")]
    public BindingList<DebuffData> DebuffList { get; set; } = [];

    [JsonPropertyName("attackClearTime_")]
    public float AttackClearTime { get; set; } = 0.0f;

    [Obsolete("Not used by the game")]
    [JsonPropertyName("atkRateSubDist_")]
    public int AtkRateSubDist { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("atkRateMaxSubDist_")]
    public int AtkRateMaxSubDist { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("atkSubRateClamp_")]
    public int AtkSubRateClamp { get; set; }

    [JsonPropertyName("appropriStartDist")]
    public float AppropriStartDist { get; set; } = -1.0f;

    [JsonPropertyName("appropriEndDist")]
    public float AppropriEndDist { get; set; } = 0.0f;

    [JsonPropertyName("notAppropriDistAtkRate_")]
    public float NotAppropriDistAtkRate { get; set; } = 0.0f;

    [JsonPropertyName("isTakeOverAppropriDist_")]
    public bool IsTakeOverAppropriDist { get; set; } = false;

    [JsonPropertyName("isAlreadyHitClearEachEntity_")]
    public bool IsAlreadyHitClearEachEntity { get; set; } = false;

    [JsonPropertyName("isHitOnlyHormingTarget_")]
    public bool IsHitOnlyHormingTarget { get; set; } = false;

    [Obsolete("Not read by the game")]
    [JsonPropertyName("setAttackDelayTime_")]
    public int SetAttackDelayTime { get; set; }

}
