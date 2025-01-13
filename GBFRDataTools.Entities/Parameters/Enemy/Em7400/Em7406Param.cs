using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7400;

public class Em7406Param : Em7400CoreParam
{
    [JsonPropertyName("riseHeight_")]
    public float RiseHeight { get; set; } = 3.5f;

    [JsonPropertyName("riseSpeed_")]
    public float RiseSpeed { get; set; } = 10f;

    [JsonPropertyName("fallSpeed_")]
    public float FallSpeed { get; set; } = 6f;

    [JsonPropertyName("topShakeParam_")]
    public Em7400ShakeParam TopShakeParam { get; set; }

    [JsonPropertyName("bottomShakeParam_")]
    public Em7400ShakeParam BottomShakeParam { get; set; }

    [JsonPropertyName("reflectionSignSec_")]
    public float ReflectionSignSec { get; set; } = 2f;

    [JsonPropertyName("plugMaxHpRate_")]
    public float PlugMaxHpRate { get; set; } = 1f;

    [JsonPropertyName("boltMaxHpRate_")]
    public float BoltMaxHpRate { get; set; } = 0.6f;

    [JsonPropertyName("cylinderMaxHpRate_")]
    public float CylinderMaxHpRate { get; set; } = 1.35f;

    public Em7406Param()
    {
        Hp = 300;
        Atk = 100;
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
        EnemySize = 1;
        LinkAttackCameraDistRate = 0.75f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 2.6f;
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
