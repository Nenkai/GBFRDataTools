using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0000;

public class Em0001Param : EnemyParameterInfo
{
    [JsonPropertyName("moveEndDist_")]
    public float MoveEndDist { get; set; } = 25f;

    [JsonPropertyName("escapeDist_")]
    public float EscapeDist { get; set; } = 10f;

    [JsonPropertyName("checkWallLength_")]
    public float CheckWallLength { get; set; } = 6f;

    [JsonPropertyName("checkWallBackLength_")]
    public float CheckWallBackLength { get; set; } = 10f;

    [JsonPropertyName("frontArea_")]
    public float FrontArea { get; set; } = 60f;

    [JsonPropertyName("frontAreaShortRangeOffset_")]
    public float FrontAreaShortRangeOffset { get; set; } = 2f;

    [JsonPropertyName("slowAreaRange_")]
    public float SlowAreaRange { get; set; } = 12f;

    [JsonPropertyName("slowRate_")]
    public float SlowRate { get; set; } = 0.7f;

    [JsonPropertyName("slowTime_")]
    public float SlowTime { get; set; } = 10f;

    [JsonPropertyName("checkSlowAreaDist_")]
    public float CheckSlowAreaDist { get; set; } = 30f;

    [JsonPropertyName("checkEnemyNum")]
    public int CheckEnemyNum { get; set; } = 2;

    [JsonPropertyName("buffTime_")]
    public float BuffTime { get; set; } = 1f;

    [JsonPropertyName("buffAttackRate_")]
    public float BuffAttackRate { get; set; } = 0.3f;

    [JsonPropertyName("buffHealCycleSec_")]
    public float BuffHealCycleSec { get; set; } = 1f;

    [JsonPropertyName("buffHealRate_")]
    public float BuffHealRate { get; set; } = 0.03f;

    [JsonPropertyName("buffDist_")]
    public float BuffDist { get; set; } = 30f;

    [JsonPropertyName("damageReactionBreakValue_")]
    public float DamageReactionBreakValue { get; set; } = 80f;

    [JsonPropertyName("stepCoolTime_")]
    public float StepCoolTime { get; set; } = 10f;

    [JsonPropertyName("trapCoolTime_")]
    public float TrapCoolTime { get; set; } = 6f;

    [JsonPropertyName("attackCoolTime_")]
    public float AttackCoolTime { get; set; } = 1f;

    [JsonPropertyName("firebBallHomingUpdateTime_")]
    public float FirebBallHomingUpdateTime { get; set; } = 0.1f;

    [JsonPropertyName("fireWallParam_")]
    public EmAttackWall_Param FireWallParam { get; set; } // EmAttackWall::Param

    [JsonPropertyName("fireWallAtkRate_")]
    public float FireWallAtkRate { get; set; } = 2f;

    [JsonPropertyName("fireWallBreakRate_")]
    public float FireWallBreakRate { get; set; } = 0f;

    [JsonPropertyName("fireWallBurnSec_")]
    public float FireWallBurnSec { get; set; } = 5f;

    [JsonPropertyName("fireWallBurnRate_")]
    public float FireWallBurnRate { get; set; } = 0.5f;

    [JsonPropertyName("atkOntheSpotTypeList_")]
    public BindingList<int> AtkOntheSpotTypeList { get; set; } = []; // std::vector<int>

    public Em0001Param()
    {
        Hp = 2500;
        Atk = 80;
        Break = 3;
        Def = 0f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 15;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 35;
        HateRateBackAngle = 0;
        HateRateDamage = 50;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 0;
        HateUpdateTime = 10f;
        DamageToHateRate = 0.02f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 30;
        ItemRewordMoneyVal = 20;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 0.8f;
        BasicHitStopTimeRate = 1f;
        DamageReactionHitStopTimeRate = 1f;
        SuperArmorHitStopTimeRate = 0.5f;
        AttackerHitStopTimeRate = 0f;
        AddReactionHitstopFrameMin = -1f;
        AddReactionHitstopFrameMax = -1f;
        AddReactionWeightRateMin = -1f;
        AddReactionWeightRateMax = -1f;
        AddReactionWeightRateAI = -1f;
        AddReactionInterSec = -1f;
        IsEyeLookingAtLockOn = false;
        LookingAtPartsNo = 5;
        IsEnableSyncWeaponAnim = false;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = true;
    }
}
