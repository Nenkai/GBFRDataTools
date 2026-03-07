using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0000;

public class Em0005Param : EmBossBaseParam
{
    [JsonPropertyName("checkWallLength_")]
    public float CheckWallLength { get; set; } = 3f;

    [JsonPropertyName("shieldMaxHp_")]
    public float ShieldMaxHp { get; set; } = 3500f;

    [JsonPropertyName("shieldTerminateTime_")]
    public float ShieldTerminateTime { get; set; } = 60f;

    [JsonPropertyName("guardRate_")]
    public float GuardRate { get; set; } = 0.05f;

    [JsonPropertyName("guardRateLongRange_")]
    public float GuardRateLongRange { get; set; } = 0f;

    [JsonPropertyName("guardEndurance_")]
    public float GuardEndurance { get; set; } = 50000f;

    [JsonPropertyName("guardKnockBackRate_")]
    public float GuardKnockBackRate { get; set; } = 0.2f;

    [JsonPropertyName("summonGoblinKnockBack_")]
    public float SummonGoblinKnockBack { get; set; } = 12f;

    [JsonPropertyName("shieldModeCoolTimeAILevel1_")]
    public float ShieldModeCoolTimeAILevel1 { get; set; } = 4.5f;

    [JsonPropertyName("shieldModeCoolTimeAILevel2_")]
    public float ShieldModeCoolTimeAILevel2 { get; set; } = 4.5f;

    [JsonPropertyName("shieldModeCoolTimeAILevel3_")]
    public float ShieldModeCoolTimeAILevel3 { get; set; } = 1.5f;

    [JsonPropertyName("shieldModeCoolTimeAILevel4_")]
    public float ShieldModeCoolTimeAILevel4 { get; set; } = 1.5f;

    [JsonPropertyName("shieldStompCoolTime_")]
    public float ShieldStompCoolTime { get; set; } = 15f;

    [JsonPropertyName("jumpStompCoolTime_")]
    public float JumpStompCoolTime { get; set; } = 20f;

    [JsonPropertyName("shieldTackleCoolTime_")]
    public float ShieldTackleCoolTime { get; set; } = 31.5f;

    [JsonPropertyName("shieldTackleComboCoolTime_")]
    public float ShieldTackleComboCoolTime { get; set; } = 12f;

    [JsonPropertyName("slashAttackCoolTime_")]
    public float SlashAttackCoolTime { get; set; } = 0f;

    [JsonPropertyName("shieldBashCoolTime_")]
    public float ShieldBashCoolTime { get; set; } = 6.5f;

    [JsonPropertyName("shieldBreakModeCoolTimeAILevel1_")]
    public float ShieldBreakModeCoolTimeAILevel1 { get; set; } = 4.5f;

    [JsonPropertyName("shieldBreakModeCoolTimeAILevel2_")]
    public float ShieldBreakModeCoolTimeAILevel2 { get; set; } = 4.5f;

    [JsonPropertyName("shieldBreakModeCoolTimeAILevel3_")]
    public float ShieldBreakModeCoolTimeAILevel3 { get; set; } = 1.5f;

    [JsonPropertyName("shieldBreakModeCoolTimeAILevel4_")]
    public float ShieldBreakModeCoolTimeAILevel4 { get; set; } = 1.5f;

    [JsonPropertyName("jumpSlashCoolTime_")]
    public float JumpSlashCoolTime { get; set; } = 5f;

    [JsonPropertyName("spinSlashCoolTime_")]
    public float SpinSlashCoolTime { get; set; } = 8f;

    [JsonPropertyName("backStepCoolTime_")]
    public float BackStepCoolTime { get; set; } = 8f;

    [JsonPropertyName("turnSlashCoolTime_")]
    public float TurnSlashCoolTime { get; set; } = 30f;

    [JsonPropertyName("overDriveModeTime_")]
    public float OverDriveModeTime { get; set; } = 10f;

    [JsonPropertyName("guardCoolTime_")]
    public float GuardCoolTime { get; set; } = 25f;

    [JsonPropertyName("overDriveAttackMax_")]
    public int OverDriveAttackMax { get; set; } = 2;

    [JsonPropertyName("damageReactionBreakValue_")]
    public float DamageReactionBreakValue { get; set; } = 100f;

    [JsonPropertyName("hpTriggerGuardAction01_")]
    public int HpTriggerGuardAction01 { get; set; } = 95;

    [Obsolete("Not used by the game")]
    [JsonPropertyName("hpTriggerGuardAction02_")]
    public int HpTriggerGuardAction02 { get; set; }

    [JsonPropertyName("hpTriggerGuardActionMin_")]
    public int HpTriggerGuardActionMin { get; set; } = 25;

    [JsonPropertyName("stabChoppingShootOffset1_")]
    public Vector3 StabChoppingShootOffset1 { get; set; } = new Vector3(0f, 0f, 0.1f);

    [JsonPropertyName("stabChoppingShootOffset23_")]
    public Vector3 StabChoppingShootOffset23 { get; set; } = new Vector3(1.5f, 0f, 0f);

    [JsonPropertyName("stabChoppingShootRot_")]
    public Vector3 StabChoppingShootRot { get; set; } = new Vector3(0f, 12f, -12f);

    [JsonPropertyName("overDriveAnimRateAILevel1_")]
    public float OverDriveAnimRateAILevel1 { get; set; } = 1f;

    [JsonPropertyName("overDriveAnimRateAILevel2_")]
    public float OverDriveAnimRateAILevel2 { get; set; } = 1f;

    [JsonPropertyName("overDriveAnimRateAILevel3_")]
    public float OverDriveAnimRateAILevel3 { get; set; } = 1.05f;

    [JsonPropertyName("overDriveAnimRateAILevel4_")]
    public float OverDriveAnimRateAILevel4 { get; set; } = 1.075f;

    [JsonPropertyName("overDriveAttackBuffRate_")]
    public float OverDriveAttackBuffRate { get; set; } = 0.2f;

    [JsonPropertyName("rollSlashSpecialDownStunValueAILevel1_")]
    public float RollSlashSpecialDownStunValueAILevel1 { get; set; } = 50f;

    [JsonPropertyName("rollSlashSpecialDownStunValueAILevel2_")]
    public float RollSlashSpecialDownStunValueAILevel2 { get; set; } = 50f;

    [JsonPropertyName("rollSlashSpecialDownStunValueAILevel3_")]
    public float RollSlashSpecialDownStunValueAILevel3 { get; set; } = 120f;

    [JsonPropertyName("rollSlashSpecialDownStunValueAILevel4_")]
    public float RollSlashSpecialDownStunValueAILevel4 { get; set; } = 180f;

    [JsonPropertyName("backAttackSpecialDownStunValue_")]
    public float BackAttackSpecialDownStunValue { get; set; } = 100f;

    [JsonPropertyName("enableBackAttackSpecialDownRot_")]
    public float EnableBackAttackSpecialDownRot { get; set; } = 240f;

    public Em0005Param()
    {
        Hp = 200000;
        Atk = 1000;
        Break = 8;
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
        CombatPower = 65;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 0.5f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 1.4f;
        BasicHitStopTimeRate = 0f;
        DamageReactionHitStopTimeRate = 0f;
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
        CameraLength = 1.5f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
    }
}
