using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1900;

public class Em1900Param : EmBossBaseParam
{
    [JsonPropertyName("targetLineTime_")]
    public float TargetLineTime { get; set; } = 0.2f;

    [JsonPropertyName("rushAttackCoolTime_")]
    public float RushAttackCoolTime { get; set; } = 15f;

    [JsonPropertyName("jumpAttackCoolTime_")]
    public float JumpAttackCoolTime { get; set; } = 15f;

    [JsonPropertyName("shieldLaunchCoolTime_")]
    public float ShieldLaunchCoolTime { get; set; } = 15f;

    [JsonPropertyName("counterAttackStackDamage_")]
    public float CounterAttackStackDamage { get; set; } = 800f;

    [JsonPropertyName("counterAttackStackTime_")]
    public float CounterAttackStackTime { get; set; } = 2f;

    [JsonPropertyName("counterAttackCoolTime_")]
    public float CounterAttackCoolTime { get; set; } = 5f;

    [JsonPropertyName("specialBreakCheckCount")]
    public int SpecialBreakCheckCount { get; set; } = 4;

    [JsonPropertyName("specialBreakCameraTargetOffset1_")]
    public Vector4 SpecialBreakCameraTargetOffset1 { get; set; } = new Vector4(0f, 0f, 0f, 1f);

    [JsonPropertyName("specialBreakCameraViewOffset1_")]
    public Vector4 SpecialBreakCameraViewOffset1 { get; set; } = new Vector4(7.5f, 2f, 7.5f, 1f);

    [JsonPropertyName("specialBreakCameraTargetOffset2_")]
    public Vector4 SpecialBreakCameraTargetOffset2 { get; set; } = new Vector4(0f, 0f, 0f, 1f);

    [JsonPropertyName("specialBreakCameraViewOffset2_")]
    public Vector4 SpecialBreakCameraViewOffset2 { get; set; } = new Vector4(-7.5f, 0f, 7.5f, 1f);

    [JsonPropertyName("specialBreakCameraTargetOffset3_")]
    public Vector4 SpecialBreakCameraTargetOffset3 { get; set; } = new Vector4(0f, 0f, 0f, 1f);

    [JsonPropertyName("specialBreakCameraViewOffset3_")]
    public Vector4 SpecialBreakCameraViewOffset3 { get; set; } = new Vector4(7.5f, 0f, -7.5f, 1f);

    [JsonPropertyName("specialBreakCameraTargetOffset4_")]
    public Vector4 SpecialBreakCameraTargetOffset4 { get; set; } = new Vector4(0f, 0f, 0f, 1f);

    [JsonPropertyName("specialBreakCameraViewOffset4_")]
    public Vector4 SpecialBreakCameraViewOffset4 { get; set; } = new Vector4(-7.5f, 0f, -7.5f, 1f);

    [JsonPropertyName("specialBreakCameraTime_")]
    public float SpecialBreakCameraTime { get; set; } = 3f;

    [JsonPropertyName("partsHpHead_")]
    public int PartsHpHead { get; set; } = 1000;

    [JsonPropertyName("partsHpBack_")]
    public int PartsHpBack { get; set; } = 1000;

    [JsonPropertyName("partsHpLegAILevel1_")]
    public int PartsHpLegAILevel1 { get; set; } = 50;

    [JsonPropertyName("partsHpLegAILevel2_")]
    public int PartsHpLegAILevel2 { get; set; } = 100;

    [JsonPropertyName("partsHpLegAILevel3_")]
    public int PartsHpLegAILevel3 { get; set; } = 140;

    [JsonPropertyName("partsHpLegAILevel4_")]
    public int PartsHpLegAILevel4 { get; set; } = 200;

    [JsonPropertyName("partsHpEye_")]
    public int PartsHpEye { get; set; } = 1000;

    [JsonPropertyName("partsHpChainsaw_")]
    public int PartsHpChainsaw { get; set; } = 1000;

    [JsonPropertyName("partsHpGatling_")]
    public int PartsHpGatling { get; set; } = 1000;

    [JsonPropertyName("partsHpFlamethrower_")]
    public int PartsHpFlamethrower { get; set; } = 1000;

    [JsonPropertyName("partsHpLaserMissile_")]
    public int PartsHpLaserMissile { get; set; } = 1000;

    [JsonPropertyName("missileAtk_")]
    public int MissileAtk { get; set; } = 30;

    [JsonPropertyName("missileAtkFire_")]
    public int MissileAtkFire { get; set; } = 0;

    [JsonPropertyName("missileAtkIce_")]
    public int MissileAtkIce { get; set; } = 0;

    [JsonPropertyName("missileAtkRadius_")]
    public float MissileAtkRadius { get; set; } = 2.5f;

    [JsonPropertyName("missileHitStopTime_")]
    public int MissileHitStopTime { get; set; } = 3;

    [JsonPropertyName("missileAttackWaitTimer_")]
    public float MissileAttackWaitTimer { get; set; } = 0.2f;

    [JsonPropertyName("missileAttackTimer_")]
    public float MissileAttackTimer { get; set; } = 0.5f;

    [JsonPropertyName("laserMissileLandingEffectWaitTime_")]
    public float LaserMissileLandingEffectWaitTime { get; set; } = 3f;

    [JsonPropertyName("laserMissileImpactSiteTimeLag_")]
    public float LaserMissileImpactSiteTimeLag { get; set; } = 0.25f;

    [JsonPropertyName("laserMissileImpactShotWait_")]
    public float LaserMissileImpactShotWait { get; set; } = 180f;

    [JsonPropertyName("freeMissileFireEffectWaitTime_")]
    public float FreeMissileFireEffectWaitTime { get; set; } = 0.5f;

    [JsonPropertyName("freeMissileLandingEffectWaitTime_")]
    public float FreeMissileLandingEffectWaitTime { get; set; } = 2f;

    [JsonPropertyName("freeMissileImpactSiteWait_")]
    public float FreeMissileImpactSiteWait { get; set; } = 0f;

    [JsonPropertyName("freeMissileImpactShotWait_")]
    public float FreeMissileImpactShotWait { get; set; } = 60f;

    [JsonPropertyName("freeMissileReFireWaitTime_")]
    public float FreeMissileReFireWaitTime { get; set; } = 0.5f;

    [JsonPropertyName("freeMissileTargetCheckRadius_")]
    public float FreeMissileTargetCheckRadius { get; set; } = 3f;

    [JsonPropertyName("gatlingHitCheck_")]
    public float GatlingHitCheck { get; set; } = 100f;

    [JsonPropertyName("gatlingBreakRate_")]
    public float GatlingBreakRate { get; set; } = 0.2f;

    [JsonPropertyName("electromagneticBarrierAtk_")]
    public int ElectromagneticBarrierAtk { get; set; } = 20;

    [JsonPropertyName("electromagneticBarrierHitStopTime_")]
    public int ElectromagneticBarrierHitStopTime { get; set; } = 0;

    [JsonPropertyName("electromagneticBarrierTimer_")]
    public float ElectromagneticBarrierTimer { get; set; } = 0.1f;

    [JsonPropertyName("electromagneticBarrierHitTimer_")]
    public float ElectromagneticBarrierHitTimer { get; set; } = 0.3f;

    [JsonPropertyName("camAddTimer")]
    public float CamAddTimer { get; set; } = 3f;

    [JsonPropertyName("camAddLen")]
    public float CamAddLen { get; set; } = 10f;

    [JsonPropertyName("camAddRate")]
    public float CamAddRate { get; set; } = 0.02f;

    [JsonPropertyName("mageDeviceLegCloseReq")]
    public float MageDeviceLegCloseReq { get; set; } = 0f;

    [JsonPropertyName("mageDeviceLegInterTimeOpen")]
    public float MageDeviceLegInterTimeOpen { get; set; } = 0f;

    [JsonPropertyName("mageDeviceLegInterTimeOpenWait")]
    public float MageDeviceLegInterTimeOpenWait { get; set; } = 0f;

    [JsonPropertyName("mageDeviceLegInterTimeClose")]
    public float MageDeviceLegInterTimeClose { get; set; } = 0f;

    [JsonPropertyName("mageDeviceLegInterTimeCloseWait")]
    public float MageDeviceLegInterTimeCloseWait { get; set; } = 0f;

    [JsonPropertyName("mageDeviceLegInterTimeDestruction")]
    public float MageDeviceLegInterTimeDestruction { get; set; } = 0.2f;

    [JsonPropertyName("aimGatlingAtkRate_")]
    public float AimGatlingAtkRate { get; set; } = 0.2f;

    [JsonPropertyName("aimGatlingDelayFrame_")]
    public int AimGatlingDelayFrame { get; set; } = 30;

    [JsonPropertyName("overDriveFireAtk_")]
    public int OverDriveFireAtk { get; set; } = 120;

    [JsonPropertyName("overDriveFireHitStop_")]
    public int OverDriveFireHitStop { get; set; } = 1;

    [JsonPropertyName("magicHammerSwingDownAtk_")]
    public int MagicHammerSwingDownAtk { get; set; } = 600;

    [JsonPropertyName("magicHammerSwingDownHitStop_")]
    public int MagicHammerSwingDownHitStop { get; set; } = 1;

    [JsonPropertyName("enableWeaponChangeTimer_")]
    public int EnableWeaponChangeTimer { get; set; } = 60;

    [JsonPropertyName("dpsCheckTimer_")]
    public int DpsCheckTimer { get; set; } = 25;

    [JsonPropertyName("laserMissileCoolTime_")]
    public Vector4 LaserMissileCoolTime { get; set; } = new Vector4(3f, 4f, 5f, 6f);

    [JsonPropertyName("laserMissileRapidfireIntervalTime_")]
    public Vector4 LaserMissileRapidfireIntervalTime { get; set; } = new Vector4(1f, 1.5f, 1.8f, 2f);

    [JsonPropertyName("laserMissileEffectWaitTime_")]
    public Vector4 LaserMissileEffectWaitTime { get; set; } = new Vector4(0.5f, 0.5f, 0.5f, 0.5f);

    [JsonPropertyName("laserMissileStopPartsWaitTime_")]
    public Vector4 LaserMissileStopPartsWaitTime { get; set; } = new Vector4(1f, 1f, 1f, 1f);

    [JsonPropertyName("laserMissileLandingTime_")]
    public Vector4 LaserMissileLandingTime { get; set; } = new Vector4(1f, 1f, 1f, 1f);

    [JsonPropertyName("laserMissileRapidFireNum01_")]
    public int LaserMissileRapidFireNum01 { get; set; } = 2;

    [JsonPropertyName("laserMissileRapidFireNum02_")]
    public int LaserMissileRapidFireNum02 { get; set; } = 2;

    [JsonPropertyName("laserMissileRapidFireNum03_")]
    public int LaserMissileRapidFireNum03 { get; set; } = 5;

    [JsonPropertyName("laserMissileRapidFireNum04_")]
    public int LaserMissileRapidFireNum04 { get; set; } = 5;

    [JsonPropertyName("laserMissileRadius_")]
    public float LaserMissileRadius { get; set; } = 1.5f;

    [JsonPropertyName("laserMissileCoolTimeAILevel1_")]
    public Vector4 LaserMissileCoolTimeAILevel1 { get; set; } = new Vector4(6f, 8f, 0f, 1f);

    [JsonPropertyName("laserMissileOffsetDist_")]
    public float LaserMissileOffsetDist { get; set; } = 2f;

    [JsonPropertyName("laserMissileCoolTimeRapidAction_")]
    public Vector4 LaserMissileCoolTimeRapidAction { get; set; } = new Vector4(0.5f, 0.5f, 0.5f, 0.5f);

    [JsonPropertyName("laserMissileRapidfireIntervalTimeRapidAction_")]
    public Vector4 LaserMissileRapidfireIntervalTimeRapidAction { get; set; } = new Vector4(0.1f, 0.1f, 0.1f, 0.1f);

    [JsonPropertyName("laserMissileEffectWaitTimeRapidAction_")]
    public Vector4 LaserMissileEffectWaitTimeRapidAction { get; set; } = new Vector4(0f, 0f, 0f, 0f);

    [JsonPropertyName("laserMissileStopPartsWaitTimeRapidAction_")]
    public Vector4 LaserMissileStopPartsWaitTimeRapidAction { get; set; } = new Vector4(1f, 1f, 1f, 1f);

    [JsonPropertyName("laserMissileLandingTimeRapidAction_")]
    public Vector4 LaserMissileLandingTimeRapidAction { get; set; } = new Vector4(1f, 2f, 3f, 4f);

    [JsonPropertyName("laserMissileRapidFireNumRapidAction01_")]
    public int LaserMissileRapidFireNumRapidAction01 { get; set; } = 500;

    [JsonPropertyName("laserMissileRapidFireNumRapidAction02_")]
    public int LaserMissileRapidFireNumRapidAction02 { get; set; } = 500;

    [JsonPropertyName("laserMissileRapidFireNumRapidAction03_")]
    public int LaserMissileRapidFireNumRapidAction03 { get; set; } = 500;

    [JsonPropertyName("laserMissileRapidFireNumRapidAction04_")]
    public int LaserMissileRapidFireNumRapidAction04 { get; set; } = 500;

    [JsonPropertyName("laserMissileRadiusRapidAction_")]
    public float LaserMissileRadiusRapidAction { get; set; } = 2.5f;

    [JsonPropertyName("laserMissileCoolTimeTwin_")]
    public Vector4 LaserMissileCoolTimeTwin { get; set; } = new Vector4(3f, 4f, 5f, 6f);

    [JsonPropertyName("laserMissileRapidfireIntervalTimeTwin_")]
    public Vector4 LaserMissileRapidfireIntervalTimeTwin { get; set; } = new Vector4(3f, 4f, 5f, 6f);

    [JsonPropertyName("laserMissileEffectWaitTimeTwin_")]
    public Vector4 LaserMissileEffectWaitTimeTwin { get; set; } = new Vector4(0.5f, 0.5f, 0.5f, 0.5f);

    [JsonPropertyName("laserMissileStopPartsWaitTimeTwin_")]
    public Vector4 LaserMissileStopPartsWaitTimeTwin { get; set; } = new Vector4(2f, 2f, 2f, 2f);

    [JsonPropertyName("laserMissileRapidFireNum01Twin_")]
    public int LaserMissileRapidFireNum01Twin { get; set; } = 4;

    [JsonPropertyName("laserMissileRapidFireNum02Twin_")]
    public int LaserMissileRapidFireNum02Twin { get; set; } = 4;

    [JsonPropertyName("laserMissileRapidFireNum03Twin_")]
    public int LaserMissileRapidFireNum03Twin { get; set; } = 5;

    [JsonPropertyName("laserMissileRapidFireNum04Twin_")]
    public int LaserMissileRapidFireNum04Twin { get; set; } = 5;

    [JsonPropertyName("laserMissileUseTwinParamSetType01_")]
    public int LaserMissileUseTwinParamSetType01 { get; set; } = 410;

    [JsonPropertyName("laserMissileUseTwinParamSetType02_")]
    public int LaserMissileUseTwinParamSetType02 { get; set; } = 409;

    [JsonPropertyName("coolTimeRocketChainsawGC_")]
    public float CoolTimeRocketChainsawGC { get; set; } = 20f;

    [JsonPropertyName("coolTimeChainsawSlashGC_")]
    public float CoolTimeChainsawSlashGC { get; set; } = 15f;

    [JsonPropertyName("coolTimeGatlingGC_")]
    public float CoolTimeGatlingGC { get; set; } = 20f;

    [JsonPropertyName("coolTimeFlamethrowerRadiationGF_")]
    public float CoolTimeFlamethrowerRadiationGF { get; set; } = 15f;

    [JsonPropertyName("coolTimeGatlingGF_")]
    public float CoolTimeGatlingGF { get; set; } = 20f;

    [JsonPropertyName("coolTimeFlamethrowerRadiationRFF_")]
    public float CoolTimeFlamethrowerRadiationRFF { get; set; } = 30f;

    [JsonPropertyName("coolTimeFlamethrowerRadiationLFF_")]
    public float CoolTimeFlamethrowerRadiationLFF { get; set; } = 40f;

    [JsonPropertyName("coolTimeFlamethrowerRadiationWFF_")]
    public float CoolTimeFlamethrowerRadiationWFF { get; set; } = 45f;

    [JsonPropertyName("coolTimeRocketChainsawRCC_")]
    public float CoolTimeRocketChainsawRCC { get; set; } = 10f;

    [JsonPropertyName("coolTimeRocketChainsawLCC_")]
    public float CoolTimeRocketChainsawLCC { get; set; } = 15f;

    [JsonPropertyName("coolTimeRocketChainsawWCC_")]
    public float CoolTimeRocketChainsawWCC { get; set; } = 45f;

    [JsonPropertyName("coolTimeChainsawSlashRCC_")]
    public float CoolTimeChainsawSlashRCC { get; set; } = 10f;

    [JsonPropertyName("coolTimeChainsawSlashLCC_")]
    public float CoolTimeChainsawSlashLCC { get; set; } = 15f;

    [JsonPropertyName("coolTimeChainsawSlashWCC_")]
    public float CoolTimeChainsawSlashWCC { get; set; } = 40f;

    [JsonPropertyName("coolTimeLaserMissileRapidAction_")]
    public float CoolTimeLaserMissileRapidAction { get; set; } = 60f;

    [JsonPropertyName("coolTimeODBarrierAction_")]
    public float CoolTimeODBarrierAction { get; set; } = 60f;

    [JsonPropertyName("coolTimeDPSCheck_")]
    public float CoolTimeDPSCheck { get; set; } = 150f;

    [JsonPropertyName("hpTriggerDPSCheck_")]
    public int HpTriggerDPSCheck { get; set; } = 90;

    [JsonPropertyName("explodeBreakPowerDPSCheck_")]
    public int ExplodeBreakPowerDPSCheck { get; set; } = 160;

    [JsonPropertyName("explodeDamageDPSCheck_")]
    public float ExplodeDamageDPSCheck { get; set; } = 5f;

    [JsonPropertyName("breakCountRateDPSCheck_")]
    public float BreakCountRateDPSCheck { get; set; } = 1.5f;

    [JsonPropertyName("shortRateDPSCheck_")]
    public float ShortRateDPSCheck { get; set; } = 0.5f;

    [JsonPropertyName("ikHipFrontRight_")]
    public int IkHipFrontRight { get; set; } = 770;

    [JsonPropertyName("ikKneeFrontRight_")]
    public int IkKneeFrontRight { get; set; } = 772;

    [JsonPropertyName("ikAnkleFrontRight_")]
    public int IkAnkleFrontRight { get; set; } = 773;

    [JsonPropertyName("ikHipFrontLeft_")]
    public int IkHipFrontLeft { get; set; } = 1026;

    [JsonPropertyName("ikKneeFrontLeft_")]
    public int IkKneeFrontLeft { get; set; } = 1028;

    [JsonPropertyName("ikAnkleFrontLeft_")]
    public int IkAnkleFrontLeft { get; set; } = 1029;

    [JsonPropertyName("ikHipRearRight_")]
    public int IkHipRearRight { get; set; } = 1282;

    [JsonPropertyName("ikKneeRearRight_")]
    public int IkKneeRearRight { get; set; } = 1284;

    [JsonPropertyName("ikAnkleRearRight_")]
    public int IkAnkleRearRight { get; set; } = 1285;

    [JsonPropertyName("ikHipRearLeft_")]
    public int IkHipRearLeft { get; set; } = 1538;

    [JsonPropertyName("ikKneeRearLeft_")]
    public int IkKneeRearLeft { get; set; } = 1540;

    [JsonPropertyName("ikAnkleRearLeft_")]
    public int IkAnkleRearLeft { get; set; } = 1541;

    [JsonPropertyName("ikFrontWaist_")]
    public int IkFrontWaist { get; set; } = 1;

    [JsonPropertyName("ikRearWaist_")]
    public int IkRearWaist { get; set; } = 1;

    [JsonPropertyName("regAttackTime_")]
    public float RegAttackTime { get; set; } = 3f;

    [JsonPropertyName("regAttackBreakPowerTime_")]
    public float RegAttackBreakPowerTime { get; set; } = -1f;

    [JsonPropertyName("regAttackCoolTimeAILevel1_")]
    public float RegAttackCoolTimeAILevel1 { get; set; } = 5f;

    [JsonPropertyName("regAttackCoolTimeAILevel2_")]
    public float RegAttackCoolTimeAILevel2 { get; set; } = 3f;

    [JsonPropertyName("regAttackCoolTimeAILevel3_")]
    public float RegAttackCoolTimeAILevel3 { get; set; } = 3f;

    [JsonPropertyName("regAttackCoolTimeAILevel4_")]
    public float RegAttackCoolTimeAILevel4 { get; set; } = 2f;

    [JsonPropertyName("regAttackSubTime_")]
    public float RegAttackSubTime { get; set; } = 0.01f;

    [JsonPropertyName("regAttackSignTime_")]
    public float RegAttackSignTime { get; set; } = 2f;

    [JsonPropertyName("regAttackDist_")]
    public float RegAttackDist { get; set; } = 8f;

    [JsonPropertyName("positioningRushDist_")]
    public float PositioningRushDist { get; set; } = 10f;

    [JsonPropertyName("positioningRushTime_")]
    public float PositioningRushTime { get; set; } = 30f;

    [JsonPropertyName("overdriveMotionRate1_")]
    public float OverdriveMotionRate1 { get; set; } = 1.05f;

    [JsonPropertyName("overdriveMotionRate2_")]
    public float OverdriveMotionRate2 { get; set; } = 1.1f;

    [JsonPropertyName("counterShockWaveAttackRate_")]
    public float CounterShockWaveAttackRate { get; set; } = 0.8f;

    [JsonPropertyName("counterShockWaveStunRate_")]
    public float CounterShockWaveStunRate { get; set; } = 1.5f;

    [JsonPropertyName("rockShotScaleMax_")]
    public float RockShotScaleMax { get; set; } = 0.7f;

    [JsonPropertyName("rockShotScaleMin_")]
    public float RockShotScaleMin { get; set; } = 1.2f;

    [JsonPropertyName("breathParamL_")]
    public EmHitBreathParam BreathParamL { get; set; }

    [JsonPropertyName("breathParamR_")]
    public EmHitBreathParam BreathParamR { get; set; }

    [JsonPropertyName("breathAttackRate_")]
    public float BreathAttackRate { get; set; } = 0.6f;

    [JsonPropertyName("breathStunRate_")]
    public float BreathStunRate { get; set; } = 0.3f;

    [JsonPropertyName("breathBuenSec_")]
    public float BreathBuenSec { get; set; } = 5f;

    [JsonPropertyName("breathParamODL_")]
    public EmHitBreathParam BreathParamODL { get; set; }

    [JsonPropertyName("breathParamODR_")]
    public EmHitBreathParam BreathParamODR { get; set; }

    [JsonPropertyName("breathAttackRateOD_")]
    public float BreathAttackRateOD { get; set; } = 0.6f;

    [JsonPropertyName("breathStunRateOD_")]
    public float BreathStunRateOD { get; set; } = 0.3f;

    [JsonPropertyName("breathBuenSecOD_")]
    public float BreathBuenSecOD { get; set; } = 5f;

    [JsonPropertyName("eyeBeamAttackRate_")]
    public float EyeBeamAttackRate { get; set; } = 3f;

    [JsonPropertyName("eyeBeamStunRate_")]
    public float EyeBeamStunRate { get; set; } = 2f;

    [JsonPropertyName("eyeBeamRadius_")]
    public float EyeBeamRadius { get; set; } = 0.7f;

    [JsonPropertyName("eyeBeamLandingPointLadius_")]
    public float EyeBeamLandingPointLadius { get; set; } = 1.5f;

    [JsonPropertyName("eyeBeamExplodeTime_")]
    public float EyeBeamExplodeTime { get; set; } = 2.5f;

    [JsonPropertyName("eyeBeamInitLength_")]
    public float EyeBeamInitLength { get; set; } = 5f;

    [JsonPropertyName("eyeBeamSpeed_")]
    public float EyeBeamSpeed { get; set; } = 0.3f;

    [JsonPropertyName("eyeBeamAddSpeed_")]
    public float EyeBeamAddSpeed { get; set; } = 0.1f;

    [JsonPropertyName("eyeBeamLengthPowRate_")]
    public float EyeBeamLengthPowRate { get; set; } = 2.5f;

    [JsonPropertyName("eyeBeamMinLength_")]
    public float EyeBeamMinLength { get; set; } = 25f;

    [JsonPropertyName("eyeBeamMaxLength_")]
    public float EyeBeamMaxLength { get; set; } = 45f;

    [JsonPropertyName("dpsCheckWeakPointParam_")]
    public EmWeakPointParam DpsCheckWeakPointParam { get; set; }

    [JsonPropertyName("vulcanIntervalTime_")]
    public float VulcanIntervalTime { get; set; } = 0.1f;

    [JsonPropertyName("vulcanDelayFrame_")]
    public int VulcanDelayFrame { get; set; } = 10;

    public Em1900Param()
    {
        Hp = 300000;
        Atk = 1000;
        Break = 8;
        Def = 1f;
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
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 0.75f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 2f;
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
}
