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

public class Em1800Param : EmBossBaseParam
{
    [JsonPropertyName("closeLength_")]
    public float CloseLength { get; set; } = 11f;

    [JsonPropertyName("middleLength_")]
    public float MiddleLength { get; set; } = 16f;

    [JsonPropertyName("FrontAngle_")]
    public int FrontAngle { get; set; } = 45;

    [JsonPropertyName("aroundSearchLength_")]
    public float AroundSearchLength { get; set; } = 16f;

    [JsonPropertyName("badStatusHate_")]
    public int BadStatusHate { get; set; } = 10000;

    [JsonPropertyName("isDeleteMagicCircleEvent_")]
    public bool IsDeleteMagicCircleEvent { get; set; } = true;

    [JsonPropertyName("animRateODAILevel1_")]
    public Vector2 AnimRateODAILevel1 { get; set; } = new Vector2(1f, 1f);

    [JsonPropertyName("animRateODAILevel2_")]
    public Vector2 AnimRateODAILevel2 { get; set; } = new Vector2(1f, 1f);

    [JsonPropertyName("animRateODAILevel3_")]
    public Vector2 AnimRateODAILevel3 { get; set; } = new Vector2(1f, 1.05f);

    [JsonPropertyName("animRateODAILevel4_")]
    public Vector2 AnimRateODAILevel4 { get; set; } = new Vector2(1.05f, 1.1f);

    [JsonPropertyName("overDriveHpRateAILv1_2_")]
    public Vector4 OverDriveHpRateAILv1_2 { get; set; } = new Vector4(0.25f, 0.15f, 0.25f, 0.15f);

    [JsonPropertyName("forceOverDriveHpRate_")]
    public int ForceOverDriveHpRate { get; set; } = 25;

    [JsonPropertyName("meteorHpTriggerFirst_")]
    public int MeteorHpTriggerFirst { get; set; } = 70;

    [JsonPropertyName("meteorHpTriggerSecond_")]
    public int MeteorHpTriggerSecond { get; set; } = 25;

    [JsonPropertyName("meteorSecondStopHpRate_")]
    public int MeteorSecondStopHpRate { get; set; } = 5;

    [JsonPropertyName("overdriveVoiceWaitSecond_")]
    public float OverdriveVoiceWaitSecond { get; set; } = 3f;

    [JsonPropertyName("breakVoiceWaitSecond_")]
    public float BreakVoiceWaitSecond { get; set; } = 2f;

    [JsonPropertyName("breakDownVoiceWaitSecond_")]
    public float BreakDownVoiceWaitSecond { get; set; } = 0.1f;

    [JsonPropertyName("meteorBeginVoiceWaitSecond_")]
    public float MeteorBeginVoiceWaitSecond { get; set; } = 3f;

    [JsonPropertyName("meteorShotVoiceWaitSecond_")]
    public float MeteorShotVoiceWaitSecond { get; set; } = 1.5f;

    [JsonPropertyName("headDamageRate_")]
    public float HeadDamageRate { get; set; } = 1.2f;

    [JsonPropertyName("frontDamageRate_")]
    public float FrontDamageRate { get; set; } = 1f;

    [JsonPropertyName("backDamageRate_")]
    public float BackDamageRate { get; set; } = 1f;

    [JsonPropertyName("overDriveDamageRate_")]
    public float OverDriveDamageRate { get; set; } = 1f;

    [JsonPropertyName("attackHomingRate_")]
    public float AttackHomingRate { get; set; } = 0.5f;

    [JsonPropertyName("attackHomingAngleMax_")]
    public float AttackHomingAngleMax { get; set; } = 3f;

    [JsonPropertyName("clawHomingRotRate_")]
    public float ClawHomingRotRate { get; set; } = 0.02f;

    [JsonPropertyName("clawMaxHomingAngle_")]
    public float ClawMaxHomingAngle { get; set; } = 30f;

    [JsonPropertyName("tackleHomingDegreeOffset_")]
    public float TackleHomingDegreeOffset { get; set; } = -20f;

    [JsonPropertyName("tackleHomingDegreeMax_")]
    public float TackleHomingDegreeMax { get; set; } = 60f;

    [JsonPropertyName("roarStartHpRate_")]
    public float RoarStartHpRate { get; set; } = 0.012f;

    [JsonPropertyName("roarStackDamageCheckTime_")]
    public float RoarStackDamageCheckTime { get; set; } = 6000f;

    [JsonPropertyName("roarCoolTime_")]
    public float RoarCoolTime { get; set; } = 10f;

    [JsonPropertyName("roarDamageStackArraySize_")]
    public int RoarDamageStackArraySize { get; set; } = 15;

    [JsonPropertyName("fireBallAngleX_")]
    public float FireBallAngleX { get; set; } = 80f;

    [JsonPropertyName("fireBallDistance_")]
    public float FireBallDistance { get; set; } = 10f;

    [JsonPropertyName("fireBallTargetOffsetY_")]
    public float FireBallTargetOffsetY { get; set; } = 1.5f;

    [JsonPropertyName("fireBallSpeedAILevel1_")]
    public float FireBallSpeedAILevel1 { get; set; } = 50f;

    [JsonPropertyName("fireBallSpeedAILevel2_")]
    public float FireBallSpeedAILevel2 { get; set; } = 50f;

    [JsonPropertyName("fireBallSpeedAILevel3_")]
    public float FireBallSpeedAILevel3 { get; set; } = 50f;

    [JsonPropertyName("fireBallSpeedAILevel4_")]
    public float FireBallSpeedAILevel4 { get; set; } = 70f;

    [JsonPropertyName("fireBallScale_")]
    public float FireBallScale { get; set; } = 1.5f;

    [JsonPropertyName("fireBallHomingRate_")]
    public float FireBallHomingRate { get; set; } = 0.05f;

    [JsonPropertyName("fireBallHomingAngleMax_")]
    public float FireBallHomingAngleMax { get; set; } = 3f;

    [JsonPropertyName("fireFieldTime_")]
    public float FireFieldTime { get; set; } = 0.05f;

    [JsonPropertyName("fireFieldCreateTime_")]
    public float FireFieldCreateTime { get; set; } = 0.018f;

    [JsonPropertyName("fireFieldCreateY_")]
    public float FireFieldCreateY { get; set; } = 3f;

    [JsonPropertyName("fireFieldCreateRate_")]
    public float FireFieldCreateRate { get; set; } = 0.02f;

    [JsonPropertyName("trackingMagicCircleAILevelCoolTime_")]
    public float TrackingMagicCircleAILevelCoolTime { get; set; } = 20f;

    [JsonPropertyName("chaseMagicCircleEnable_")]
    public bool ChaseMagicCircleEnable { get; set; } = false;

    [JsonPropertyName("chaseMagicCirclePresageParam_")]
    public Em1800MagicCircleParam ChaseMagicCirclePresageParam { get; set; }

    [JsonPropertyName("chaseMagicCircleNormalParam_")]
    public Em1800MagicCircleParam ChaseMagicCircleNormalParam { get; set; }

    [JsonPropertyName("chaseMagicCircleOverDriveParam_")]
    public Em1800MagicCircleParam ChaseMagicCircleOverDriveParam { get; set; }

    [JsonPropertyName("multipleMagicCircleCoolTimeNormal_")]
    public float MultipleMagicCircleCoolTimeNormal { get; set; } = 90f;

    [JsonPropertyName("multipleMagicCircleCoolTimeOverDriveFirst_")]
    public float MultipleMagicCircleCoolTimeOverDriveFirst { get; set; } = 10f;

    [JsonPropertyName("multipleMagicCircleCoolTimeOverDrive_")]
    public float MultipleMagicCircleCoolTimeOverDrive { get; set; } = 30f;

    [JsonPropertyName("multipleMagicCircleCoolTimeMeteor_")]
    public float MultipleMagicCircleCoolTimeMeteor { get; set; } = 10f;

    [JsonPropertyName("meteorForceSetSecond_")]
    public float MeteorForceSetSecond { get; set; } = 50f;

    [JsonPropertyName("meteorShotRotX_")]
    public float MeteorShotRotX { get; set; } = 65f;

    [JsonPropertyName("meteorShotRotY_")]
    public float MeteorShotRotY { get; set; } = 0f;

    [JsonPropertyName("meteorShotPosY_")]
    public float MeteorShotPosY { get; set; } = 40f;

    [JsonPropertyName("meteorShotRadius_")]
    public float MeteorShotRadius { get; set; } = 10f;

    [JsonPropertyName("meteorShotSpace_")]
    public float MeteorShotSpace { get; set; } = 0.5f;

    [JsonPropertyName("meteorShotSpeedAILevel1_")]
    public float MeteorShotSpeedAILevel1 { get; set; } = 15f;

    [JsonPropertyName("meteorShotSpeedAILevel2_")]
    public float MeteorShotSpeedAILevel2 { get; set; } = 15f;

    [JsonPropertyName("meteorShotSpeedAILevel3_")]
    public float MeteorShotSpeedAILevel3 { get; set; } = 20f;

    [JsonPropertyName("meteorShotSpeedAILevel4_")]
    public float MeteorShotSpeedAILevel4 { get; set; } = 25f;

    [JsonPropertyName("meteorShotWaitSecondMin_")]
    public float MeteorShotWaitSecondMin { get; set; } = 0.4f;

    [JsonPropertyName("meteorShotWaitSecondMax_")]
    public float MeteorShotWaitSecondMax { get; set; } = 0.8f;

    [JsonPropertyName("meteorWaitBeginSecond_")]
    public float MeteorWaitBeginSecond { get; set; } = 0.1f;

    [JsonPropertyName("meteorWaitShotSecond_")]
    public float MeteorWaitShotSecond { get; set; } = 0f;

    [JsonPropertyName("meteorWaitEndSecond_")]
    public float MeteorWaitEndSecond { get; set; } = 3f;

    [JsonPropertyName("meteorRangeCount_")]
    public int MeteorRangeCount { get; set; } = 2;

    [JsonPropertyName("meteorLineScale_")]
    public Vector3 MeteorLineScale { get; set; } = new Vector3(1f, 1f, 1f);

    [JsonPropertyName("meteorSignDispSecond_")]
    public float MeteorSignDispSecond { get; set; } = 2.28f;

    [JsonPropertyName("meteorHitDispSecond_")]
    public float MeteorHitDispSecond { get; set; } = 7.5f;

    [JsonPropertyName("meteorHitDispScale_")]
    public float MeteorHitDispScale { get; set; } = 1f;

    [JsonPropertyName("meteorCameraEnable_")]
    public bool MeteorCameraEnable { get; set; } = false;

    [JsonPropertyName("meteorCameraSecond_")]
    public float MeteorCameraSecond { get; set; } = 3.5f;

    [JsonPropertyName("meteorDisableHeight_")]
    public float MeteorDisableHeight { get; set; } = 5f;

    [JsonPropertyName("meteorMaxTotalSecond_")]
    public float MeteorMaxTotalSecond { get; set; } = 50f;

    [JsonPropertyName("meteorMaxTotalNum_")]
    public int MeteorMaxTotalNum { get; set; } = 0;

    [JsonPropertyName("meteorCameraAttachParam_")]
    public CameraBattleCutsceneAttachParam MeteorCameraAttachParam { get; set; }

    [JsonPropertyName("turnBackTurnDegree_")]
    public float TurnBackTurnDegree { get; set; } = 140f;

    [JsonPropertyName("turnLeft90Degree_")]
    public float TurnLeft90Degree { get; set; } = 75f;

    [JsonPropertyName("turnRight90Degree_")]
    public float TurnRight90Degree { get; set; } = -55f;

    [JsonPropertyName("turnLeft180Degree_")]
    public float TurnLeft180Degree { get; set; } = 140f;

    [JsonPropertyName("turnRight180Degree_")]
    public float TurnRight180Degree { get; set; } = -140f;

    [JsonPropertyName("resetStepCoolTimeAILevel1_")]
    public float ResetStepCoolTimeAILevel1 { get; set; } = 10f;

    [JsonPropertyName("resetStepCoolTimeAILevel2_")]
    public float ResetStepCoolTimeAILevel2 { get; set; } = 15f;

    [JsonPropertyName("resetStepCoolTimeAILevel3_")]
    public float ResetStepCoolTimeAILevel3 { get; set; } = 20f;

    [JsonPropertyName("resetStepCoolTimeAILevel4_")]
    public float ResetStepCoolTimeAILevel4 { get; set; } = 20f;

    [JsonPropertyName("resetStepCheckHeight_")]
    public float ResetStepCheckHeight { get; set; } = 10f;

    [JsonPropertyName("resetStepCheckLength_")]
    public float ResetStepCheckLength { get; set; } = 20f;

    [JsonPropertyName("beamParam_")]
    public EmHitBreathParam BeamParam { get; set; }

    [JsonPropertyName("breathParam_")]
    public EmHitBreathParam BreathParam { get; set; }

    [JsonPropertyName("breathDirectlyBelowParam_")]
    public EmHitBreathParam BreathDirectlyBelowParam { get; set; }

    [JsonPropertyName("breathRetreatSpeed_")]
    public float BreathRetreatSpeed { get; set; } = 5f;

    [JsonPropertyName("attackParam_smallMagicCircle_")]
    public BossAttackParam AttackParam_smallMagicCircle { get; set; }

    [JsonPropertyName("attackParam_multipleMagicCircle_")]
    public BossAttackParam AttackParam_multipleMagicCircle { get; set; }

    [JsonPropertyName("attackParam_fireBallAILevel1_")]
    public BossAttackParam AttackParam_fireBallAILevel1 { get; set; }

    [JsonPropertyName("attackParam_fireBallAILevel2_")]
    public BossAttackParam AttackParam_fireBallAILevel2 { get; set; }

    [JsonPropertyName("attackParam_fireBallAILevel3_")]
    public BossAttackParam AttackParam_fireBallAILevel3 { get; set; }

    [JsonPropertyName("attackParam_fireBallAILevel4_")]
    public BossAttackParam AttackParam_fireBallAILevel4 { get; set; }

    [JsonPropertyName("attackParam_fireBreathAILevel1_")]
    public BossAttackParam AttackParam_fireBreathAILevel1 { get; set; }

    [JsonPropertyName("attackParam_fireBreathAILevel2_")]
    public BossAttackParam AttackParam_fireBreathAILevel2 { get; set; }

    [JsonPropertyName("attackParam_fireBreathAILevel3_")]
    public BossAttackParam AttackParam_fireBreathAILevel3 { get; set; }

    [JsonPropertyName("attackParam_fireBreathAILevel4_")]
    public BossAttackParam AttackParam_fireBreathAILevel4 { get; set; }

    [JsonPropertyName("attackParam_skyFireBreath_")]
    public BossAttackParam AttackParam_skyFireBreath { get; set; }

    [JsonPropertyName("attackParam_stepFireBall_")]
    public BossAttackParam AttackParam_stepFireBall { get; set; }

    [JsonPropertyName("attackParam_meteor_")]
    public BossAttackParam AttackParam_meteor { get; set; }

    [JsonPropertyName("attackParam_beam_")]
    public BossAttackParam AttackParam_beam { get; set; }

    [JsonPropertyName("addDamageParam_")]
    public EmAddDamageParam AddDamageParam { get; set; }

    [JsonPropertyName("breakPartsValue_")]
    public float BreakPartsValue { get; set; } = 1500f;

    [JsonPropertyName("breakPartsSeName_")]
    public string BreakPartsSeName { get; set; }

    [JsonPropertyName("partsBreakWeakPointParam_")]
    public EmWeakPointParam PartsBreakWeakPointParam { get; set; }

    [JsonPropertyName("byTheWallDistance_")]
    public float ByTheWallDistance { get; set; } = 20f;

    [JsonPropertyName("byTheWallStepMag_")]
    public float ByTheWallStepMag { get; set; } = 1f;

    public Em1800Param()
    {
        Hp = 300000;
        Atk = 1500;
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
        HateRateFirstTargetPlayer = 0;
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
        IsDisableAerialDownReaction = false;
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
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em1800MagicCircleParam
{
    [JsonPropertyName("waitSecond_")]
    public float WaitSecond { get; set; } // Offset 0x18

    [JsonPropertyName("changeScaleSecond_")]
    public float ChangeScaleSecond { get; set; } // Offset 0x1C

    [JsonPropertyName("startScale_")]
    public float StartScale { get; set; } // Offset 0x20

    [JsonPropertyName("endScale_")]
    public float EndScale { get; set; } // Offset 0x24

    [JsonPropertyName("moveSecondMin_")]
    public float MoveSecondMin { get; set; } // Offset 0x28

    [JsonPropertyName("moveSecondMax_")]
    public float MoveSecondMax { get; set; } // Offset 0x2C

    [JsonPropertyName("moveSecond_")]
    public float MoveSecond { get; set; } // Offset 0x30

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } // Offset 0x34

    [JsonPropertyName("warningSecond_")]
    public float WarningSecond { get; set; } // Offset 0x38

    [JsonPropertyName("attackSecond_")]
    public float AttackSecond { get; set; } // Offset 0x3C

    [JsonPropertyName("attackPower_")]
    public float AttackPower { get; set; } // Offset 0x40

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } // Offset 0x44

    [JsonPropertyName("breakPower_")]
    public float BreakPower { get; set; } // Offset 0x48

    [JsonPropertyName("attackWaitSecond_")]
    public float AttackWaitSecond { get; set; } // Offset 0x4C

    [JsonPropertyName("attackCheckDist_")]
    public float AttackCheckDist { get; set; } // Offset 0x50

    [JsonPropertyName("color_")]
    public int Color { get; set; } // Offset 0x54

    [JsonPropertyName("isCustomEffect_")]
    public bool IsCustomEffect { get; set; } // Offset 0x58

    [JsonPropertyName("moveEstId_")]
    public int MoveEstId { get; set; } // Offset 0x5C

    [JsonPropertyName("omenEstId_")]
    public int OmenEstId { get; set; } // Offset 0x60

    [JsonPropertyName("attackEstId_")]
    public int AttackEstId { get; set; } // Offset 0x64

    [JsonPropertyName("isStartOwnerPos_")]
    public bool IsStartOwnerPos { get; set; } // Offset 0x68

    [JsonPropertyName("rebootAttackMoveNum_")]
    public int RebootAttackMoveNum { get; set; } // Offset 0x6C

    [JsonPropertyName("rebootWaitSecond_")]
    public float RebootWaitSecond { get; set; } // Offset 0x70

    [JsonPropertyName("omenStartSeDefineName_")]
    public string OmenStartSeDefineName { get; set; } // Offset 0x78

    [JsonPropertyName("attackSeDefineName_")]
    public string AttackSeDefineName { get; set; } // Offset 0x98

    [JsonPropertyName("isTargetPointOmen_")]
    public bool IsTargetPointOmen { get; set; } // Offset 0xB8

    [JsonPropertyName("targetPointOmenSpd_")]
    public float TargetPointOmenSpd { get; set; } // Offset 0xBC

    [JsonPropertyName("targetPointOmenMoveSec_")]
    public float TargetPointOmenMoveSec { get; set; } // Offset 0xC0

    public Em1800MagicCircleParam()
    {
    }
}