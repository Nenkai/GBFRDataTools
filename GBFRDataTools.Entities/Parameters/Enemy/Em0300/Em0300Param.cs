using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0300;

public class Em0300Param : EnemyParameterInfo
{
    [JsonPropertyName("modelScale_")]
    public float ModelScale { get; set; } = 0.8f;

    [JsonPropertyName("targetLineTime_")]
    public float TargetLineTime { get; set; } = 0.2f;

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; }

    [JsonPropertyName("baseHeight_")]
    public float BaseHeight { get; set; } = 1.2f;

    [JsonPropertyName("populationHeightAdd_")]
    public float PopulationHeightAdd { get; set; } = 1f;

    [JsonPropertyName("flyBlendMotionMaxDegree_")]
    public float FlyBlendMotionMaxDegree { get; set; } = 0.8f;

    [JsonPropertyName("flyBlendMotionAddRate_")]
    public float FlyBlendMotionAddRate { get; set; } = 0.02f;

    [JsonPropertyName("featherShootInitRot_")]
    public Vector3 FeatherShootInitRot { get; set; } = new Vector3(-20f, 0f, 20f);

    [JsonPropertyName("featherShootHeightOffset_")]
    public float FeatherShootHeightOffset { get; set; } = 1f;

    [JsonPropertyName("featherShootHomingMinLength_")]
    public float FeatherShootHomingMinLength { get; set; } = 5f;

    [JsonPropertyName("featherShootNonHomingLength_")]
    public float FeatherShootNonHomingLength { get; set; } = 3f;

    [JsonPropertyName("hornAttackCoolTime_")]
    public float HornAttackCoolTime { get; set; } = 20f;

    [JsonPropertyName("boundFallSpeed_")]
    public float BoundFallSpeed { get; set; } = 0.03f;

    [JsonPropertyName("linkAttackJumpSpeed_")]
    public float LinkAttackJumpSpeed { get; set; } = 0f;

    [JsonPropertyName("linkAttackGravityRate_")]
    public float LinkAttackGravityRate { get; set; } = 0.5f;

    [JsonPropertyName("downTime_")]
    public float DownTime { get; set; } = 4f;

    public Em0300Param()
    {
        Hp = 2500;
        Atk = 50;
        Break = 3;
        Def = 0f;
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
        CombatPower = 30;
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
        StageInvisibleStartDistance = 100f;
        StageInvisibleEndDistance = 125f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = false;
    }
}
