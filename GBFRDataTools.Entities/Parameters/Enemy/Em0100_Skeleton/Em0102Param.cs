using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0100_Skeleton;

public class Em0102Param : EmLargeSkeletonBaseParam
{
    [JsonPropertyName("stepSlashMoveRateB_")]
    public float StepSlashMoveRateB { get; set; } = 1.5f;

    [JsonPropertyName("stepSlashMoveRateR_")]
    public float StepSlashMoveRateR { get; set; } = 1.5f;

    [JsonPropertyName("stepSlashMoveRateL_")]
    public float StepSlashMoveRateL { get; set; } = 1.5f;

    [JsonPropertyName("stepSlashMoveRateBackLong_")]
    public float StepSlashMoveRateBackLong { get; set; } = 2f;

    [JsonPropertyName("stepSummonMoveRate_")]
    public float StepSummonMoveRate { get; set; } = 1.5f;

    [JsonPropertyName("lifeStealRate_")]
    public float LifeStealRate { get; set; } = 0.005f;

    [JsonPropertyName("lifeStealRate_HighLevelAi_")]
    public float LifeStealRate_HighLevelAi { get; set; } = 0.01f;

    [JsonPropertyName("lifeStealBuffSec_")]
    public float LifeStealBuffSec { get; set; } = 30f;

    [JsonPropertyName("slowAreaRemainSec_LevelAi1_")]
    public float SlowAreaRemainSec_LevelAi1 { get; set; } = 5f;

    [JsonPropertyName("slowAreaRemainSec_LevelAi2_")]
    public float SlowAreaRemainSec_LevelAi2 { get; set; } = 7f;

    [JsonPropertyName("slowAreaRemainSec_LevelAi3_")]
    public float SlowAreaRemainSec_LevelAi3 { get; set; } = 10f;

    [JsonPropertyName("slowAreaRemainSec_LevelAi4_")]
    public float SlowAreaRemainSec_LevelAi4 { get; set; } = 12f;

    [JsonPropertyName("slowAreaWideRemainSec_LevelAi1_")]
    public float SlowAreaWideRemainSec_LevelAi1 { get; set; } = 5f;

    [JsonPropertyName("slowAreaWideRemainSec_LevelAi2_")]
    public float SlowAreaWideRemainSec_LevelAi2 { get; set; } = 7f;

    [JsonPropertyName("slowAreaWideRemainSec_LevelAi3_")]
    public float SlowAreaWideRemainSec_LevelAi3 { get; set; } = 12f;

    [JsonPropertyName("slowAreaWideRemainSec_LevelAi4_")]
    public float SlowAreaWideRemainSec_LevelAi4 { get; set; } = 15f;

    [JsonPropertyName("throwSummonCoolSec_LevelAi1_")]
    public float ThrowSummonCoolSec_LevelAi1 { get; set; } = 100f;

    [JsonPropertyName("throwSummonCoolSec_LevelAi2_")]
    public float ThrowSummonCoolSec_LevelAi2 { get; set; } = 60f;

    [JsonPropertyName("throwSummonCoolSec_LevelAi3_")]
    public float ThrowSummonCoolSec_LevelAi3 { get; set; } = 60f;

    [JsonPropertyName("throwSummonCoolSec_LevelAi4_")]
    public float ThrowSummonCoolSec_LevelAi4 { get; set; } = 45f;

    [JsonPropertyName("stepSlashCoolSec_")]
    public float StepSlashCoolSec { get; set; } = 30f;

    [JsonPropertyName("longBackStepComboCoolSec_")]
    public float LongBackStepComboCoolSec { get; set; } = 150f;

    [JsonPropertyName("frontJumpSlashCoolSec_")]
    public float FrontJumpSlashCoolSec { get; set; } = 45f;

    [JsonPropertyName("wideSlashCoolSec_")]
    public float WideSlashCoolSec { get; set; } = 60f;

    [JsonPropertyName("slashShotCoolSec_")]
    public float SlashShotCoolSec { get; set; } = 90f;

    [JsonPropertyName("counterWaveAttackRate_")]
    public float CounterWaveAttackRate { get; set; } = 1f;

    [JsonPropertyName("counterWaveBreakRate_")]
    public float CounterWaveBreakRate { get; set; } = 1f;

    public Em0102Param()
    {
        Hp = 430000;
        Atk = 1500;
        Break = 8;
        Def = 1f;
        Endurance = 50;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 25;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 25;
        HateRateBackAngle = 0;
        HateRateDamage = 25;
        HateRateManualPlayer = 100;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 25;
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
        CombatPower = 65;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 0.5f;
        AnimInterDefaultSec = 0.2f;
        DamageAnimInterDefaultSec = 0f;
        UiPartsNo = 5;
        UiOffsetY = 0.7f;
        BasicHitStopTimeRate = 0.5f;
        DamageReactionHitStopTimeRate = 1f;
        SuperArmorHitStopTimeRate = 0.1f;
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
        StageInvisibleStartDistance = 100f;
        StageInvisibleEndDistance = 125f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = false;
        IsDisableAerialDownReaction = true;
        CameraLength = 4.5f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 1f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
        SummonNum_LevelAi1 = 2;
        SummonNum_LevelAi2 = 4;
        SummonNum_LevelAi3 = 6;
        SummonNum_LevelAi4 = 8;
        SummonCoolSec_LevelAi1 = 180f;
        SummonCoolSec_LevelAi2 = 60f;
        SummonCoolSec_LevelAi3 = 45f;
        SummonCoolSec_LevelAi4 = 30f;
        ThrowSummonNum = 3;
        WarpTargetWaitSec = 1f;
        WarpTargetBindSec = 6f;
        WarpTargetSignSec_LowLevelAi = 5f;
        WarpTargetSignSec_HighLevelAi = 2f;
        WarpTargetOffsetLength = 4f;
        SlashShotSpeed_LowLevelAi = 20f;
        SlashShotSpeed_HighLevelAi = 40f;
        OdAbilityCoolTimeSec = 60f;
        OdAbilitySummonCount_LowLevelAi = 6;
        OdAbilitySummonCount_HighLevelAi = 11;
        OdAbilitySummonWaitSec_LowLevelAi = 1f;
        OdAbilitySummonWaitSec_HighLevelAi = 0.7f;
        OdAbilityWaveSpreadSec_LowLevelAi = 2f;
        OdAbilityWaveSpreadSec_HighLevelAi = 2f;
        OdAbilityWaveWaitSec_LowLevelAi = 2f;
        OdAbilityWaveWaitSec_HighLevelAi = 2f;
        OdAbilitySummonRadius = 50f;
        OdAbilityWaveRadius = 30f;
        AttackModeSec_LevelAi1 = 30f;
        AttackModeCoolSec_LevelAi1 = 10f;
        OdAbilityWaveAttackRate = 0.1f;
        SlashShotAttackRate = 0.6f;
        OdAbilityWaveBreakRate = 1f;
        SlashShotBreakRate = 1f;
        CounterSlowRate_LowLevelAi = 0.6f;
        CounterSlowRate_HighLevelAi = 1f;
    }
}
