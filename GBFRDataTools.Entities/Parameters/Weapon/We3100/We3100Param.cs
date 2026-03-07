using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.We3100;

public class We3100Param : EnemyParameterInfo
{
    [JsonPropertyName("baseBodyRadius_")]
    public float BaseBodyRadius { get; set; } = 0.75f;

    [JsonPropertyName("launchRiseSec_")]
    public float LaunchRiseSec { get; set; } = 0.25f;

    [JsonPropertyName("launchRiseHeight_")]
    public float LaunchRiseHeight { get; set; } = 20f;

    [JsonPropertyName("launchRiseRate_")]
    public Vector2 LaunchRiseRate { get; set; } = new Vector2(0.8f, 0.95f);

    [JsonPropertyName("normalLaserSpeed_")]
    public float NormalLaserSpeed { get; set; } = 300f;

    [JsonPropertyName("normalLaserRadius_")]
    public float NormalLaserRadius { get; set; } = 0.1f;

    [JsonPropertyName("normalLaserTrailLength_")]
    public float NormalLaserTrailLength { get; set; } = 1f;

    [JsonPropertyName("normalLaserTrailCycleSec_")]
    public float NormalLaserTrailCycleSec { get; set; } = 1f;

    [JsonPropertyName("fallDownAttackParam_")]
    public We3100Param FallDownAttackParam { get; set; }

    [JsonPropertyName("homingMissileParam_")]
    public We3100Param HomingMissileParam { get; set; }

    [JsonPropertyName("tailStabRangeParam_")]
    public We3100Param TailStabRangeParam { get; set; }

    [JsonPropertyName("bladeRushAttackParam_")]
    public We3100Param BladeRushAttackParam { get; set; }

    [JsonPropertyName("reflectLaserLinkDistance_")]
    public float ReflectLaserLinkDistance { get; set; } = 30f;

    [JsonPropertyName("reflectLaserLinkOffset_")]
    public Vector3 ReflectLaserLinkOffset { get; set; } = new Vector3(40f, 0.1f, 8.5f);

    [JsonPropertyName("diffusionLaserParam_")]
    public We3100Param DiffusionLaserParam { get; set; }

    [JsonPropertyName("diffusionLaserEndFrame_")]
    public int DiffusionLaserEndFrame { get; set; } = 60;

    [JsonPropertyName("swirlTailBeamParam_")]
    public We3100Param SwirlTailBeamParam { get; set; }

    [JsonPropertyName("aimLaserParam_")]
    public We3100Param AimLaserParam { get; set; }

    [JsonPropertyName("grenadeShotParam_")]
    public We3100Param GrenadeShotParam { get; set; }

    [JsonPropertyName("rapidRayParam_")]
    public We3100Param RapidRayParam { get; set; }

    [JsonPropertyName("automaticParam_")]
    public We3100Param AutomaticParam { get; set; }

    [JsonPropertyName("odAbilityParams_")]
    public We3100Param OdAbilityParams { get; set; }

    [JsonPropertyName("spArtsParam_")]
    public We3100Param SpArtsParam { get; set; }

    public We3100Param()
    {
        Hp = 75000;
        Atk = 100;
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
        CombatPower = 50;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
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