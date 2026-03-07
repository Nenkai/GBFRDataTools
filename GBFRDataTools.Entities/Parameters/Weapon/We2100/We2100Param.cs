using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Parameters.Enemy.Em2100;

namespace GBFRDataTools.Entities.Parameters.Weapon.We2100;

public class We2100Param : EnemyParameterInfo
{
    [JsonPropertyName("emissiveParam_")]
    public Em2100SwordEmissiveParam EmissiveParam { get; set; }

    [JsonPropertyName("singleFunnelActionParam_")]
    public Em2100SwordSingleFunnelActionParam SingleFunnelActionParam { get; set; }

    [JsonPropertyName("spearActionParam_")]
    public Em2100SwordSpearActionParam SpearActionParam { get; set; }

    [JsonPropertyName("wheelActionParam_")]
    public Em2100SwordWheelActionParam WheelActionParam { get; set; }

    [JsonPropertyName("guardActionParam_")]
    public Em2100SwordGuardActionParam GuardActionParam { get; set; }

    [JsonPropertyName("shurikenActionParam_")]
    public Em2100SwordShurikenActionParam ShurikenActionParam { get; set; }

    [JsonPropertyName("funnelParam_")]
    public Em2100SwordFunnelParam FunnelParam { get; set; }

    [JsonPropertyName("homingParam_")]
    public Em2100SwordHomingParam HomingParam { get; set; }

    [JsonPropertyName("guillotineParam_")]
    public Em2100SwordGuillotineParam GuillotineParam { get; set; }

    [JsonPropertyName("arrowRainParam_")]
    public Em2100SwordArrowRainParam ArrowRainParam { get; set; }

    [JsonPropertyName("meleeThrowParam_")]
    public Em2100SwordMeleeThrowParam MeleeThrowParam { get; set; }

    [JsonPropertyName("stepThrowParam_")]
    public Em2100SworStepThrowParam StepThrowParam { get; set; }

    [JsonPropertyName("counterParam_")]
    public Em2100SwordCounterParam CounterParam { get; set; }

    [JsonPropertyName("dountParam_")]
    public Em2100SwordDountParam DountParam { get; set; }

    [JsonPropertyName("meteorsSwordParam_")]
    public Em2100SwordMeteorsSwordParam MeteorsSwordParam { get; set; }

    [JsonPropertyName("rotationSpParam_")]
    public Em2100SwordRotationSpParam RotationSpParam { get; set; }

    [JsonPropertyName("linearShotSpParam_")]
    public Em2100SwordLinearShotSpParam LinearShotSpParam { get; set; }

    [JsonPropertyName("barrierSpParam_")]
    public Em2100SwordBarrierSpParam BarrierSpParam { get; set; }

    [JsonPropertyName("barrierSpKeepParam_")]
    public Em2100SwordBarrierSpParam BarrierSpKeepParam { get; set; }

    [JsonPropertyName("spArtsCombinationParam_")]
    public Em2100SwordSpArtsCombinationParam SpArtsCombinationParam { get; set; }

    [JsonPropertyName("weaponHp_")]
    public int WeaponHp { get; set; } = 1000;

    [JsonPropertyName("directAttackDamageRate_")]
    public float DirectAttackDamageRate { get; set; } = 20f;

    [JsonPropertyName("guardDamageRate_")]
    public float GuardDamageRate { get; set; } = 0.4f;

    [JsonPropertyName("attackSphereRadius_")]
    public float AttackSphereRadius { get; set; } = 0.27f;

    [JsonPropertyName("defendSwordDist_")]
    public float DefendSwordDist { get; set; } = 1.5f;

    [JsonPropertyName("linkAttackDamageScale_")]
    public float LinkAttackDamageScale { get; set; } = 3f;

    [JsonPropertyName("damageShakeTime_")]
    public float DamageShakeTime { get; set; } = 0.25f;

    [JsonPropertyName("damageShakeOffsetXZ_")]
    public float DamageShakeOffsetXZ { get; set; } = 2f;

    [JsonPropertyName("damageShakeSpeedXZ_")]
    public float DamageShakeSpeedXZ { get; set; } = 65f;

    [JsonPropertyName("damageShakeOffsetY_")]
    public float DamageShakeOffsetY { get; set; } = 2f;

    [JsonPropertyName("damageShakeSpeedY_")]
    public float DamageShakeSpeedY { get; set; } = 55f;

    [JsonPropertyName("breakHitStopTimer_")]
    public int BreakHitStopTimer { get; set; } = 16;

    [JsonPropertyName("breakEmissiveOffSec_")]
    public float BreakEmissiveOffSec { get; set; } = 0.125f;

    public We2100Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 75;
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
        CombatPower = 0;
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

public class Em2100SwordEmissiveParam
{
    [JsonPropertyName("emissives_")]
    [Editable(false)]
    public BindingList<Emissive> Emissives { get; set; } = [.. Enumerable.Repeat(new Emissive(), 6).ToList()]; // std::array<Em2100SwordEmissiveParam::Emissive,6>

    public Em2100SwordEmissiveParam()
    {
    }
}


public class Emissive // Em2100SwordEmissiveParam::Emissive
{
    [JsonPropertyName("color_")]
    [Editable(false)]
    public BindingList<Vector3> Color { get; set; } = [.. Enumerable.Repeat(new Vector3(), 2).ToList()]; // std::array<cVec3,2>

    [JsonPropertyName("intensity_")]
    [Editable(false)]
    public BindingList<float> Intensity { get; set; } = [.. Enumerable.Repeat(0, 2).ToList()]; // std::array<float,2>

    [JsonPropertyName("useEmissiveAnim_")]
    public bool UseEmissiveAnim { get; set; }

    [JsonPropertyName("blinkTime_")]
    public float BlinkTime { get; set; }

    public Emissive()
    {
    }
}


public class Em2100SwordSingleFunnelActionParam
{
    [JsonPropertyName("speed_")]
    public float Speed { get; set; }

    [JsonPropertyName("shotWaitSec_")]
    public float ShotWaitSec { get; set; }

    [JsonPropertyName("hitRotXMin_")]
    public float HitRotXMin { get; set; }

    [JsonPropertyName("hitAdjustRotXSec_")]
    public float HitAdjustRotXSec { get; set; }

    [JsonPropertyName("attackSignOffsetZ_")]
    public float AttackSignOffsetZ { get; set; }

    [JsonPropertyName("groundedOffset_")]
    public Vector4 GroundedOffset { get; set; }

    [JsonPropertyName("funnelAtkParam_")]
    public Em2100AttackParam FunnelAtkParam { get; set; }

    [JsonPropertyName("explodeAtkParam_")]
    public Em2100AttackParam ExplodeAtkParam { get; set; }

    public Em2100SwordSingleFunnelActionParam()
    {
    }
}


public class Em2100SwordSpearActionParam
{
    [JsonPropertyName("fallSpeed_")]
    public float FallSpeed { get; set; }

    [JsonPropertyName("fallWaitSec_")]
    public float FallWaitSec { get; set; }

    [JsonPropertyName("upShootHeight_")]
    public float UpShootHeight { get; set; }

    [JsonPropertyName("spinEndSec_")]
    public float SpinEndSec { get; set; }

    [JsonPropertyName("spearAtkParam_")]
    public Em2100AttackParam SpearAtkParam { get; set; }

    [JsonPropertyName("explodeAtkParam_")]
    public Em2100AttackParam ExplodeAtkParam { get; set; }

    public Em2100SwordSpearActionParam()
    {
    }
}


public class Em2100SwordWheelActionParam
{
    [JsonPropertyName("groundOffsetY_")]
    public float GroundOffsetY { get; set; }

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; }

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; }

    [JsonPropertyName("addDist_")]
    public float AddDist { get; set; }

    [JsonPropertyName("maxDistance_")]
    public float MaxDistance { get; set; }

    [JsonPropertyName("atkParam_")]
    public Em2100AttackParam AtkParam { get; set; }

    public Em2100SwordWheelActionParam()
    {
    }
}


public class Em2100SwordGuardActionParam
{
    [JsonPropertyName("guardDispSec_")]
    public float GuardDispSec { get; set; }

    public Em2100SwordGuardActionParam()
    {
    }
}


public class Em2100SwordShurikenActionParam
{
    [JsonPropertyName("guardWaitSec_")]
    public float GuardWaitSec { get; set; }

    [JsonPropertyName("swordSpeed_")]
    public float SwordSpeed { get; set; }

    [JsonPropertyName("maxDist_")]
    public float MaxDist { get; set; }

    [JsonPropertyName("targetOffsetY_")]
    public float TargetOffsetY { get; set; }

    [JsonPropertyName("counterIntervalSec_")]
    public float CounterIntervalSec { get; set; }

    [JsonPropertyName("reduceDamageValueInSec_")]
    public int ReduceDamageValueInSec { get; set; }

    [JsonPropertyName("stopReduceSec_")]
    public float StopReduceSec { get; set; }

    [JsonPropertyName("atkParam_")]
    public Em2100AttackParam AtkParam { get; set; }

    public Em2100SwordShurikenActionParam()
    {
    }
}


public class Em2100SwordFunnelParam
{
    [JsonPropertyName("funnelAtkParam_")]
    public Em2100AttackParam FunnelAtkParam { get; set; }

    [JsonPropertyName("explodeAtkParam_")]
    public Em2100AttackParam ExplodeAtkParam { get; set; }

    public Em2100SwordFunnelParam()
    {
    }
}


public class Em2100SwordHomingParam
{
    [JsonPropertyName("homingAtkParam_")]
    public Em2100AttackParam HomingAtkParam { get; set; }

    [JsonPropertyName("explodeAtkParam_")]
    public Em2100AttackParam ExplodeAtkParam { get; set; }

    public Em2100SwordHomingParam()
    {
    }
}


public class Em2100SwordGuillotineParam
{
    [JsonPropertyName("atkParam_")]
    public Em2100AttackParam AtkParam { get; set; }

    public Em2100SwordGuillotineParam()
    {
    }
}


public class Em2100SwordArrowRainParam
{
    [JsonPropertyName("atkParam_")]
    public Em2100AttackParam AtkParam { get; set; }

    public Em2100SwordArrowRainParam()
    {
    }
}


public class Em2100SwordMeleeThrowParam
{
    [JsonPropertyName("throwAtkParam_")]
    public Em2100AttackParam ThrowAtkParam { get; set; }

    [JsonPropertyName("explodeAtkParam_")]
    public Em2100AttackParam ExplodeAtkParam { get; set; }

    public Em2100SwordMeleeThrowParam()
    {
    }
}


public class Em2100SworStepThrowParam
{
    [JsonPropertyName("throwAtkParam_")]
    public Em2100AttackParam ThrowAtkParam { get; set; }

    [JsonPropertyName("explodeAtkParam_")]
    public Em2100AttackParam ExplodeAtkParam { get; set; }

    public Em2100SworStepThrowParam()
    {
    }
}


public class Em2100SwordCounterParam
{
    [JsonPropertyName("atkParam_")]
    public Em2100AttackParam AtkParam { get; set; }

    [JsonPropertyName("largePartsAtkParam_")]
    public Em2100AttackParam LargePartsAtkParam { get; set; }

    public Em2100SwordCounterParam()
    {
    }
}


public class Em2100SwordDountParam
{
    [JsonPropertyName("atkParam_")]
    public Em2100AttackParam AtkParam { get; set; }

    public Em2100SwordDountParam()
    {
    }
}


public class Em2100SwordMeteorsSwordParam
{
    [JsonPropertyName("atkParam_")]
    public Em2100AttackParam AtkParam { get; set; }

    [JsonPropertyName("explodeAtkParam_")]
    public Em2100AttackParam ExplodeAtkParam { get; set; }

    public Em2100SwordMeteorsSwordParam()
    {
    }
}


public class Em2100SwordRotationSpParam
{
    [JsonPropertyName("atkParam_")]
    public Em2100AttackParam AtkParam { get; set; }

    public Em2100SwordRotationSpParam()
    {
    }
}


public class Em2100SwordLinearShotSpParam
{
    [JsonPropertyName("shotSpeed_")]
    public float ShotSpeed { get; set; }

    [JsonPropertyName("shotLength_")]
    public float ShotLength { get; set; }

    [JsonPropertyName("atkParam_")]
    public Em2100AttackParam AtkParam { get; set; }

    public Em2100SwordLinearShotSpParam()
    {
    }
}


public class Em2100SwordBarrierSpParam
{
    [JsonPropertyName("atkParam_")]
    public Em2100AttackParam AtkParam { get; set; }

    public Em2100SwordBarrierSpParam()
    {
    }
}


public class Em2100SwordSpArtsCombinationParam
{
    [JsonPropertyName("spreadAttackParam_")]
    public Em2100AttackParam SpreadAttackParam { get; set; }

    [JsonPropertyName("doorAttackParam_")]
    public Em2100AttackParam DoorAttackParam { get; set; }

    public Em2100SwordSpArtsCombinationParam()
    {
    }
}
