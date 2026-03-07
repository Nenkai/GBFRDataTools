using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1500;

public class Em1500Param : EmBossBaseParam
{
    [JsonPropertyName("headParts_")]
    public PartsParam HeadParts { get; set; }

    [JsonPropertyName("bodyParts_")]
    public PartsParam BodyParts { get; set; }

    [JsonPropertyName("armRightParts_")]
    public PartsParam ArmRightParts { get; set; }

    [JsonPropertyName("armLeftParts_")]
    public PartsParam ArmLeftParts { get; set; }

    [JsonPropertyName("legRightParts_")]
    public PartsParam LegRightParts { get; set; }

    [JsonPropertyName("legLeftParts_")]
    public PartsParam LegLeftParts { get; set; }

    [JsonPropertyName("guardRate_")]
    public float GuardRate { get; set; } = 0.6f;

    [JsonPropertyName("guardEndurance_")]
    public float GuardEndurance { get; set; } = 10000f;

    [JsonPropertyName("guardEffRate_EST_ID_5_")]
    public float GuardEffRate_EST_ID_5 { get; set; } = 0.7f;

    [JsonPropertyName("guardEffRate_EST_ID_6_")]
    public float GuardEffRate_EST_ID_6 { get; set; } = 0.4f;

    [JsonPropertyName("guardEffRate_EST_ID_7_")]
    public float GuardEffRate_EST_ID_7 { get; set; } = 0.1f;

    [JsonPropertyName("guardKnockBackRate_")]
    public float GuardKnockBackRate { get; set; } = 0.3f;

    [JsonPropertyName("damageReactionBreakValue_")]
    public float DamageReactionBreakValue { get; set; } = 100f;

    [JsonPropertyName("weakPointRate_")]
    public float WeakPointRate { get; set; } = 1.5f;

    [JsonPropertyName("overDriveRate_")]
    public float OverDriveRate { get; set; } = 1.07f;

    [JsonPropertyName("overDriveRateHL_")]
    public float OverDriveRateHL { get; set; } = 1.1f;

    [JsonPropertyName("isEnableHalfBreak_")]
    public bool IsEnableHalfBreak { get; set; } = true;

    [JsonPropertyName("shotStoneNum_")]
    public float ShotStoneNum { get; set; } = 20f;

    [JsonPropertyName("shotStoneHeight_")]
    public float ShotStoneHeight { get; set; } = 2f;

    [JsonPropertyName("attackCoolTime_")]
    public float AttackCoolTime { get; set; } = 3f;

    [JsonPropertyName("jumpAttackCoolTime_")]
    public float JumpAttackCoolTime { get; set; } = 20f;

    [JsonPropertyName("punchCoolTime_")]
    public float PunchCoolTime { get; set; } = 10f;

    [JsonPropertyName("fistStompCoolTime_")]
    public float FistStompCoolTime { get; set; } = 15f;

    [JsonPropertyName("spinAttackCoolTime_")]
    public float SpinAttackCoolTime { get; set; } = 15f;

    [JsonPropertyName("doubleSledgeHammerCoolTime_")]
    public float DoubleSledgeHammerCoolTime { get; set; } = 15f;

    [JsonPropertyName("bunkerBusterTime_")]
    public float BunkerBusterTime { get; set; } = 30f;

    [JsonPropertyName("bindAttackCoolTime_")]
    public float BindAttackCoolTime { get; set; } = 30f;

    [JsonPropertyName("backAttackCoolTime_")]
    public float BackAttackCoolTime { get; set; } = 15f;

    [JsonPropertyName("backFistCoolTime_")]
    public float BackFistCoolTime { get; set; } = 60f;

    [JsonPropertyName("rollingAttackCoolTime_")]
    public float RollingAttackCoolTime { get; set; } = 30f;

    [JsonPropertyName("guardCoolTime_")]
    public float GuardCoolTime { get; set; } = 15f;

    [JsonPropertyName("overDriveTime_")]
    public float OverDriveTime { get; set; } = 60f;

    [JsonPropertyName("earthQuakeLariatCoolTime_")]
    public float EarthQuakeLariatCoolTime { get; set; } = 60f;

    [JsonPropertyName("overDriveAttackCoolTime_")]
    public float OverDriveAttackCoolTime { get; set; } = 120f;

    [JsonPropertyName("homingGeyserCoolTime_")]
    public float HomingGeyserCoolTime { get; set; } = 10f;

    [JsonPropertyName("superJumpAttackCoolTime_")]
    public float SuperJumpAttackCoolTime { get; set; } = 60f;

    [JsonPropertyName("overDriveAttackOnceCoolTime_")]
    public float OverDriveAttackOnceCoolTime { get; set; } = 30f;

    [JsonPropertyName("partsDamageHp_BackHandBlow_")]
    public int PartsDamageHp_BackHandBlow { get; set; } = 45;

    [JsonPropertyName("partsDamageHp_EarthquakLeariat_")]
    public int PartsDamageHp_EarthquakLeariat { get; set; } = 30;

    [JsonPropertyName("partsDamageHpBreakCountRate_")]
    public float PartsDamageHpBreakCountRate { get; set; } = 1.2f;

    [JsonPropertyName("partsDamageHpBreakCountRateHL_")]
    public float PartsDamageHpBreakCountRateHL { get; set; } = 1.5f;

    [JsonPropertyName("earthQuakeLariatAttackRate_")]
    public float EarthQuakeLariatAttackRate { get; set; } = 4f;

    [JsonPropertyName("backHandBlowAttackRate_")]
    public float BackHandBlowAttackRate { get; set; } = 2f;

    [JsonPropertyName("earthquakeLariatHpTrigger01_")]
    public int EarthquakeLariatHpTrigger01 { get; set; } = 70;

    [JsonPropertyName("earthquakeLariatHpTrigger02_")]
    public int EarthquakeLariatHpTrigger02 { get; set; } = 40;

    [JsonPropertyName("earthquakeLariatHpTrigger03_")]
    public int EarthquakeLariatHpTrigger03 { get; set; } = 10;

    [JsonPropertyName("guardHpTrigger01_")]
    public int GuardHpTrigger01 { get; set; } = 85;

    [JsonPropertyName("guardHpTrigger02_")]
    public int GuardHpTrigger02 { get; set; } = 50;

    [JsonPropertyName("guardHpTrigger03_")]
    public int GuardHpTrigger03 { get; set; } = 0;

    [JsonPropertyName("earthquakeLariatHomingRate01_")]
    public float EarthquakeLariatHomingRate01 { get; set; } = 0.02f;

    [JsonPropertyName("earthquakeLariatHomingRate02_")]
    public float EarthquakeLariatHomingRate02 { get; set; } = 0.1f;

    [JsonPropertyName("earthquakeLariatLimitDist_")]
    public float EarthquakeLariatLimitDist { get; set; } = 30f;

    [JsonPropertyName("jumpPunchShockWaveAttackRate_")]
    public float JumpPunchShockWaveAttackRate { get; set; } = 0.6f;

    [JsonPropertyName("jumpPunchShockWaveBreakRate_")]
    public float JumpPunchShockWaveBreakRate { get; set; } = 0.6f;

    [JsonPropertyName("earthquakeLariatShockWaveAttackRate_")]
    public float EarthquakeLariatShockWaveAttackRate { get; set; } = 0.6f;

    [JsonPropertyName("earthquakeLariatShockWaveBreakRate_")]
    public float EarthquakeLariatShockWaveBreakRate { get; set; } = 0.6f;

    [JsonPropertyName("overDriveRockHP_")]
    public int OverDriveRockHP { get; set; } = 1;

    [JsonPropertyName("counterAttackRockHP_")]
    public int CounterAttackRockHP { get; set; } = 1;

    [JsonPropertyName("counterAttackRockBreakTimer_")]
    public float CounterAttackRockBreakTimer { get; set; } = 19f;

    [JsonPropertyName("counterAttackRockRadius_")]
    public float CounterAttackRockRadius { get; set; } = 5f;

    [JsonPropertyName("counterAttackRockAttackTimer_")]
    public float CounterAttackRockAttackTimer { get; set; } = 0.1f;

    [JsonPropertyName("counterAttackRockAttackRate_")]
    public float CounterAttackRockAttackRate { get; set; } = 1f;

    [JsonPropertyName("counterAttackRockStunRate_")]
    public float CounterAttackRockStunRate { get; set; } = 1f;

    [JsonPropertyName("initEmissiveRate_")]
    public float InitEmissiveRate { get; set; } = 0.3f;

    [JsonPropertyName("minEmissiveRate_")]
    public float MinEmissiveRate { get; set; } = 0.3f;

    [JsonPropertyName("maxEmissiveRate_")]
    public float MaxEmissiveRate { get; set; } = 1f;

    [JsonPropertyName("emissiveCycleTime_")]
    public float EmissiveCycleTime { get; set; } = 1f;

    [JsonPropertyName("jumpAttackLimitDist_")]
    public float JumpAttackLimitDist { get; set; } = 30f;

    [JsonPropertyName("rockGeyserScaleMin_")]
    public float RockGeyserScaleMin { get; set; } = 1f;

    [JsonPropertyName("rockGeyserScaleMax_")]
    public float RockGeyserScaleMax { get; set; } = 1f;

    [JsonPropertyName("exDownWeakPointParam_")]
    public EmWeakPointParam ExDownWeakPointParam { get; set; }

    public Em1500Param()
    {
        Hp = 250000;
        Atk = 2000;
        Break = 8;
        Def = 0f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 25;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 25;
        HateRateBackAngle = 0;
        HateRateDamage = 50;
        HateRateManualPlayer = 100;
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
        CombatPower = 65;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 0.75f;
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
        StageInvisibleStartDistance = 90f;
        StageInvisibleEndDistance = 100f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = false;
        IsDisableAerialDownReaction = true;
        CameraLength = 2f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PartsParam
    {
        [JsonPropertyName("hp_")]
        public int Hp { get; set; } // Offset 0x8

        [JsonPropertyName("rate_")]
        public float Rate { get; set; } // Offset 0xC

        public PartsParam()
        {
        }
    }
}
