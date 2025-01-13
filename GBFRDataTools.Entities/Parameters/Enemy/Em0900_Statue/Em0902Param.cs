using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0900_Statue;

public class Em0902Param : EmStatueBaseParam
{
    [JsonPropertyName("wideSwingCoolTime_")]
    public float WideSwingCoolTime { get; set; } = 10f;

    [JsonPropertyName("handsAttackCoolTime_")]
    public float HandsAttackCoolTime { get; set; } = 10f;

    [JsonPropertyName("freezeBeamCoolTime_")]
    public float FreezeBeamCoolTime { get; set; } = 20f;

    [JsonPropertyName("drillCoolTime_")]
    public float DrillCoolTime { get; set; } = 10f;

    [JsonPropertyName("spinChargeCoolTime_")]
    public float SpinChargeCoolTime { get; set; } = 20f;

    [JsonPropertyName("populationAttackCoolTimeAddValue_")]
    public float PopulationAttackCoolTimeAddValue { get; set; } = 0.5f;

    [JsonPropertyName("freezeBeamSpeed_")]
    public float FreezeBeamSpeed { get; set; } = 0.09f;

    [JsonPropertyName("freezeBeamSize_")]
    public float FreezeBeamSize { get; set; } = 0.5f;

    [JsonPropertyName("freezeBeamLandingSec_")]
    public float FreezeBeamLandingSec { get; set; } = 0.2f;

    [JsonPropertyName("freezeBeamStartPosOffset_")]
    public float FreezeBeamStartPosOffset { get; set; } = 10f;

    [JsonPropertyName("freezeBeamAtkRate_")]
    public float FreezeBeamAtkRate { get; set; } = 1.8f;

    [JsonPropertyName("freezeBeamBreakRate_")]
    public float FreezeBeamBreakRate { get; set; } = 1.8f;

    [JsonPropertyName("freezeBeamFrozenSec_")]
    public float FreezeBeamFrozenSec { get; set; } = 5f;

    [JsonPropertyName("freezeBeamFrozenRate_")]
    public float FreezeBeamFrozenRate { get; set; } = 0.5f;

    public Em0902Param()
    {
        Hp = 10000;
        Atk = 100;
        Break = 5;
        Def = 1f;
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
        DamageToHateRate = 0.2f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 55;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
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
        ScaleParam = 0.55f;
        DamageReactionBreakValue = 0f;
        CoreLightOffSec = 3.7f;
        AttackCoolTime = 3f;
        StepCoolTime = 3f;
        CoreLightUpGuardRate = 0.5f;
        CoreLightUpGuardBreakRate = 0.4f;
        CoreLightUpKnockBackRate = 0f;
        CoreLightUpCounterRate = 4f;
        CoreLightUpGuardUi = false;
        CoreLightUpGuardEffect = true;
        CoreLightUpGuardSe = true;
        CoreLightAlphaRate = 0.5f;
        CoreLightOnEmissiveRate = 1f;
        CoreLightOffEmissiveRate = 0.01f;
        DrillFlyMoveStopRangeXZ = 0.5f;
        DrillFlyMoveSpdXZ = 45f;
    }
}
