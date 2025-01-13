using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1200;

public class Em1200Param : EnemyParameterInfo
{
    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; }

    [JsonPropertyName("moveTimeOutSecond_")]
    public float MoveTimeOutSecond { get; set; } = 10f;

    [JsonPropertyName("homingMoveParam_")]
    public HomingMoveParam HomingMoveParam_ { get; set; }

    [JsonPropertyName("chargeBeamParam_")]
    public ChargeBeamParam ChargeBeamParam_ { get; set; }

    [JsonPropertyName("missileParam_")]
    public MissileRangeParam MissileParam { get; set; }

    [JsonPropertyName("counterAtkParam_")]
    public CounterAttackParam CounterAtkParam { get; set; }

    [JsonPropertyName("carpetBombingParam_")]
    public CounterCarpetBombingParam CarpetBombingParam { get; set; }

    [JsonPropertyName("moveHomingRate_")]
    public float MoveHomingRate { get; set; } = 0.03f;

    [JsonPropertyName("moveHomingDegree_")]
    public float MoveHomingDegree { get; set; } = 3f;

    [JsonPropertyName("attackHomingRate_")]
    public float AttackHomingRate { get; set; } = 0.015f;

    [JsonPropertyName("attackHomingDegree_")]
    public float AttackHomingDegree { get; set; } = 7f;

    [JsonPropertyName("designatedPosAddLengthMin_")]
    public float DesignatedPosAddLengthMin { get; set; } = 0f;

    [JsonPropertyName("designatedPosAddLengthMax_")]
    public float DesignatedPosAddLengthMax { get; set; } = 0f;

    [JsonPropertyName("linkAttackJumpSpeed_")]
    public float LinkAttackJumpSpeed { get; set; } = 0.2f;

    [JsonPropertyName("linkAttackGravityRate_")]
    public float LinkAttackGravityRate { get; set; } = 0.5f;

    [JsonPropertyName("heavyDamageReactionScale_")]
    public float HeavyDamageReactionScale { get; set; } = 2.5f;

    [JsonPropertyName("electricEffTime_")]
    public float ElectricEffTime { get; set; } = 0.25f;

    public Em1200Param()
    {
        Hp = 2500;
        Atk = 300;
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

    public class HomingMoveParam
    {
        [JsonPropertyName("speedMax_")]
        public float SpeedMax { get; set; } // Offset 0x8

        [JsonPropertyName("speedMin_")]
        public float SpeedMin { get; set; } // Offset 0xC

        [JsonPropertyName("acceleration_")]
        public float Acceleration { get; set; } // Offset 0x10

        [JsonPropertyName("deceleration_")]
        public float Deceleration { get; set; } // Offset 0x14

        [JsonPropertyName("shouldTurnMotDeg_")]
        public float ShouldTurnMotDeg { get; set; } // Offset 0x18

        [JsonPropertyName("turnMotInterTime_")]
        public float TurnMotInterTime { get; set; } // Offset 0x1C

        [JsonPropertyName("turnDirRateDest_")]
        public float TurnDirRateDest { get; set; } // Offset 0x20

        [JsonPropertyName("turnDirMaxDegDest_")]
        public float TurnDirMaxDegDest { get; set; } // Offset 0x24

        [JsonPropertyName("turnDirRateTarget_")]
        public float TurnDirRateTarget { get; set; } // Offset 0x28

        [JsonPropertyName("turnDirMaxDegTarget_")]
        public float TurnDirMaxDegTarget { get; set; } // Offset 0x2C

        [JsonPropertyName("closeDistThreholdRelay_")]
        public float CloseDistThreholdRelay { get; set; } // Offset 0x30

        [JsonPropertyName("closeDistThreholdDest_")]
        public float CloseDistThreholdDest { get; set; } // Offset 0x34

        public HomingMoveParam()
        {
        }
    }


    public class ChargeBeamParam
    {
        [JsonPropertyName("attackLength_")]
        public float AttackLength { get; set; } // Offset 0x8

        [JsonPropertyName("attackRadiusMin_")]
        public float AttackRadiusMin { get; set; } // Offset 0xC

        [JsonPropertyName("attackRadiusMax_")]
        public float AttackRadiusMax { get; set; } // Offset 0x10

        [JsonPropertyName("attackRadiusIncreaseUnit_")]
        public float AttackRadiusIncreaseUnit { get; set; } // Offset 0x14

        [JsonPropertyName("attackRate_")]
        public float AttackRate { get; set; } // Offset 0x18

        [JsonPropertyName("chargeTime_")]
        public float ChargeTime { get; set; } // Offset 0x1C

        [JsonPropertyName("disableTurnTime_")]
        public float DisableTurnTime { get; set; } // Offset 0x20

        [JsonPropertyName("attackTime_")]
        public float AttackTime { get; set; } // Offset 0x24

        [JsonPropertyName("coolTime_")]
        public float CoolTime { get; set; } // Offset 0x28

        [JsonPropertyName("coopBeamIntervalTime_")]
        public float CoopBeamIntervalTime { get; set; } // Offset 0x2C

        public ChargeBeamParam()
        {
        }
    }


    public class MissileRangeParam
    {
        [JsonPropertyName("aimParabolaEndSpd_")]
        public float AimParabolaEndSpd { get; set; } // Offset 0x8

        [JsonPropertyName("aimParabolaEndMaxDist_")]
        public float AimParabolaEndMaxDist { get; set; } // Offset 0xC

        [JsonPropertyName("moveStopDistInAimLoop_")]
        public float MoveStopDistInAimLoop { get; set; } // Offset 0x10

        [JsonPropertyName("moveAccelInAimLoop_")]
        public float MoveAccelInAimLoop { get; set; } // Offset 0x14

        [JsonPropertyName("moveSpdMaxInAimLoop_")]
        public float MoveSpdMaxInAimLoop { get; set; } // Offset 0x18

        [JsonPropertyName("rotAddDegInAimLoop_")]
        public float RotAddDegInAimLoop { get; set; } // Offset 0x1C

        [JsonPropertyName("rotMaxDegInAimLoop_")]
        public float RotMaxDegInAimLoop { get; set; } // Offset 0x20

        [JsonPropertyName("rotRateDecelInAimLoop_")]
        public float RotRateDecelInAimLoop { get; set; } // Offset 0x24

        [JsonPropertyName("rotRateStopInAimLoop_")]
        public float RotRateStopInAimLoop { get; set; } // Offset 0x28

        [JsonPropertyName("rotRateStopInMissileEnd_")]
        public float RotRateStopInMissileEnd { get; set; } // Offset 0x2C

        [JsonPropertyName("moveRateInAimLoop_")]
        public float MoveRateInAimLoop { get; set; } // Offset 0x30

        [JsonPropertyName("moveMaxDegInAimLoop_")]
        public float MoveMaxDegInAimLoop { get; set; } // Offset 0x34

        [JsonPropertyName("lengthMin_")]
        public float LengthMin { get; set; } // Offset 0x38

        [JsonPropertyName("lengthMax_")]
        public float LengthMax { get; set; } // Offset 0x3C

        [JsonPropertyName("widthMin_")]
        public float WidthMin { get; set; } // Offset 0x40

        [JsonPropertyName("widthMax_")]
        public float WidthMax { get; set; } // Offset 0x44

        [JsonPropertyName("spaceMin_")]
        public float SpaceMin { get; set; } // Offset 0x48

        [JsonPropertyName("spaceMax_")]
        public float SpaceMax { get; set; } // Offset 0x4C

        [JsonPropertyName("randomShiftMin_")]
        public float RandomShiftMin { get; set; } // Offset 0x50

        [JsonPropertyName("randomShiftMax_")]
        public float RandomShiftMax { get; set; } // Offset 0x54

        [JsonPropertyName("lengthIcreaseUnit_")]
        public float LengthIcreaseUnit { get; set; } // Offset 0x58

        [JsonPropertyName("widthIcreaseUnit_")]
        public float WidthIcreaseUnit { get; set; } // Offset 0x5C

        [JsonPropertyName("moveSpd_")]
        public float MoveSpd { get; set; } // Offset 0x60

        [JsonPropertyName("addMoveSpdEachIdx_")]
        public float AddMoveSpdEachIdx { get; set; } // Offset 0x64

        [JsonPropertyName("intervalTime_")]
        public float IntervalTime { get; set; } // Offset 0x68

        [JsonPropertyName("passRotRange_")]
        public float PassRotRange { get; set; } // Offset 0x6C

        [JsonPropertyName("firePosOffsetZ_")]
        public float FirePosOffsetZ { get; set; } // Offset 0x70

        [JsonPropertyName("aimTime_")]
        public float AimTime { get; set; } // Offset 0x74

        [JsonPropertyName("aimTurnRate_")]
        public float AimTurnRate { get; set; } // Offset 0x7C

        [JsonPropertyName("aimTurnMaxDeg_")]
        public float AimTurnMaxDeg { get; set; } // Offset 0x80

        [JsonPropertyName("lockOnTurnRate_")]
        public float LockOnTurnRate { get; set; } // Offset 0x84

        [JsonPropertyName("lockOnTurnMaxDeg_")]
        public float LockOnTurnMaxDeg { get; set; } // Offset 0x88

        [JsonPropertyName("fireTurnRate_")]
        public float FireTurnRate { get; set; } // Offset 0x8C

        [JsonPropertyName("fireTurnMaxDeg_")]
        public float FireTurnMaxDeg { get; set; } // Offset 0x90

        [JsonPropertyName("fireMissileNumAtOneTime_")]
        public int FireMissileNumAtOneTime { get; set; } // Offset 0x94

        public MissileRangeParam()
        {
        }
    }


    public class CounterAttackParam
    {
        [JsonPropertyName("signTime_")]
        public float SignTime { get; set; } // Offset 0x8

        [JsonPropertyName("initFallSpd_")]
        public float InitFallSpd { get; set; } // Offset 0xC

        [JsonPropertyName("atkRadius_")]
        public float AtkRadius { get; set; } // Offset 0x10

        [JsonPropertyName("atkTime_")]
        public float AtkTime { get; set; } // Offset 0x14

        public CounterAttackParam()
        {
        }
    }


    public class CounterCarpetBombingParam
    {
        [JsonPropertyName("initialVelocity_")]
        public float InitialVelocity { get; set; } // Offset 0x10

        [JsonPropertyName("moveAccel_")]
        public float MoveAccel { get; set; } // Offset 0x14

        [JsonPropertyName("moveSpdMax_")]
        public float MoveSpdMax { get; set; } // Offset 0x18

        [JsonPropertyName("bombingInterval_")]
        public float BombingInterval { get; set; } // Offset 0x1C

        [JsonPropertyName("turnDirRate_")]
        public float TurnDirRate { get; set; } // Offset 0x20

        [JsonPropertyName("turnDirMaxDeg_")]
        public float TurnDirMaxDeg { get; set; } // Offset 0x24

        [JsonPropertyName("moveDistInCloseRange_")]
        public float MoveDistInCloseRange { get; set; } // Offset 0x28

        [JsonPropertyName("moveBackRaiseOffset_")]
        public Vector2 MoveBackRaiseOffset { get; set; } // Offset 0x2C

        [JsonPropertyName("moveTargetOffsetGrd_")]
        public Vector4 MoveTargetOffsetGrd { get; set; } // Offset 0x40

        [JsonPropertyName("moveTargetOffsetFly_")]
        public Vector4 MoveTargetOffsetFly { get; set; } // Offset 0x50

        [JsonPropertyName("isToGround_")]
        public bool IsToGround { get; set; } // Offset 0x60

        public CounterCarpetBombingParam()
        {
        }
    }
}
