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

public class Em1804Param : Em1800Param
{
    [JsonPropertyName("breathWait_")]
    public float BreathWait { get; set; } = 0.07f;

    [JsonPropertyName("flappingWingsPower_")]
    public float FlappingWingsPower { get; set; } = 0.1f;

    [JsonPropertyName("flappingWingsRange_")]
    public float FlappingWingsRange { get; set; } = 29.5f;

    [JsonPropertyName("flappingWingsCoolTime_")]
    public Vector2 FlappingWingsCoolTime { get; set; } = new Vector2(20f, 20f);

    [JsonPropertyName("clawLeftTwister_")]
    public TwisterParam ClawLeftTwister { get; set; }

    [JsonPropertyName("clawRightTwister_")]
    public TwisterParam ClawRightTwister { get; set; }

    [JsonPropertyName("clawTurnLeftTwister_")]
    public TwisterParam ClawTurnLeftTwister { get; set; }

    [JsonPropertyName("clawTurnRightTwister_")]
    public TwisterParam ClawTurnRightTwister { get; set; }

    [JsonPropertyName("flapFirstRightTwister_")]
    public SingleTwisterParam FlapFirstRightTwister { get; set; }

    [JsonPropertyName("flapSecondRightTwister_")]
    public SingleTwisterParam FlapSecondRightTwister { get; set; }

    [JsonPropertyName("flapThirdRightTwister_")]
    public SingleTwisterParam FlapThirdRightTwister { get; set; }

    [JsonPropertyName("flapFirstLeftTwister_")]
    public SingleTwisterParam FlapFirstLeftTwister { get; set; }

    [JsonPropertyName("flapSecondLeftTwister_")]
    public SingleTwisterParam FlapSecondLeftTwister { get; set; }

    [JsonPropertyName("flapThirdLeftTwister_")]
    public SingleTwisterParam FlapThirdLeftTwister { get; set; }

    [JsonPropertyName("cycloneCreateAILevel1_")]
    public float CycloneCreateAILevel1 { get; set; } = 180f;

    [JsonPropertyName("cycloneCreateAILevel2_")]
    public float CycloneCreateAILevel2 { get; set; } = 135f;

    [JsonPropertyName("cycloneCreateAILevel3_")]
    public float CycloneCreateAILevel3 { get; set; } = 90f;

    [JsonPropertyName("cycloneCreateAILevel4_")]
    public float CycloneCreateAILevel4 { get; set; } = 45f;

    [JsonPropertyName("cycloneResetStepDis_")]
    public float CycloneResetStepDis { get; set; } = 6f;

    [JsonPropertyName("cycloneSyncTime_")]
    public float CycloneSyncTime { get; set; } = 0.5f;

    [JsonPropertyName("cycloneDeadPlayerRange_")]
    public float CycloneDeadPlayerRange { get; set; } = 8f;

    [JsonPropertyName("dragonicCycloneOccurrencePos_")]
    public float DragonicCycloneOccurrencePos { get; set; } = 15f;

    [JsonPropertyName("dragonicCycloneTime_")]
    public float DragonicCycloneTime { get; set; } = 15f;

    [JsonPropertyName("dragonicCycloneShortPowerAiLv3_4_")]
    public Vector2 DragonicCycloneShortPowerAiLv3_4 { get; set; } = new Vector2(0.05f, 0.05f);

    [JsonPropertyName("dragonicCycloneMediumPowerAiLv3_4_")]
    public Vector2 DragonicCycloneMediumPowerAiLv3_4 { get; set; } = new Vector2(0.07f, 0.07f);

    [JsonPropertyName("dragonicCycloneLongPowerAiLv3_4_")]
    public Vector2 DragonicCycloneLongPowerAiLv3_4 { get; set; } = new Vector2(0.08f, 0.12f);

    [JsonPropertyName("dragonicCycloneNoWindDistance_")]
    public float DragonicCycloneNoWindDistance { get; set; } = 5f;

    [JsonPropertyName("dragonicCycloneShortMediumDistance_")]
    public float DragonicCycloneShortMediumDistance { get; set; } = 12.5f;

    [JsonPropertyName("dragonicCycloneMediumLongDistance_")]
    public float DragonicCycloneMediumLongDistance { get; set; } = 23f;

    [JsonPropertyName("dragonicCycloneFinishTime_")]
    public float DragonicCycloneFinishTime { get; set; } = 0.5f;

    [JsonPropertyName("dragonicCycloneFinishCoefficientAILevel1_")]
    public float DragonicCycloneFinishCoefficientAILevel1 { get; set; } = 0.5f;

    [JsonPropertyName("dragonicCycloneFinishCoefficientAILevel2_")]
    public float DragonicCycloneFinishCoefficientAILevel2 { get; set; } = 0.5f;

    [JsonPropertyName("dragonicCycloneFinishCoefficientAILevel3_")]
    public float DragonicCycloneFinishCoefficientAILevel3 { get; set; } = 0.75f;

    [JsonPropertyName("dragonicCycloneFinishCoefficientAILevel4_")]
    public float DragonicCycloneFinishCoefficientAILevel4 { get; set; } = 0.75f;

    [JsonPropertyName("dragonicCycloneCreateTwisterTime_")]
    public float DragonicCycloneCreateTwisterTime { get; set; } = 1.35f;

    [JsonPropertyName("dragonicCycloneCreateTwisterNumAILevel1_")]
    public int DragonicCycloneCreateTwisterNumAILevel1 { get; set; } = 11;

    [JsonPropertyName("dragonicCycloneCreateTwisterNumAILevel2_")]
    public int DragonicCycloneCreateTwisterNumAILevel2 { get; set; } = 11;

    [JsonPropertyName("dragonicCycloneCreateTwisterNumAILevel3_")]
    public int DragonicCycloneCreateTwisterNumAILevel3 { get; set; } = 17;

    [JsonPropertyName("dragonicCycloneCreateTwisterNumAILevel4_")]
    public int DragonicCycloneCreateTwisterNumAILevel4 { get; set; } = 17;

    [JsonPropertyName("dragonicCycloneCreateAngle_")]
    public float DragonicCycloneCreateAngle { get; set; } = 37f;

    [JsonPropertyName("dragonicCycloneTwisterExplodeDisSolo_")]
    public float DragonicCycloneTwisterExplodeDisSolo { get; set; } = 33f;

    [JsonPropertyName("dragonicCycloneTwisterDistanceDecelerationTime_")]
    public float DragonicCycloneTwisterDistanceDecelerationTime { get; set; } = 1f;

    [JsonPropertyName("dragonicCycloneTwisterFinishTime_")]
    public float DragonicCycloneTwisterFinishTime { get; set; } = 5.15f;

    [JsonPropertyName("dragonicCycloneTwisterFinishDecelerationTime_")]
    public float DragonicCycloneTwisterFinishDecelerationTime { get; set; } = 1.5f;

    [JsonPropertyName("dragonicCycloneTwisterFinishExplodeTime_")]
    public float DragonicCycloneTwisterFinishExplodeTime { get; set; } = 2f;

    [JsonPropertyName("jumpBreathWindFlinchOffset_")]
    public Vector3 JumpBreathWindFlinchOffset { get; set; } = new Vector3(1.5f, 0f, 6f);

    [JsonPropertyName("jumpBallFrontWindFlinchOffset_")]
    public Vector3 JumpBallFrontWindFlinchOffset { get; set; } = new Vector3(-1.5f, 0f, 6f);

    [JsonPropertyName("jumpBallLeftWindFlinchOffset_")]
    public Vector3 JumpBallLeftWindFlinchOffset { get; set; } = new Vector3(1.5f, 0f, 7f);

    [JsonPropertyName("jumpBallRightWindFlinchOffset_")]
    public Vector3 JumpBallRightWindFlinchOffset { get; set; } = new Vector3(1.5f, 0f, 7f);

    [JsonPropertyName("jumpBallLeftWindFlinchRot_")]
    public float JumpBallLeftWindFlinchRot { get; set; } = -30f;

    [JsonPropertyName("jumpBallRightWindFlinchRot_")]
    public float JumpBallRightWindFlinchRot { get; set; } = 0f;

    [JsonPropertyName("windBeamWaitTime_")]
    public float WindBeamWaitTime { get; set; } = 0.12f;

    [JsonPropertyName("counterTriggerDis_")]
    public float CounterTriggerDis { get; set; } = 2f;

    [JsonPropertyName("counterTwisterNum_")]
    public int CounterTwisterNum { get; set; } = 5;

    [JsonPropertyName("counterFirstTwisterPos_")]
    public Vector3 CounterFirstTwisterPos { get; set; } = new Vector3(-8.967f, 0f, -15.201f);

    [JsonPropertyName("counterFirstTwisterRotY_")]
    public float CounterFirstTwisterRotY { get; set; } = -31.527f;

    [JsonPropertyName("counterFirstTwisterIsLeft_")]
    public bool CounterFirstTwisterIsLeft { get; set; } = true;

    [JsonPropertyName("counterSecondTwisterPos_")]
    public Vector3 CounterSecondTwisterPos { get; set; } = new Vector3(4.04f, 0f, 10.939f);

    [JsonPropertyName("counterSecondTwisterRotY_")]
    public float CounterSecondTwisterRotY { get; set; } = 89.908f;

    [JsonPropertyName("counterSecondTwisterIsLeft_")]
    public bool CounterSecondTwisterIsLeft { get; set; } = true;

    [JsonPropertyName("counterThirdTwisterPos_")]
    public Vector3 CounterThirdTwisterPos { get; set; } = new Vector3(22.076f, 0f, 1.204f);

    [JsonPropertyName("counterThirdTwisterRotY_")]
    public float CounterThirdTwisterRotY { get; set; } = 150.911f;

    [JsonPropertyName("counterThirdTwisterIsLeft_")]
    public bool CounterThirdTwisterIsLeft { get; set; } = true;

    [JsonPropertyName("counterFourthTwisterPos_")]
    public Vector3 CounterFourthTwisterPos { get; set; } = new Vector3(25.413f, 0f, -15.673f);

    [JsonPropertyName("counterFourthTwisterRotY_")]
    public float CounterFourthTwisterRotY { get; set; } = -168.336f;

    [JsonPropertyName("counterFourthTwisterIsLeft_")]
    public bool CounterFourthTwisterIsLeft { get; set; } = true;

    [JsonPropertyName("counterFifthTwisterPos_")]
    public Vector3 CounterFifthTwisterPos { get; set; } = new Vector3(12.885f, 0f, -26.32f);

    [JsonPropertyName("counterFifthTwisterRotY_")]
    public float CounterFifthTwisterRotY { get; set; } = -85.629f;

    [JsonPropertyName("counterFifthTwisterIsLeft_")]
    public bool CounterFifthTwisterIsLeft { get; set; } = true;

    [JsonPropertyName("counterSixthTwisterPos_")]
    public Vector3 CounterSixthTwisterPos { get; set; } = new Vector3(0f, 0f, 0f);

    [JsonPropertyName("counterSixthTwisterRotY_")]
    public float CounterSixthTwisterRotY { get; set; } = 0f;

    [JsonPropertyName("counterSixthTwisterIsLeft_")]
    public bool CounterSixthTwisterIsLeft { get; set; } = true;

    [JsonPropertyName("windBallVfxOffsetZ")]
    public float WindBallVfxOffsetZ { get; set; } = -15f;

    [JsonPropertyName("comboCoolTime_")]
    public Vector2 ComboCoolTime { get; set; } = new Vector2(15f, 15f);

    [JsonPropertyName("windBreathInhaleOffset_")]
    public Vector4 WindBreathInhaleOffset { get; set; } = new Vector4(-1f, 0f, 8f, 1f);

    [JsonPropertyName("windBreathInhaleAngle_")]
    public float WindBreathInhaleAngle { get; set; } = 360f;

    [JsonPropertyName("windBreathInhaleRadius_")]
    public float WindBreathInhaleRadius { get; set; } = 20f;

    [JsonPropertyName("windBreathInhalePower_")]
    public float WindBreathInhalePower { get; set; } = 0.06f;

    [JsonPropertyName("windBeamInhaleOffset_")]
    public Vector4 WindBeamInhaleOffset { get; set; } = new Vector4(0f, 0f, 7f, 1f);

    [JsonPropertyName("windBeamInhaleAngle_")]
    public float WindBeamInhaleAngle { get; set; } = 360f;

    [JsonPropertyName("windBeamInhaleRadius_")]
    public float WindBeamInhaleRadius { get; set; } = 35f;

    [JsonPropertyName("windBeamInhalePower_")]
    public float WindBeamInhalePower { get; set; } = 0.06f;

    public Em1804Param()
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
        AnimRateODAILevel3 = new Vector2(1.1f, 1.2f);
        AnimRateODAILevel4 = new Vector2(1.2f, 1.2f);
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
        FireBallSpeedAILevel1 = 30f;
        FireBallSpeedAILevel2 = 30f;
        FireBallSpeedAILevel3 = 30f;
        FireBallSpeedAILevel4 = 50f;
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
        MeteorWaitEndSecond = 0f;
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
        ByTheWallStepMag = 1f;
    }

    public class TwisterParam
    {
        [JsonPropertyName("twisterPos_")]
        public Vector3 TwisterPos { get; set; } // Offset 0x10

        [JsonPropertyName("twisterRot_")]
        public Vector4 TwisterRot { get; set; } // Offset 0x20

        [JsonPropertyName("twisterSubPos_")]
        public Vector3 TwisterSubPos { get; set; } // Offset 0x30

        [JsonPropertyName("twisterSubRot_")]
        public Vector4 TwisterSubRot { get; set; } // Offset 0x40

        public TwisterParam()
        {
        }
    }


    public class SingleTwisterParam
    {
        [JsonPropertyName("popWait")]
        public float PopWait { get; set; } // Offset 0x10

        [JsonPropertyName("twisterPos_")]
        public Vector3 TwisterPos { get; set; } // Offset 0x14

        [JsonPropertyName("twisterRot_")]
        public Vector4 TwisterRot { get; set; } // Offset 0x20

        public SingleTwisterParam()
        {
        }
    }
}

