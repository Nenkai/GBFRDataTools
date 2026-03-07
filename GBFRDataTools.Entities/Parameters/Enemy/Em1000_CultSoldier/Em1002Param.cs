using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1000_CultSoldier;

public class Em1002Param : EmCultSoldierBaseParam
{
    [JsonPropertyName("guideWidth_")]
    public float GuideWidth { get; set; } = 0.2f;

    [JsonPropertyName("normalArrowGuideColor_")]
    public Vector4 NormalArrowGuideColor { get; set; } = new Vector4(255f, 0f, 0f, 30f);

    [JsonPropertyName("changeGuideDraw_")]
    public bool ChangeGuideDraw { get; set; } = true;

    [JsonPropertyName("arrowRainJoinDist_")]
    public float ArrowRainJoinDist { get; set; } = 14f;

    [JsonPropertyName("arrowRainAttackDelayTime_")]
    public float ArrowRainAttackDelayTime { get; set; } = 1.5f;

    [JsonPropertyName("arrowRainRadius_")]
    public float ArrowRainRadius { get; set; } = 4f;

    [JsonPropertyName("arrowRainAttackResetCount_")]
    public int ArrowRainAttackResetCount { get; set; } = 3;

    [JsonPropertyName("arrowRainAttackResetTime_")]
    public float ArrowRainAttackResetTime { get; set; } = 0.5f;

    [JsonPropertyName("arrowRainGuideTime_")]
    public float ArrowRainGuideTime { get; set; } = 1.5f;

    [JsonPropertyName("arrowRainPointRamdomRadius_")]
    public float ArrowRainPointRamdomRadius { get; set; } = 4.5f;

    [JsonPropertyName("arrowRainStartMinSoldiers_")]
    public int ArrowRainStartMinSoldiers { get; set; } = 3;

    [JsonPropertyName("arrowRainStartMaxSoldiers_")]
    public int ArrowRainStartMaxSoldiers { get; set; } = 10;

    [JsonPropertyName("normalArrowRangeY_")]
    public float NormalArrowRangeY { get; set; } = 6f;

    [JsonPropertyName("normalArrowCheckTime_")]
    public float NormalArrowCheckTime { get; set; } = 2f;

    [JsonPropertyName("normalArrowCheckLineHeight_")]
    public float NormalArrowCheckLineHeight { get; set; } = 1.5f;

    [JsonPropertyName("hitCheckLength_")]
    public float HitCheckLength { get; set; } = 5f;

    [JsonPropertyName("arrowRainSignRadius_")]
    public float ArrowRainSignRadius { get; set; } = 5f;

    public Em1002Param()
    {
        Hp = 2800;
        Atk = 30;
        Break = 3;
        Def = 0f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 15;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 35;
        HateRateBackAngle = 0;
        HateRateDamage = 25;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 25;
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
        CombatPower = 35;
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
        IsDisableAerialDownReaction = true;
        CounterAttackProbability = 30;
        MaxFormationSoldiers = 6;
        MaxFormationDeg = 90f;
        MinFormationDeg = 20f;
        InsideCameraDeg = 80f;
        InsideCameraOffsetY = 1f;
        InsideCameraRadius = 0.2f;
        InsideCameraCoolTime = 0.5f;
        DrainRate = 0.05f;
    }
}