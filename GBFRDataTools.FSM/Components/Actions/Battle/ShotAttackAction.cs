using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotAttackAction : ShotHitBaseAction
{
    [JsonPropertyName("direction_")]
    public int Direction { get; set; }

    [JsonPropertyName("target_")]
    public int Target { get; set; }

    [JsonPropertyName("globalType_")]
    public int GlobalType { get; set; }

    [JsonPropertyName("type_")]
    public int Type { get; set; }

    [JsonPropertyName("reaction_")]
    public int Reaction { get; set; }

    [JsonPropertyName("hitFlag_")]
    public ulong HitFlag { get; set; }

    [JsonPropertyName("categoryFlag_")]
    public int CategoryFlag { get; set; }

    [JsonPropertyName("element_")]
    public int Element { get; set; }

    [Obsolete("Not read by the game")]
    [JsonPropertyName("badStatus_")]
    public int BadStatus { get; set; }

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; }

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; }

    [JsonPropertyName("spArtsRate_")]
    public float SpArtsRate { get; set; }

    [JsonPropertyName("hitStopSecond_")]
    public float HitStopSecond { get; set; }

    [JsonPropertyName("hitVibrationType_")]
    public int HitVibrationType { get; set; }

    [JsonPropertyName("lifeSecond_")]
    public float LifeSecond { get; set; }

    [JsonPropertyName("multiHitIntervalSecond_")]
    public float MultiHitIntervalSecond { get; set; }

    [JsonPropertyName("knockBackRate_")]
    public float KnockBackRate { get; set; }

    [JsonPropertyName("damageMovementRate_")]
    public float DamageMovementRate { get; set; }

    [JsonPropertyName("damageMovementRateY_")]
    public float DamageMovementRateY { get; set; }

    [JsonPropertyName("isHitOnce_")]
    public bool IsHitOnce { get; set; }

    [JsonPropertyName("isMoveToHitPos_")]
    public bool IsMoveToHitPos { get; set; }

    [JsonPropertyName("isSetAttackerPos_")]
    public bool IsSetAttackerPos { get; set; }

    [JsonPropertyName("isSetAttackerHitList_")]
    public bool IsSetAttackerHitList { get; set; }

    [JsonPropertyName("isClearHitList_")]
    public bool IsClearHitList { get; set; }

    [JsonPropertyName("multiHitLimit_")]
    public int MultiHitLimit { get; set; }

    [JsonPropertyName("isSwept_")]
    public bool IsSwept { get; set; }

    [JsonPropertyName("debuffList_")]
    public BindingList<DebuffData> DebuffList { get; set; }

    [JsonPropertyName("attackClearTime_")]
    public float AttackClearTime { get; set; }

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
    public float AppropriStartDist { get; set; }

    [JsonPropertyName("appropriEndDist")]
    public float AppropriEndDist { get; set; }

    [JsonPropertyName("notAppropriDistAtkRate_")]
    public float NotAppropriDistAtkRate { get; set; }

    [JsonPropertyName("isTakeOverAppropriDist_")]
    public bool IsTakeOverAppropriDist { get; set; }

    [JsonPropertyName("isAlreadyHitClearEachEntity_")]
    public bool IsAlreadyHitClearEachEntity { get; set; }

    [JsonPropertyName("isHitOnlyHormingTarget_")]
    public bool IsHitOnlyHormingTarget { get; set; }

    [Obsolete("Not read by the game")]
    [JsonPropertyName("setAttackDelayTime_")]
    public int SetAttackDelayTime { get; set; }

}
