using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7000;

public class Em7000Param : EmBossBaseParam
{
    [JsonPropertyName("rideSingleAttackMotionNameArray_")]
    public /* RideSingleAttackMotionNameArray */ SideMotionName[] RideSingleAttackMotionNameArray { get; set; } = new SideMotionName[5]; // std::array<Em7000Param::SideMotionName,5>

    [JsonPropertyName("rideChangeMotionName_")]
    public SideMotionName RideChangeMotionName { get; set; }

    [JsonPropertyName("strikeAttackMotionNameArray_")]
    public SideMotionName[] StrikeAttackMotionNameArray { get; set; } = new SideMotionName[2]; // std::array<Em7000Param::SideMotionName,2>

    [JsonPropertyName("attackParam_")]
    public BossAttackParam[] AttackParam { get; set; } = new BossAttackParam[2]; // std::array<EmBossBaseParam::BossAttackParam,2>

    [JsonPropertyName("strikeShockWaveLifeSecond_")]
    public float StrikeShockWaveLifeSecond { get; set; } = 4.2f;

    [JsonPropertyName("energyBallParams_")]
    public Em7000EnergyBallParam[] EnergyBallParams { get; set; } = new Em7000EnergyBallParam[5]; // std::array<Em7000EnergyBallParam,5>

    [JsonPropertyName("shockWavePresagePosArray_")]
    public BindingList<Vector4> ShockWavePresagePosArray { get; set; } = []; // std::array<Hw::cVec4,4>

    [JsonPropertyName("attackComboPosArray_")]
    public BindingList<Vector4> AttackComboPosArray { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("lockOnArray_")]
    public ActionLockOnParam[] LockOnArray { get; set; } = new ActionLockOnParam[19]; // std::array<Em7000Param::ActionLockOnParam,19>

    [JsonPropertyName("cameraEnableArray_")]
    public /* EnableArray */ bool[] CameraEnableArray { get; set; } = new bool[19]; // std::array<bool, 19>

    [JsonPropertyName("neckEnableArray_")]
    public /* EnableArray */ bool[] NeckEnableArray { get; set; } = new bool[19]; // std::array<bool, 19>

    [JsonPropertyName("endLastPhaseBreak_")]
    public float EndLastPhaseBreak { get; set; } = 600f;

    [JsonPropertyName("enableLockOnLength_")]
    public float EnableLockOnLength { get; set; } = 500f;

    public Em7000Param()
    {
        Hp = 100000;
        Atk = 10;
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
        EnemySize = 2;
        LinkAttackCameraDistRate = 1f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 0.6f;
        BasicHitStopTimeRate = 0f;
        DamageReactionHitStopTimeRate = 0f;
        SuperArmorHitStopTimeRate = 0f;
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
        CameraLength = 2f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0.2f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
    }

    public class SideMotionName // Em7000Param::SideMotionName
    {
        [JsonPropertyName("left_")]
        public string Left { get; set; } // cyan::inplace_string<5>

        [JsonPropertyName("right_")]
        public string Right { get; set; } // cyan::inplace_string<5>
    }

    public class ActionLockOnParam // Em7000Param::ActionLockOnParam
    {
        [JsonPropertyName("isLockOn_")]
        public bool IsLockOn { get; set; }

        [JsonPropertyName("lockOnPartsNo_")]
        public int LockOnPartsNo { get; set; }
    }
}

public class Em7000EnergyBallParam
{
    [JsonPropertyName("bezierOffset_")]
    public /* cVec4 */ Vector4 BezierOffset { get; set; }

    [JsonPropertyName("effectScale_")]
    public float EffectScale { get; set; }

    [JsonPropertyName("setWaitSecondMax_")]
    public float SetWaitSecondMax { get; set; }

    [JsonPropertyName("moveSecond_")]
    public float MoveSecond { get; set; }

    [JsonPropertyName("attackSignOffsetDispSec_")]
    public float AttackSignOffsetDispSec { get; set; }

    [JsonPropertyName("setPos_")]
    public /* cVec4 */ Vector4 SetPos { get; set; }

    [JsonPropertyName("impactPos_")]
    public /* cVec4 */ Vector4 ImpactPos { get; set; }
}
