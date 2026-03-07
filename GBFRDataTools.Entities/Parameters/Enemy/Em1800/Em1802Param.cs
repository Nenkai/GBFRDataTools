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

public class Em1802Param : Em1800Param
{
    [JsonPropertyName("addFreezeTime_")]
    public float AddFreezeTime { get; set; } = 30f;

    [JsonPropertyName("addForceFreezeTime_")]
    public float AddForceFreezeTime { get; set; } = 10f;

    [JsonPropertyName("stepIceBall_FrontDist_")]
    public float StepIceBall_FrontDist { get; set; } = 15f;

    [JsonPropertyName("stepIceBall_MinDist_")]
    public float StepIceBall_MinDist { get; set; } = 5f;

    [JsonPropertyName("stepIceBall_MaxDist_")]
    public float StepIceBall_MaxDist { get; set; } = 25f;

    [JsonPropertyName("stepIceBall_3wayAngle_")]
    public float StepIceBall_3wayAngle { get; set; } = 30f;

    [JsonPropertyName("iceBall_FrontDist_")]
    public float IceBall_FrontDist { get; set; } = 10f;

    [JsonPropertyName("iceBall_MaxAngle_")]
    public float IceBall_MaxAngle { get; set; } = 40f;

    [JsonPropertyName("clawLeftIceSheetPos_")]
    public Vector3 ClawLeftIceSheetPos { get; set; } = new Vector3(5f, 0f, 6f);

    [JsonPropertyName("clawLeftIceSheetRot_")]
    public Vector4 ClawLeftIceSheetRot { get; set; } = new Vector4(0f, 10f, 0f, 0f);

    [JsonPropertyName("clawRightIceSheetPos_")]
    public Vector3 ClawRightIceSheetPos { get; set; } = new Vector3(-5f, 0f, 6f);

    [JsonPropertyName("clawRightIceSheetRot_")]
    public Vector4 ClawRightIceSheetRot { get; set; } = new Vector4(0f, -10f, 0f, 0f);

    [JsonPropertyName("clawTurnLeftIceSheetPos_")]
    public Vector3 ClawTurnLeftIceSheetPos { get; set; } = new Vector3(-7f, 0f, -5f);

    [JsonPropertyName("clawTurnLeftIceSheetRot_")]
    public Vector4 ClawTurnLeftIceSheetRot { get; set; } = new Vector4(0f, -110f, 0f, 0f);

    [JsonPropertyName("clawTurnRightIceSheetPos_")]
    public Vector3 ClawTurnRightIceSheetPos { get; set; } = new Vector3(6f, 0f, 5f);

    [JsonPropertyName("clawTurnRightIceSheetRot_")]
    public Vector4 ClawTurnRightIceSheetRot { get; set; } = new Vector4(0f, -140f, 0f, 0f);

    [JsonPropertyName("clawLeftIceGasPos_")]
    public Vector3 ClawLeftIceGasPos { get; set; } = new Vector3(0f, 0f, 4f);

    [JsonPropertyName("clawRightIceGasPos_")]
    public Vector3 ClawRightIceGasPos { get; set; } = new Vector3(0f, 0f, 4f);

    [JsonPropertyName("clawTurnLeftIceGasPos_")]
    public Vector3 ClawTurnLeftIceGasPos { get; set; } = new Vector3(0f, 0f, 4f);

    [JsonPropertyName("clawTurnRightIceGasPos_")]
    public Vector3 ClawTurnRightIceGasPos { get; set; } = new Vector3(0f, 0f, -4f);

    [JsonPropertyName("clawLeftIceGasRightPos_")]
    public Vector3 ClawLeftIceGasRightPos { get; set; } = new Vector3(4.35f, 0f, 2.8f);

    [JsonPropertyName("clawRightIceGasRightPos_")]
    public Vector3 ClawRightIceGasRightPos { get; set; } = new Vector3(-4.35f, 0f, 2.8f);

    [JsonPropertyName("clawTurnLeftIceGasRightPos_")]
    public Vector3 ClawTurnLeftIceGasRightPos { get; set; } = new Vector3(7.8f, 0f, 2.8f);

    [JsonPropertyName("clawTurnRightIceGasRightPos_")]
    public Vector3 ClawTurnRightIceGasRightPos { get; set; } = new Vector3(-7.8f, 0f, -2.8f);

    [JsonPropertyName("clawLeftIceGasLeftPos_")]
    public Vector3 ClawLeftIceGasLeftPos { get; set; } = new Vector3(-4.35f, 0f, 2.8f);

    [JsonPropertyName("clawRightIceGasLeftPos_")]
    public Vector3 ClawRightIceGasLeftPos { get; set; } = new Vector3(4.35f, 0f, 2.8f);

    [JsonPropertyName("clawTurnLeftIceGasLeftPos_")]
    public Vector3 ClawTurnLeftIceGasLeftPos { get; set; } = new Vector3(-7.8f, 0f, 2.8f);

    [JsonPropertyName("clawTurnRightIceGasLeftPos_")]
    public Vector3 ClawTurnRightIceGasLeftPos { get; set; } = new Vector3(7.8f, 0f, -2.8f);

    [JsonPropertyName("clawIceGasSideYRot_")]
    public float ClawIceGasSideYRot { get; set; } = 45f;

    [JsonPropertyName("proximityBreathFirstPos_")]
    public Vector3 ProximityBreathFirstPos { get; set; } = new Vector3(-7f, 0f, 6f);

    [JsonPropertyName("proximityBreathFirstRot_")]
    public Vector4 ProximityBreathFirstRot { get; set; } = new Vector4(0f, -40f, 0f, 0f);

    [JsonPropertyName("proximityBreathSecondPos_")]
    public Vector3 ProximityBreathSecondPos { get; set; } = new Vector3(-3.5f, 0f, 7.2f);

    [JsonPropertyName("proximityBreathSecondRot_")]
    public Vector4 ProximityBreathSecondRot { get; set; } = new Vector4(0f, 10f, 0f, 0f);

    [JsonPropertyName("proximityBreathThirdPos_")]
    public Vector3 ProximityBreathThirdPos { get; set; } = new Vector3(0.7f, 0f, 6.1f);

    [JsonPropertyName("proximityBreathThirdRot_")]
    public Vector4 ProximityBreathThirdRot { get; set; } = new Vector4(0f, 30f, 0f, 0f);

    [JsonPropertyName("proximityBreathFourthPos_")]
    public Vector3 ProximityBreathFourthPos { get; set; } = new Vector3(5.7f, 0f, 5f);

    [JsonPropertyName("proximityBreathFourthRot_")]
    public Vector4 ProximityBreathFourthRot { get; set; } = new Vector4(0f, -5f, 0f, 0f);

    [JsonPropertyName("beamIceSheetNum_")]
    public int BeamIceSheetNum { get; set; } = 3;

    [JsonPropertyName("beamIceSheetOffsetLength_")]
    public float BeamIceSheetOffsetLength { get; set; } = 26f;

    [JsonPropertyName("beamIceSheetAddRot_")]
    public float BeamIceSheetAddRot { get; set; } = 70f;

    [JsonPropertyName("beamZGapDis_")]
    public float BeamZGapDis { get; set; } = 4.5f;

    [JsonPropertyName("beamSpeedRate_")]
    public float BeamSpeedRate { get; set; } = 1.3f;

    [JsonPropertyName("laserChargeLoopNum_")]
    public int LaserChargeLoopNum { get; set; } = 0;

    [JsonPropertyName("startBaseOffsetLength_")]
    public float StartBaseOffsetLength { get; set; } = 4f;

    [JsonPropertyName("neckOffsetLength_")]
    public float NeckOffsetLength { get; set; } = 4f;

    [JsonPropertyName("laserSpeedRate_")]
    public float LaserSpeedRate { get; set; } = 2f;

    [JsonPropertyName("laserExplodeSizeMag_")]
    public float LaserExplodeSizeMag { get; set; } = 4f;

    [JsonPropertyName("laserAfterFrostWaitTime_")]
    public float LaserAfterFrostWaitTime { get; set; } = 0.15f;

    [JsonPropertyName("laserCoolTime_")]
    public float LaserCoolTime { get; set; } = 10f;

    [JsonPropertyName("weakIceLaserSpeedRate_")]
    public float WeakIceLaserSpeedRate { get; set; } = 3f;

    [JsonPropertyName("iceLanceCoolTime_")]
    public float IceLanceCoolTime { get; set; } = 20f;

    [JsonPropertyName("iceLancePosFirst_")]
    public Vector3 IceLancePosFirst { get; set; } = new Vector3(9f, 14f, -5f);

    [JsonPropertyName("iceLancePosThird_")]
    public Vector3 IceLancePosThird { get; set; } = new Vector3(7f, 11.5f, -1f);

    [JsonPropertyName("iceLancePosFifth_")]
    public Vector3 IceLancePosFifth { get; set; } = new Vector3(5f, 13f, -4f);

    [JsonPropertyName("iceLancePosSeventh_")]
    public Vector3 IceLancePosSeventh { get; set; } = new Vector3(4f, 10f, -2f);

    [JsonPropertyName("iceLancePosNineth_")]
    public Vector3 IceLancePosNineth { get; set; } = new Vector3(2f, 11.5f, 1f);

    [JsonPropertyName("leaveActionChangeTriggerHP_")]
    public int LeaveActionChangeTriggerHP { get; set; } = 75;

    [JsonPropertyName("leaveActionCoolTime_")]
    public float LeaveActionCoolTime { get; set; } = 15f;

    [JsonPropertyName("leaveFirstWeakActionCoolTime_")]
    public float LeaveFirstWeakActionCoolTime { get; set; } = 20f;

    [JsonPropertyName("leaveFirstStrongActionCoolTime_")]
    public float LeaveFirstStrongActionCoolTime { get; set; } = 35f;

    [JsonPropertyName("leaveSecondWeakActionCoolTime_")]
    public float LeaveSecondWeakActionCoolTime { get; set; } = 20f;

    [JsonPropertyName("leaveSecondStrongActionCoolTime_")]
    public float LeaveSecondStrongActionCoolTime { get; set; } = 30f;

    [JsonPropertyName("lanceCircleRadius_")]
    public float LanceCircleRadius { get; set; } = 15f;

    [JsonPropertyName("lanceCircleHeight_")]
    public float LanceCircleHeight { get; set; } = 0f;

    [JsonPropertyName("lanceShotIntervalTime_")]
    public float LanceShotIntervalTime { get; set; } = 1.5f;

    [JsonPropertyName("lanceGapTime_")]
    public float LanceGapTime { get; set; } = 0.1f;

    [JsonPropertyName("lanceRegenerationTime_")]
    public float LanceRegenerationTime { get; set; } = 1f;

    [JsonPropertyName("lanceLoopNum_")]
    public int LanceLoopNum { get; set; } = 4;

    [JsonPropertyName("laserWaitTime_")]
    public float LaserWaitTime { get; set; } = 2.7f;

    [JsonPropertyName("subBombRadius_")]
    public float SubBombRadius { get; set; } = 0.8f;

    [JsonPropertyName("iceBombFirstWaitTimeAILv3_4_")]
    public Vector2 IceBombFirstWaitTimeAILv3_4 { get; set; } = new Vector2(1f, 1f);

    [JsonPropertyName("iceBombThirdWaitTimeAILv3_4_")]
    public Vector2 IceBombThirdWaitTimeAILv3_4 { get; set; } = new Vector2(0.8f, 0.8f);

    [JsonPropertyName("iceBombFifthWaitTimeAILv3_4_")]
    public Vector2 IceBombFifthWaitTimeAILv3_4 { get; set; } = new Vector2(0.6f, 0.6f);

    [JsonPropertyName("iceBombSeventhWaitTimeAILv3_4_")]
    public Vector2 IceBombSeventhWaitTimeAILv3_4 { get; set; } = new Vector2(0.4f, 0.4f);

    [JsonPropertyName("iceBombFirstVelocityAILv3_4_")]
    public Vector2 IceBombFirstVelocityAILv3_4 { get; set; } = new Vector2(20f, 20f);

    [JsonPropertyName("iceBombThirdVelocityAILv3_4_")]
    public Vector2 IceBombThirdVelocityAILv3_4 { get; set; } = new Vector2(25f, 25f);

    [JsonPropertyName("iceBombFifthVelocityAILv3_4_")]
    public Vector2 IceBombFifthVelocityAILv3_4 { get; set; } = new Vector2(30f, 30f);

    [JsonPropertyName("iceBombSeventhVelocityAILv3_4_")]
    public Vector2 IceBombSeventhVelocityAILv3_4 { get; set; } = new Vector2(35f, 35f);

    [JsonPropertyName("underBreathFirstPos_")]
    public Vector3 UnderBreathFirstPos { get; set; } = new Vector3(-5f, 0f, 12f);

    [JsonPropertyName("underBreathFirstRot_")]
    public Vector4 UnderBreathFirstRot { get; set; } = new Vector4(0f, 10f, 0f, 0f);

    [JsonPropertyName("underBreathSecondPos_")]
    public Vector3 UnderBreathSecondPos { get; set; } = new Vector3(3.5f, 0f, 9f);

    [JsonPropertyName("underBreathSecondRot_")]
    public Vector4 UnderBreathSecondRot { get; set; } = new Vector4(0f, 35f, 0f, 0f);

    [JsonPropertyName("underBreathThirdPos_")]
    public Vector3 UnderBreathThirdPos { get; set; } = new Vector3(3.9f, 0f, 8.9f);

    [JsonPropertyName("underBreathThirdRot_")]
    public Vector4 UnderBreathThirdRot { get; set; } = new Vector4(0f, 80f, 0f, 0f);

    [JsonPropertyName("toCenterOffset_")]
    public Vector3 ToCenterOffset { get; set; } = new Vector3(0f, 0f, 5f);

    [JsonPropertyName("normalArrangementGapAngle_")]
    public float NormalArrangementGapAngle { get; set; } = 40f;

    [JsonPropertyName("normalArrangementRadius_")]
    public float NormalArrangementRadius { get; set; } = 15f;

    [JsonPropertyName("odNearMinePos_")]
    public Vector3 OdNearMinePos { get; set; } = new Vector3(0f, 0f, 8f);

    [JsonPropertyName("odNearMineAddZPos_")]
    public float OdNearMineAddZPos { get; set; } = 12f;

    [JsonPropertyName("odLeftMinePos_")]
    public Vector3 OdLeftMinePos { get; set; } = new Vector3(-12f, 0f, 15f);

    [JsonPropertyName("stepDisMag_")]
    public float StepDisMag { get; set; } = 0.25f;

    [JsonPropertyName("iceBeamSpeedRate_")]
    public float IceBeamSpeedRate { get; set; } = 1.4f;

    [JsonPropertyName("iceLaserPreparationSpeedRate_")]
    public float IceLaserPreparationSpeedRate { get; set; } = 2.1f;

    public Em1802Param()
    {
        Hp = 150000;
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
        FireFieldTime = 0.05f;
        FireFieldCreateTime = 0.018f;
        FireFieldCreateY = 3f;
        FireFieldCreateRate = 0.02f;
        TrackingMagicCircleAILevelCoolTime = 20f;
        ChaseMagicCircleEnable = false;
        MultipleMagicCircleCoolTimeNormal = 90f;
        MultipleMagicCircleCoolTimeOverDriveFirst = 10f;
        MultipleMagicCircleCoolTimeOverDrive = 30f;
        MultipleMagicCircleCoolTimeMeteor = 10f;
        MeteorForceSetSecond = 50f;
        MeteorShotRotX = 65f;
        MeteorShotRotY = 0f;
        MeteorShotPosY = 30f;
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
        MeteorSignDispSecond = 2f;
        MeteorHitDispSecond = 7.5f;
        MeteorHitDispScale = 1f;
        MeteorCameraEnable = false;
        MeteorCameraSecond = 3.5f;
        MeteorDisableHeight = 5f;
        MeteorMaxTotalSecond = 50f;
        MeteorMaxTotalNum = 0;
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
        ByTheWallStepMag = 0.75f;
    }
}
