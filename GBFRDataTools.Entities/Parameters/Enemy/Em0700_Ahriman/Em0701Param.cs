using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0700_Ahriman;

public class Em0701Param : EmAhrimanSmallBaseParam
{
    [JsonPropertyName("tailAttackCoolTime_")]
    public float TailAttackCoolTime { get; set; } = 6f;

    [JsonPropertyName("laserCoolTime_")]
    public float LaserCoolTime { get; set; } = 15f;

    [JsonPropertyName("tauntAttackCoolTime_")]
    public float TauntAttackCoolTime { get; set; } = 6f;

    [JsonPropertyName("diamondDustCoolTime_")]
    public float DiamondDustCoolTime { get; set; } = 6f;

    [JsonPropertyName("tailRockShotCoolTime_")]
    public float TailRockShotCoolTime { get; set; } = 10f;

    public Em0701Param()
    {
        Hp = 10000;
        Atk = 100;
        Break = 5;
        Def = 1f;
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
        CombatPower = 55;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 1;
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
        BaseHeight = 0.5f;
        PopulationHeightAdd = 0.5f;
        LowHeight = 0f;
        TargetHeightMaxDiff = 3f;
        AttackCoolTime = 3f;
        StepCoolTime = 6f;
        AroundTheBackCoolTime = 4f;
        FrontChargeCoolTime = 10f;
        CheckWallLength = 4f;
        FrontArea = 60f;
        FrontAreaShortRangeOffset = -4f;
        HitEyePosOffset = new Vector4(0f, 0f, -0.3f, 1f);
        HitEyeAreaDeg = 80f;
        FrontChargeTime = 3f;
        FrontChargeShotDelayTime = 0f;
        TargetShotArea_Short = new Vector2(4f, 1f);
        TargetShotArea_Middle = new Vector2(8f, 0.8f);
        TargetShotArea_Long = new Vector2(13f, 0.6f);
        FrontChargeStartPosOffset = new Vector4(0f, 0f, 0.5f, 1f);
        DebugFullChargeSize = 0.6f;
        DebugFrontShotSizeRatio = 1f;
        LaserNum = 4;
        OmenControlHeight = 11f;
        RockShotOffset = new Vector4(0f, 0f, -1f, 1f);
        RockShotGroundVfxEstId = 2210;
        HeavyDamageReactionScale = 3f;
        ScaleParam = 1f;
        StageHitColScale = 1f;
        StageHitColOffset = new Vector4(0f, 0f, 0f, 1f);
        GroundCheckEndHeight = -15f;
        IsDeadSmallEffect = true;
    }
}