using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em2600;

public class Em2600Param : EnemyParameterInfo
{
    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("behindDeg_")]
    public float BehindDeg { get; set; } = 120f;

    [JsonPropertyName("attackCoolTime_")]
    public float AttackCoolTime { get; set; } = 1f;

    [JsonPropertyName("meleeCoolTime_")]
    public float MeleeCoolTime { get; set; } = 5f;

    [JsonPropertyName("poisonGasCoolTime_")]
    public float PoisonGasCoolTime { get; set; } = 5f;

    [JsonPropertyName("poisonShotCoolTime_")]
    public float PoisonShotCoolTime { get; set; } = 15f;

    [JsonPropertyName("digPopCoolTime_")]
    public float DigPopCoolTime { get; set; } = 5f;

    [JsonPropertyName("tackleBiteCoolTime_")]
    public float TackleBiteCoolTime { get; set; } = 5f;

    [JsonPropertyName("poisonGasMoveCoolTime_")]
    public float PoisonGasMoveCoolTime { get; set; } = 20f;

    [JsonPropertyName("digModeCheckLength_")]
    public float DigModeCheckLength { get; set; } = 20f;

    [JsonPropertyName("digModeCheckDeg_")]
    public float DigModeCheckDeg { get; set; } = 40f;

    [JsonPropertyName("digModeCheckHeightOffset_")]
    public Vector2 DigModeCheckHeightOffset { get; set; } = new Vector2(1f, 1f);

    [JsonPropertyName("faceCheckModeCheckLength_")]
    public float FaceCheckModeCheckLength { get; set; } = 30f;

    [JsonPropertyName("faceCheckModeCheckDeg_")]
    public float FaceCheckModeCheckDeg { get; set; } = 120f;

    [JsonPropertyName("faceCheckModeCheckHeightOffset_")]
    public Vector2 FaceCheckModeCheckHeightOffset { get; set; } = new Vector2(2f, 5f);

    [JsonPropertyName("startPartsId_")]
    public int StartPartsId { get; set; } = 16;

    [JsonPropertyName("endPartsId_")]
    public int EndPartsId { get; set; } = 38;

    [JsonPropertyName("partsGroundOffsetY_")]
    public float PartsGroundOffsetY { get; set; } = 0.4f;

    [JsonPropertyName("partsMoveInterpSec_")]
    public float PartsMoveInterpSec { get; set; } = 0.3f;

    [JsonPropertyName("parentPartsMaxDistDiff_")]
    public float ParentPartsMaxDistDiff { get; set; } = 0.25f;

    [JsonPropertyName("wallDeg_")]
    public float WallDeg { get; set; } = 25f;

    [JsonPropertyName("poisonTime_")]
    public float PoisonTime { get; set; } = 20f;

    [JsonPropertyName("isPoisonUnimplemented_")]
    public bool IsPoisonUnimplemented { get; set; } = false;

    [JsonPropertyName("poisonGasAreaCheckDist_")]
    public float PoisonGasAreaCheckDist { get; set; } = 20f;

    [JsonPropertyName("poisonGasAreaNearDist_")]
    public float PoisonGasAreaNearDist { get; set; } = 10f;

    [JsonPropertyName("poisonShotPatternNum_")]
    public int PoisonShotPatternNum { get; set; } = 3;

    [JsonPropertyName("foundActionNoParam_")]
    public Em2600Param FoundActionNoParam { get; set; }

    [JsonPropertyName("damageBehindActionNoParam_")]
    public ExEmVoiceActionNo_Param DamageBehindActionNoParam { get; set; }

    [JsonPropertyName("groundMoveAnimBlendAddRate_")]
    public float GroundMoveAnimBlendAddRate { get; set; } = 0.1f;

    [JsonPropertyName("navMeshHomingAngle_")]
    public float NavMeshHomingAngle { get; set; } = 10f;

    [JsonPropertyName("moveCollisionParam_")]
    public CharaCollisionParam MoveCollisionParam { get; set; }

    [JsonPropertyName("addDamageParam_")]
    public EmAddDamageParam AddDamageParam { get; set; }

    public Em2600Param()
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
        CombatPower = 60;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 1;
        LinkAttackCameraDistRate = 0.5f;
        AnimInterDefaultSec = 0.5f;
        DamageAnimInterDefaultSec = 0.5f;
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
        StageInvisibleStartDistance = 100f;
        StageInvisibleEndDistance = 125f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = true;
    }
}