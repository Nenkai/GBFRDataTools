using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1600;

public class Em1600Param : EmBossBaseParam
{
    [JsonPropertyName("animRateOD_")]
    public float AnimRateOD { get; set; } = 1f;

    [JsonPropertyName("forceOverDriveHpRate_")]
    public int ForceOverDriveHpRate { get; set; } = 25;

    [JsonPropertyName("hpRateNormalHighAILevel_")]
    public float HpRateNormalHighAILevel { get; set; } = 0.25f;

    [JsonPropertyName("hpRateOverDriveHighAILevel_")]
    public float HpRateOverDriveHighAILevel { get; set; } = 0.15f;

    [JsonPropertyName("hpRateBreakHighAILevel_")]
    public float HpRateBreakHighAILevel { get; set; } = 10f;

    [JsonPropertyName("breakVoiceWaitSecond_")]
    public float BreakVoiceWaitSecond { get; set; } = 2f;

    [JsonPropertyName("breakDownVoiceWaitSecond_")]
    public float BreakDownVoiceWaitSecond { get; set; } = 0.1f;

    [JsonPropertyName("coolTimeAttackAILevel1_")]
    public float CoolTimeAttackAILevel1 { get; set; } = 5f;

    [JsonPropertyName("coolTimeAttackAILevel2_")]
    public float CoolTimeAttackAILevel2 { get; set; } = 2f;

    [JsonPropertyName("coolTimeAttackAILevel3_")]
    public float CoolTimeAttackAILevel3 { get; set; } = 2f;

    [JsonPropertyName("coolTimeAttackAILevel4_")]
    public float CoolTimeAttackAILevel4 { get; set; } = 2f;

    [JsonPropertyName("coolTimeFeatherShotAILevel_")]
    public Vector4 CoolTimeFeatherShotAILevel { get; set; } = new Vector4(25f, 25f, 25f, 25f);

    [JsonPropertyName("coolTimeRoundTripRush_")]
    public float CoolTimeRoundTripRush { get; set; } = 30f;

    [JsonPropertyName("coolTimeSomersaultKick_")]
    public float CoolTimeSomersaultKick { get; set; } = 30f;

    [JsonPropertyName("coolTimeCombo_")]
    public float CoolTimeCombo { get; set; } = 30f;

    [JsonPropertyName("coolTimeScratch_")]
    public float CoolTimeScratch { get; set; } = 35f;

    [JsonPropertyName("coolTimeCrossTornade_")]
    public float CoolTimeCrossTornade { get; set; } = 20f;

    [JsonPropertyName("coolTimeStomping_")]
    public float CoolTimeStomping { get; set; } = 30f;

    [JsonPropertyName("coolTimeBackRush_")]
    public float CoolTimeBackRush { get; set; } = 40f;

    [JsonPropertyName("coolTimeSpiralTornade_")]
    public float CoolTimeSpiralTornade { get; set; } = 20f;

    [JsonPropertyName("coolTimeFeatherCombo_")]
    public float CoolTimeFeatherCombo { get; set; } = 20f;

    [JsonPropertyName("coolTimeTornadoCombo_")]
    public float CoolTimeTornadoCombo { get; set; } = 40f;

    [JsonPropertyName("coolTimePositioningAction_")]
    public float CoolTimePositioningAction { get; set; } = 5f;

    [JsonPropertyName("tornadeAtkFirstShotRate_")]
    public float TornadeAtkFirstShotRate { get; set; } = 0.8f;

    [JsonPropertyName("tornadeAtkSecondShotRate_")]
    public float TornadeAtkSecondShotRate { get; set; } = 0.5f;

    [JsonPropertyName("overDriveAtkRate_")]
    public float OverDriveAtkRate { get; set; } = 1.3f;

    [JsonPropertyName("hitStopAtkTime_")]
    public float HitStopAtkTime { get; set; } = 0.2f;

    [JsonPropertyName("flyHighModeHeight_")]
    public float FlyHighModeHeight { get; set; } = 2.9f;

    [JsonPropertyName("flyHighModeRate_")]
    public float FlyHighModeRate { get; set; } = 0.03f;

    [JsonPropertyName("landModeRate_")]
    public float LandModeRate { get; set; } = 0.1f;

    [JsonPropertyName("modeChangeLandToFlyAILevel_")]
    public Vector4 ModeChangeLandToFlyAILevel { get; set; } = new Vector4(40f, 40f, 40f, 40f);

    [JsonPropertyName("modeChangeFlyToLandAILevel_")]
    public Vector4 ModeChangeFlyToLandAILevel { get; set; } = new Vector4(90f, 90f, 180f, 180f);

    [JsonPropertyName("modeChangeLandToFlyAILevelShort_")]
    public Vector4 ModeChangeLandToFlyAILevelShort { get; set; } = new Vector4(20f, 20f, 20f, 20f);

    [JsonPropertyName("tornadoHitRadius_")]
    public float TornadoHitRadius { get; set; } = 1.8f;

    [JsonPropertyName("tornadoHitHeight_")]
    public float TornadoHitHeight { get; set; } = 6.5f;

    [JsonPropertyName("tornadoCrossCrawlingAddSin_")]
    public float TornadoCrossCrawlingAddSin { get; set; } = 0.05f;

    [JsonPropertyName("tornadoCrossCrawlingOffsetX_")]
    public float TornadoCrossCrawlingOffsetX { get; set; } = 10f;

    [JsonPropertyName("tornadoCrossCrawlingMoveSpeed_")]
    public float TornadoCrossCrawlingMoveSpeed { get; set; } = 0.05f;

    [JsonPropertyName("tornadoCrossCrawlingMoveTime_")]
    public float TornadoCrossCrawlingMoveTime { get; set; } = 5f;

    [JsonPropertyName("tornadoCrossCrawlingAccelerationSpeed_")]
    public float TornadoCrossCrawlingAccelerationSpeed { get; set; } = 0.002f;

    [JsonPropertyName("tornadoSpiralMoveSpeed_")]
    public float TornadoSpiralMoveSpeed { get; set; } = 0.4f;

    [JsonPropertyName("tornadoSpiralAddRotY_")]
    public float TornadoSpiralAddRotY { get; set; } = 0f;

    [JsonPropertyName("tornadoSpiralMoveTime_")]
    public float TornadoSpiralMoveTime { get; set; } = 7f;

    [JsonPropertyName("tornadoSpiralInitRadius_")]
    public float TornadoSpiralInitRadius { get; set; } = 5f;

    [JsonPropertyName("tornadoCrossCrawlingAcceleration_")]
    public float TornadoCrossCrawlingAcceleration { get; set; } = 0f;

    [JsonPropertyName("tornadoCrossCrawlingAccelerationRotY_")]
    public float TornadoCrossCrawlingAccelerationRotY { get; set; } = 0f;

    [JsonPropertyName("tornadoCrawlingAddSin_")]
    public float TornadoCrawlingAddSin { get; set; } = 0.05f;

    [JsonPropertyName("tornadoCrawlingOffsetX_")]
    public float TornadoCrawlingOffsetX { get; set; } = 1f;

    [JsonPropertyName("tornadoCrawlingMoveSpeed_")]
    public float TornadoCrawlingMoveSpeed { get; set; } = 0.2f;

    [JsonPropertyName("tornadoCrawlingMoveTime_")]
    public float TornadoCrawlingMoveTime { get; set; } = 3f;

    [JsonPropertyName("tornadoAddSin_")]
    public float TornadoAddSin { get; set; } = 0.05f;

    [JsonPropertyName("tornadoOffsetX_")]
    public float TornadoOffsetX { get; set; } = 1f;

    [JsonPropertyName("tornadogMoveSpeed_")]
    public float TornadogMoveSpeed { get; set; } = 0.2f;

    [JsonPropertyName("tornadoMoveTime_")]
    public float TornadoMoveTime { get; set; } = 3f;

    [JsonPropertyName("tornadoAddSinOD_")]
    public float TornadoAddSinOD { get; set; } = 0.05f;

    [JsonPropertyName("tornadoOffsetXOD_")]
    public float TornadoOffsetXOD { get; set; } = 1f;

    [JsonPropertyName("tornadogMoveSpeedOD_")]
    public float TornadogMoveSpeedOD { get; set; } = 0.2f;

    [JsonPropertyName("tornadoMoveTimeOD_")]
    public float TornadoMoveTimeOD { get; set; } = 5f;

    [JsonPropertyName("tornadoAddSinODArts_")]
    public float TornadoAddSinODArts { get; set; } = 0.05f;

    [JsonPropertyName("tornadoOffsetXODArts_")]
    public float TornadoOffsetXODArts { get; set; } = 2f;

    [JsonPropertyName("tornadogMoveSpeedODArts_")]
    public float TornadogMoveSpeedODArts { get; set; } = 0.2f;

    [JsonPropertyName("tornadoMoveTimeODArts_")]
    public float TornadoMoveTimeODArts { get; set; } = 5f;

    [JsonPropertyName("tornadoAddSinGlide_")]
    public float TornadoAddSinGlide { get; set; } = 0.05f;

    [JsonPropertyName("tornadoOffsetXGlide_")]
    public float TornadoOffsetXGlide { get; set; } = 2f;

    [JsonPropertyName("tornadoMoveSpeedGlide_")]
    public float TornadoMoveSpeedGlide { get; set; } = 0.2f;

    [JsonPropertyName("tornadoMoveTimeGlide_")]
    public float TornadoMoveTimeGlide { get; set; } = 5f;

    [JsonPropertyName("knockOffBreakPowerAILevel1_")]
    public int KnockOffBreakPowerAILevel1 { get; set; } = 2500;

    [JsonPropertyName("knockOffBreakPowerAILevel2_")]
    public int KnockOffBreakPowerAILevel2 { get; set; } = 2500;

    [JsonPropertyName("knockOffBreakPowerAILevel3_")]
    public int KnockOffBreakPowerAILevel3 { get; set; } = 4500;

    [JsonPropertyName("knockOffBreakPowerAILevel4_")]
    public int KnockOffBreakPowerAILevel4 { get; set; } = 5000;

    [JsonPropertyName("knockOffBreakPowerBulletRate_")]
    public float KnockOffBreakPowerBulletRate { get; set; } = 0.5f;

    [JsonPropertyName("flyModeCameraSecond_")]
    public float FlyModeCameraSecond { get; set; } = 0.1f;

    [JsonPropertyName("flyModeCameraAddLength_")]
    public float FlyModeCameraAddLength { get; set; } = 10f;

    [JsonPropertyName("flyModeCameraRate_")]
    public float FlyModeCameraRate { get; set; } = 0.01f;

    [JsonPropertyName("smallTornadoAttackRate_")]
    public float SmallTornadoAttackRate { get; set; } = 1.3f;

    [JsonPropertyName("smallTornadoStunRate_")]
    public float SmallTornadoStunRate { get; set; } = 2.5f;

    [JsonPropertyName("bigTornadoAttackRate_")]
    public float BigTornadoAttackRate { get; set; } = 2f;

    [JsonPropertyName("bigTornadoStunRate_")]
    public float BigTornadoStunRate { get; set; } = 3f;

    [JsonPropertyName("counterAttackParamAILevel1_")]
    public CounterAttackParam CounterAttackParamAILevel1 { get; set; }

    [JsonPropertyName("counterAttackParamAILevel2_")]
    public CounterAttackParam CounterAttackParamAILevel2 { get; set; }

    [JsonPropertyName("counterAttackParamAILevel3_")]
    public CounterAttackParam CounterAttackParamAILevel3 { get; set; }

    [JsonPropertyName("counterAttackParamAILevel4_")]
    public CounterAttackParam CounterAttackParamAILevel4 { get; set; }

    [JsonPropertyName("ikFrontWaist_")]
    public int IkFrontWaist { get; set; } = 3;

    [JsonPropertyName("ikFrontHeightMax_")]
    public float IkFrontHeightMax { get; set; } = 5f;

    [JsonPropertyName("ikFrontWaistMax_")]
    public float IkFrontWaistMax { get; set; } = 0f;

    [JsonPropertyName("ikHipFrontRight_")]
    public int IkHipFrontRight { get; set; } = 2594;

    [JsonPropertyName("ikKneeFrontRight_")]
    public int IkKneeFrontRight { get; set; } = 18;

    [JsonPropertyName("ikAnkleFrontRight_")]
    public int IkAnkleFrontRight { get; set; } = 1025;

    [JsonPropertyName("ikHipFrontLeft_")]
    public int IkHipFrontLeft { get; set; } = 2595;

    [JsonPropertyName("ikKneeFrontLeft_")]
    public int IkKneeFrontLeft { get; set; } = 34;

    [JsonPropertyName("ikAnkleFrontLeft_")]
    public int IkAnkleFrontLeft { get; set; } = 1024;

    [JsonPropertyName("ikRearWaist_")]
    public int IkRearWaist { get; set; } = 1;

    [JsonPropertyName("ikRearHeightMax_")]
    public float IkRearHeightMax { get; set; } = 5f;

    [JsonPropertyName("ikRearWaistMax_")]
    public float IkRearWaistMax { get; set; } = 0f;

    [JsonPropertyName("ikHipRearRight_")]
    public int IkHipRearRight { get; set; } = 65;

    [JsonPropertyName("ikKneeRearRight_")]
    public int IkKneeRearRight { get; set; } = 66;

    [JsonPropertyName("ikAnkleRearRight_")]
    public int IkAnkleRearRight { get; set; } = 70;

    [JsonPropertyName("ikHipRearLeft_")]
    public int IkHipRearLeft { get; set; } = 81;

    [JsonPropertyName("ikKneeRearLeft_")]
    public int IkKneeRearLeft { get; set; } = 82;

    [JsonPropertyName("ikAnkleRearLeft_")]
    public int IkAnkleRearLeft { get; set; } = 86;

    [JsonPropertyName("ikAnkleAdjust_")]
    public bool IkAnkleAdjust { get; set; } = true;

    [JsonPropertyName("ikUseModelWorldRot_")]
    public bool IkUseModelWorldRot { get; set; } = true;

    [JsonPropertyName("ikRestrainAdjust_")]
    public bool IkRestrainAdjust { get; set; } = true;

    [JsonPropertyName("chanceTurnAroundRate_")]
    public float ChanceTurnAroundRate { get; set; } = 0.01f;

    [JsonPropertyName("chanceTurnAroundTime_")]
    public float ChanceTurnAroundTime { get; set; } = 3f;

    [JsonPropertyName("limitTiltRotX_")]
    public float LimitTiltRotX { get; set; } = 30f;

    [JsonPropertyName("limitTiltRotZ_")]
    public float LimitTiltRotZ { get; set; } = 30f;

    [JsonPropertyName("stunRateGround_")]
    public float StunRateGround { get; set; } = 0.25f;

    [JsonPropertyName("stunRateSky_")]
    public float StunRateSky { get; set; } = 1f;

    [JsonPropertyName("collisionParamFly_")]
    public CharaCollisionParam CollisionParamFly { get; set; }

    public Em1600Param()
    {
        Hp = 250000;
        Atk = 1000;
        Break = 8;
        Def = 1f;
        Endurance = 1;
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
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = false;
        IsDisableAerialDownReaction = false;
        CameraLength = 7f;
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
