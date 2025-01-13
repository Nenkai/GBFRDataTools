using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Base;

using static GBFRDataTools.Entities.Parameters.Enemy.Em2900.Em2901Param;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7700;

public class Em7700Param : EmBossBaseParam
{
    [JsonPropertyName("typeParam_")]
    public BindingList<TypeParam> TypeParam_ { get; set; } = []; // std::vector<Em7700Param::TypeParam, 3>

    [JsonPropertyName("gopherwoodArkRushListTypeA_")]
    public BindingList<GopherwoodArkRushParam> GopherwoodArkRushListTypeA { get; set; } = []; // std::vector<Em7700Param::GopherwoodArkRushParam>

    [JsonPropertyName("gopherwoodArkRushListTypeB_")]
    public BindingList<GopherwoodArkRushParam> GopherwoodArkRushListTypeB { get; set; } = []; // std::vector<Em7700Param::GopherwoodArkRushParam>

    [JsonPropertyName("gopherwoodArkFinishSlashList_")]
    public BindingList<GopherwoodArkFinishSlashParam> GopherwoodArkFinishSlashList { get; set; } = []; // std::vector<Em7700Param::GopherwoodArkFinishSlashParam>

    [JsonPropertyName("paradiseLostBigLaserList_")]
    public BindingList<ParadiseLostBigLaserParam> ParadiseLostBigLaserList { get; set; } = []; // std::vector<Em7700Param::ParadiseLostBigLaserParam>

    [JsonPropertyName("paradiseLostPowerUpBigLaserList_")]
    public BindingList<ParadiseLostBigLaserParam> ParadiseLostPowerUpBigLaserList { get; set; } = []; // std::vector<Em7700Param::ParadiseLostBigLaserParam>

    [JsonPropertyName("gopherwoodArkRushListHLTypeA_")]
    public BindingList<GopherwoodArkRushParam> GopherwoodArkRushListHLTypeA { get; set; } = []; // std::vector<Em7700Param::GopherwoodArkRushParam>

    [JsonPropertyName("gopherwoodArkRushListHLTypeB_")]
    public BindingList<GopherwoodArkRushParam> GopherwoodArkRushListHLTypeB { get; set; } = []; // std::vector<Em7700Param::GopherwoodArkRushParam>

    [JsonPropertyName("gopherwoodArkFinishSlashListHL_")]
    public BindingList<GopherwoodArkFinishSlashParam> GopherwoodArkFinishSlashListHL { get; set; } = []; // std::vector<Em7700Param::GopherwoodArkFinishSlashParam>

    [JsonPropertyName("gopherwoodArkFinishSlashListHL2_")]
    public BindingList<GopherwoodArkFinishSlashParam> GopherwoodArkFinishSlashListHL2 { get; set; } = []; // std::vector<Em7700Param::GopherwoodArkFinishSlashParam>

    [JsonPropertyName("gopherwoodArkFinishSlashListHL3_")]
    public BindingList<GopherwoodArkFinishSlashParam> GopherwoodArkFinishSlashListHL3 { get; set; } = []; // std::vector<Em7700Param::GopherwoodArkFinishSlashParam>

    [JsonPropertyName("paradiseLostBigLaserListHL_")]
    public BindingList<ParadiseLostBigLaserParam> ParadiseLostBigLaserListHL { get; set; } = []; // std::vector<Em7700Param::ParadiseLostBigLaserParam>

    [JsonPropertyName("paradiseLostBigLaserListHL2_")]
    public BindingList<ParadiseLostBigLaserParam> ParadiseLostBigLaserListHL2 { get; set; } = []; // std::vector<Em7700Param::ParadiseLostBigLaserParam>

    [JsonPropertyName("paradiseLostBigLaserListHL3_")]
    public BindingList<ParadiseLostBigLaserParam> ParadiseLostBigLaserListHL3 { get; set; } = []; // std::vector<Em7700Param::ParadiseLostBigLaserParam>

    [JsonPropertyName("paradiseLostPowerUpBigLaserListHL_")]
    public BindingList<ParadiseLostBigLaserParam> ParadiseLostPowerUpBigLaserListHL { get; set; } = []; // std::vector<Em7700Param::ParadiseLostBigLaserParam>

    [JsonPropertyName("paradiseLostPowerUpBigLaserListHL2_")]
    public BindingList<ParadiseLostBigLaserParam> ParadiseLostPowerUpBigLaserListHL2 { get; set; } = []; // std::vector<Em7700Param::ParadiseLostBigLaserParam>

    [JsonPropertyName("paradiseLostPowerUpBigLaserListHL3_")]
    public BindingList<ParadiseLostBigLaserParam> ParadiseLostPowerUpBigLaserListHL3 { get; set; } = []; // std::vector<Em7700Param::ParadiseLostBigLaserParam>

    [JsonPropertyName("trial8_11CrystalList_")]
    public BindingList<Trial8_11CrystalParam> Trial8_11CrystalList { get; set; } = []; // std::vector<Em7700Param::Trial8_11CrystalParam>

    [JsonPropertyName("penaltyShotSpeedCurve_")]
    public GuiImportableCurve<float> PenaltyShotSpeedCurve { get; set; }

    [JsonPropertyName("trialSword_SwordAppearSec_")]
    public float TrialSword_SwordAppearSec { get; set; } = 1f;

    [JsonPropertyName("trialSword_MagicCircleAppearSec_")]
    public float TrialSword_MagicCircleAppearSec { get; set; } = 0.3f;

    [JsonPropertyName("trialSword_CenterAppearSec_")]
    public float TrialSword_CenterAppearSec { get; set; } = 0.5f;

    [JsonPropertyName("trialSword_SphereAppearSec_")]
    public float TrialSword_SphereAppearSec { get; set; } = 1f;

    [JsonPropertyName("targetCameraTime_")]
    public float TargetCameraTime { get; set; } = 1f;

    [JsonPropertyName("cameraTime_")]
    public float[] CameraTime { get; set; } = new float[16]; // std::array<float,16>

    [JsonPropertyName("paradiseLostAppearanceCameraLookAtOffsetY_")]
    public float ParadiseLostAppearanceCameraLookAtOffsetY { get; set; } = 0f;

    [JsonPropertyName("magicSpreadBulletParamList_")]
    public MagicSpreadBulletParam[] MagicSpreadBulletParamList { get; set; } = new MagicSpreadBulletParam[5];  // std::array<Em7700Param::MagicSpreadBulletParam,5>

    [JsonPropertyName("magicSpreadBulletHLParamList_")]
    public MagicSpreadBulletParam[] MagicSpreadBulletHLParamList { get; set; } = new MagicSpreadBulletParam[5];  // std::array<Em7700Param::MagicSpreadBulletParam,5>

    [JsonPropertyName("magicCurveBulletParamList_")]
    public MagicCurveBulletParam[] MagicCurveBulletParamList { get; set; } = new MagicCurveBulletParam[2]; // std::array<Em7700Param::MagicCurveBulletParam,2>

    [JsonPropertyName("magicCurveBulletHLParamList_")]
    public MagicCurveBulletParam[] MagicCurveBulletHLParamList { get; set; } = new MagicCurveBulletParam[2]; // std::array<Em7700Param::MagicCurveBulletParam,2>

    [JsonPropertyName("magicInstallationParamList_")]
    public MagicInstallationParam[] MagicInstallationParamList { get; set; } = new MagicInstallationParam[2]; // std::array<Em7700Param::MagicInstallationParam,2>

    [JsonPropertyName("magicInstallationHLParamList_")]
    public MagicInstallationParam[] MagicInstallationHLParamList { get; set; } = new MagicInstallationParam[2]; // std::array<Em7700Param::MagicInstallationParam,2>

    [JsonPropertyName("magicHormingLaserTime_")]
    public float MagicHormingLaserTime { get; set; } = 5f;

    [JsonPropertyName("magicHormingLaserAttackRate_")]
    public float MagicHormingLaserAttackRate { get; set; } = 0.3f;

    [JsonPropertyName("magicHormingLaserBreakRate_")]
    public float MagicHormingLaserBreakRate { get; set; } = 1f;

    [JsonPropertyName("magicHormingLaserSpeed_")]
    public float MagicHormingLaserSpeed { get; set; } = 0.7f;

    [JsonPropertyName("magicHormingLaserSpeedMax_")]
    public float MagicHormingLaserSpeedMax { get; set; } = 0.5f;

    [JsonPropertyName("magicHormingLaserSpeedRateEnemyType1_")]
    public float MagicHormingLaserSpeedRateEnemyType1 { get; set; } = 0.3f;

    [JsonPropertyName("magicHormingLaserSpeedRateEnemyType2_")]
    public float MagicHormingLaserSpeedRateEnemyType2 { get; set; } = 0.3f;

    [JsonPropertyName("magicHormingLaserSpeedRateEnemyType3_")]
    public float MagicHormingLaserSpeedRateEnemyType3 { get; set; } = 0.3f;

    [JsonPropertyName("magicHormingLaserMaxEnemyType1")]
    public int MagicHormingLaserMaxEnemyType1 { get; set; } = 4;

    [JsonPropertyName("magicHormingLaserMaxEnemyType2")]
    public int MagicHormingLaserMaxEnemyType2 { get; set; } = 4;

    [JsonPropertyName("magicHormingLaserMaxEnemyType3")]
    public int MagicHormingLaserMaxEnemyType3 { get; set; } = 4;

    [JsonPropertyName("magicHormingLaserStartRadius_")]
    public float MagicHormingLaserStartRadius { get; set; } = 8f;

    [JsonPropertyName("magicHormingLaserAttackDownTime_")]
    public float MagicHormingLaserAttackDownTime { get; set; } = 30f;

    [JsonPropertyName("magicHormingLaserAttackDownRate_")]
    public float MagicHormingLaserAttackDownRate { get; set; } = 50f;

    [JsonPropertyName("magicTimeStopLaserTime_")]
    public float MagicTimeStopLaserTime { get; set; } = 20f;

    [JsonPropertyName("magicTimeStopLaserAttackRate_")]
    public float MagicTimeStopLaserAttackRate { get; set; } = 0.3f;

    [JsonPropertyName("magicTimeStopLaserBreakRate_")]
    public float MagicTimeStopLaserBreakRate { get; set; } = 1f;

    [JsonPropertyName("magicTimeStopLaserSpeed_")]
    public float MagicTimeStopLaserSpeed { get; set; } = 0.7f;

    [JsonPropertyName("magicTimeStopLaserSpeedMax_")]
    public float MagicTimeStopLaserSpeedMax { get; set; } = 0.5f;

    [JsonPropertyName("magicTimeStopLaserSpeedRateEnemyType1_")]
    public float MagicTimeStopLaserSpeedRateEnemyType1 { get; set; } = 0.3f;

    [JsonPropertyName("magicTimeStopLaserSpeedRateEnemyType2_")]
    public float MagicTimeStopLaserSpeedRateEnemyType2 { get; set; } = 0.3f;

    [JsonPropertyName("magicTimeStopLaserSpeedRateEnemyType3_")]
    public float MagicTimeStopLaserSpeedRateEnemyType3 { get; set; } = 0.3f;

    [JsonPropertyName("magicTimeStopLaserMaxEnemyType1")]
    public int MagicTimeStopLaserMaxEnemyType1 { get; set; } = 8;

    [JsonPropertyName("magicTimeStopLaserMaxEnemyType2")]
    public int MagicTimeStopLaserMaxEnemyType2 { get; set; } = 8;

    [JsonPropertyName("magicTimeStopLaserMaxEnemyType3")]
    public int MagicTimeStopLaserMaxEnemyType3 { get; set; } = 8;

    [JsonPropertyName("magicTimeStopLaserStartRadius_")]
    public float MagicTimeStopLaserStartRadius { get; set; } = 6f;

    [JsonPropertyName("magicTimeStopLaserStopTime_")]
    public float MagicTimeStopLaserStopTime { get; set; } = 15f;

    [JsonPropertyName("magicTimeStopLaserAttackDownTime_")]
    public float MagicTimeStopLaserAttackDownTime { get; set; } = 30f;

    [JsonPropertyName("magicTimeStopLaserAttackDownRate_")]
    public float MagicTimeStopLaserAttackDownRate { get; set; } = 65f;

    [JsonPropertyName("magic123LaserAtkRate_")]
    public float Magic123LaserAtkRate { get; set; } = 0.3f;

    [JsonPropertyName("magic123LaserBreakRate_")]
    public float Magic123LaserBreakRate { get; set; } = 1.5f;

    [JsonPropertyName("magicBarrageLaserAttackSignSec_")]
    public float MagicBarrageLaserAttackSignSec { get; set; } = 3f;

    [JsonPropertyName("magicBarrageFallingLaserSignSec_")]
    public float MagicBarrageFallingLaserSignSec { get; set; } = 0.7f;

    [JsonPropertyName("magicBarrageFallingLaserTargetFrontDistance_")]
    public float MagicBarrageFallingLaserTargetFrontDistance { get; set; } = 5f;

    [JsonPropertyName("magicBarrageFallingLaserSafetyRange_")]
    public float MagicBarrageFallingLaserSafetyRange { get; set; } = 5f;

    [JsonPropertyName("magicBarrageOuterLaserMaxAngle_")]
    public float MagicBarrageOuterLaserMaxAngle { get; set; } = 90f;

    [JsonPropertyName("BarrageLaserListHL_")]
    public BindingList<BarrageLaserParam> BarrageLaserListHL { get; set; } = []; // std::vector<Em7700Param::BarrageLaserParam>

    [JsonPropertyName("barrageLaserParamList_")]
    public BindingList<BarrageLaserParam>[] BarrageLaserParamList { get; set; } = new BindingList<BarrageLaserParam>[3]; // std::array<std::vector<Em7700Param::BarrageLaserParam>, 3>

    [JsonPropertyName("barrageLaserCommonParamList_")]
    public BarrageLaserCommonParam[] BarrageLaserCommonParamList { get; set; } = new BarrageLaserCommonParam[3]; // std::array<Em7700Param::BarrageLaserCommonParam,3>

    [JsonPropertyName("barrageLaserTriggerHpRateList_")]
    public int[] BarrageLaserTriggerHpRateList { get; set; } = new int[3]; // std::array<int,3>

    [JsonPropertyName("shotSwordSlashOffsetZ_")]
    public float ShotSwordSlashOffsetZ { get; set; } = 5f;

    [JsonPropertyName("iblisWarpOffsetZ_")]
    public float IblisWarpOffsetZ { get; set; } = -10f;

    [JsonPropertyName("iblisWarpOffsetY_")]
    public float IblisWarpOffsetY { get; set; } = 3f;

    [JsonPropertyName("iblisHomingRate_")]
    public float IblisHomingRate { get; set; } = 2f;

    [JsonPropertyName("iblisFinishTargetOffsetX_")]
    public float IblisFinishTargetOffsetX { get; set; } = 0f;

    [JsonPropertyName("iblisFinishTargetOffsetZ_")]
    public float IblisFinishTargetOffsetZ { get; set; } = 0f;

    [JsonPropertyName("installationBomSignWaitSec_")]
    public float InstallationBomSignWaitSec { get; set; } = 1.5f;

    [JsonPropertyName("installationBomExplodePresageSec_")]
    public float InstallationBomExplodePresageSec { get; set; } = 0.5f;

    [JsonPropertyName("installationBomBodyScale_")]
    public float InstallationBomBodyScale { get; set; } = 1f;

    [JsonPropertyName("installationBomExplodeSignAttackPowerRate_")]
    public float InstallationBomExplodeSignAttackPowerRate { get; set; } = 0.4f;

    [JsonPropertyName("installationBomExplodeSignBreakPowerRate_")]
    public float InstallationBomExplodeSignBreakPowerRate { get; set; } = 0.5f;

    [JsonPropertyName("installationBomExplodeAttackPowerRate_")]
    public float InstallationBomExplodeAttackPowerRate { get; set; } = 0.4f;

    [JsonPropertyName("installationBomExplodeBreakPowerRate_")]
    public float InstallationBomExplodeBreakPowerRate { get; set; } = 0.5f;

    [JsonPropertyName("installationBomExplodeSignAttackPowerRateHl_")]
    public float InstallationBomExplodeSignAttackPowerRateHl { get; set; } = 0.4f;

    [JsonPropertyName("installationBomExplodeSignBreakPowerRateHl_")]
    public float InstallationBomExplodeSignBreakPowerRateHl { get; set; } = 1f;

    [JsonPropertyName("installationBomExplodeAttackPowerRateHl_")]
    public float InstallationBomExplodeAttackPowerRateHl { get; set; } = 0.4f;

    [JsonPropertyName("installationBomExplodeBreakPowerRateHl_")]
    public float InstallationBomExplodeBreakPowerRateHl { get; set; } = 1f;

    [JsonPropertyName("crackAttackRate_")]
    public float CrackAttackRate { get; set; } = 5f;

    [JsonPropertyName("crackBreakRate_")]
    public float CrackBreakRate { get; set; } = 5f;

    [JsonPropertyName("crackSignSec_")]
    public float CrackSignSec { get; set; } = 4f;

    [JsonPropertyName("crackAttackSec_")]
    public float CrackAttackSec { get; set; } = 0.1f;

    [JsonPropertyName("crackBranchParamTable_")]
    public BindingList<CrackBranchParam> CrackBranchParamTable { get; set; } = []; // std::vector<Em7700Param::CrackBranchParam>

    [JsonPropertyName("counterExplosionPresageSecond_")]
    public float CounterExplosionPresageSecond { get; set; } = 1f;

    [JsonPropertyName("counterExplosionAttackRadius_")]
    public float CounterExplosionAttackRadius { get; set; } = 4f;

    [JsonPropertyName("counterExplosionAttackSecond_")]
    public float CounterExplosionAttackSecond { get; set; } = 0.3f;

    [JsonPropertyName("counterExplosionOneLineMax_")]
    public int CounterExplosionOneLineMax { get; set; } = 10;

    [JsonPropertyName("counterExplosionInterval_")]
    public float CounterExplosionInterval { get; set; } = 0.25f;

    [JsonPropertyName("counterExplosionAddIntervalRate_")]
    public float CounterExplosionAddIntervalRate { get; set; } = 0.65f;

    [JsonPropertyName("counterExplosionFluctuation_")]
    public float CounterExplosionFluctuation { get; set; } = 5f;

    [JsonPropertyName("counterExplosionStartOffsetZ_")]
    public float CounterExplosionStartOffsetZ { get; set; } = 15f;

    [JsonPropertyName("counterExplosionAttackPowerRate_")]
    public float CounterExplosionAttackPowerRate { get; set; } = 1.5f;

    [JsonPropertyName("counterExplosionBreakPowerRate_")]
    public float CounterExplosionBreakPowerRate { get; set; } = 3.5f;

    [JsonPropertyName("counterExplosionBanAbilitySecond_")]
    public float CounterExplosionBanAbilitySecond { get; set; } = 20f;

    [JsonPropertyName("swordComboFinish2ForceDist_")]
    public float SwordComboFinish2ForceDist { get; set; } = 11.5f;

    [JsonPropertyName("swordComboFinish2InhaleDist_")]
    public float SwordComboFinish2InhaleDist { get; set; } = 12f;

    [JsonPropertyName("swordComboFinish2ForceSpeed_")]
    public float SwordComboFinish2ForceSpeed { get; set; } = 12f;

    [JsonPropertyName("paradiseLostChargeLevel2TimeRate_")]
    public float ParadiseLostChargeLevel2TimeRate { get; set; } = 0.25f;

    [JsonPropertyName("paradiseLostChargeLevel3TimeRate_")]
    public float ParadiseLostChargeLevel3TimeRate { get; set; } = 0.5f;

    [JsonPropertyName("paradiseLostExplosionTargetPlayerShotCount_")]
    public int ParadiseLostExplosionTargetPlayerShotCount { get; set; } = 10;

    [JsonPropertyName("paradiseLostExplosionPresageSecond_")]
    public float ParadiseLostExplosionPresageSecond { get; set; } = 2.5f;

    [JsonPropertyName("paradiseLostExplosionAttackRadius_")]
    public float ParadiseLostExplosionAttackRadius { get; set; } = 3f;

    [JsonPropertyName("paradiseLostExplosionAttackSecond_")]
    public float ParadiseLostExplosionAttackSecond { get; set; } = 0.25f;

    [JsonPropertyName("paradiseLostExplosionAttackRate_")]
    public float ParadiseLostExplosionAttackRate { get; set; } = 1f;

    [JsonPropertyName("paradiseLostExplosionBreakRate_")]
    public float ParadiseLostExplosionBreakRate { get; set; } = 2f;

    [JsonPropertyName("paradiseLostBigLaserAttackRate_")]
    public float ParadiseLostBigLaserAttackRate { get; set; } = 1f;

    [JsonPropertyName("paradiseLostBigLaserBreakRate_")]
    public float ParadiseLostBigLaserBreakRate { get; set; } = 2f;

    [JsonPropertyName("paradiseLostPowerUpExplosionTargetPlayerShotCount_")]
    public int ParadiseLostPowerUpExplosionTargetPlayerShotCount { get; set; } = 10;

    [JsonPropertyName("paradiseLostPowerUpExplosionPresageSecond_")]
    public float ParadiseLostPowerUpExplosionPresageSecond { get; set; } = 2.5f;

    [JsonPropertyName("paradiseLostPowerUpExplosionAttackRadius_")]
    public float ParadiseLostPowerUpExplosionAttackRadius { get; set; } = 4.5f;

    [JsonPropertyName("paradiseLostPowerUpExplosionAttackSecond_")]
    public float ParadiseLostPowerUpExplosionAttackSecond { get; set; } = 0.25f;

    [JsonPropertyName("paradiseLostPowerUpExplosionAttackRate_")]
    public float ParadiseLostPowerUpExplosionAttackRate { get; set; } = 1.5f;

    [JsonPropertyName("paradiseLostPowerUpExplosionBreakRate_")]
    public float ParadiseLostPowerUpExplosionBreakRate { get; set; } = 2.5f;

    [JsonPropertyName("paradiseLostPowerUpBigLaserAttackRate_")]
    public float ParadiseLostPowerUpBigLaserAttackRate { get; set; } = 1.5f;

    [JsonPropertyName("paradiseLostPowerUpBigLaserBreakRate_")]
    public float ParadiseLostPowerUpBigLaserBreakRate { get; set; } = 2.5f;

    [JsonPropertyName("paradiseLostShinExplosionTargetPlayerShotCount_")]
    public int ParadiseLostShinExplosionTargetPlayerShotCount { get; set; } = 5;

    [JsonPropertyName("paradiseLostShinExplosionPresageSecond_")]
    public float ParadiseLostShinExplosionPresageSecond { get; set; } = 1.5f;

    [JsonPropertyName("paradiseLostShinBigLaserPresageSecMinRate_")]
    public float ParadiseLostShinBigLaserPresageSecMinRate { get; set; } = 0.5f;

    [JsonPropertyName("paradiseLostShinExplosionAttackRadius_")]
    public float ParadiseLostShinExplosionAttackRadius { get; set; } = 4.5f;

    [JsonPropertyName("paradiseLostShinExplosionAttackSecond_")]
    public float ParadiseLostShinExplosionAttackSecond { get; set; } = 0.25f;

    [JsonPropertyName("paradiseLostShinExplosionAttackRate_")]
    public float ParadiseLostShinExplosionAttackRate { get; set; } = 5f;

    [JsonPropertyName("paradiseLostShinExplosionBreakRate_")]
    public float ParadiseLostShinExplosionBreakRate { get; set; } = 5f;

    [JsonPropertyName("paradiseLostShinBigLaserAttackRate_")]
    public float ParadiseLostShinBigLaserAttackRate { get; set; } = 5f;

    [JsonPropertyName("paradiseLostShinBigLaserBreakRate_")]
    public float ParadiseLostShinBigLaserBreakRate { get; set; } = 5f;

    [JsonPropertyName("paradiseLostChargeExplosionTargetPlayerShotCount_")]
    public int ParadiseLostChargeExplosionTargetPlayerShotCount { get; set; } = 20;

    [JsonPropertyName("paradiseLostChargeTimeBlockingCountMaxHL_")]
    public int ParadiseLostChargeTimeBlockingCountMaxHL { get; set; } = 5;

    [JsonPropertyName("paradiseLostChargeTimeBlockingTimeRateHL_")]
    public float ParadiseLostChargeTimeBlockingTimeRateHL { get; set; } = 0.07f;

    [JsonPropertyName("paradiseLostChargeAttackThunderMax_")]
    public int ParadiseLostChargeAttackThunderMax { get; set; } = 30;

    [JsonPropertyName("paradiseLostChargeAttackThunderPresageSecond_")]
    public float ParadiseLostChargeAttackThunderPresageSecond { get; set; } = 1.5f;

    [JsonPropertyName("paradiseLostChargeAttackThunderAttackRadius_")]
    public float ParadiseLostChargeAttackThunderAttackRadius { get; set; } = 2.5f;

    [JsonPropertyName("paradiseLostChargeAttackThunderAttackSecond_")]
    public float ParadiseLostChargeAttackThunderAttackSecond { get; set; } = 0.2f;

    [JsonPropertyName("paradiseLostChargeAttackThunderStartWait")]
    public float ParadiseLostChargeAttackThunderStartWait { get; set; } = 0.5f;

    [JsonPropertyName("paradiseLostChargeAttackThunderInterval_")]
    public float ParadiseLostChargeAttackThunderInterval { get; set; } = 0.1f;

    [JsonPropertyName("paradiseLostChargeAttackThunderAttackPowerRate_")]
    public float ParadiseLostChargeAttackThunderAttackPowerRate { get; set; } = 0.2f;

    [JsonPropertyName("paradiseLostChargeAttackThunderBreakPowerRate_")]
    public float ParadiseLostChargeAttackThunderBreakPowerRate { get; set; } = 0.5f;

    [JsonPropertyName("paradiseLostChargeAttackThunderBanSpArtsSecond_")]
    public float ParadiseLostChargeAttackThunderBanSpArtsSecond { get; set; } = 30f;

    [JsonPropertyName("paradiseLostChargeAttackThunderExclusionAreaRadius_")]
    public float ParadiseLostChargeAttackThunderExclusionAreaRadius { get; set; } = 10f;

    [JsonPropertyName("changeEnemyType1TriggerHpRate_")]
    public int ChangeEnemyType1TriggerHpRate { get; set; } = 0;

    [JsonPropertyName("changeEnemyType2TriggerHpRate_")]
    public int ChangeEnemyType2TriggerHpRate { get; set; } = 60;

    [JsonPropertyName("linkParamType2HL_")]
    public EmLinkAttackParam LinkParamType2HL { get; set; }

    [JsonPropertyName("linkParamType3HL_")]
    public EmLinkAttackParam LinkParamType3HL { get; set; }

    [JsonPropertyName("specialArtsTriggerHpRate1st_")]
    public int SpecialArtsTriggerHpRate1st { get; set; } = 60;

    [JsonPropertyName("specialArtsTriggerHpRate2nd_")]
    public int SpecialArtsTriggerHpRate2nd { get; set; } = 30;

    [JsonPropertyName("specialArtsTriggerHpRate1stHL_")]
    public int SpecialArtsTriggerHpRate1stHL { get; set; } = 75;

    [JsonPropertyName("specialArtsTriggerHpRate2ndHL_")]
    public int SpecialArtsTriggerHpRate2ndHL { get; set; } = 40;

    [JsonPropertyName("specialArtsUnexpandCircleSize_")]
    public float SpecialArtsUnexpandCircleSize { get; set; } = 3f;

    [JsonPropertyName("specialArtsExpandCircleSize_")]
    public float SpecialArtsExpandCircleSize { get; set; } = 5f;

    [JsonPropertyName("specialArtsExpandCirclePhaseMaxCount_")]
    public int SpecialArtsExpandCirclePhaseMaxCount { get; set; } = 3;

    [JsonPropertyName("specialArtsAreaInitPosSets_")]
    public BindingList<Vector4> SpecialArtsAreaInitPosSets { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("specialArtsAreaInitPosIndices1st_")]
    public BindingList<int> SpecialArtsAreaInitPosIndices1st { get; set; } = []; // std::vector<int>

    [JsonPropertyName("specialArtsAreaInitPosIndices2nd_")]
    public BindingList<int> SpecialArtsAreaInitPosIndices2nd { get; set; }

    [JsonPropertyName("specialArtsPointLaserWaitSec_")]
    public float SpecialArtsPointLaserWaitSec { get; set; } = 1f;

    [JsonPropertyName("specialArtsPointLaserIntervalSec_")]
    public float SpecialArtsPointLaserIntervalSec { get; set; } = 0.3f;

    [JsonPropertyName("specialArtsPointLaserTargettingCount_")]
    public int SpecialArtsPointLaserTargettingCount { get; set; } = 2;

    [JsonPropertyName("specialArtsPointLaserAttackRate_")]
    public float SpecialArtsPointLaserAttackRate { get; set; } = 0.5f;

    [JsonPropertyName("specialArtsPointLaserBreakRate_")]
    public float SpecialArtsPointLaserBreakRate { get; set; } = 2.5f;

    [JsonPropertyName("specialArtsLaserMoveSpeed_")]
    public float SpecialArtsLaserMoveSpeed { get; set; } = 7.5f;

    [JsonPropertyName("specialArtsLaserHomingRate_")]
    public float SpecialArtsLaserHomingRate { get; set; } = 0.05f;

    [JsonPropertyName("specialArtsLaserAttackRate_")]
    public float SpecialArtsLaserAttackRate { get; set; } = 0.5f;

    [JsonPropertyName("specialArtsLaserBreakRate_")]
    public float SpecialArtsLaserBreakRate { get; set; } = 2.5f;

    [JsonPropertyName("specialArtsMeteoIntervalSec_")]
    public float SpecialArtsMeteoIntervalSec { get; set; } = 2f;

    [JsonPropertyName("specialArtsMeteoCreateHeight_")]
    public float SpecialArtsMeteoCreateHeight { get; set; } = 50f;

    [JsonPropertyName("specialArtsMeteoRippleScale_")]
    public float SpecialArtsMeteoRippleScale { get; set; } = 1f;

    [JsonPropertyName("specialArtsFinishPointLaserEnableSec_")]
    public float SpecialArtsFinishPointLaserEnableSec { get; set; } = 1f;

    [JsonPropertyName("specialArtsMeteoFallSpeed_")]
    public float SpecialArtsMeteoFallSpeed { get; set; } = 20f;

    [JsonPropertyName("specialArtsWaitFinishSec_")]
    public float SpecialArtsWaitFinishSec { get; set; } = 12f;

    [JsonPropertyName("specialArtsFinishSignSec_")]
    public float SpecialArtsFinishSignSec { get; set; } = 5f;

    [JsonPropertyName("specialArtsFinishRadius_")]
    public float SpecialArtsFinishRadius { get; set; } = 18f;

    [JsonPropertyName("specialArtsFirstTimeStopTime_")]
    public float SpecialArtsFirstTimeStopTime { get; set; } = 5f;

    [JsonPropertyName("specialArtsFirstLaserTime_")]
    public float SpecialArtsFirstLaserTime { get; set; } = 3f;

    [JsonPropertyName("specialArtsFinishTimeStopDelay_")]
    public float SpecialArtsFinishTimeStopDelay { get; set; } = 1.3f;

    [JsonPropertyName("specialArtsFinishTimeStopTime_")]
    public float SpecialArtsFinishTimeStopTime { get; set; } = 5f;

    [JsonPropertyName("specialArtsTimeStopLaserNum_")]
    public int SpecialArtsTimeStopLaserNum { get; set; } = 15;

    [JsonPropertyName("hlSpecialArtsExpandCircleSize_")]
    public float HlSpecialArtsExpandCircleSize { get; set; } = 8f;

    [JsonPropertyName("hlSpecialArtsPointLaserIntervalSec_")]
    public float HlSpecialArtsPointLaserIntervalSec { get; set; } = 0.08f;

    [JsonPropertyName("hlSpecialArtsPointLaserTargettingCount_")]
    public int HlSpecialArtsPointLaserTargettingCount { get; set; } = 1;

    [JsonPropertyName("hlSpecialArtsMeteoIntervalSec_")]
    public float HlSpecialArtsMeteoIntervalSec { get; set; } = 1.3f;

    [JsonPropertyName("hlSpecialArtsMeteoFallSpeed_")]
    public float HlSpecialArtsMeteoFallSpeed { get; set; } = 30f;

    [JsonPropertyName("hlSpecialArtsAreaInitPosIndices1st_")]
    public BindingList<int> HlSpecialArtsAreaInitPosIndices1st { get; set; } = []; // std::vector<int>

    [JsonPropertyName("hlSpecialArtsAreaInitPosIndices2nd_")]
    public BindingList<int> HlSpecialArtsAreaInitPosIndices2nd { get; set; } = []; // std::vector<int>

    [JsonPropertyName("gopherwoodArkTriggerHpRate_")]
    public int GopherwoodArkTriggerHpRate { get; set; } = 20;

    [JsonPropertyName("gopherwoodArkTriggerHpRateHL_")]
    public int GopherwoodArkTriggerHpRateHL { get; set; } = 30;

    [JsonPropertyName("gopherwoodArkSlashWidth_")]
    public float GopherwoodArkSlashWidth { get; set; } = 2f;

    [JsonPropertyName("gopherwoodArkSlashHeight_")]
    public float GopherwoodArkSlashHeight { get; set; } = 3f;

    [JsonPropertyName("gopherwoodArkSlashAttackRate_")]
    public float GopherwoodArkSlashAttackRate { get; set; } = 5f;

    [JsonPropertyName("gopherwoodArkSlashBreakRate_")]
    public float GopherwoodArkSlashBreakRate { get; set; } = 10f;

    [JsonPropertyName("gopherwoodArkSlashAttackSizeWidthRate_")]
    public float GopherwoodArkSlashAttackSizeWidthRate { get; set; } = 0.9f;

    [JsonPropertyName("theEndChargeLevel2TimeRate_")]
    public float TheEndChargeLevel2TimeRate { get; set; } = 0.2f;

    [JsonPropertyName("theEndChargeLevel3TimeRate_")]
    public float TheEndChargeLevel3TimeRate { get; set; } = 0.5f;

    [JsonPropertyName("theEndHpRate_")]
    public int TheEndHpRate { get; set; } = 10;

    [JsonPropertyName("theEndChargeTime_")]
    public float TheEndChargeTime { get; set; } = 40f;

    [JsonPropertyName("theEndChargeTimeHl_")]
    public float TheEndChargeTimeHl { get; set; } = 25f;

    [JsonPropertyName("powerupAttackPowerRate_")]
    public float PowerupAttackPowerRate { get; set; } = 1.3f;

    [JsonPropertyName("powerupBreakPowerRate_")]
    public float PowerupBreakPowerRate { get; set; } = 1f;

    [JsonPropertyName("powerupAttackPowerRateHL_")]
    public float PowerupAttackPowerRateHL { get; set; } = 1.3f;

    [JsonPropertyName("powerupBreakPowerRateHL_")]
    public float PowerupBreakPowerRateHL { get; set; } = 1f;

    [JsonPropertyName("powerupOverDriveParam_")]
    public OverDriveParam PowerupOverDriveParam { get; set; }

    [JsonPropertyName("overDriveHLParam_")]
    public OverDriveParam OverDriveHLParam { get; set; }

    [JsonPropertyName("powerupOverDriveHLParam_")]
    public OverDriveParam PowerupOverDriveHLParam { get; set; }

    [JsonPropertyName("timeStopEffectVanishTime_")]
    public float TimeStopEffectVanishTime { get; set; } = 1.3f;

    [JsonPropertyName("timeStopRelaseDelay_")]
    public float TimeStopRelaseDelay { get; set; } = 0.666f;

    [JsonPropertyName("emissiveParamNormal_")]
    public CharacterEmissiveParam EmissiveParamNormal { get; set; }

    [JsonPropertyName("pl2100FsmInfixName_")]
    public string Pl2100FsmInfixName { get; set; }

    [JsonPropertyName("stageRadiusSize_")]
    public float StageRadiusSize { get; set; } = 25f;

    [JsonPropertyName("stageCenterPos_")]
    public Vector4 StageCenterPos { get; set; } = new Vector4(0f, 0f, 0f, 0f);

    [JsonPropertyName("trialEm7700Height_")]
    public float TrialEm7700Height { get; set; } = 10f;

    [JsonPropertyName("trialPl2100RestraintPos_")]
    public Vector4 TrialPl2100RestraintPos { get; set; } = new Vector4(3.32f, 10f, -2.9f, 1f);

    [JsonPropertyName("isAllViewNormal_")]
    public bool IsAllViewNormal { get; set; } = false;

    [JsonPropertyName("isAllViewHL_")]
    public bool IsAllViewHL { get; set; } = false;

    [JsonPropertyName("isActiveCounterBuff_")]
    public bool IsActiveCounterBuff { get; set; } = true;

    [JsonPropertyName("buffTimerAddRate_")]
    public float BuffTimerAddRate { get; set; } = 0.5f;

    public Em7700Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 15;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 15;
        HateRateFarPlayer = 25;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
        HateRateBackAngle = 5;
        HateRateDamage = 55;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 5;
        HateUpdateTime = 1f;
        DamageToHateRate = 0.002f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0.001f;
        FarHateDecRate = 0f;
        CombatPower = 50;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 1;
        LinkAttackCameraDistRate = 0f;
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
        IsEnableSyncWeaponAnim = true;
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

    public class CrackBranchParam
    {
        [JsonPropertyName("offsetX_")]
        public float OffsetX { get; set; }

        [JsonPropertyName("offsetZ_")]
        public float OffsetZ { get; set; }

        [JsonPropertyName("degreeY_")]
        public float DegreeY { get; set; }

        [JsonPropertyName("length_")]
        public float Length { get; set; }

        [JsonPropertyName("width_")]
        public float Width { get; set; }

        [JsonPropertyName("id_")]
        public int Id { get; set; }

        [JsonPropertyName("parentId_")]
        public int ParentId { get; set; }

        public CrackBranchParam()
        {
        }
    }

    public class TypeParam
    {
        [JsonPropertyName("levelAIParam_")]
        public LevelAIParam[] LevelAIParam { get; set; } = new LevelAIParam[5]; // std::array<Em7700Param::LevelAIParam,5>

        public TypeParam()
        {
        }
    }


    public class MagicSpreadBulletParam
    {
        [JsonPropertyName("inholeBaseSpeed_")]
        public float InholeBaseSpeed { get; set; }

        [JsonPropertyName("inholeAddSpeed_")]
        public float InholeAddSpeed { get; set; }

        [JsonPropertyName("inholeDist_")]
        public float InholeDist { get; set; }

        [JsonPropertyName("inholeDistSqr_")]
        public float InholeDistSqr { get; set; }

        [JsonPropertyName("isWaveDegreeRandom_")]
        public bool IsWaveDegreeRandom { get; set; }

        [JsonPropertyName("waveShotNum_")]
        public BindingList<int> WaveShotNum { get; set; } = []; // std::vector<int>

        [JsonPropertyName("waveDegree_")]
        public BindingList<float> WaveDegree { get; set; } = []; // std::vector<float>

        [JsonPropertyName("waveShotTimes_")]
        public int WaveShotTimes { get; set; }

        [JsonPropertyName("waveShotInterval_")]
        public float WaveShotInterval { get; set; }

        [JsonPropertyName("waveShotDistance_")]
        public float WaveShotDistance { get; set; }

        [JsonPropertyName("firstWaveDistance_")]
        public float FirstWaveDistance { get; set; }

        [JsonPropertyName("shotPosRandom_")]
        public float ShotPosRandom { get; set; }

        [JsonPropertyName("shotOffsetHeight_")]
        public float ShotOffsetHeight { get; set; }

        public MagicSpreadBulletParam()
        {
        }
    }


    public class MagicCurveBulletParam
    {
        [JsonPropertyName("shotNum_")]
        public int ShotNum { get; set; }

        [JsonPropertyName("offsetHeight_")]
        public float OffsetHeight { get; set; }

        [JsonPropertyName("shotUserCustomType_")]
        public int ShotUserCustomType { get; set; }

        public MagicCurveBulletParam()
        {
        }
    }


    public class MagicInstallationParam
    {
        [JsonPropertyName("shotNum_")]
        public int ShotNum { get; set; }

        [JsonPropertyName("baseRadius_")]
        public float BaseRadius { get; set; }

        [JsonPropertyName("randRadius_")]
        public float RandRadius { get; set; }

        [JsonPropertyName("explodeWaitSec_")]
        public float ExplodeWaitSec { get; set; }

        public MagicInstallationParam()
        {
        }
    }

    public class GopherwoodArkRushParam
    {
        [JsonPropertyName("start_")]
        public Vector4 Start { get; set; }

        [JsonPropertyName("end_")]
        public Vector4 End { get; set; }

        [JsonPropertyName("useStartGate_")]
        public bool UseStartGate { get; set; }

        [JsonPropertyName("useEndGate_")]
        public bool UseEndGate { get; set; }

        [JsonPropertyName("isView_")]
        public bool IsView { get; set; }

        public GopherwoodArkRushParam()
        {
        }
    }


    public class GopherwoodArkFinishSlashParam
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }

        [JsonPropertyName("waitTime_")]
        public float WaitTime { get; set; }

        [JsonPropertyName("presageTime_")]
        public float PresageTime { get; set; }

        [JsonPropertyName("slashTime_")]
        public float SlashTime { get; set; }

        [JsonPropertyName("isGroupAttack_")]
        public bool IsGroupAttack { get; set; }

        [JsonPropertyName("isView_")]
        public bool IsView { get; set; }

        public GopherwoodArkFinishSlashParam()
        {
        }
    }


    public class ParadiseLostBigLaserParam
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }

        [JsonPropertyName("waitTime_")]
        public float WaitTime { get; set; }

        [JsonPropertyName("presageWaitTime_")]
        public float PresageWaitTime { get; set; }

        [JsonPropertyName("presageTime_")]
        public float PresageTime { get; set; }

        [JsonPropertyName("isView_")]
        public bool IsView { get; set; }

        public ParadiseLostBigLaserParam()
        {
        }
    }


    public class Trial8_11CrystalParam
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }

        public Trial8_11CrystalParam()
        {
        }
    }


    public class BarrageLaserParam
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }

        [JsonPropertyName("rot_")]
        public Vector4 Rot { get; set; }

        [JsonPropertyName("targetPos_")]
        public Vector4 TargetPos { get; set; }

        [JsonPropertyName("signSec_")]
        public float SignSec { get; set; }

        [JsonPropertyName("hormingSec_")]
        public float HormingSec { get; set; }

        [JsonPropertyName("attackSec_")]
        public float AttackSec { get; set; }

        [JsonPropertyName("appearWaitSec_")]
        public float AppearWaitSec { get; set; }

        [JsonPropertyName("isView_")]
        public bool IsView { get; set; }

        public BarrageLaserParam()
        {
        }
    }


    public class BarrageLaserCommonParam
    {
        [JsonPropertyName("magicBarrageLaserFallNum_")]
        public int MagicBarrageLaserFallNum { get; set; }

        [JsonPropertyName("magicBarrageLaserFallSec_")]
        public float MagicBarrageLaserFallSec { get; set; }

        [JsonPropertyName("magicBarrageOuterLaserStartWaitSec_")]
        public float MagicBarrageOuterLaserStartWaitSec { get; set; }

        [JsonPropertyName("magicBarrageFallingLaserStartWaitSec_")]
        public float MagicBarrageFallingLaserStartWaitSec { get; set; }

        [JsonPropertyName("magicBarrageFallingLaserTargetFreq_")]
        public int MagicBarrageFallingLaserTargetFreq { get; set; }

        [JsonPropertyName("magicBarrageLaserAttackEndWaitSec_")]
        public float MagicBarrageLaserAttackEndWaitSec { get; set; }

        [JsonPropertyName("magicBarrageLaserForceDist_")]
        public float MagicBarrageLaserForceDist { get; set; }

        [JsonPropertyName("magicBarrageLaserForceSpeed_")]
        public float MagicBarrageLaserForceSpeed { get; set; }

        [JsonPropertyName("magicBarrageLaserFirstHalfSec_")]
        public float MagicBarrageLaserFirstHalfSec { get; set; }

        [JsonPropertyName("magicBarrageLaserSecondHalfFallSec_")]
        public float MagicBarrageLaserSecondHalfFallSec { get; set; }

        public BarrageLaserCommonParam()
        {
        }
    }

    public class UseActionParam
    {
        [JsonPropertyName("useAction_")]
        public bool[] UseAction { get; set; } = new bool[23]; // std::array<bool,23>

        public UseActionParam()
        {
        }
    }

    public class LevelAIParam
    {
        [JsonPropertyName("movePhaseCoolTimeSecond_")]
        public float MovePhaseCoolTimeSecond { get; set; }

        [JsonPropertyName("moveTeleportTimeSecond_")]
        public float MoveTeleportTimeSecond { get; set; }

        [JsonPropertyName("odAbilityCoolTimeSecond_")]
        public float OdAbilityCoolTimeSecond { get; set; }

        [JsonPropertyName("paradiseLostChargeAbilityShortCoolTimeSecond_")]
        public float ParadiseLostChargeAbilityShortCoolTimeSecond { get; set; }

        [JsonPropertyName("oneShotTrialCoolTimeSecond_")]
        public float OneShotTrialCoolTimeSecond { get; set; }

        [JsonPropertyName("swordFinish1CoolTimeSecond_")]
        public float SwordFinish1CoolTimeSecond { get; set; }

        [JsonPropertyName("swordFinish2CoolTimeSecond_")]
        public float SwordFinish2CoolTimeSecond { get; set; }

        [JsonPropertyName("swordFinish3CoolTimeSecond_")]
        public float SwordFinish3CoolTimeSecond { get; set; }

        [JsonPropertyName("swordFinish4CoolTimeSecond_")]
        public float SwordFinish4CoolTimeSecond { get; set; }

        [JsonPropertyName("magicFinish1CoolTimeSecond_")]
        public float MagicFinish1CoolTimeSecond { get; set; }

        [JsonPropertyName("magicFinish2CoolTimeSecond_")]
        public float MagicFinish2CoolTimeSecond { get; set; }

        [JsonPropertyName("magicFinish3CoolTimeSecond_")]
        public float MagicFinish3CoolTimeSecond { get; set; }

        [JsonPropertyName("magicInstallationCoolTimeSecond_")]
        public float MagicInstallationCoolTimeSecond { get; set; }

        [JsonPropertyName("magicHormingLaserCoolTimeSecond_")]
        public float MagicHormingLaserCoolTimeSecond { get; set; }

        [JsonPropertyName("magicTimeStopLaserCoolTimeSecond_")]
        public float MagicTimeStopLaserCoolTimeSecond { get; set; }

        [JsonPropertyName("magicBarrageLaserCoolTimeSecond_")]
        public float MagicBarrageLaserCoolTimeSecond { get; set; }

        [JsonPropertyName("magicCrackGroundLaserCoolTimeSecond_")]
        public float MagicCrackGroundLaserCoolTimeSecond { get; set; }

        [JsonPropertyName("timeStopComboCoolTimeSecond_")]
        public float TimeStopComboCoolTimeSecond { get; set; }

        [JsonPropertyName("buffModeCoolTimeSecond_")]
        public float BuffModeCoolTimeSecond { get; set; }

        [JsonPropertyName("bigTrickCoolTimeSecond_")]
        public float BigTrickCoolTimeSecond { get; set; }

        [JsonPropertyName("useActionParam_")]
        public UseActionParam[] UseActionParam { get; set; } = new UseActionParam[1]; // std::array<Em7700Param::UseActionParam,1>

        [JsonPropertyName("trialFailedDebuffRate_")]
        public float TrialFailedDebuffRate { get; set; }

        [JsonPropertyName("trial1_4CircleLineNum_")]
        public int Trial1_4CircleLineNum { get; set; }

        [JsonPropertyName("trial1_4CircleLineDistance_")]
        public BindingList<float> Trial1_4CircleLineDistance { get; set; } = []; // std::vector<float>

        [JsonPropertyName("trial1_4CircleRadius_")]
        public BindingList<float> Trial1_4CircleRadius { get; set; } = []; // std::vector<float>

        [JsonPropertyName("trial1_4IsFixedPlace_")]
        public bool Trial1_4IsFixedPlace { get; set; }

        [JsonPropertyName("trial1_4CirclePlaceDegree_")]
        public BindingList<float[]> Trial1_4CirclePlaceDegree { get; set; } = []; // std::vector<std::array<float,4>>

        [JsonPropertyName("trial1_4CircleMinDistance_")]
        public float Trial1_4CircleMinDistance { get; set; }

        [JsonPropertyName("trial1_4CircleExplodeDelay_")]
        public float[][] Trial1_4CircleExplodeDelay { get; set; } = new float[4][/*4*/]; // std::array<std::array<float,4>,4>

        [JsonPropertyName("trial1_4CircleMinSpeed_")]
        public float Trial1_4CircleMinSpeed { get; set; }

        [JsonPropertyName("trial1_4CircleMaxSpeed_")]
        public float Trial1_4CircleMaxSpeed { get; set; }

        [JsonPropertyName("trial1_4CircleStartDelay_")]
        public float Trial1_4CircleStartDelay { get; set; }

        [JsonPropertyName("trial1_4CircleExplodeCoolTime_")]
        public float Trial1_4CircleExplodeCoolTime { get; set; }

        [JsonPropertyName("trial1_4CircleTouchCoolTime_")]
        public float Trial1_4CircleTouchCoolTime { get; set; }

        [JsonPropertyName("trial1_4CircleActivateStopTime_")]
        public float Trial1_4CircleActivateStopTime { get; set; }

        [JsonPropertyName("trial1_4CircleDeactivateStopTime_")]
        public float Trial1_4CircleDeactivateStopTime { get; set; }

        [JsonPropertyName("trial1_4StageCenterPos_")]
        public Vector4 Trial1_4StageCenterPos { get; set; }

        [JsonPropertyName("trial1_4StageRadius_")]
        public float Trial1_4StageRadius { get; set; }

        [JsonPropertyName("trial1_4CenterAreaRadius_")]
        public float Trial1_4CenterAreaRadius { get; set; }

        [JsonPropertyName("trial1_4FirstAttackDelay_")]
        public float Trial1_4FirstAttackDelay { get; set; }

        [JsonPropertyName("trial1_4AttackRate_")]
        public float Trial1_4AttackRate { get; set; }

        [JsonPropertyName("trial1_4AttackBreakRate_")]
        public float Trial1_4AttackBreakRate { get; set; }

        [JsonPropertyName("trial1_4AttackDelay_")]
        public float Trial1_4AttackDelay { get; set; }

        [JsonPropertyName("trial1_4AttackInsideRadius_")]
        public float Trial1_4AttackInsideRadius { get; set; }

        [JsonPropertyName("trial1_4AttackSize_")]
        public float Trial1_4AttackSize { get; set; }

        [JsonPropertyName("trial1_4AttackInterval_")]
        public float[] Trial1_4AttackInterval { get; set; } = new float[4]; // std::array<float,4>

        [JsonPropertyName("trial1_4AttackTime_")]
        public float[] Trial1_4AttackTime { get; set; } = new float[4]; // std::array<float,4>

        [JsonPropertyName("trial1_4TrialTimePlayerNum_")]
        public float[] Trial1_4TrialTimePlayerNum { get; set; } = new float[4]; // std::array<float,4>

        [JsonPropertyName("trial1_4OneShotTrialTime_")]
        public float Trial1_4OneShotTrialTime { get; set; }

        [JsonPropertyName("trial1_4JackFsm_")]
        public bool Trial1_4JackFsm { get; set; }

        [JsonPropertyName("trial1_4FsmClassName_")]
        public string Trial1_4FsmClassName { get; set; }

        [JsonPropertyName("trial1_4FsmFileInfix_")]
        public string Trial1_4FsmFileInfix { get; set; }

        [JsonPropertyName("trial8_11TimeLimitSec_")]
        public float[] Trial8_11TimeLimitSec { get; set; } = new float[4]; // std::array<float,4>

        [JsonPropertyName("trial8_11CrystalHPRate_")]
        public float Trial8_11CrystalHPRate { get; set; }

        [JsonPropertyName("trial8_11CrystalColorResetSec_")]
        public float[][] Trial8_11CrystalColorResetSec { get; set; } = new float[4][/*4*/]; // std::array<std::array<float,4>,4>

        [JsonPropertyName("trial8_11CrystalShotCoolTimeSec_")]
        public float Trial8_11CrystalShotCoolTimeSec { get; set; }

        [JsonPropertyName("trial8_11CrystalShotDurationSec_")]
        public float Trial8_11CrystalShotDurationSec { get; set; }

        [JsonPropertyName("trial8_11CrystalShotWaitSec_")]
        public float Trial8_11CrystalShotWaitSec { get; set; }

        [JsonPropertyName("trial8_11CrystalShotSignSec_")]
        public float Trial8_11CrystalShotSignSec { get; set; }

        [JsonPropertyName("trial8_11BigCrystalScale_")]
        public float Trial8_11BigCrystalScale { get; set; }

        [JsonPropertyName("trial8_11CrystalShotAttackValue_")]
        public float Trial8_11CrystalShotAttackValue { get; set; }

        [JsonPropertyName("trial8_11CrystalShotBreakValue_")]
        public float Trial8_11CrystalShotBreakValue { get; set; }

        [JsonPropertyName("trial8_11CrystalRipplesShotAttackValue_")]
        public float Trial8_11CrystalRipplesShotAttackValue { get; set; }

        [JsonPropertyName("trial8_11CrystalRipplesShotBreakValue_")]
        public float Trial8_11CrystalRipplesShotBreakValue { get; set; }

        [JsonPropertyName("trial8_11CrystalMaxTargetNum_")]
        public int[] Trial8_11CrystalMaxTargetNum { get; set; } = new int[4]; // std::array<int,4>

        [JsonPropertyName("trial8_11CrystalRadius_")]
        public float Trial8_11CrystalRadius { get; set; }

        [JsonPropertyName("trial8_11CrystalHeight_")]
        public float Trial8_11CrystalHeight { get; set; }

        [JsonPropertyName("trial8_11OneShotTrialTime_")]
        public float[] Trial8_11OneShotTrialTime { get; set; } = new float[4]; // std::array<float,4>

        [JsonPropertyName("trial8_11OneShotColorCrystalNum_")]
        public int Trial8_11OneShotColorCrystalNum { get; set; }

        [JsonPropertyName("trial8_11CrystalShotRadius_")]
        public float Trial8_11CrystalShotRadius { get; set; }

        [JsonPropertyName("trial8_11CrystalShotLength_")]
        public float Trial8_11CrystalShotLength { get; set; }

        [JsonPropertyName("trial8_11CrystalShotHeight_")]
        public float Trial8_11CrystalShotHeight { get; set; }

        [JsonPropertyName("trial8_11AppearSignSec_")]
        public float Trial8_11AppearSignSec { get; set; }

        [JsonPropertyName("trial8_11DevideVFXParabolaHeight_")]
        public float Trial8_11DevideVFXParabolaHeight { get; set; }

        [JsonPropertyName("trial8_11EmphasisSignSec_")]
        public float Trial8_11EmphasisSignSec { get; set; }

        [JsonPropertyName("trial8_11EmphasisCameraMoveRate_")]
        public float Trial8_11EmphasisCameraMoveRate { get; set; }

        [JsonPropertyName("trial8_11CrystalVFXOffset_")]
        public float Trial8_11CrystalVFXOffset { get; set; }

        [JsonPropertyName("trial8_11SelectVFXTargetOffset_")]
        public float Trial8_11SelectVFXTargetOffset { get; set; }

        [JsonPropertyName("trial8_11BigCrystalDist_")]
        public float Trial8_11BigCrystalDist { get; set; }

        [JsonPropertyName("trial8_11AppearWaitSec_")]
        public float Trial8_11AppearWaitSec { get; set; }

        [JsonPropertyName("trial8_11ChangeBigCrystalColorSec_")]
        public float Trial8_11ChangeBigCrystalColorSec { get; set; }

        [JsonPropertyName("trial8_11ColorCrystalNum_")]
        public float[] Trial8_11ColorCrystalNum { get; set; } = new float[4]; // std::array<int,4>

        [JsonPropertyName("trial8_11NPCWaitSec_")]
        public float Trial8_11NPCWaitSec { get; set; }

        [JsonPropertyName("trial8_11CrystalLaserAttackDownRate_")]
        public float Trial8_11CrystalLaserAttackDownRate { get; set; }

        [JsonPropertyName("trial8_11CrystalLaserAttackDownTime_")]
        public float Trial8_11CrystalLaserAttackDownTime { get; set; }

        [JsonPropertyName("trialSwordTimeLimitSecList_")]
        public float[] TrialSwordTimeLimitSecList { get; set; } = new float[4]; // std::array<int,4>

        [JsonPropertyName("trial11TimeLimitSec_")]
        public float Trial11TimeLimitSec { get; set; }

        [JsonPropertyName("oneShotTrialSwordHpRate_")]
        public float OneShotTrialSwordHpRate { get; set; }

        [JsonPropertyName("theEndSwordHpRate_")]
        public float TheEndSwordHpRate { get; set; }

        [JsonPropertyName("theEndSwordAttackBuffRate_")]
        public float TheEndSwordAttackBuffRate { get; set; }

        [JsonPropertyName("paradiseLostChargeSecond_")]
        public float ParadiseLostChargeSecond { get; set; }

        [JsonPropertyName("isUseSpecialArts1st_")]
        public bool IsUseSpecialArts1st { get; set; }

        [JsonPropertyName("isUseSpecialArts2st_")]
        public bool IsUseSpecialArts2st { get; set; }

        public LevelAIParam()
        {
        }
    }
}