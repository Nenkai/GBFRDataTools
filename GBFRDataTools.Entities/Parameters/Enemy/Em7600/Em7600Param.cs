using System.ComponentModel;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Parameters.Enemy.Em7000;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7600;

public class Em7600Param : EmBossBaseParam
{
    [JsonPropertyName("bgmPhase1Time_")]
    public float BgmPhase1Time { get; set; } = 258f;

    [JsonPropertyName("bgmPhase2Time_")]
    public float BgmPhase2Time { get; set; } = 462f;

    [JsonPropertyName("bgmPhase3Time_")]
    public float BgmPhase3Time { get; set; } = 536f;

    [JsonPropertyName("bgmPhase4Time_")]
    public float BgmPhase4Time { get; set; } = 646f;

    [JsonPropertyName("bgmPhase1SPStartTime_")]
    public float BgmPhase1SPStartTime { get; set; } = 170f;

    [JsonPropertyName("bgmPhase1SPCheckTime_")]
    public float BgmPhase1SPCheckTime { get; set; } = 215f;

    [JsonPropertyName("bgmPhase1SPNp0000DashTime_")]
    public float BgmPhase1SPNp0000DashTime { get; set; } = 223f;

    [JsonPropertyName("bgmPhase1SPChargeEndTime_")]
    public float BgmPhase1SPChargeEndTime { get; set; } = 230f;

    [JsonPropertyName("bgmPhase1SPEm7000SummonTime_")]
    public float BgmPhase1SPEm7000SummonTime { get; set; } = 237f;

    [JsonPropertyName("bgmPhase1SPEm2300SummonTime_")]
    public float BgmPhase1SPEm2300SummonTime { get; set; } = 248f;

    [JsonPropertyName("bgmPhase1SPDamageEndTime_")]
    public float BgmPhase1SPDamageEndTime { get; set; } = 208f;

    [JsonPropertyName("bgmPhase2SPStartTime_")]
    public float BgmPhase2SPStartTime { get; set; } = 410f;

    [JsonPropertyName("bgmPhase2SPCheckTime_")]
    public float BgmPhase2SPCheckTime { get; set; } = 431f;

    [JsonPropertyName("bgmPhase2SPEm2300DisableSpArtsTime_")]
    public float BgmPhase2SPEm2300DisableSpArtsTime { get; set; } = 355f;

    [JsonPropertyName("bgmPhase2SPEm2300JumpTime_")]
    public float BgmPhase2SPEm2300JumpTime { get; set; } = 383f;

    [JsonPropertyName("bgmPhase2SPEm2300ChargeStart_")]
    public float BgmPhase2SPEm2300ChargeStart { get; set; } = 400f;

    [JsonPropertyName("bgmPhase2SPEm2300ChargeEnd_")]
    public float BgmPhase2SPEm2300ChargeEnd { get; set; } = 428f;

    [JsonPropertyName("bgmPhase2Em7600AttackStart_")]
    public float BgmPhase2Em7600AttackStart { get; set; } = 383.22f;

    [JsonPropertyName("bgmPhase2Em7600SpecialEnd_")]
    public float BgmPhase2Em7600SpecialEnd { get; set; } = 455f;

    [JsonPropertyName("bgmPhase2Em7000DisappearStart_")]
    public float BgmPhase2Em7000DisappearStart { get; set; } = 425f;

    [JsonPropertyName("bgmPhase3Em2200Down_")]
    public float BgmPhase3Em2200Down { get; set; } = 501f;

    [JsonPropertyName("bgmPhase3Pl190aChange_")]
    public float BgmPhase3Pl190aChange { get; set; } = 515f;

    [JsonPropertyName("bgmPhase4SPStartTime_")]
    public float BgmPhase4SPStartTime { get; set; } = 550f;

    [JsonPropertyName("bgmPhase4SPCheckTime_")]
    public float BgmPhase4SPCheckTime { get; set; } = 628.5f;

    [JsonPropertyName("bgmPhase1SPLimitTime1_")]
    public float BgmPhase1SPLimitTime1 { get; set; } = 160f;

    [JsonPropertyName("bgmPhase1SPLimitTime2_")]
    public float BgmPhase1SPLimitTime2 { get; set; } = 160f;

    [JsonPropertyName("hpRatePhase1Under_")]
    public float HpRatePhase1Under { get; set; } = 50f;

    [JsonPropertyName("hpRateSp1_")]
    public float HpRateSp1 { get; set; } = 80f;

    [JsonPropertyName("hpRateSp1Break_")]
    public float HpRateSp1Break { get; set; } = 5f;

    [JsonPropertyName("hpRateSp1BreakMulti_")]
    public float HpRateSp1BreakMulti { get; set; } = 7f;

    [JsonPropertyName("hpRateEm7000_")]
    public float HpRateEm7000 { get; set; } = 25f;

    [JsonPropertyName("hpRatePhase4_")]
    public float HpRatePhase4 { get; set; } = 20f;

    [JsonPropertyName("bgmPhase1OverAttackTime_")]
    public float BgmPhase1OverAttackTime { get; set; } = 80f;

    [JsonPropertyName("bgmPhase1DashAttackTime_")]
    public float BgmPhase1DashAttackTime { get; set; } = 130f;

    [JsonPropertyName("energyBallParams_")]
    public Em7000EnergyBallParam[] EnergyBallParams { get; set; } = new Em7000EnergyBallParam[5]; // std::array<Em7000EnergyBallParam,5>

    [JsonPropertyName("waveAttackRate_")]
    public float WaveAttackRate { get; set; } = 0.8f;

    [JsonPropertyName("partsLaserAttackRate_")]
    public float PartsLaserAttackRate { get; set; } = 2f;

    [JsonPropertyName("overAttackRate_")]
    public float OverAttackRate { get; set; } = 2.5f;

    [JsonPropertyName("sp2ShotAttackRate_")]
    public float Sp2ShotAttackRate { get; set; } = 1.5f;

    [JsonPropertyName("cameraCloseLength_")]
    public float CameraCloseLength { get; set; } = 10f;

    [JsonPropertyName("cameraMidLength_")]
    public float CameraMidLength { get; set; } = 20f;

    [JsonPropertyName("cameraHandCloseLength_")]
    public float CameraHandCloseLength { get; set; } = 10f;

    public Em7600Param()
    {
        Hp = 250000;
        Atk = 1000;
        Break = 10;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 25;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 25;
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
        CombatPower = 100;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 1f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 0.6f;
        BasicHitStopTimeRate = 0f;
        DamageReactionHitStopTimeRate = 0f;
        SuperArmorHitStopTimeRate = 0f;
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
        CameraLength = 0f;
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