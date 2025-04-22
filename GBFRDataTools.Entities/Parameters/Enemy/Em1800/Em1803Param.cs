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

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1800;

public class Em1803Param : Em1800Param
{
    [JsonPropertyName("clawLeftSandWallPos_")]
    public Vector3 ClawLeftSandWallPos { get; set; } = new Vector3(0.1f, -0.9f, 7.5f);

    [JsonPropertyName("clawLeftSandWallRot_")]
    public Vector4 ClawLeftSandWallRot { get; set; } = new Vector4(0f, -80f, 0f, 0f);

    [JsonPropertyName("clawRightSandWallPos_")]
    public Vector3 ClawRightSandWallPos { get; set; } = new Vector3(-0.1f, -0.9f, 8f);

    [JsonPropertyName("clawRightSandWallRot_")]
    public Vector4 ClawRightSandWallRot { get; set; } = new Vector4(0f, 75f, 0f, 0f);

    [JsonPropertyName("clawTurnLeftSandWallPos_")]
    public Vector3 ClawTurnLeftSandWallPos { get; set; } = new Vector3(5f, 0f, 5f);

    [JsonPropertyName("clawTurnLeftSandWallRot_")]
    public Vector4 ClawTurnLeftSandWallRot { get; set; } = new Vector4(0f, 130f, 0f, 0f);

    [JsonPropertyName("clawTurnRightSandWallPos_")]
    public Vector3 ClawTurnRightSandWallPos { get; set; } = new Vector3(-5f, 0f, 6.5f);

    [JsonPropertyName("clawTurnRightSandWallRot_")]
    public Vector4 ClawTurnRightSandWallRot { get; set; } = new Vector4(0f, -130f, 0f, 0f);

    [JsonPropertyName("clawRockRotX_")]
    public float ClawRockRotX { get; set; } = -18f;

    [JsonPropertyName("clawRockRotY_")]
    public float ClawRockRotY { get; set; } = 15f;

    [JsonPropertyName("clawRockNum_")]
    public int ClawRockNum { get; set; } = 3;

    [JsonPropertyName("clawRockOverDriveNum_")]
    public int ClawRockOverDriveNum { get; set; } = 5;

    [JsonPropertyName("clawRockOffsetPos_")]
    public Vector4 ClawRockOffsetPos { get; set; } = new Vector4(0f, 0f, 5f, 4.450461E-10f);

    [JsonPropertyName("clawRockOffsetRotY_")]
    public float ClawRockOffsetRotY { get; set; } = 10f;

    [JsonPropertyName("clawRockDelaySec_")]
    public float ClawRockDelaySec { get; set; } = 0.08f;

    [JsonPropertyName("clawWaveNum_")]
    public int ClawWaveNum { get; set; } = 3;

    [JsonPropertyName("clawWaveOffset1_")]
    public Vector3 ClawWaveOffset1 { get; set; } = new Vector3(0f, 0f, 6.1f);

    [JsonPropertyName("clawWaveOffset23_")]
    public Vector3 ClawWaveOffset23 { get; set; } = new Vector3(1.5f, 0f, 6f);

    [JsonPropertyName("clawWaveRot_")]
    public Vector3 ClawWaveRot { get; set; } = new Vector3(0f, 12f, -12f);

    [JsonPropertyName("clawWaveOffsetRotY_")]
    public float ClawWaveOffsetRotY { get; set; } = 10f;

    [JsonPropertyName("beamSandWallNum_")]
    public int BeamSandWallNum { get; set; } = 3;

    [JsonPropertyName("beamSandWallOffsetLength_")]
    public float BeamSandWallOffsetLength { get; set; } = 25f;

    [JsonPropertyName("beamSandWallAddRot_")]
    public float BeamSandWallAddRot { get; set; } = 19.4f;

    [JsonPropertyName("breathSandWallOffsetPos_")]
    public Vector3 BreathSandWallOffsetPos { get; set; } = new Vector3(-3f, 0f, 8f);

    [JsonPropertyName("breathSandWallOffsetRotY_")]
    public float BreathSandWallOffsetRotY { get; set; } = 90f;

    [JsonPropertyName("dragonicQuakeHomingRotRate_")]
    public float DragonicQuakeHomingRotRate { get; set; } = 1f;

    [JsonPropertyName("dragonicQuakeMaxHomingAngle_")]
    public float DragonicQuakeMaxHomingAngle { get; set; } = 1.7f;

    [JsonPropertyName("dragonicQuakeHomingSpeed_")]
    public float DragonicQuakeHomingSpeed { get; set; } = 80f;

    [JsonPropertyName("dragonicQuakeWallOffsetX_")]
    public float DragonicQuakeWallOffsetX { get; set; } = 15f;

    [JsonPropertyName("dragonicQuakeWallAdjustX_")]
    public Vector2 DragonicQuakeWallAdjustX { get; set; } = new Vector2(-4f, 7f);

    [JsonPropertyName("dragonicQuakeWallOffsetZ_")]
    public float DragonicQuakeWallOffsetZ { get; set; } = -6.5f;

    [JsonPropertyName("dragonicQuakeWallAdjustZ_")]
    public Vector2 DragonicQuakeWallAdjustZ { get; set; } = new Vector2(0f, 0f);

    [JsonPropertyName("dragonicQuakeWallRot_")]
    public float DragonicQuakeWallRot { get; set; } = 67.5f;

    [JsonPropertyName("dragonicQuakeWallAdjustRot_")]
    public Vector2 DragonicQuakeWallAdjustRot { get; set; } = new Vector2(0f, 0f);

    [JsonPropertyName("dragonicQuakeWallSec_")]
    public float DragonicQuakeWallSec { get; set; } = 0f;

    [JsonPropertyName("dragonicQuakeWallAddonOffset_")]
    public Vector4 DragonicQuakeWallAddonOffset { get; set; } = new Vector4(25f, 0f, -6.5f, 1f);

    [JsonPropertyName("dragonicQuakeWallAddonRot_")]
    public float DragonicQuakeWallAddonRot { get; set; } = 0f;

    [JsonPropertyName("dragonicQuakeClawRockOffsetRotY_")]
    public float DragonicQuakeClawRockOffsetRotY { get; set; } = 0f;

    [JsonPropertyName("rotationBeamParam_")]
    public Em1806AuraBreathParam RotationBeamParam { get; set; }

    [JsonPropertyName("rotationBeamRadiusAI4_")]
    public float RotationBeamRadiusAI4 { get; set; } = 1.5f;

    [JsonPropertyName("rotationBeamDirOffsetXDegAI4_")]
    public float RotationBeamDirOffsetXDegAI4 { get; set; } = 2f;

    [JsonPropertyName("dragonicQuakeClawRockNum_")]
    public int DragonicQuakeClawRockNum { get; set; } = 18;

    [JsonPropertyName("dragonicQuakeClawRockOffsetPos_")]
    public Vector4 DragonicQuakeClawRockOffsetPos { get; set; } = new Vector4(-2.8f, 0f, 3.8f, 1f);

    [JsonPropertyName("dragonicQuakeClawRockMinDist_")]
    public float DragonicQuakeClawRockMinDist { get; set; } = 12f;

    [JsonPropertyName("dragonicQuakeClawRockMaxDist_")]
    public float DragonicQuakeClawRockMaxDist { get; set; } = 42f;

    [JsonPropertyName("dragonicQuakeClawRockAngle_")]
    public float DragonicQuakeClawRockAngle { get; set; } = 100f;

    [JsonPropertyName("dragonicQuakeClawRockInitPosOffset_")]
    public float DragonicQuakeClawRockInitPosOffset { get; set; } = 0.1f;

    [JsonPropertyName("dragonicQuakeWallAdjustPos1Right_")]
    public Vector4 DragonicQuakeWallAdjustPos1Right { get; set; } = new Vector4(5.5f, 0f, 1.5f, 1f);

    [JsonPropertyName("dragonicQuakeWallAdjustRot1Right_")]
    public float DragonicQuakeWallAdjustRot1Right { get; set; } = 20f;

    [JsonPropertyName("dragonicQuakeWallAdjustPos1Left_")]
    public Vector4 DragonicQuakeWallAdjustPos1Left { get; set; } = new Vector4(5f, 0f, 2.5f, 1f);

    [JsonPropertyName("dragonicQuakeWallAdjustRot1Left_")]
    public float DragonicQuakeWallAdjustRot1Left { get; set; } = 0f;

    [JsonPropertyName("dragonicQuakeWallAdjustPos2Right_")]
    public Vector4 DragonicQuakeWallAdjustPos2Right { get; set; } = new Vector4(0f, 0f, -0.25f, 1f);

    [JsonPropertyName("dragonicQuakeWallAdjustRot2Right_")]
    public float DragonicQuakeWallAdjustRot2Right { get; set; } = -10f;

    [JsonPropertyName("dragonicQuakeWallAdjustPos2Left_")]
    public Vector4 DragonicQuakeWallAdjustPos2Left { get; set; } = new Vector4(2f, 0f, 1f, 1f);

    [JsonPropertyName("dragonicQuakeWallAdjustRot2Left_")]
    public float DragonicQuakeWallAdjustRot2Left { get; set; } = -15f;

    [JsonPropertyName("dragonicQuakeWallAdjustPos3Right_")]
    public Vector4 DragonicQuakeWallAdjustPos3Right { get; set; } = new Vector4(3.5f, 0f, 1f, 1f);

    [JsonPropertyName("dragonicQuakeWallAdjustRot3Right_")]
    public float DragonicQuakeWallAdjustRot3Right { get; set; } = 25f;

    [JsonPropertyName("dragonicQuakeWallAdjustPos3Left_")]
    public Vector4 DragonicQuakeWallAdjustPos3Left { get; set; } = new Vector4(5.5f, 0f, -0.5f, 1f);

    [JsonPropertyName("dragonicQuakeWallAdjustRot3Left_")]
    public float DragonicQuakeWallAdjustRot3Left { get; set; } = -35f;

    [JsonPropertyName("dragonicQuakeWallAdjustPos4Right_")]
    public Vector4 DragonicQuakeWallAdjustPos4Right { get; set; } = new Vector4(0f, 0f, -2f, 1f);

    [JsonPropertyName("dragonicQuakeWallAdjustRot4Right_")]
    public float DragonicQuakeWallAdjustRot4Right { get; set; } = 0f;

    [JsonPropertyName("dragonicQuakeWallAdjustPos4Left_")]
    public Vector4 DragonicQuakeWallAdjustPos4Left { get; set; } = new Vector4(2.5f, 0f, -1.5f, 1f);

    [JsonPropertyName("dragonicQuakeWallAdjustRot4Left_")]
    public float DragonicQuakeWallAdjustRot4Left { get; set; } = 0f;

    [JsonPropertyName("dragonicQuakeWallAdjustPos5Right_")]
    public Vector4 DragonicQuakeWallAdjustPos5Right { get; set; } = new Vector4(3.5f, 0f, 1f, 1f);

    [JsonPropertyName("dragonicQuakeWallAdjustRot5Right_")]
    public float DragonicQuakeWallAdjustRot5Right { get; set; } = 60f;

    [JsonPropertyName("dragonicQuakeWallAdjustPos5Left_")]
    public Vector4 DragonicQuakeWallAdjustPos5Left { get; set; } = new Vector4(4.5f, 0f, 0.5f, 1f);

    [JsonPropertyName("dragonicQuakeWallAdjustRot5Left_")]
    public float DragonicQuakeWallAdjustRot5Left { get; set; } = 40f;

    [JsonPropertyName("dragonicQuakeWallAddonAdjustPos1Right_")]
    public Vector4 DragonicQuakeWallAddonAdjustPos1Right { get; set; } = new Vector4(0f, 0f, -1f, 1f);

    [JsonPropertyName("dragonicQuakeWallAddonAdjustRot1Right_")]
    public float DragonicQuakeWallAddonAdjustRot1Right { get; set; } = 25f;

    [JsonPropertyName("dragonicQuakeWallAddonAdjustPos1Left_")]
    public Vector4 DragonicQuakeWallAddonAdjustPos1Left { get; set; } = new Vector4(0f, 0f, 3f, 1f);

    [JsonPropertyName("dragonicQuakeWallAddonAdjustRot1Left_")]
    public float DragonicQuakeWallAddonAdjustRot1Left { get; set; } = -30f;

    [JsonPropertyName("dragonicQuakeWallAddonAdjustPos2Right_")]
    public Vector4 DragonicQuakeWallAddonAdjustPos2Right { get; set; } = new Vector4(0f, 0f, 5f, 1f);

    [JsonPropertyName("dragonicQuakeWallAddonAdjustRot2Right_")]
    public float DragonicQuakeWallAddonAdjustRot2Right { get; set; } = -40f;

    [JsonPropertyName("dragonicQuakeWallAddonAdjustPos2Left_")]
    public Vector4 DragonicQuakeWallAddonAdjustPos2Left { get; set; } = new Vector4(0f, 0f, -1f, 1f);

    [JsonPropertyName("dragonicQuakeWallAddonAdjustRot2Left_")]
    public float DragonicQuakeWallAddonAdjustRot2Left { get; set; } = -45f;

    [JsonPropertyName("groundCrackAtkRate_")]
    public float GroundCrackAtkRate { get; set; } = 1.81f;

    [JsonPropertyName("groundCrackBreakRate_")]
    public float GroundCrackBreakRate { get; set; } = 2.5f;

    [JsonPropertyName("groundCrackWaitSec_")]
    public float GroundCrackWaitSec { get; set; } = 2f;

    [JsonPropertyName("groundCrackAttackSec_")]
    public float GroundCrackAttackSec { get; set; } = 0.35f;

    [JsonPropertyName("groundCrackAttackBoxSize_")]
    public Vector3 GroundCrackAttackBoxSize { get; set; } = new Vector3(18f, 0.6f, 1f);

    [JsonPropertyName("groundCrackQuakeRadius_")]
    public float GroundCrackQuakeRadius { get; set; } = 11.8f;

    [JsonPropertyName("groundCrackWaveSec_")]
    public float GroundCrackWaveSec { get; set; } = 0.167f;

    [JsonPropertyName("groundCrackParamLists_")]
    [Editable(false)]
    public BindingList<BindingList<CrackParam>> GroundCrackParamLists { get; set; } = [..Enumerable.Repeat(new BindingList<CrackParam>(), 5)]; // std::array<std::vector<Em1803Param::CrackParam>>

    [JsonPropertyName("slashBeamParam_")]
    public Em1806AuraBreathParam SlashBeamParam { get; set; }

    [JsonPropertyName("slashBeamTimeScaleAILv4_")]
    public float SlashBeamTimeScaleAILv4 { get; set; } = 1.2f;

    [JsonPropertyName("normalBreathParam_")]
    public Em1806AuraBreathParam NormalBreathParam { get; set; }

    [JsonPropertyName("stepBeamParam_")]
    public Em1806AuraBreathParam StepBeamParam { get; set; }

    [JsonPropertyName("quakeSignSec_")]
    public float QuakeSignSec { get; set; } = 1.1f;

    [JsonPropertyName("quakeCrackAtkRate_")]
    public float QuakeCrackAtkRate { get; set; } = 1.8f;

    [JsonPropertyName("quakeCrackBreakRate_")]
    public float QuakeCrackBreakRate { get; set; } = 2.5f;

    [JsonPropertyName("quakeCrackWaitSec_")]
    public float QuakeCrackWaitSec { get; set; } = 2f;

    [JsonPropertyName("quakeCrackAttackSec_")]
    public float QuakeCrackAttackSec { get; set; } = 0.35f;

    [JsonPropertyName("quakeCrackAttackBoxSize_")]
    public Vector3 QuakeCrackAttackBoxSize { get; set; } = new Vector3(28.7f, 0.6f, 1f);

    [JsonPropertyName("quakeCrackRadius_")]
    public Vector2 QuakeCrackRadius { get; set; } = new Vector2(11f, 20.35f);

    [JsonPropertyName("quakeCrackHeight_")]
    public float QuakeCrackHeight { get; set; } = 0.5f;

    [JsonPropertyName("quakeCrackWidth_")]
    public float QuakeCrackWidth { get; set; } = 1f;

    [JsonPropertyName("sandWallLiveSecAILevel3_")]
    public Vector2 SandWallLiveSecAILevel3 { get; set; } = new Vector2(3f, 3f);

    [JsonPropertyName("sandWallLiveSecAILevel4_")]
    public Vector2 SandWallLiveSecAILevel4 { get; set; } = new Vector2(4f, 5f);

    [JsonPropertyName("sandWallScaleSecAILevel3_")]
    public float SandWallScaleSecAILevel3 { get; set; } = 5f;

    [JsonPropertyName("sandWallScaleSecAILevel4_")]
    public float SandWallScaleSecAILevel4 { get; set; } = 6f;

    [JsonPropertyName("tailAttackCrackAtkRate_")]
    public float TailAttackCrackAtkRate { get; set; } = 1.8f;

    [JsonPropertyName("tailAttackCrackBreakRate_")]
    public float TailAttackCrackBreakRate { get; set; } = 2.5f;

    [JsonPropertyName("tailAttackCrackWaitSec_")]
    public float TailAttackCrackWaitSec { get; set; } = 2f;

    [JsonPropertyName("tailAttackCrackAttackSec_")]
    public float TailAttackCrackAttackSec { get; set; } = 0.35f;

    [JsonPropertyName("tailAttackCrackAttackHeight_")]
    public float TailAttackCrackAttackHeight { get; set; } = 0.6f;

    [JsonPropertyName("tailAttackCrackAttackRadius_")]
    public float TailAttackCrackAttackRadius { get; set; } = 1f;

    [JsonPropertyName("tailAttackCrackAttackOffset_")]
    public Vector4 TailAttackCrackAttackOffset { get; set; } = new Vector4(0f, 0f, 0f, 0f);

    [JsonPropertyName("tailAttackCrackRadius_")]
    public float TailAttackCrackRadius { get; set; } = 20f;

    [JsonPropertyName("tailAttackCrackAdjustRotY_")]
    public float TailAttackCrackAdjustRotY { get; set; } = 0f;

    [JsonPropertyName("tailAttackCrackFirstAngle_")]
    public float TailAttackCrackFirstAngle { get; set; } = 90f;

    [JsonPropertyName("tailAttackCrackExpansionAngle_")]
    public float TailAttackCrackExpansionAngle { get; set; } = 270f;

    [JsonPropertyName("tailAttackCrackOneRotationExpansionAngle_")]
    public float TailAttackCrackOneRotationExpansionAngle { get; set; } = 360f;

    [JsonPropertyName("tailAttackCrackExpansionTime_")]
    public float TailAttackCrackExpansionTime { get; set; } = 0f;

    [JsonPropertyName("tailAttackCrackEffectExpansionSec_")]
    public float TailAttackCrackEffectExpansionSec { get; set; } = 1f;

    [JsonPropertyName("tailAttackCrackAdditionalCrackExpansionSec_")]
    public float TailAttackCrackAdditionalCrackExpansionSec { get; set; } = 1f;

    [JsonPropertyName("tailAttackCrackAdditionalCrackTargetLength_")]
    public float TailAttackCrackAdditionalCrackTargetLength { get; set; } = 18f;

    [JsonPropertyName("tailAttackCrackAdditionalCrackBoxSize_")]
    public Vector4 TailAttackCrackAdditionalCrackBoxSize { get; set; } = new Vector4(1f, 0.6f, 7.5f, 0f);

    [JsonPropertyName("quakeActionCoolTime_")]
    public float QuakeActionCoolTime { get; set; } = 20f;

    [JsonPropertyName("jumpBreathActionCoolTime_")]
    public float JumpBreathActionCoolTime { get; set; } = 50f;

    [JsonPropertyName("stageCenterPos_")]
    public Vector4 StageCenterPos { get; set; } = new Vector4(-270f, 88.41f, -52f, 1f);

    [JsonPropertyName("stageRadius_")]
    public float StageRadius { get; set; } = 30f;

    public Em1803Param()
    {
        Hp = 300000;
        Atk = 750;
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
        AnimRateODAILevel3 = new Vector2(1.05f, 1.15f);
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
        ClawHomingRotRate = 0.05f;
        ClawMaxHomingAngle = 40f;
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

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CrackParam
    {
        [JsonPropertyName("shotNo_")]
        public int ShotNo { get; set; } // Offset 0x8

        [JsonPropertyName("offsetPos_")]
        public Vector2 OffsetPos { get; set; } // Offset 0xC

        public CrackParam()
        {
        }
    }
}