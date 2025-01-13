using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7500;

public class Em7530Param : EnemyParameterInfo
{
    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("armTransArray_")]
    public MegaHandTrans[] ArmTransArray { get; set; } = new MegaHandTrans[5];

    [JsonPropertyName("armTransArrayList_")]
    public MegaHandTrans[][] ArmTransArrayList { get; set; } = new MegaHandTrans[2][/*5*/];

    [JsonPropertyName("armOverDriveHormingInitPosArray_")]
    public Vector4[] ArmOverDriveHormingInitPosArray { get; set; } = new Vector4[2];

    [JsonPropertyName("armOverDriveChargeInitPosArray_")]
    public Vector4[] ArmOverDriveChargeInitPosArray { get; set; } = new Vector4[2];

    [JsonPropertyName("armInitPosArray_")]
    public Vector4[] ArmInitPosArray { get; set; } = new Vector4[2];

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } = 0.3f;

    [JsonPropertyName("updatePosTime_")]
    public float UpdatePosTime { get; set; } = 2f;

    [JsonPropertyName("rundomTimeMax_")]
    public float RundomTimeMax { get; set; } = 1f;

    [JsonPropertyName("waitMoveSpeed_")]
    public float WaitMoveSpeed { get; set; } = 4f;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.02f;

    [JsonPropertyName("moveJointIndex_")]
    public int MoveJointIndex { get; set; } = 1;

    [JsonPropertyName("moveRadius_")]
    public float MoveRadius { get; set; } = 5f;

    [JsonPropertyName("offsetSize_")]
    public float OffsetSize { get; set; } = 2.5f;

    public Em7530Param()
    {
        Hp = 10000;
        Atk = 30;
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
        CombatPower = 60;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 1;
        LinkAttackCameraDistRate = 0.5f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 865;
        UiOffsetY = 3f;
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

public class MegaHandTrans
{
    [JsonPropertyName("pos_")]
    public Vector4 Pos { get; set; } // Offset 0x10

    [JsonPropertyName("rot_")]
    public Vector4 Rot { get; set; } // Offset 0x20

    public MegaHandTrans()
    {
    }
}