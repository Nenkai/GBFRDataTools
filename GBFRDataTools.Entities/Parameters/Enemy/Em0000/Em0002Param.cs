using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0000;

public class Em0002Param : EnemyParameterInfo
{
    [JsonPropertyName("damageReactionBreakValue_")]
    public float DamageReactionBreakValue { get; set; } = 50f;

    [JsonPropertyName("shieldHp_")]
    public int ShieldHp { get; set; } = 500;

    [JsonPropertyName("shieldHpAILevel1_")]
    public int ShieldHpAILevel1 { get; set; } = 100;

    [JsonPropertyName("shieldHpAILevel2_")]
    public int ShieldHpAILevel2 { get; set; } = 225;

    [JsonPropertyName("shieldHpAILevel3_")]
    public int ShieldHpAILevel3 { get; set; } = 350;

    [JsonPropertyName("shieldHpAILevel4_")]
    public int ShieldHpAILevel4 { get; set; } = 500;

    [JsonPropertyName("guardAngle_")]
    public float GuardAngle { get; set; } = 90f;

    [JsonPropertyName("guardDamageRate_")]
    public float GuardDamageRate { get; set; } = 0.1f;

    [JsonPropertyName("guardContinueExtendTime_")]
    public float GuardContinueExtendTime { get; set; } = 1.5f;

    [JsonPropertyName("guardKnockbackRate_")]
    public float GuardKnockbackRate { get; set; } = 0.175f;

    [JsonPropertyName("meleeAttackCoolTime_")]
    public float MeleeAttackCoolTime { get; set; } = 5f;

    [JsonPropertyName("provokeCoolTime_")]
    public float ProvokeCoolTime { get; set; } = 20f;

    [JsonPropertyName("backStepCoolTime_")]
    public float BackStepCoolTime { get; set; } = 30f;

    [JsonPropertyName("guardActionCoolTime_")]
    public float GuardActionCoolTime { get; set; } = 3f;

    [JsonPropertyName("slapHPRate_")]
    public float SlapHPRate { get; set; } = 0.5f;

    [JsonPropertyName("slapSubShieldHPRate")]
    public float SlapSubShieldHPRate { get; set; } = 0.2f;

    [JsonPropertyName("slapBreakShieldHPRate")]
    public float SlapBreakShieldHPRate { get; set; } = 0.5f;

    [JsonPropertyName("effectShieldHPRate")]
    public float EffectShieldHPRate { get; set; } = 0.5f;

    [JsonPropertyName("forceGuardCount_")]
    public int ForceGuardCount { get; set; } = 20;

    [JsonPropertyName("successAddGuardCount_")]
    public int SuccessAddGuardCount { get; set; } = 7;

    [JsonPropertyName("missAddGuardCount_")]
    public int MissAddGuardCount { get; set; } = 4;

    [JsonPropertyName("stackDamageAngle_")]
    public float StackDamageAngle { get; set; } = 360f;

    [JsonPropertyName("jumpSlapAttackRate_")]
    public float JumpSlapAttackRate { get; set; } = 3f;

    [JsonPropertyName("jumpSlapBreakRate_")]
    public float JumpSlapBreakRate { get; set; } = 3f;

    [JsonPropertyName("counterDebuffSec_")]
    public float CounterDebuffSec { get; set; } = 60f;

    [JsonPropertyName("counterDebuffRate_")]
    public float CounterDebuffRate { get; set; } = 15f;

    [JsonPropertyName("moveToActionCheckHeight_")]
    public float MoveToActionCheckHeight { get; set; } = 3f;

    public Em0002Param()
    {
        Hp = 2500;
        Atk = 100;
        Break = 3;
        Def = 0f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 20;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 30;
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
        CombatPower = 40;
        ItemRewordMoneyVal = 0;
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
        IsEnableSyncWeaponAnim = true;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = true;
    }
}
