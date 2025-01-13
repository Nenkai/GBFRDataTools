using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7400;

public class Em7401Param : Em7400CoreParam
{
    [JsonPropertyName("spArtsBasePosList_")]
    public BindingList<Vector4> SpArtsBasePosList { get; set; } = [];

    [JsonPropertyName("counterDamageValue_")]
    public int[] CounterDamageValue { get; set; } = new int[5];

    [JsonPropertyName("floorAttackRate_")]
    public float FloorAttackRate { get; set; } = 0.1f;

    [JsonPropertyName("floorBreakRate_")]
    public float FloorBreakRate { get; set; } = 0.1f;

    [JsonPropertyName("floorSignSec_")]
    public float FloorSignSec { get; set; } = 2f;

    [JsonPropertyName("floorSignFloorSec_")]
    public float FloorSignFloorSec { get; set; } = 0.5f;

    [JsonPropertyName("floorAttackSec_")]
    public float FloorAttackSec { get; set; } = 8f;

    [JsonPropertyName("floorWaitEndSec_")]
    public float FloorWaitEndSec { get; set; } = 0.8f;

    [JsonPropertyName("electricBurstNum_")]
    public int ElectricBurstNum { get; set; } = 3;

    [JsonPropertyName("electricBurstIntervalSec_")]
    public float ElectricBurstIntervalSec { get; set; } = 0.5f;

    [JsonPropertyName("electricBurstCoolSec_")]
    public float ElectricBurstCoolSec { get; set; } = 20f;

    [JsonPropertyName("electricDischargeAttackRate_")]
    public float ElectricDischargeAttackRate { get; set; } = 0.3f;

    [JsonPropertyName("electricDischargeSignSec_")]
    public float ElectricDischargeSignSec { get; set; } = 1.2f;

    [JsonPropertyName("electricDischargeSignSec_LowLevelAi_")]
    public float ElectricDischargeSignSec_LowLevelAi { get; set; } = 2f;

    [JsonPropertyName("electricDischargeAttackSec_")]
    public float ElectricDischargeAttackSec { get; set; } = 0.8f;

    [JsonPropertyName("electricDischargeWaitEndSec_")]
    public float ElectricDischargeWaitEndSec { get; set; } = 0.8f;

    [JsonPropertyName("electricDischargeCoolSec_")]
    public float ElectricDischargeCoolSec { get; set; } = 10f;

    [JsonPropertyName("electricDischargeEnableCoolTimerSec_")]
    public float ElectricDischargeEnableCoolTimerSec { get; set; } = 5f;

    [JsonPropertyName("throwingDamageAttackRate_")]
    public float ThrowingDamageAttackRate { get; set; } = 1f;

    [JsonPropertyName("throwingBreakAttackRate_")]
    public float ThrowingBreakAttackRate { get; set; } = 1f;

    [JsonPropertyName("distanceShowGauge_")]
    public float DistanceShowGauge { get; set; } = 10f;

    public Em7401Param()
    {
        Hp = 2000;
        Atk = 45;
        Break = 10;
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
        CombatPower = 100;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0.5f;
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