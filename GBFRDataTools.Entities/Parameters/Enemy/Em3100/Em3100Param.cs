using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em3100;

public class Em3100Param : EmBossBaseParam
{
    [JsonPropertyName("baseHomingSpeed_")]
    public float BaseHomingSpeed { get; set; } = 180f;

    [JsonPropertyName("baseJumpPower_")]
    public float BaseJumpPower { get; set; } = 1.5f;

    [JsonPropertyName("baseJumpGravity_")]
    public float BaseJumpGravity { get; set; } = 0.04f;

    [JsonPropertyName("uiHeadPositionOffsetY_")]
    public float UiHeadPositionOffsetY { get; set; } = -2f;

    [JsonPropertyName("aiLevelParams_")]
    public BindingList<Em3100AILevelParam> AiLevelParams { get; set; } = [];

    [JsonPropertyName("aiLevelSpArtsParams_")]
    public Em3100AILevelSpArtsParam[] AiLevelSpArtsParams { get; set; } = new Em3100AILevelSpArtsParam[2]; // std::array<Em3100AILevelSpArtsParam,2>

    [JsonPropertyName("hazardWaveAttackHeight_")]
    public float HazardWaveAttackHeight { get; set; } = 1f;

    [JsonPropertyName("coolTimeBackStepSlash_")]
    public float CoolTimeBackStepSlash { get; set; } = 45f;

    [JsonPropertyName("coolTimeFallDownAttack_")]
    public float CoolTimeFallDownAttack { get; set; } = 60f;

    [JsonPropertyName("coolTimeHomingMissile_")]
    public float CoolTimeHomingMissile { get; set; } = 90f;

    [JsonPropertyName("coolTimeMissileAttack_")]
    public float CoolTimeMissileAttack { get; set; } = 15f;

    [JsonPropertyName("coolTimeRapidMissile_")]
    public float CoolTimeRapidMissile { get; set; } = 10f;

    [JsonPropertyName("coolTimeRapidMissileLong_")]
    public float CoolTimeRapidMissileLong { get; set; } = 30f;

    [JsonPropertyName("coolTimeBurstAuraAttack_")]
    public float CoolTimeBurstAuraAttack { get; set; } = 10f;

    [JsonPropertyName("meleeAttackComboConditionDist_")]
    public float MeleeAttackComboConditionDist { get; set; } = 10f;

    [JsonPropertyName("meleeAttackComboConditionDegreeR_")]
    public float MeleeAttackComboConditionDegreeR { get; set; } = 120f;

    [JsonPropertyName("meleeAttackComboConditionDegreeL_")]
    public float MeleeAttackComboConditionDegreeL { get; set; } = 90f;

    [JsonPropertyName("biteAttackBiteComboRange_")]
    public Vector3 BiteAttackBiteComboRange { get; set; } = new Vector3(2.5f, 10f, 7.5f);

    [JsonPropertyName("biteAttackTailComboRange_")]
    public float BiteAttackTailComboRange { get; set; } = 15f;

    [JsonPropertyName("handStrikeAttackHomingSpeed_")]
    public float HandStrikeAttackHomingSpeed { get; set; } = 180f;

    [JsonPropertyName("handStrikeAttackMoveRateMin_")]
    public float HandStrikeAttackMoveRateMin { get; set; } = 0.5f;

    [JsonPropertyName("handStrikeAttackMoveRateMax_")]
    public float HandStrikeAttackMoveRateMax { get; set; } = 1.5f;

    [JsonPropertyName("handStrikeAttackComboConditionDist_")]
    public float HandStrikeAttackComboConditionDist { get; set; } = 15f;

    [JsonPropertyName("handStrikeAttackComboConditionDegree_")]
    public float HandStrikeAttackComboConditionDegree { get; set; } = 60f;

    [JsonPropertyName("backStepSlashConditionDist_")]
    public float BackStepSlashConditionDist { get; set; } = 10f;

    [JsonPropertyName("backStepSlashCloseRangeDist_")]
    public float BackStepSlashCloseRangeDist { get; set; } = 15f;

    [JsonPropertyName("backStepSlashCloseShotDist_")]
    public float BackStepSlashCloseShotDist { get; set; } = 10f;

    [JsonPropertyName("backStepSlashShotSizeX_")]
    public float BackStepSlashShotSizeX { get; set; } = 9f;

    [JsonPropertyName("backStepSlashShotSizeZ_")]
    public float BackStepSlashShotSizeZ { get; set; } = 1f;

    [JsonPropertyName("backStepSlashShotScale_")]
    public float BackStepSlashShotScale { get; set; } = 0.7f;

    [JsonPropertyName("backStepSlashTargetOffsetY_")]
    public float BackStepSlashTargetOffsetY { get; set; } = 0.5f;

    [JsonPropertyName("backStepSlashRangeDegree_")]
    public float BackStepSlashRangeDegree { get; set; } = 10f;

    [JsonPropertyName("backStepSlashOffsetRotZ_")]
    public float BackStepSlashOffsetRotZ { get; set; } = 10f;

    [JsonPropertyName("backStepExplodeOffsetRotY_")]
    public float BackStepExplodeOffsetRotY { get; set; } = 20f;

    [JsonPropertyName("backStepSlashAttackVelocity_")]
    public BindingList<float> BackStepSlashAttackVelocity { get; set; } = []; // std::array<float,3>

    [JsonPropertyName("fallDownParam_")]
    public Em3100FallDownParam FallDownParam { get; set; }

    [JsonPropertyName("tailBeamAttackStartFrame_")]
    public int TailBeamAttackStartFrame { get; set; } = 138;

    [JsonPropertyName("tailBeamAttackEndFrame_")]
    public int TailBeamAttackEndFrame { get; set; } = 255;

    [JsonPropertyName("tailBeamAttackCrackFrameL_")]
    public int TailBeamAttackCrackFrameL { get; set; } = 155;

    [JsonPropertyName("tailBeamAttackCrackFrameR_")]
    public int TailBeamAttackCrackFrameR { get; set; } = 145;

    [JsonPropertyName("tailBeamAttackLength_")]
    public float TailBeamAttackLength { get; set; } = 50f;

    [JsonPropertyName("tailBeamAttackRadius_")]
    public float TailBeamAttackRadius { get; set; } = 0.3f;

    [JsonPropertyName("tailBeamAttackRadiusOF_")]
    public float TailBeamAttackRadiusOF { get; set; } = 0.3f;

    [JsonPropertyName("tailBeamAttackOffsetZ_")]
    public float TailBeamAttackOffsetZ { get; set; } = 0f;

    [JsonPropertyName("tailBeamAttackAdjustZ_")]
    public float TailBeamAttackAdjustZ { get; set; } = 0f;

    [JsonPropertyName("tailBeamAttackRangeFront_")]
    public Vector2 TailBeamAttackRangeFront { get; set; } = new Vector2(-5f, 15f);

    [JsonPropertyName("tailBeamAttackRangeBack_")]
    public Vector2 TailBeamAttackRangeBack { get; set; } = new Vector2(-15f, 0f);

    [JsonPropertyName("tailBeamAttackRangeRight_")]
    public Vector2 TailBeamAttackRangeRight { get; set; } = new Vector2(-10f, 7.5f);

    [JsonPropertyName("tailBeamAttackRangeLeft_")]
    public Vector2 TailBeamAttackRangeLeft { get; set; } = new Vector2(0f, 20f);

    [JsonPropertyName("tailBeamAttackRangeOffsetX_")]
    public float TailBeamAttackRangeOffsetX { get; set; } = 0f;

    [JsonPropertyName("homingMissileHatchOpenFrame_")]
    public int HomingMissileHatchOpenFrame { get; set; } = 15;

    [JsonPropertyName("homingMissileHatchOpenIntervalFrame_")]
    public int HomingMissileHatchOpenIntervalFrame { get; set; } = 2;

    [JsonPropertyName("homingMissileFireTargetNum_")]
    public int HomingMissileFireTargetNum { get; set; } = 4;

    [JsonPropertyName("homingMissileFireIntervalFrames_")]
    public int[] HomingMissileFireIntervalFrames { get; set; } = new int[3]; // std::array<int,3>

    [JsonPropertyName("homingMissileFiredMoveSpeed_")]
    public Vector2 HomingMissileFiredMoveSpeed { get; set; } = new Vector2(4f, 8f);

    [JsonPropertyName("homingMissileFiredWaitSec_")]
    public float HomingMissileFiredWaitSec { get; set; } = 1f;

    [JsonPropertyName("homingMissileFiredWaitRate_")]
    public float HomingMissileFiredWaitRate { get; set; } = 0.5f;

    [JsonPropertyName("homingMissileFiredWaitTerm_")]
    public float HomingMissileFiredWaitTerm { get; set; } = 1f;

    [JsonPropertyName("homingMissileAttackSignTime_")]
    public float HomingMissileAttackSignTime { get; set; } = 1f;

    [JsonPropertyName("homingMissileAttackRadius_")]
    public float HomingMissileAttackRadius { get; set; } = 6f;

    [JsonPropertyName("homingMissileAttackRangeRate_")]
    public float HomingMissileAttackRangeRate { get; set; } = 1.5f;

    [JsonPropertyName("homingMissileAccuracyDegree_")]
    public float HomingMissileAccuracyDegree { get; set; } = 15f;

    [JsonPropertyName("homingMissileAreaSignSec_")]
    public float HomingMissileAreaSignSec { get; set; } = 2f;

    [JsonPropertyName("homingMissileAreaWaitTerm_")]
    public float HomingMissileAreaWaitTerm { get; set; } = 5f;

    [JsonPropertyName("homingMissileAreaRangeRate_")]
    public float HomingMissileAreaRangeRate { get; set; } = 1.3f;

    [JsonPropertyName("homingMissileAreaRangeRateOF_")]
    public float HomingMissileAreaRangeRateOF { get; set; } = 1f;

    [JsonPropertyName("homingMissileAreaAccurary_")]
    public float HomingMissileAreaAccurary { get; set; } = 2f;

    [JsonPropertyName("homingMissileQuickFireNum_")]
    public int HomingMissileQuickFireNum { get; set; } = 1;

    [JsonPropertyName("homingMissileQuickIntervalSec_")]
    public float HomingMissileQuickIntervalSec { get; set; } = 0.5f;

    [JsonPropertyName("rapidMissileFireNum_")]
    public int RapidMissileFireNum { get; set; } = 1;

    [JsonPropertyName("rapidMissileHatchInterval_")]
    public int RapidMissileHatchInterval { get; set; } = 5;

    [JsonPropertyName("rapidMissileFireInterval_")]
    public int RapidMissileFireInterval { get; set; } = 5;

    [JsonPropertyName("rapidMissileFireDistRate_")]
    public float RapidMissileFireDistRate { get; set; } = 2f;

    [JsonPropertyName("rapidMissileFireLimitDist_")]
    public float RapidMissileFireLimitDist { get; set; } = 12f;

    [JsonPropertyName("rapidMissileFirePoint_")]
    public Vector2 RapidMissileFirePoint { get; set; } = new Vector2(3f, -1f);

    [JsonPropertyName("rapidMissileFireDegree_")]
    public Vector2 RapidMissileFireDegree { get; set; } = new Vector2(45f, 30f);

    [JsonPropertyName("chargeLaserShotStartFrame_")]
    public int ChargeLaserShotStartFrame { get; set; } = 126;

    [JsonPropertyName("chargeLaserShotEndFrame_")]
    public int ChargeLaserShotEndFrame { get; set; } = 219;

    [JsonPropertyName("chargeLaserBeamLength_")]
    public float ChargeLaserBeamLength { get; set; } = 150f;

    [JsonPropertyName("chargeLaserBeamRadius_")]
    public float ChargeLaserBeamRadius { get; set; } = 0.5f;

    [JsonPropertyName("chargeLaserBeamRadiusOF_")]
    public float ChargeLaserBeamRadiusOF { get; set; } = 2f;

    [JsonPropertyName("chargeLaserBeamOffsetZ_")]
    public float ChargeLaserBeamOffsetZ { get; set; } = 0.5f;

    [JsonPropertyName("chargeLaserBeamAdjustZ_")]
    public float ChargeLaserBeamAdjustZ { get; set; } = 0f;

    [JsonPropertyName("chargeLaserCrackCount_")]
    public int ChargeLaserCrackCount { get; set; } = 4;

    [JsonPropertyName("chargeLaserCrackCountOverflow_")]
    public int ChargeLaserCrackCountOverflow { get; set; } = 4;

    [JsonPropertyName("chargeLaserCrackFrame_")]
    public int ChargeLaserCrackFrame { get; set; } = 60;

    [JsonPropertyName("chargeLaserCrackLength_")]
    public float ChargeLaserCrackLength { get; set; } = 30f;

    [JsonPropertyName("chargeLaserCrackOffsetDegree_")]
    public float ChargeLaserCrackOffsetDegree { get; set; } = 40f;

    [JsonPropertyName("chargeLaserCrackOffsetLength_")]
    public float ChargeLaserCrackOffsetLength { get; set; } = 1.2f;

    [JsonPropertyName("chargeLaserCrackOffsetPos_")]
    public Vector2 ChargeLaserCrackOffsetPos { get; set; } = new Vector2(0f, 5f);

    [JsonPropertyName("bladeRushAttackCheckDegree_")]
    public float BladeRushAttackCheckDegree { get; set; } = 90f;

    [JsonPropertyName("bladeRushAttackReadyTime_")]
    public float BladeRushAttackReadyTime { get; set; } = 1f;

    [JsonPropertyName("bladeRushAttackJumpMinDist_")]
    public float BladeRushAttackJumpMinDist { get; set; } = 20f;

    [JsonPropertyName("bladeRushAttackJumpMaxDist_")]
    public float BladeRushAttackJumpMaxDist { get; set; } = 50f;

    [JsonPropertyName("bladeRushAttackLandingDist_")]
    public float BladeRushAttackLandingDist { get; set; } = 4f;

    [JsonPropertyName("bladeRushAttackHomingSpeed_")]
    public float BladeRushAttackHomingSpeed { get; set; } = 30f;

    [JsonPropertyName("bladeRushAttackContinueDegree_")]
    public float BladeRushAttackContinueDegree { get; set; } = 45f;

    [JsonPropertyName("bladeRushAttackLinkageStartFrame_")]
    public int BladeRushAttackLinkageStartFrame { get; set; } = 20;

    [JsonPropertyName("bladeRushAttackSignSize_")]
    public Vector3 BladeRushAttackSignSize { get; set; } = new Vector3(5f, 5f, 15f);

    [JsonPropertyName("tailStabRangeAttackStartFrame_")]
    public int TailStabRangeAttackStartFrame { get; set; } = 35;

    [JsonPropertyName("tailStabRangeExplodeRadius_")]
    public float TailStabRangeExplodeRadius { get; set; } = 8f;

    [JsonPropertyName("tailStabRangeExplodeInterval_")]
    public float TailStabRangeExplodeInterval { get; set; } = 3f;

    [JsonPropertyName("tailStabRangeExplodeOverlap_")]
    public float TailStabRangeExplodeOverlap { get; set; } = 0.7f;

    [JsonPropertyName("tailStabRangeExplodeSignSec_")]
    public float TailStabRangeExplodeSignSec { get; set; } = 2f;

    [JsonPropertyName("tailStabRangeExplodeWaitRate_")]
    public float TailStabRangeExplodeWaitRate { get; set; } = 0.7f;

    [JsonPropertyName("tailStabRangeExplodeExtension_")]
    public float TailStabRangeExplodeExtension { get; set; } = 3f;

    [JsonPropertyName("tailStabRangeExplodeSafeDist_")]
    public float TailStabRangeExplodeSafeDist { get; set; } = 4f;

    [JsonPropertyName("reflectLaserSignReadyTime_")]
    public float ReflectLaserSignReadyTime { get; set; } = 0.5f;

    [JsonPropertyName("reflectLaserFireTime_")]
    public float ReflectLaserFireTime { get; set; } = 3f;

    [JsonPropertyName("reflectLaserOffsetPosZ_")]
    public float ReflectLaserOffsetPosZ { get; set; } = 2.5f;

    [JsonPropertyName("reflectLaserExplodeRadius_")]
    public float ReflectLaserExplodeRadius { get; set; } = 40f;

    [JsonPropertyName("reflectLaserExplodeOffsetZ_")]
    public float ReflectLaserExplodeOffsetZ { get; set; } = 16f;

    [JsonPropertyName("diffusionLaserBulletStartFrame_")]
    public int DiffusionLaserBulletStartFrame { get; set; } = 150;

    [JsonPropertyName("diffusionLaserBulletEndFrame_")]
    public int DiffusionLaserBulletEndFrame { get; set; } = 400;

    [JsonPropertyName("diffusionLaserFunnelTurnSpeed_")]
    public float DiffusionLaserFunnelTurnSpeed { get; set; } = 90f;

    [JsonPropertyName("diffusionLaserFunnelLaserOffset_")]
    public float DiffusionLaserFunnelLaserOffset { get; set; } = 1.5f;

    [JsonPropertyName("diffusionLaserBulletRadius_")]
    public float DiffusionLaserBulletRadius { get; set; } = 3f;

    [JsonPropertyName("diffusionLaserBulletInterval_")]
    public float DiffusionLaserBulletInterval { get; set; } = 6f;

    [JsonPropertyName("diffusionLaserBulletIntervalOF_")]
    public float DiffusionLaserBulletIntervalOF { get; set; } = 3.5f;

    [JsonPropertyName("diffusionLaserBulletOverlap_")]
    public float DiffusionLaserBulletOverlap { get; set; } = 1.1f;

    [JsonPropertyName("diffusionLaserBulletSignSec_")]
    public float DiffusionLaserBulletSignSec { get; set; } = 1f;

    [JsonPropertyName("diffusionLaserBulletShotSec_")]
    public Vector2 DiffusionLaserBulletShotSec { get; set; } = new Vector2(0.4f, 0.6f);

    [JsonPropertyName("diffusionLaserBurstWaitSec_")]
    public float DiffusionLaserBurstWaitSec { get; set; } = 2f;

    [JsonPropertyName("diffusionLaserBurstSignSec_")]
    public float DiffusionLaserBurstSignSec { get; set; } = 1f;

    [JsonPropertyName("diffusionLaserVacuumeRange_")]
    public float[] DiffusionLaserVacuumeRange { get; set; } = new float[2]; // std::array<float,2>

    [JsonPropertyName("diffusionLaserVacuumePower_")]
    public float[] DiffusionLaserVacuumePower { get; set; } = new float[2]; // std::array<float,2>

    [JsonPropertyName("diffusionLaserThrowSignFrame_")]
    public float[] DiffusionLaserThrowSignFrame { get; set; } = new float[2]; // std::array<int,2>

    [JsonPropertyName("continueBladeSlashWaitTime_")]
    public float ContinueBladeSlashWaitTime { get; set; } = 0f;

    [JsonPropertyName("continueBladeSlashTurnWaitTime_")]
    public float ContinueBladeSlashTurnWaitTime { get; set; } = 0f;

    [JsonPropertyName("continueBladeSlashTurnTargetRange_")]
    public float ContinueBladeSlashTurnTargetRange { get; set; } = 5f;

    [JsonPropertyName("continueBladeSlashRushOffsetX_")]
    public float ContinueBladeSlashRushOffsetX { get; set; } = 0f;

    [JsonPropertyName("continueBladeSlashRushPassDist_")]
    public float ContinueBladeSlashRushPassDist { get; set; } = 20f;

    [JsonPropertyName("continueBladeSlashRushTurnDist_")]
    public float ContinueBladeSlashRushTurnDist { get; set; } = 10f;

    [JsonPropertyName("continueBladeSlashRushSignSize_")]
    public Vector3 ContinueBladeSlashRushSignSize { get; set; } = new Vector3(2.6f, 11.6f, 5f);

    [JsonPropertyName("continueBladeSlashJumpRisePower_")]
    public float ContinueBladeSlashJumpRisePower { get; set; } = 1f;

    [JsonPropertyName("continueBladeSlashJumpGravity_")]
    public float ContinueBladeSlashJumpGravity { get; set; } = 0.01f;

    [JsonPropertyName("continueBladeSlashJumpFallPower_")]
    public float ContinueBladeSlashJumpFallPower { get; set; } = -3f;

    [JsonPropertyName("continueBladeSlashJumpSignRadius_")]
    public float ContinueBladeSlashJumpSignRadius { get; set; } = 20f;

    [JsonPropertyName("continueBladeSlashJumpHomingRate_")]
    public float ContinueBladeSlashJumpHomingRate { get; set; } = 0.5f;

    [JsonPropertyName("continueBladeSlashExplodeSignStartFrame_")]
    public int ContinueBladeSlashExplodeSignStartFrame { get; set; } = 3;

    [JsonPropertyName("continueBladeSlashExplodeSignTime_")]
    public float ContinueBladeSlashExplodeSignTime { get; set; } = 1.5f;

    [JsonPropertyName("continueBladeSlashExplodeAttackSize_")]
    public Vector3 ContinueBladeSlashExplodeAttackSize { get; set; } = new Vector3(7.5f, 17.5f, 35f);

    [JsonPropertyName("rampageAttackJumpThreshold_")]
    public float RampageAttackJumpThreshold { get; set; } = 15f;

    [JsonPropertyName("rampageAttackJumpMinDist_")]
    public float RampageAttackJumpMinDist { get; set; } = 10f;

    [JsonPropertyName("rampageAttackJumpOffsetDist_")]
    public float RampageAttackJumpOffsetDist { get; set; } = 15f;

    [JsonPropertyName("rampageAttackJumpPower_")]
    public float RampageAttackJumpPower { get; set; } = 0.5f;

    [JsonPropertyName("rampageAttackJumpGravity_")]
    public float RampageAttackJumpGravity { get; set; } = 0.015f;

    [JsonPropertyName("rampageAttackImpactSignSec_")]
    public float RampageAttackImpactSignSec { get; set; } = 1.5f;

    [JsonPropertyName("rampageAttackImpactWidth_")]
    public float RampageAttackImpactWidth { get; set; } = 5f;

    [JsonPropertyName("rampageAttackImpactDepth_")]
    public float RampageAttackImpactDepth { get; set; } = 40f;

    [JsonPropertyName("rampageAttackWaveStartSec_")]
    public float RampageAttackWaveStartSec { get; set; } = 0.5f;

    [JsonPropertyName("rampageAttackWaveWaitSec_")]
    public float RampageAttackWaveWaitSec { get; set; } = 3f;

    [JsonPropertyName("rampageAttackWaveInterval_")]
    public float RampageAttackWaveInterval { get; set; } = 3.5f;

    [JsonPropertyName("rampageAttackWaveIntervalOF_")]
    public float RampageAttackWaveIntervalOF { get; set; } = 1.5f;

    [JsonPropertyName("rampageAttackWaveParam_")]
    public Em3100HazardWaveParam RampageAttackWaveParam { get; set; }

    [JsonPropertyName("swirlTailBeamStartFrame_")]
    public int SwirlTailBeamStartFrame { get; set; } = 110;

    [JsonPropertyName("swirlTailBeamEndFrame_")]
    public int SwirlTailBeamEndFrame { get; set; } = 375;

    [JsonPropertyName("tailBladeSlashStompStartFrame_")]
    public int TailBladeSlashStompStartFrame { get; set; } = 93;

    [JsonPropertyName("tailBladeSlashStompPosOffset_")]
    public Vector4 TailBladeSlashStompPosOffset { get; set; } = new Vector4(0.1f, 0f, 0.4f, 1f);

    [JsonPropertyName("tailBladeSlashStompAttackRadius_")]
    public float TailBladeSlashStompAttackRadius { get; set; } = 7f;

    [JsonPropertyName("tailBladeSlashShotDirectionNum_")]
    public int TailBladeSlashShotDirectionNum { get; set; } = 4;

    [JsonPropertyName("tailBladeSlashShotWaitSec_")]
    public float TailBladeSlashShotWaitSec { get; set; } = 0.01f;

    [JsonPropertyName("tailBladeSlashShotOffsetZ_")]
    public float TailBladeSlashShotOffsetZ { get; set; } = 10f;

    [JsonPropertyName("tailBladeSlashShotSection_")]
    public int[] TailBladeSlashShotSection { get; set; } = new int[2]; // std::array<int,2>

    [JsonPropertyName("tailBladeSlashShotDegree_")]
    public float[] TailBladeSlashShotDegree { get; set; } = new float[2]; // std::array<float,2>

    [JsonPropertyName("odAbilityEm3100Param_")]
    public Em3100OdAbilityParam OdAbilityEm3100Param { get; set; }

    [JsonPropertyName("spArtsParam_")]
    public Em3100SpArtsParam SpArtsParam { get; set; }

    [JsonPropertyName("gameOverParam_")]
    public Em3100GameOverParam GameOverParam { get; set; }

    [JsonPropertyName("funnelFirstDeployDistance_")]
    public float FunnelFirstDeployDistance { get; set; } = 5f;

    [JsonPropertyName("funnelFirstDeployHeight_")]
    public float FunnelFirstDeployHeight { get; set; } = 7f;

    [JsonPropertyName("funnelFirstDeployDegree_")]
    public float FunnelFirstDeployDegree { get; set; } = 45f;

    [JsonPropertyName("funnelReloadParams_")]
    public BindingList<Em3100FunnelReloadDetailParam> FunnelReloadParams { get; set; } = []; // std::array<Em3100FunnelReloadDetailParam,3>

    [JsonPropertyName("detailRangeParam_")]
    public Em3100TargetRangeParam DetailRangeParam { get; set; }

    [JsonPropertyName("partsBreakParam_")]
    public Em3100PartsBreakParam PartsBreakParam { get; set; }

    [JsonPropertyName("partsBreakWeakPointParam_")]
    public EmWeakPointParam PartsBreakWeakPointParam { get; set; }

    [JsonPropertyName("homingParam_")]
    public Em3100HomingParam HomingParam { get; set; }

    [JsonPropertyName("crackParam_")]
    public Em3100CrackParam CrackParam { get; set; }

    [JsonPropertyName("hazardShotParam_")]
    public Em3100HazardShotParam HazardShotParam { get; set; }

    [JsonPropertyName("modeChangeParam_")]
    public Em3100ModeChangeParam ModeChangeParam { get; set; }

    [JsonPropertyName("nameTextParam_")]
    public Em3100NameTextParam NameTextParam { get; set; }

    [JsonPropertyName("addDamageParam_")]
    public EmAddDamageParam AddDamageParam { get; set; }

    public Em3100Param()
    {
        Hp = 10000;
        Atk = 100;
        Break = 10;
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
        DamageToHateRate = 0.001f;
        DamageHateDecPerSec = 5f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 50;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
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
        IsDisableAerialDownReaction = true;
        CameraLength = 4.5f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0.25f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
    }
}

public class Em3100HazardWaveParam
{
    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x8

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0xC

    [JsonPropertyName("startRadius_")]
    public float StartRadius { get; set; } // Offset 0x10

    [JsonPropertyName("endRadius_")]
    public float EndRadius { get; set; } // Offset 0x14

    [JsonPropertyName("lifeSec_")]
    public float LifeSec { get; set; } // Offset 0x18

    public Em3100HazardWaveParam()
    {
    }
}


public class Em3100OdAbilityParam
{
    [JsonPropertyName("electricCircleRadius_")]
    public float ElectricCircleRadius { get; set; } // Offset 0x8

    [JsonPropertyName("electricCircleSignSec_")]
    public float ElectricCircleSignSec { get; set; } // Offset 0xC

    [JsonPropertyName("lastBeamAttackLength_")]
    public float LastBeamAttackLength { get; set; } // Offset 0x10

    public Em3100OdAbilityParam()
    {
    }
}


public class Em3100SpArtsParam
{
    [JsonPropertyName("hpTrigger1st_")]
    public int HpTrigger1st { get; set; } // Offset 0x8

    [JsonPropertyName("hpTrigger2nd_")]
    public int HpTrigger2nd { get; set; } // Offset 0xC

    [JsonPropertyName("dpsCheckStartCameraAngleX_")]
    public float DpsCheckStartCameraAngleX { get; set; } // Offset 0x10

    [JsonPropertyName("dpsCheckWaveAttack_")]
    public Em3100SpArtsParam DpsCheckWaveAttack { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("energyChargePhaseSec_")]
    public float EnergyChargePhaseSec { get; set; } // Offset 0x38

    [JsonPropertyName("energyChargingTimeRate_")]
    public float EnergyChargingTimeRate { get; set; } // Offset 0x3C

    [JsonPropertyName("chargingWaveAttackRadius_")]
    public float ChargingWaveAttackRadius { get; set; } // Offset 0x40

    [JsonPropertyName("chargingWaveAttackSignSec_")]
    public float ChargingWaveAttackSignSec { get; set; } // Offset 0x44

    [JsonPropertyName("chargingWaveAttackWaitSec_")]
    public float ChargingWaveAttackWaitSec { get; set; } // Offset 0x48

    [JsonPropertyName("combinedPhaseBaseSec_")]
    public float CombinedPhaseBaseSec { get; set; } // Offset 0x4C

    [JsonPropertyName("combinedPhaseAuraRadius_")]
    public float CombinedPhaseAuraRadius { get; set; } // Offset 0x50

    [JsonPropertyName("combinedPhaseBeamCrackOffset_")]
    public float CombinedPhaseBeamCrackOffset { get; set; } // Offset 0x54

    [JsonPropertyName("fireLaserNextSec_")]
    public float FireLaserNextSec { get; set; } // Offset 0x58

    [JsonPropertyName("fireLaserEndTime_")]
    public float FireLaserEndTime { get; set; } // Offset 0x5C

    [JsonPropertyName("fireLaserWaitSec_")]
    public float FireLaserWaitSec { get; set; } // Offset 0x60

    [JsonPropertyName("fireLaserSignSec_")]
    public float FireLaserSignSec { get; set; } // Offset 0x64

    [JsonPropertyName("fireLaserAttackInterval_")]
    public float FireLaserAttackInterval { get; set; } // Offset 0x68

    [JsonPropertyName("fireLaserAttackRadius_")]
    public float FireLaserAttackRadius { get; set; } // Offset 0x6C

    [JsonPropertyName("hexZoneAttackSignSec_")]
    public float HexZoneAttackSignSec { get; set; } // Offset 0x70

    [JsonPropertyName("hexZoneAttackRadius_")]
    public float HexZoneAttackRadius { get; set; } // Offset 0x74

    [JsonPropertyName("hexZoneAttackAdjustRate_")]
    public float HexZoneAttackAdjustRate { get; set; } // Offset 0x78

    [JsonPropertyName("hexZoneAttackInterval_")]
    public float HexZoneAttackInterval { get; set; } // Offset 0x7C

    [JsonPropertyName("hexZoneRangeStartFrame_")]
    public int HexZoneRangeStartFrame { get; set; } // Offset 0x80

    [JsonPropertyName("hexZoneRangeWaitLength_")]
    public int HexZoneRangeWaitLength { get; set; } // Offset 0x84

    [JsonPropertyName("lastTailSignStartFrame_")]
    public int LastTailSignStartFrame { get; set; } // Offset 0x88

    [JsonPropertyName("lastTailSignDispFrame_")]
    public int LastTailSignDispFrame { get; set; } // Offset 0x8C

    [JsonPropertyName("lastTailSignEftScale_")]
    public float LastTailSignEftScale { get; set; } // Offset 0x90

    [JsonPropertyName("lastWaveSignEftScale_")]
    public float LastWaveSignEftScale { get; set; } // Offset 0x94

    [JsonPropertyName("lastWavePlayFrame_")]
    public int LastWavePlayFrame { get; set; } // Offset 0x98

    [JsonPropertyName("lastWaveAttackParam_")]
    public Em3100SpArtsParam LastWaveAttackParam { get; set; } // Offset 0xCF543FFA

    public Em3100SpArtsParam()
    {
    }
}


public class Em3100GameOverParam
{
    [JsonPropertyName("hpTrigger_")]
    public int HpTrigger { get; set; } // Offset 0x8

    [JsonPropertyName("dpsCheckHpRate_")]
    public int DpsCheckHpRate { get; set; } // Offset 0xC

    [JsonPropertyName("dpsCheckSec_")]
    public float DpsCheckSec { get; set; } // Offset 0x10

    [JsonPropertyName("missileFirstWaitSec_")]
    public float MissileFirstWaitSec { get; set; } // Offset 0x14

    [JsonPropertyName("missileNextWaitSec_")]
    public float MissileNextWaitSec { get; set; } // Offset 0x18

    public Em3100GameOverParam()
    {
    }
}


public class Em3100FunnelReloadCountParam
{
    [JsonPropertyName("reloadList_")]
    public int[] ReloadList { get; set; } = new int[6]; // Offset 0x8

    public Em3100FunnelReloadCountParam()
    {
    }
}


public class Em3100FunnelReloadDetailParam
{
    [JsonPropertyName("countParams_")]
    public Em3100FunnelReloadCountParam[] CountParams { get; set; } = new Em3100FunnelReloadCountParam[2]; // Offset 0x8

    public Em3100FunnelReloadDetailParam()
    {
    }
}


public class Em3100TargetRangeParam
{
    [JsonPropertyName("distClose_")]
    public Vector2 DistClose { get; set; } // Offset 0x8

    [JsonPropertyName("distShort_")]
    public Vector2 DistShort { get; set; } // Offset 0x10

    [JsonPropertyName("distStep_")]
    public Vector2 DistStep { get; set; } // Offset 0x18

    [JsonPropertyName("distMiddle_")]
    public Vector2 DistMiddle { get; set; } // Offset 0x20

    [JsonPropertyName("distLong_")]
    public Vector2 DistLong { get; set; } // Offset 0x28

    public Em3100TargetRangeParam()
    {
    }
}


public class Em3100PartsBreakParam
{
    [JsonPropertyName("breakHpHead_")]
    public float BreakHpHead { get; set; } // Offset 0x8

    [JsonPropertyName("breakHpBody_")]
    public float BreakHpBody { get; set; } // Offset 0xC

    [JsonPropertyName("breakHpArmR_")]
    public float BreakHpArmR { get; set; } // Offset 0x10

    [JsonPropertyName("breakHpArmL_")]
    public float BreakHpArmL { get; set; } // Offset 0x14

    [JsonPropertyName("breakHpLegR_")]
    public float BreakHpLegR { get; set; } // Offset 0x18

    [JsonPropertyName("breakHpLegL_")]
    public float BreakHpLegL { get; set; } // Offset 0x1C

    [JsonPropertyName("breakHpTail_")]
    public float BreakHpTail { get; set; } // Offset 0x20

    public Em3100PartsBreakParam()
    {
    }
}


public class Em3100HomingParam
{
    [JsonPropertyName("turnActionSpeedRate_")]
    public float TurnActionSpeedRate { get; set; } // Offset 0x8

    [JsonPropertyName("turnActionBackTurnDegree_")]
    public float TurnActionBackTurnDegree { get; set; } // Offset 0xC

    [JsonPropertyName("turnActionSideTurnDiffDegree_")]
    public float TurnActionSideTurnDiffDegree { get; set; } // Offset 0x10

    [JsonPropertyName("turnActionBackTurnDiffDegree_")]
    public float TurnActionBackTurnDiffDegree { get; set; } // Offset 0x14

    [JsonPropertyName("turnActionSideStartFrame_")]
    public int TurnActionSideStartFrame { get; set; } // Offset 0x18

    [JsonPropertyName("turnActionSideEndFrame_")]
    public int TurnActionSideEndFrame { get; set; } // Offset 0x1C

    [JsonPropertyName("turnActionSideCancelFrame_")]
    public int TurnActionSideCancelFrame { get; set; } // Offset 0x20

    [JsonPropertyName("turnActionBackStartFrame_")]
    public int TurnActionBackStartFrame { get; set; } // Offset 0x24

    [JsonPropertyName("turnActionBackEndFrame_")]
    public int TurnActionBackEndFrame { get; set; } // Offset 0x28

    [JsonPropertyName("turnActionBackCancelFrame_")]
    public int TurnActionBackCancelFrame { get; set; } // Offset 0x2C

    [JsonPropertyName("bladeSlashWalkStartFrame_")]
    public int BladeSlashWalkStartFrame { get; set; } // Offset 0x30

    [JsonPropertyName("bladeSlashWalkEndFrame_")]
    public int BladeSlashWalkEndFrame { get; set; } // Offset 0x34

    [JsonPropertyName("bladeSlashWalkSmoothFrame_")]
    public int BladeSlashWalkSmoothFrame { get; set; } // Offset 0x38

    [JsonPropertyName("bladeSlashWalkTurnSpeed_")]
    public float BladeSlashWalkTurnSpeed { get; set; } // Offset 0x3C

    [JsonPropertyName("backStepSlashStartFrame_")]
    public int BackStepSlashStartFrame { get; set; } // Offset 0x40

    [JsonPropertyName("backStepSlashEndFrame_")]
    public int BackStepSlashEndFrame { get; set; } // Offset 0x44

    [JsonPropertyName("backStepSlashTurnSpeed_")]
    public float BackStepSlashTurnSpeed { get; set; } // Offset 0x48

    [JsonPropertyName("backStepSlashTurnLimit_")]
    public float BackStepSlashTurnLimit { get; set; } // Offset 0x4C

    [JsonPropertyName("homingMissileTurnSpeed_")]
    public float HomingMissileTurnSpeed { get; set; } // Offset 0x50

    [JsonPropertyName("homingMissileTurnFix_")]
    public float HomingMissileTurnFix { get; set; } // Offset 0x54

    [JsonPropertyName("rampageAttackJumpStartFrame_")]
    public int RampageAttackJumpStartFrame { get; set; } // Offset 0x58

    [JsonPropertyName("rampageAttackJumpEndFrame_")]
    public int RampageAttackJumpEndFrame { get; set; } // Offset 0x5C

    [JsonPropertyName("rampageAttackJumpTurnSpeed_")]
    public float RampageAttackJumpTurnSpeed { get; set; } // Offset 0x60

    [JsonPropertyName("rampageAttackJumpTurnLimit_")]
    public float RampageAttackJumpTurnLimit { get; set; } // Offset 0x64

    [JsonPropertyName("rampageAttackTurnBackFrameSection_")]
    public int[] RampageAttackTurnBackFrameSection { get; set; } = new int[2]; // Offset 0x68

    [JsonPropertyName("rampageAttackTurnRightFrameSection_")]
    public int[] RampageAttackTurnRightFrameSection { get; set; } = new int[2]; // Offset 0x70

    [JsonPropertyName("rampageAttackTurnLeftFrameSection_")]
    public int[] RampageAttackTurnLeftFrameSection { get; set; } = new int[2]; // Offset 0x78

    public Em3100HomingParam()
    {
    }
}


public class Em3100CrackParam
{
    [JsonPropertyName("baseIgnitionSec_")]
    public float BaseIgnitionSec { get; set; } // Offset 0x10

    [JsonPropertyName("baseExplodeSec_")]
    public float BaseExplodeSec { get; set; } // Offset 0x14

    [JsonPropertyName("baseExplodeRadius_")]
    public float BaseExplodeRadius { get; set; } // Offset 0x18

    [JsonPropertyName("baseExplodeRadiusOF_")]
    public float BaseExplodeRadiusOF { get; set; } // Offset 0x1C

    [JsonPropertyName("baseExplodeInterval_")]
    public float BaseExplodeInterval { get; set; } // Offset 0x20

    [JsonPropertyName("bladeSlashPoint_")]
    public Vector4 BladeSlashPoint { get; set; } // Offset 0x30

    [JsonPropertyName("bladeSlashOverflowPoint_")]
    public Vector4 BladeSlashOverflowPoint { get; set; } // Offset 0x40

    [JsonPropertyName("spArtsIgnitionSec_")]
    public float SpArtsIgnitionSec { get; set; } // Offset 0x50

    public Em3100CrackParam()
    {
    }
}


public class Em3100HazardShotParam
{
    [JsonPropertyName("badStatusSecFire_")]
    public float BadStatusSecFire { get; set; } // Offset 0x8

    [JsonPropertyName("badStatusSecFreeze_")]
    public float BadStatusSecFreeze { get; set; } // Offset 0xC

    [JsonPropertyName("badStatusSecThunder_")]
    public float BadStatusSecThunder { get; set; } // Offset 0x10

    [JsonPropertyName("badStatusRate_")]
    public float BadStatusRate { get; set; } // Offset 0x14

    [JsonPropertyName("fireExplodeAttackRadius_")]
    public float FireExplodeAttackRadius { get; set; } // Offset 0x18

    [JsonPropertyName("fireExplodeAttackInterval_")]
    public float FireExplodeAttackInterval { get; set; } // Offset 0x1C

    [JsonPropertyName("fireExplodeAttackRange_")]
    public float FireExplodeAttackRange { get; set; } // Offset 0x20

    [JsonPropertyName("fireExplodeTotalWaitSec_")]
    public float FireExplodeTotalWaitSec { get; set; } // Offset 0x24

    [JsonPropertyName("fireExplodeSignSec_")]
    public float FireExplodeSignSec { get; set; } // Offset 0x28

    [JsonPropertyName("fireExplodeOverflowAttackInterval_")]
    public float FireExplodeOverflowAttackInterval { get; set; } // Offset 0x2C

    [JsonPropertyName("fireExplodeOverflowTotalWaitSec_")]
    public float FireExplodeOverflowTotalWaitSec { get; set; } // Offset 0x30

    [JsonPropertyName("freezeWaveBackAttackDegree_")]
    public float FreezeWaveBackAttackDegree { get; set; } // Offset 0x34

    [JsonPropertyName("freezeWallAttackWaitSec_")]
    public float FreezeWallAttackWaitSec { get; set; } // Offset 0x38

    [JsonPropertyName("freezeWallTrunkCount_")]
    public int FreezeWallTrunkCount { get; set; } // Offset 0x3C

    [JsonPropertyName("freezeWallSizeDepth_")]
    public float FreezeWallSizeDepth { get; set; } // Offset 0x44

    [JsonPropertyName("freezeWallSizeWidth_")]
    public float FreezeWallSizeWidth { get; set; } // Offset 0x40

    [JsonPropertyName("freezeWallTrunkIntervalSec_")]
    public float FreezeWallTrunkIntervalSec { get; set; } // Offset 0x48

    [JsonPropertyName("freezeWallBranchCount_")]
    public int FreezeWallBranchCount { get; set; } // Offset 0x4C

    [JsonPropertyName("freezeWallBranchIntervalSec_")]
    public float FreezeWallBranchIntervalSec { get; set; } // Offset 0x50

    [JsonPropertyName("freezeWallDivideCount_")]
    public int[] FreezeWallDivideCount { get; set; } = new int[2]; // Offset 0x54

    [JsonPropertyName("freezeWallDivideRotY_")]
    public int[] FreezeWallDivideRotY { get; set; } = new int[2]; // Offset 0x5C

    [JsonPropertyName("thunderWaveAttackCount_")]
    public int ThunderWaveAttackCount { get; set; } // Offset 0x64

    [JsonPropertyName("thunderWaveAttackSignSec_")]
    public float ThunderWaveAttackSignSec { get; set; } // Offset 0x68

    [JsonPropertyName("thunderWaveAttackWidth_")]
    public float ThunderWaveAttackWidth { get; set; } // Offset 0x6C

    [JsonPropertyName("thunderWaveAttackDepth_")]
    public float ThunderWaveAttackDepth { get; set; } // Offset 0x70

    [JsonPropertyName("thunderWaveAttackIntervalSec_")]
    public float ThunderWaveAttackIntervalSec { get; set; } // Offset 0x74

    [JsonPropertyName("thunderWaveAttackIntervalDist_")]
    public float ThunderWaveAttackIntervalDist { get; set; } // Offset 0x78

    [JsonPropertyName("thunderWaveBackAttackDegree_")]
    public float ThunderWaveBackAttackDegree { get; set; } // Offset 0x7C

    [JsonPropertyName("backStepSlashFreezeCount_")]
    public int BackStepSlashFreezeCount { get; set; } // Offset 0x80

    [JsonPropertyName("backStepSlashFreezeDegree_")]
    public float BackStepSlashFreezeDegree { get; set; } // Offset 0x84

    [JsonPropertyName("backStepSlashFreezeOffset_")]
    public Vector2 BackStepSlashFreezeOffset { get; set; } // Offset 0x88

    [JsonPropertyName("backStepSlashThunderCount_")]
    public int BackStepSlashThunderCount { get; set; } // Offset 0x90

    [JsonPropertyName("backStepSlashThunderDegree_")]
    public float BackStepSlashThunderDegree { get; set; } // Offset 0x94

    [JsonPropertyName("backStepSlashThunderOffset_")]
    public Vector2 BackStepSlashThunderOffset { get; set; } // Offset 0x98

    [JsonPropertyName("fallDownAttackFireRange_")]
    public float FallDownAttackFireRange { get; set; } // Offset 0xA0

    [JsonPropertyName("fallDownAttackFreezeCount_")]
    public int FallDownAttackFreezeCount { get; set; } // Offset 0xA4

    [JsonPropertyName("fallDownAttackFreezeOffset_")]
    public float FallDownAttackFreezeOffset { get; set; } // Offset 0xA8

    [JsonPropertyName("fallDownAttackThunderCount_")]
    public int FallDownAttackThunderCount { get; set; } // Offset 0xAC

    [JsonPropertyName("fallDownAttackThunderOffset_")]
    public float FallDownAttackThunderOffset { get; set; } // Offset 0xB0

    [JsonPropertyName("bladeRushOffsetPosition_")]
    public Vector2 BladeRushOffsetPosition { get; set; } // Offset 0xB4

    [JsonPropertyName("bladeRushOffsetDegreeY_")]
    public float BladeRushOffsetDegreeY { get; set; } // Offset 0xBC

    [JsonPropertyName("bladeRushOverflowSizeRate_")]
    public float BladeRushOverflowSizeRate { get; set; } // Offset 0xC0

    public Em3100HazardShotParam()
    {
    }
}


public class Em3100ModeChangeParam
{
    [JsonPropertyName("neutralModeContinueSec_")]
    public float NeutralModeContinueSec { get; set; } // Offset 0x8

    [JsonPropertyName("energyChargeHateFar_")]
    public int EnergyChargeHateFar { get; set; } // Offset 0xC

    [JsonPropertyName("energyChargeShotSec_")]
    public float EnergyChargeShotSec { get; set; } // Offset 0x10

    [JsonPropertyName("deviceSummonDistance_")]
    public float DeviceSummonDistance { get; set; } // Offset 0x14

    [JsonPropertyName("changeModeChargePhaseSec_")]
    public float ChangeModeChargePhaseSec { get; set; } // Offset 0x18

    [JsonPropertyName("changeModeChargeStartTime_")]
    public float ChangeModeChargeStartTime { get; set; } // Offset 0x1C

    [JsonPropertyName("changeModeChargeReceiveTime_")]
    public float ChangeModeChargeReceiveTime { get; set; } // Offset 0x20

    [JsonPropertyName("changeModeChargeEndTime_")]
    public float ChangeModeChargeEndTime { get; set; } // Offset 0x24

    [JsonPropertyName("modeChangeContinueSec_")]
    public float ModeChangeContinueSec { get; set; } // Offset 0x28

    [JsonPropertyName("buffAttackRate_")]
    public float BuffAttackRate { get; set; } // Offset 0x2C

    [JsonPropertyName("buffDefenceRate_")]
    public float BuffDefenceRate { get; set; } // Offset 0x30

    [JsonPropertyName("buffAtkDrainRate_")]
    public float BuffAtkDrainRate { get; set; } // Offset 0x34

    [JsonPropertyName("overflowTimeRate_")]
    public float OverflowTimeRate { get; set; } // Offset 0x38

    [JsonPropertyName("overflowAttackRate_")]
    public float OverflowAttackRate { get; set; } // Offset 0x3C

    [JsonPropertyName("overflowBreakRate_")]
    public float OverflowBreakRate { get; set; } // Offset 0x40

    [JsonPropertyName("overflowDamageRate_")]
    public float OverflowDamageRate { get; set; } // Offset 0x44

    [JsonPropertyName("overedDownActionSec_")]
    public float OveredDownActionSec { get; set; } // Offset 0x48

    [JsonPropertyName("overedDownAttackRate_")]
    public float OveredDownAttackRate { get; set; } // Offset 0x4C

    [JsonPropertyName("overedDownBreakRate_")]
    public float OveredDownBreakRate { get; set; } // Offset 0x50

    [JsonPropertyName("finishAttackFunnelLaunchFrame_")]
    public int FinishAttackFunnelLaunchFrame { get; set; } // Offset 0x54

    public Em3100ModeChangeParam()
    {
    }
}


public class Em3100NameTextParam
{
    [JsonPropertyName("textList_")]
    public string[] TextList { get; set; } = new string[15]; // Offset 0x8

    public Em3100NameTextParam()
    {
    }
}

public class Em3100AILevelParam
{
    [JsonPropertyName("deviceInitialAddCount_")]
    public int DeviceInitialAddCount { get; set; }

    [JsonPropertyName("deviceEnergyChargeSec_")]
    public float DeviceEnergyChargeSec { get; set; }

    [JsonPropertyName("fallDownAttackEnableContinueJump_")]
    public bool FallDownAttackEnableContinueJump { get; set; }

    [JsonPropertyName("tailBeamAttackHomingSpeed_")]
    public float TailBeamAttackHomingSpeed { get; set; }

    [JsonPropertyName("rapidMissileEnable_")]
    public bool RapidMissileEnable { get; set; }

    [JsonPropertyName("chargeLaserNeckSpeedRate_")]
    public float ChargeLaserNeckSpeedRate { get; set; }

    [JsonPropertyName("chargeLaserEnableCrack_")]
    public bool ChargeLaserEnableCrack { get; set; }

    [JsonPropertyName("bladeRushAttackJumpSpeed_")]
    public float BladeRushAttackJumpSpeed { get; set; }

    [JsonPropertyName("bladeRushAttackEnableShot_")]
    public bool BladeRushAttackEnableShot { get; set; }

    [JsonPropertyName("reflectLaserChargeSec_")]
    public float ReflectLaserChargeSec { get; set; }

    [JsonPropertyName("diffusionLaserExplodeRadius_")]
    public float DiffusionLaserExplodeRadius { get; set; }

    [JsonPropertyName("diffusionLaserEnableVacuume_")]
    public bool DiffusionLaserEnableVacuume { get; set; }

    [JsonPropertyName("continueBladeSlashRushSpeed_")]
    public float ContinueBladeSlashRushSpeed { get; set; }

    [JsonPropertyName("rampageAttackEnableImpactCrack_")]
    public bool RampageAttackEnableImpactCrack { get; set; }

    [JsonPropertyName("odAbilityGroundZoneSpeedRate_")]
    public float OdAbilityGroundZoneSpeedRate { get; set; }

    [JsonPropertyName("odAbilityEnableFinishFunnel_")]
    public bool OdAbilityEnableFinishFunnel { get; set; }

    [JsonPropertyName("odAbilityReflectionCountRate_")]
    public BindingList<float> OdAbilityReflectionCountRate { get; set; } = []; // std::array<float,4>

    [JsonPropertyName("funnelEnableAutomaticMode_")]
    public bool FunnelEnableAutomaticMode { get; set; }

    public Em3100AILevelParam()
    {
    }
}

public class Em3100AILevelSpArtsParam
{
    [JsonPropertyName("dpsCheckPhaseSec_")]
    public BindingList<float> DpsCheckPhaseSec { get; set; } = []; // std::array<float,2>

    [JsonPropertyName("dpsCheckWaveInterval_")]
    public BindingList<float> DpsCheckWaveInterval { get; set; } = []; // std::array<float,2>

    [JsonPropertyName("dpsCheckWaveSpeedRate_")]
    public float DpsCheckWaveSpeedRate { get; set; }

    [JsonPropertyName("fireLaserAttackNumList_")]
    public BindingList<int> FireLaserAttackNumList { get; set; } = []; // std::array<int,3>

    [JsonPropertyName("iceFunnelLaserSpeedRate_")]
    public float IceFunnelLaserSpeedRate { get; set; }

    [JsonPropertyName("finishAttackCrackCount_")]
    public int FinishAttackCrackCount { get; set; }

    [JsonPropertyName("lastWaveAttackSpeedRate_")]
    public float LastWaveAttackSpeedRate { get; set; }

    public Em3100AILevelSpArtsParam()
    {
    }
}

public class Em3100FallDownParam
{
    [JsonPropertyName("impactRadius_")]
    public float ImpactRadius { get; set; }

    [JsonPropertyName("jumpedFrame_")]
    public int JumpedFrame { get; set; }

    [JsonPropertyName("landedFrame_")]
    public int LandedFrame { get; set; }

    [JsonPropertyName("continueJumpCount_")]
    public int ContinueJumpCount { get; set; }

    [JsonPropertyName("explodeWaitSec_")]
    public float ExplodeWaitSec { get; set; }

    [JsonPropertyName("explodeSignSec_")]
    public float ExplodeSignSec { get; set; }

    [JsonPropertyName("staySwitchSpeed_")]
    public float StaySwitchSpeed { get; set; }

    [JsonPropertyName("fallSwitchSpeed_")]
    public float FallSwitchSpeed { get; set; }

    [JsonPropertyName("jumpPower_")]
    public Vector2 JumpPower { get; set; }

    [JsonPropertyName("fallPower_")]
    public Vector2 FallPower { get; set; }

    [JsonPropertyName("stayGravityList_")]
    public BindingList<float> StayGravityList { get; set; } = []; // std::array<float, 3>

    public Em3100FallDownParam()
    {
    }
}
