using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1800;

public class Em1801Param : Em1800Param
{
    [JsonPropertyName("magmaFieldCreateY_")]
    public float MagmaFieldCreateY { get; set; } = 3f;

    [JsonPropertyName("magmaFieldCreateMeteorY_")]
    public float MagmaFieldCreateMeteorY { get; set; } = 5f;

    [JsonPropertyName("clawLeftFireWallPos_")]
    public Vector3 ClawLeftFireWallPos { get; set; } = new Vector3(5f, 0f, 6f);

    [JsonPropertyName("clawLeftFireWallRot_")]
    public Vector4 ClawLeftFireWallRot { get; set; } = new Vector4(0f, 10f, 0f, 0f);

    [JsonPropertyName("clawRightFireWallPos_")]
    public Vector3 ClawRightFireWallPos { get; set; } = new Vector3(-5f, 0f, 6f);

    [JsonPropertyName("clawRightFireWallRot_")]
    public Vector4 ClawRightFireWallRot { get; set; } = new Vector4(0f, -10f, 0f, 0f);

    [JsonPropertyName("clawTurnLeftFireWallPos_")]
    public Vector3 ClawTurnLeftFireWallPos { get; set; } = new Vector3(4f, 0f, 6f);

    [JsonPropertyName("clawTurnLeftFireWallRot_")]
    public Vector4 ClawTurnLeftFireWallRot { get; set; } = new Vector4(0f, 60f, 0f, 0f);

    [JsonPropertyName("clawTurnRightFireWallPos_")]
    public Vector3 ClawTurnRightFireWallPos { get; set; } = new Vector3(0f, 0f, 10f);

    [JsonPropertyName("clawTurnRightFireWallRot_")]
    public Vector4 ClawTurnRightFireWallRot { get; set; } = new Vector4(0f, -60f, 0f, 0f);

    [JsonPropertyName("meleeBreathOffsetMagmaFieldPos_")]
    public Vector3 MeleeBreathOffsetMagmaFieldPos { get; set; } = new Vector3(0f, 0.1f, 7f);

    [JsonPropertyName("meleeBreathFrontMagmaFieldPos_")]
    public Vector3 MeleeBreathFrontMagmaFieldPos { get; set; } = new Vector3(0f, 0f, 2f);

    [JsonPropertyName("meleeBreathBackMagmaFieldPos_")]
    public Vector3 MeleeBreathBackMagmaFieldPos { get; set; } = new Vector3(0f, 0f, -2f);

    [JsonPropertyName("meleeBreathRightMagmaFieldPos_")]
    public Vector3 MeleeBreathRightMagmaFieldPos { get; set; } = new Vector3(-6f, 0f, 0f);

    [JsonPropertyName("meleeBreathLeftMagmaFieldPos_")]
    public Vector3 MeleeBreathLeftMagmaFieldPos { get; set; } = new Vector3(6f, 0f, 0f);

    [JsonPropertyName("straightBreathParam_")]
    public Em1801Param StraightBreathParam { get; set; }

    [JsonPropertyName("flyingBreathParam_")]
    public Em1801Param FlyingBreathParam { get; set; }

    [JsonPropertyName("fireWaveHeight_")]
    public float FireWaveHeight { get; set; } = 1f;

    [JsonPropertyName("fireWaveRadius_")]
    public float FireWaveRadius { get; set; } = 1f;

    [JsonPropertyName("fireWaveSize_")]
    public float FireWaveSize { get; set; } = 30f;

    [JsonPropertyName("fireWaveTimeSec_")]
    public float FireWaveTimeSec { get; set; } = 4f;

    [JsonPropertyName("BeamFireWallNum_")]
    public int BeamFireWallNum { get; set; } = 3;

    [JsonPropertyName("BeamFireWallOffsetLength_")]
    public float BeamFireWallOffsetLength { get; set; } = 25f;

    [JsonPropertyName("BeamFireWallAddRot_")]
    public float BeamFireWallAddRot { get; set; } = 19.4f;

    [JsonPropertyName("attackParam_straightBreath_")]
    public BossAttackParam AttackParam_straightBreath { get; set; }

    [JsonPropertyName("attackParam_fireWave_")]
    public BossAttackParam AttackParam_fireWave { get; set; }

    [JsonPropertyName("attackParam_flyingBreath_")]
    public BossAttackParam AttackParam_flyingBreath { get; set; }

    [JsonPropertyName("objectLiveSecAILevel1_")]
    public Vector2 ObjectLiveSecAILevel1 { get; set; } = new Vector2(30f, 30f);

    [JsonPropertyName("objectLiveSecAILevel2_")]
    public Vector2 ObjectLiveSecAILevel2 { get; set; } = new Vector2(30f, 30f);

    [JsonPropertyName("objectLiveSecAILevel3_")]
    public Vector2 ObjectLiveSecAILevel3 { get; set; } = new Vector2(30f, 30f);

    [JsonPropertyName("objectLiveSecAILevel4_")]
    public Vector2 ObjectLiveSecAILevel4 { get; set; } = new Vector2(30f, 30f);

    [JsonPropertyName("objectLiveSecAILevel5_")]
    public Vector2 ObjectLiveSecAILevel5 { get; set; } = new Vector2(30f, 30f);

    [JsonPropertyName("magmaMaxNum_")]
    public int MagmaMaxNum { get; set; } = 30;

    [JsonPropertyName("fireWallMaxNum_")]
    public int FireWallMaxNum { get; set; } = 3;

    [JsonPropertyName("magmaPillarMaxNum_")]
    public int MagmaPillarMaxNum { get; set; } = 10;

    [JsonPropertyName("magmaExplodeLength_")]
    public Vector2 MagmaExplodeLength { get; set; } = new Vector2(40f, 40f);

    [JsonPropertyName("magmaExplodeSignTime_")]
    public float MagmaExplodeSignTime { get; set; } = 2.15f;

    [JsonPropertyName("magmaExplodePhaseTime_")]
    public float MagmaExplodePhaseTime { get; set; } = 1.98f;

    [JsonPropertyName("magmaExplodeSignRadius_")]
    public float MagmaExplodeSignRadius { get; set; } = 7.5f;

    [JsonPropertyName("magmaCreateActiveChangeNum_")]
    public Vector3 MagmaCreateActiveChangeNum { get; set; } = new Vector3(10f, 15f, 20f);

    [JsonPropertyName("magmaCreateActivePercent_")]
    public Vector3 MagmaCreateActivePercent { get; set; } = new Vector3(0.5f, 0.3f, 0.2f);

    [JsonPropertyName("magmaExplodeActiveChangeNum_")]
    public Vector3 MagmaExplodeActiveChangeNum { get; set; } = new Vector3(3f, 6f, 10f);

    [JsonPropertyName("magmaExplodeActivePercent_")]
    public Vector3 MagmaExplodeActivePercent { get; set; } = new Vector3(0f, 0.5f, 1f);

    [JsonPropertyName("magmaStopLiveTimerLength_")]
    public float MagmaStopLiveTimerLength { get; set; } = 0f;

    [JsonPropertyName("waitSecondMagAILevel1_")]
    public float WaitSecondMagAILevel1 { get; set; } = 1.4f;

    [JsonPropertyName("waitSecondMagAILevel2_")]
    public float WaitSecondMagAILevel2 { get; set; } = 1.2f;

    [JsonPropertyName("waitSecondMagAILevel3_")]
    public float WaitSecondMagAILevel3 { get; set; } = 1f;

    [JsonPropertyName("waitSecondMagAILevel4_")]
    public float WaitSecondMagAILevel4 { get; set; } = 0.9f;

    [JsonPropertyName("waitSecondMagAILevel5_")]
    public float WaitSecondMagAILevel5 { get; set; } = 0.9f;

    [JsonPropertyName("meteorAddRandomMaxPos_")]
    public Vector3 MeteorAddRandomMaxPos { get; set; } = new Vector3(5.25f, 0f, 5.25f);

    [JsonPropertyName("stepFireBallCoolTime_")]
    public float StepFireBallCoolTime { get; set; } = 20f;

    [JsonPropertyName("beamCoolTime_")]
    public float BeamCoolTime { get; set; } = 20f;

    [JsonPropertyName("meleeBreathCoolTime_")]
    public float MeleeBreathCoolTime { get; set; } = 20f;

    [JsonPropertyName("stepFireBallExtendLength_")]
    public float StepFireBallExtendLength { get; set; } = 5f;

    [JsonPropertyName("magmaRockNum_")]
    public int MagmaRockNum { get; set; } = 4;

    [JsonPropertyName("magmaRockRange_")]
    public Vector2 MagmaRockRange { get; set; } = new Vector2(8f, 25f);

    [JsonPropertyName("magmaRockPosRand_")]
    public float MagmaRockPosRand { get; set; } = 9f;

    [JsonPropertyName("magmaRockDisengageRange_")]
    public float MagmaRockDisengageRange { get; set; } = 4f;

    [JsonPropertyName("magmaRockTime_")]
    public Vector2 MagmaRockTime { get; set; } = new Vector2(1.5f, 2.5f);

    [JsonPropertyName("createMagmaCoolTime_")]
    public float CreateMagmaCoolTime { get; set; } = 10f;

    [JsonPropertyName("explodeMagmaCoolTime_")]
    public float ExplodeMagmaCoolTime { get; set; } = 30f;

    [JsonPropertyName("eruptionMagmaCoolTime_")]
    public float EruptionMagmaCoolTime { get; set; } = 20f;

    [JsonPropertyName("jumpBreathFireWallParam_")]
    public Em1801Param JumpBreathFireWallParam { get; set; }

    [JsonPropertyName("jumpBreathFireWallBurnSec_")]
    public float JumpBreathFireWallBurnSec { get; set; } = 8f;

    [JsonPropertyName("jumpBreathFireWallBurnRate_")]
    public float JumpBreathFireWallBurnRate { get; set; } = 1f;

    [JsonPropertyName("jumpBreathFireWallAttackRate_")]
    public float JumpBreathFireWallAttackRate { get; set; } = 0.5f;

    [JsonPropertyName("jumpBreathFireWallStunRate_")]
    public float JumpBreathFireWallStunRate { get; set; } = 0.5f;

    [JsonPropertyName("rightClawFireWallParam_")]
    public EmAttackWallParam RightClawFireWallParam { get; set; }

    [JsonPropertyName("leftClawFireWallParam_")]
    public EmAttackWallParam LeftClawFireWallParam { get; set; }

    [JsonPropertyName("clawFireWallBurnSec_")]
    public float ClawFireWallBurnSec { get; set; } = 8f;

    [JsonPropertyName("clawFireWallBurnRate_")]
    public float ClawFireWallBurnRate { get; set; } = 1f;

    [JsonPropertyName("clawFireWallAttackRate_")]
    public float ClawFireWallAttackRate { get; set; } = 0.2f;

    [JsonPropertyName("clawFireWallStunRate_")]
    public float ClawFireWallStunRate { get; set; } = 0f;

    [JsonPropertyName("beamBreathFireWallParam_")]
    public Em1801Param BeamBreathFireWallParam { get; set; }

    [JsonPropertyName("beamBreathFireWallBurnSec_")]
    public float BeamBreathFireWallBurnSec { get; set; } = 8f;

    [JsonPropertyName("beamBreathFireWallBurnRate_")]
    public float BeamBreathFireWallBurnRate { get; set; } = 1f;

    [JsonPropertyName("beamBreathFireWallAttackRate_")]
    public float BeamBreathFireWallAttackRate { get; set; } = 0.2f;

    [JsonPropertyName("beamBreathFireWallStunRate_")]
    public float BeamBreathFireWallStunRate { get; set; } = 0f;

    public Em1801Param()
    {
        Hp = 250000;
        Atk = 1000;
        Break = 8;
        Def = 0f;
        Endurance = 10;
        Exp = 20;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 25;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 25;
        HateRateBackAngle = 0;
        HateRateDamage = 50;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 7;
        HateUpdateTime = 5f;
        DamageToHateRate = 0.2f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 70;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 1000f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 1f;
        AnimInterDefaultSec = 0.5f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 0;
        UiOffsetY = 1f;
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
        IsDisableAerialDownReaction = true;
        CameraLength = 4.5f;
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
        CloseLength = 11f;
        MiddleLength = 16f;
        FrontAngle = 45;
        AroundSearchLength = 16f;
        BadStatusHate = 10000;
        IsDeleteMagicCircleEvent = true;
        AnimRateODAILevel1 = new Vector2(1f, 1f);
        AnimRateODAILevel2 = new Vector2(1f, 1f);
        AnimRateODAILevel3 = new Vector2(1f, 1.05f);
        AnimRateODAILevel4 = new Vector2(1.05f, 1.1f);
        OverDriveHpRateAILv1_2 = new Vector4(0.25f, 0.15f, 0.25f, 0.15f);
        ForceOverDriveHpRate = 25;
        MeteorHpTriggerFirst = 70;
        MeteorHpTriggerSecond = 25;
        MeteorSecondStopHpRate = 5;
        OverdriveVoiceWaitSecond = 3f;
        BreakVoiceWaitSecond = 2f;
        BreakDownVoiceWaitSecond = 0.1f;
        MeteorBeginVoiceWaitSecond = 3f;
        MeteorShotVoiceWaitSecond = 1.5f;
        HeadDamageRate = 1.2f;
        FrontDamageRate = 1f;
        BackDamageRate = 1f;
        OverDriveDamageRate = 1f;
        AttackHomingRate = 0.5f;
        AttackHomingAngleMax = 3f;
        ClawHomingRotRate = 0.02f;
        ClawMaxHomingAngle = 30f;
        TackleHomingDegreeOffset = -20f;
        TackleHomingDegreeMax = 60f;
        RoarStartHpRate = 0.012f;
        RoarStackDamageCheckTime = 6000f;
        RoarCoolTime = 10f;
        RoarDamageStackArraySize = 15;
        FireBallAngleX = 80f;
        FireBallDistance = 10f;
        FireBallTargetOffsetY = 1.5f;
        FireBallSpeedAILevel1 = 50f;
        FireBallSpeedAILevel2 = 50f;
        FireBallSpeedAILevel3 = 50f;
        FireBallSpeedAILevel4 = 60f;
        FireBallScale = 1.5f;
        FireBallHomingRate = 0.05f;
        FireBallHomingAngleMax = 3f;
        FireFieldTime = 0.2f;
        FireFieldCreateTime = 1f;
        FireFieldCreateY = 3f;
        FireFieldCreateRate = 0f;
        TrackingMagicCircleAILevelCoolTime = 20f;
        ChaseMagicCircleEnable = false;
        MultipleMagicCircleCoolTimeNormal = 90f;
        MultipleMagicCircleCoolTimeOverDriveFirst = 10f;
        MultipleMagicCircleCoolTimeOverDrive = 30f;
        MultipleMagicCircleCoolTimeMeteor = 10f;
        MeteorForceSetSecond = 50f;
        MeteorShotRotX = 65f;
        MeteorShotRotY = 0f;
        MeteorShotPosY = 40f;
        MeteorShotRadius = 10f;
        MeteorShotSpace = 0.5f;
        MeteorShotSpeedAILevel1 = 15f;
        MeteorShotSpeedAILevel2 = 15f;
        MeteorShotSpeedAILevel3 = 20f;
        MeteorShotSpeedAILevel4 = 25f;
        MeteorShotWaitSecondMin = 0.4f;
        MeteorShotWaitSecondMax = 0.8f;
        MeteorWaitBeginSecond = 0.1f;
        MeteorWaitShotSecond = 0f;
        MeteorWaitEndSecond = 3f;
        MeteorRangeCount = 2;
        MeteorLineScale = new Vector3(1f, 1f, 1f);
        MeteorSignDispSecond = 2.28f;
        MeteorHitDispSecond = 7.5f;
        MeteorHitDispScale = 1f;
        MeteorCameraEnable = false;
        MeteorCameraSecond = 3.5f;
        MeteorDisableHeight = 50f;
        MeteorMaxTotalSecond = 0f;
        MeteorMaxTotalNum = 30;
        TurnBackTurnDegree = 140f;
        TurnLeft90Degree = 75f;
        TurnRight90Degree = -55f;
        TurnLeft180Degree = 140f;
        TurnRight180Degree = -140f;
        ResetStepCoolTimeAILevel1 = 10f;
        ResetStepCoolTimeAILevel2 = 15f;
        ResetStepCoolTimeAILevel3 = 20f;
        ResetStepCoolTimeAILevel4 = 20f;
        ResetStepCheckHeight = 10f;
        ResetStepCheckLength = 20f;
        BreathRetreatSpeed = 5f;
        BreakPartsValue = 1500f;
        ByTheWallDistance = 20f;
        ByTheWallStepMag = 1f;
    }
}
