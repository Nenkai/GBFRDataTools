using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7500;

public class Em7520Param : EnemyParameterInfo
{
    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("createHandMoveParamArray_")]
    public HandMoveParam[] CreateHandMoveParamArray { get; set; } = new HandMoveParam[5];

    [JsonPropertyName("handMoveParamBodyOffset_")]
    public Vector4 HandMoveParamBodyOffset { get; set; } = new Vector4(0f, -5f, -40f, 1f);

    [JsonPropertyName("handMoveParamBodyRadius_")]
    public float HandMoveParamBodyRadius { get; set; } = 100f;

    [JsonPropertyName("handMoveHitBodyOffset_")]
    public Vector4 HandMoveHitBodyOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f);

    [JsonPropertyName("handMoveHitBodyRadius_")]
    public float HandMoveHitBodyRadius { get; set; } = 50f;

    [JsonPropertyName("armOverDriveHormingInitPosArray_")]
    public Vector4[] ArmOverDriveHormingInitPosArray { get; set; } = new Vector4[8];

    [JsonPropertyName("armOverDriveChargeInitPosArray_")]
    public Vector4[] ArmOverDriveChargeInitPosArray { get; set; } = new Vector4[8];

    [JsonPropertyName("armInitPosArray_")]
    public Vector4[] ArmInitPosArray { get; set; } = new Vector4[8];

    [JsonPropertyName("armClosePosArray_")]
    public Vector4[] ArmClosePosArray { get; set; } = new Vector4[8];

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } = 1f;

    [JsonPropertyName("updatePosTime_")]
    public float UpdatePosTime { get; set; } = 2f;

    [JsonPropertyName("rundomTimeMax_")]
    public float RundomTimeMax { get; set; } = 0.5f;

    [JsonPropertyName("waitMoveSpeed_")]
    public float WaitMoveSpeed { get; set; } = 1.7f;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.02f;

    [JsonPropertyName("moveRadius_")]
    public float MoveRadius { get; set; } = 5f;

    [JsonPropertyName("offsetSize_")]
    public float OffsetSize { get; set; } = 5f;

    [JsonPropertyName("tripleLaserFrontLength_")]
    public float TripleLaserFrontLength { get; set; } = 25f;

    [JsonPropertyName("closeInterTime_")]
    public float CloseInterTime { get; set; } = 1f;

    [JsonPropertyName("closeLength_")]
    public float CloseLength { get; set; } = 25f;

    public Em7520Param()
    {
        Hp = 10000;
        Atk = 30;
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
        CombatPower = 40;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 1;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 1089;
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

public class HandMoveParam
{
    [JsonPropertyName("bezierRate_")]
    public float BezierRate { get; set; } // Offset 0x8

    [JsonPropertyName("rate_")]
    public float Rate { get; set; } // Offset 0xC

    [JsonPropertyName("randAddPos_")]
    public float RandAddPos { get; set; } // Offset 0x10

    [JsonPropertyName("hermiteTan0_")]
    public float HermiteTan0 { get; set; } // Offset 0x14

    [JsonPropertyName("hermiteTan1_")]
    public float HermiteTan1 { get; set; } // Offset 0x18

    public HandMoveParam()
    {
    }
}