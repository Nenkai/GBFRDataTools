using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em2900;

public class Em2900Param : EnemyParameterInfo
{
    [JsonPropertyName("lightAttackWaitTime_")]
    public float LightAttackWaitTime { get; set; } = 0.2f;

    [JsonPropertyName("lightAttackTime_")]
    public float LightAttackTime { get; set; } = 0.5f;

    [JsonPropertyName("lightPillerDamage_")]
    public float LightPillerDamage { get; set; } = 1f;

    [JsonPropertyName("lightPillerRadius_")]
    public float LightPillerRadius { get; set; } = 18f;

    [JsonPropertyName("lightPillerHeight_")]
    public float LightPillerHeight { get; set; } = 80f;

    [JsonPropertyName("safetyAreaRadius_")]
    public float SafetyAreaRadius { get; set; } = 18f;

    [JsonPropertyName("poisonAtk_")]
    public float PoisonAtk { get; set; } = 50f;

    [JsonPropertyName("poisonRadius_")]
    public float PoisonRadius { get; set; } = 7f;

    [JsonPropertyName("poisonAtkTime_")]
    public float PoisonAtkTime { get; set; } = 0.5f;

    [JsonPropertyName("selfDestructAttackTime_")]
    public float SelfDestructAttackTime { get; set; } = 0.5f;

    [JsonPropertyName("selfDestructRadius_")]
    public float SelfDestructRadius { get; set; } = 9f;

    [JsonPropertyName("selfDestructHeight_")]
    public float SelfDestructHeight { get; set; } = 20f;

    [JsonPropertyName("selfDestructStartTime_")]
    public float SelfDestructStartTime { get; set; } = 10f;

    [JsonPropertyName("selfDestructTime_")]
    public float SelfDestructTime { get; set; } = 5f;

    [JsonPropertyName("selfDestructAttackPowerRate_")]
    public float SelfDestructAttackPowerRate { get; set; } = 1.5f;

    [JsonPropertyName("selfDestructBreakPowerRate_")]
    public float SelfDestructBreakPowerRate { get; set; } = 1.5f;

    [JsonPropertyName("magicCircleWaitTime_")]
    public float MagicCircleWaitTime { get; set; } = 0.5f;

    [JsonPropertyName("appearanceWaitTime_")]
    public float AppearanceWaitTime { get; set; } = 1f;

    [JsonPropertyName("appearanceSignRadius_")]
    public float AppearanceSignRadius { get; set; } = 1.5f;

    [JsonPropertyName("appearanceAttackPowerRate_")]
    public float AppearanceAttackPowerRate { get; set; } = 1f;

    [JsonPropertyName("appearanceBreakPowerRate_")]
    public float AppearanceBreakPowerRate { get; set; } = 1f;

    public Em2900Param()
    {
        Hp = 1011;
        Atk = 10;
        Break = 3;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 0;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
        HateRateBackAngle = 0;
        HateRateDamage = 0;
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
        CombatPower = 0;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 2.5f;
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