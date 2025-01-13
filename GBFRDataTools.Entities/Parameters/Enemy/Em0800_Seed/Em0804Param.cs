using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0800_Seed;

public class Em0804Param : EmSeedParam
{
    [JsonPropertyName("minionThunderCoolTime_")]
    public Vector2 MinionThunderCoolTime { get; set; } = new Vector2(15f, 15f);

    [JsonPropertyName("homePostitionFarDist_")]
    public float HomePostitionFarDist { get; set; } = 2f;

    [JsonPropertyName("attackClearTime_")]
    public float AttackClearTime { get; set; } = 1f;

    [JsonPropertyName("damageCutFirstLevelRate_")]
    public float DamageCutFirstLevelRate { get; set; } = 0.5f;

    [JsonPropertyName("damageCutFirstLevelHpRate_")]
    public float DamageCutFirstLevelHpRate { get; set; } = 0.8f;

    [JsonPropertyName("damageCutSecondLevelRate_")]
    public float DamageCutSecondLevelRate { get; set; } = 0.7f;

    [JsonPropertyName("damageCutSecondLevelHpRate_")]
    public float DamageCutSecondLevelHpRate { get; set; } = 0.4f;

    [JsonPropertyName("waveAttackRate_")]
    public float WaveAttackRate { get; set; } = 1.5f;

    [JsonPropertyName("waveBreakRate_")]
    public float WaveBreakRate { get; set; } = 1f;

    [JsonPropertyName("waveStartRadius_")]
    public float WaveStartRadius { get; set; } = 0.6f;

    [JsonPropertyName("waveTime_")]
    public float WaveTime { get; set; } = 22.5f;

    [JsonPropertyName("interruptSpreadTime_")]
    public float InterruptSpreadTime { get; set; } = 1f;

    [JsonPropertyName("sparkAttackRate_")]
    public float SparkAttackRate { get; set; } = 0.4f;

    [JsonPropertyName("sparkBreakRate_")]
    public float SparkBreakRate { get; set; } = 1f;

    [JsonPropertyName("sparkRadius_")]
    public float SparkRadius { get; set; } = 1.7f;

    [JsonPropertyName("chainBeamAttackRate_")]
    public float ChainBeamAttackRate { get; set; } = 1.1f;

    [JsonPropertyName("chainBeamBreakRate_")]
    public float ChainBeamBreakRate { get; set; } = 1f;

    [JsonPropertyName("chainBeamRadius_")]
    public float ChainBeamRadius { get; set; } = 0.8f;

    [JsonPropertyName("fallBeamAttackRate_")]
    public float FallBeamAttackRate { get; set; } = 1.5f;

    [JsonPropertyName("fallBeamBreakRate_")]
    public float FallBeamBreakRate { get; set; } = 1f;

    [JsonPropertyName("fallBeamJudgmentThunderAttackRate_")]
    public float FallBeamJudgmentThunderAttackRate { get; set; } = 1f;

    [JsonPropertyName("fallBeamOffset_")]
    public float FallBeamOffset { get; set; } = 0.5f;

    [JsonPropertyName("fallBeamRadius_")]
    public float FallBeamRadius { get; set; } = 0.25f;

    [JsonPropertyName("fallRotationSecondMax_")]
    public float FallRotationSecondMax { get; set; } = 5f;

    [JsonPropertyName("fallRotationReverse_")]
    public bool FallRotationReverse { get; set; } = false;

    [JsonPropertyName("blowBombSummonAtkRate_")]
    public float BlowBombSummonAtkRate { get; set; } = 30f;

    [JsonPropertyName("blowBombSummonBreakRate_")]
    public float BlowBombSummonBreakRate { get; set; } = 10f;

    [JsonPropertyName("blowBombSummonHitStop_")]
    public int BlowBombSummonHitStop { get; set; } = 10;

    [JsonPropertyName("blowBombDispelAbilityNum_")]
    public int BlowBombDispelAbilityNum { get; set; } = 1;

    public Em0804Param()
    {
        Hp = 4500;
        Atk = 100;
        Break = 3;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 50;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
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
        CombatPower = 30;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 2304;
        UiOffsetY = 2f;
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
        HitCheckLength = 3f;
        ShotCoolTime = 7f;
        BackStepCoolTime = 7f;
        LiftUpCollisionRadius = 0.2f;
        BlowVecRate = 0.1f;
        BlowRotRate = 0f;
        ThrowGravityRate = 0.15f;
        BlowBombAtkRate = 8f;
        BlowBombBreakRate = 20f;
        BlowBombHitStop = 10;
        BlowBombAttackSignSize = 6f;
    }
}