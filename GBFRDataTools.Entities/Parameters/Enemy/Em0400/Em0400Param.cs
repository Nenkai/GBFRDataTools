using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0400;

public class Em0400Param : EnemyParameterInfo
{
    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("downSecond_")]
    public float DownSecond { get; set; } = 0f;

    [JsonPropertyName("downFallSpeed_")]
    public float DownFallSpeed { get; set; } = 0.04f;

    [JsonPropertyName("boundFallSpeed_")]
    public float BoundFallSpeed { get; set; } = 0.3f;

    [JsonPropertyName("blowSpeed_")]
    public float BlowSpeed { get; set; } = 7f;

    [JsonPropertyName("blowSecond_")]
    public float BlowSecond { get; set; } = 0f;

    [JsonPropertyName("linkBlowSpeedScale_")]
    public float LinkBlowSpeedScale { get; set; } = 1.5f;

    [JsonPropertyName("heavyDamageReactionScale_")]
    public float HeavyDamageReactionScale { get; set; } = 1.5f;

    [JsonPropertyName("linkAttackJumpSpeed_")]
    public float LinkAttackJumpSpeed { get; set; } = 0.07f;

    [JsonPropertyName("linkAttackGravityRate_")]
    public float LinkAttackGravityRate { get; set; } = 0.55f;

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; }

    [JsonPropertyName("stepFlyParam_")]
    public CharaFlyParam StepFlyParam { get; set; }

    [JsonPropertyName("moveTimeOutSecond_")]
    public float MoveTimeOutSecond { get; set; } = 2.5f;

    [JsonPropertyName("stepAnimSpeed_")]
    public float StepAnimSpeed { get; set; } = 1f;

    [JsonPropertyName("stepBeginkDistance_")]
    public float StepBeginkDistance { get; set; } = 5f;

    [JsonPropertyName("stepJumpSpeed_")]
    public float StepJumpSpeed { get; set; } = 9f;

    [JsonPropertyName("stepUpCollisionCheckLen_")]
    public float StepUpCollisionCheckLen { get; set; } = 7f;

    [JsonPropertyName("stepCollisionCheckLen_")]
    public float StepCollisionCheckLen { get; set; } = 10.5f;

    [JsonPropertyName("moveHomingRate_")]
    public float MoveHomingRate { get; set; } = 0.03f;

    [JsonPropertyName("moveHomingDegree_")]
    public float MoveHomingDegree { get; set; } = 3f;

    [JsonPropertyName("attackHomingRate_")]
    public float AttackHomingRate { get; set; } = 0.08f;

    [JsonPropertyName("attackHomingDegree_")]
    public float AttackHomingDegree { get; set; } = 10f;

    [JsonPropertyName("clawDistanceXZ_")]
    public float ClawDistanceXZ { get; set; } = 2f;

    [JsonPropertyName("clawDistanceY_")]
    public float ClawDistanceY { get; set; } = 0.5f;

    [JsonPropertyName("glideDistanceXZ_")]
    public float GlideDistanceXZ { get; set; } = 10f;

    [JsonPropertyName("glideDistanceY_")]
    public float GlideDistanceY { get; set; } = 0f;

    [JsonPropertyName("fireBreathDistanceXZ_")]
    public float FireBreathDistanceXZ { get; set; } = 8f;

    [JsonPropertyName("fireBreathDistanceY_")]
    public float FireBreathDistanceY { get; set; } = 0.5f;

    [JsonPropertyName("fireBreathRotationDegree_")]
    public float FireBreathRotationDegree { get; set; } = 120f;

    [JsonPropertyName("fireBreathRotationSecond_")]
    public float FireBreathRotationSecond { get; set; } = 1.5f;

    [JsonPropertyName("fireBreathHomingRotationOffset_")]
    public float FireBreathHomingRotationOffset { get; set; } = -60f;

    [JsonPropertyName("fireBreathHomingRotationScale_")]
    public float FireBreathHomingRotationScale { get; set; } = 0.3f;

    [JsonPropertyName("fireBreathAttackRate_")]
    public float FireBreathAttackRate { get; set; } = 2f;

    [JsonPropertyName("fireBreathBreakRate_")]
    public float FireBreathBreakRate { get; set; } = 2f;

    [JsonPropertyName("fireBreathParam_")]
    public EmHitBreathParam FireBreathParam { get; set; }

    [JsonPropertyName("counterAttackCheckDistance_")]
    public float CounterAttackCheckDistance { get; set; } = 7.5f;

    [JsonPropertyName("counterAttackPlayerCount_")]
    public int CounterAttackPlayerCount { get; set; } = 1;

    [JsonPropertyName("maxDegreeX_")]
    public float MaxDegreeX { get; set; } = 0f;

    [JsonPropertyName("minDegreeX_")]
    public float MinDegreeX { get; set; } = 0f;

    [JsonPropertyName("maxDegreeY_")]
    public float MaxDegreeY { get; set; } = 70f;

    [JsonPropertyName("minDegreeY_")]
    public float MinDegreeY { get; set; } = -70f;

    public Em0400Param()
    {
        Hp = 7200;
        Atk = 700;
        Break = 5;
        Def = 0f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 35;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 15;
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
        HateUpdateTime = 5f;
        DamageToHateRate = 2f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 55;
        ItemRewordMoneyVal = 90;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 50f;
        Search2battleLength = 10f;
        EnemySize = 1;
        LinkAttackCameraDistRate = 0.25f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 0.6f;
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
        IsDisableAerialDownReaction = false;
    }
}
