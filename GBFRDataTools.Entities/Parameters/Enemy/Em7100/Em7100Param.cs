using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

using static GBFRDataTools.Entities.Parameters.Enemy.Em2100.Em2100Param;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7100;

public class Em7100Param : EmBossBaseParam
{
    [JsonPropertyName("addDamageParam_")]
    public EmAddDamageParam AddDamageParam { get; set; }

    [JsonPropertyName("moveParam_")]
    public Em7100MoveParam MoveParam { get; set; }

    [JsonPropertyName("shellParams_")]
    public BindingList<Em7100ShellParam> ShellParams { get; set; } = []; // std::vector<Em7100ShellParam>

    [JsonPropertyName("magmaAreaParam_")]
    public Em7100MagmaAreaParam MagmaAreaParam { get; set; }

    [JsonPropertyName("hammerCrackParams_")]
    public BindingList<Em7100HammerCrackParam> HammerCrackParams { get; set; } = []; // std::vector<Em7100HammerCrackParam>

    [JsonPropertyName("aiLevelParams_")]
    public AILevelParam[] AiLevelParams { get; set; } = new AILevelParam[5]; // std::array<Em7100Param::AILevelParam,5>

    [JsonPropertyName("shellDamageRadius_")]
    public float ShellDamageRadius { get; set; } = 2.7f;

    [JsonPropertyName("shellDamageRadiusAddHit_")]
    public float ShellDamageRadiusAddHit { get; set; } = 1.6f;

    [JsonPropertyName("shellDamageOffset_")]
    public Vector4 ShellDamageOffset { get; set; } = new Vector4(0f, 1.2f, 0f, 1f);

    [JsonPropertyName("shellShakeSecond_")]
    public float ShellShakeSecond { get; set; } = 0.12f;

    [JsonPropertyName("shellShakeDegreeMax_")]
    public float ShellShakeDegreeMax { get; set; } = 3.5f;

    [JsonPropertyName("shellShakeCycle_")]
    public float ShellShakeCycle { get; set; } = 3f;

    [JsonPropertyName("shellShakeEndRate_")]
    public float ShellShakeEndRate { get; set; } = 1f;

    [JsonPropertyName("shellReviveCoolSec_")]
    public float ShellReviveCoolSec { get; set; } = 1f;

    [JsonPropertyName("breakShellHitEffectStopSec_")]
    public float BreakShellHitEffectStopSec { get; set; } = 0.2f;

    [JsonPropertyName("hpLowerLimitRate1stBattle_")]
    public float HpLowerLimitRate1stBattle { get; set; } = 0.8f;

    [JsonPropertyName("hpLowerLimitRate2ndBattle_")]
    public float HpLowerLimitRate2ndBattle { get; set; } = 0.84f;

    [JsonPropertyName("hpLowerLimitRate3rdBattle1st_")]
    public float HpLowerLimitRate3rdBattle1st { get; set; } = 0.7f;

    [JsonPropertyName("hpLowerLimitRate3rdBattle2nd_")]
    public float HpLowerLimitRate3rdBattle2nd { get; set; } = 0.4f;

    [JsonPropertyName("hpLowerLimitRate3rdBattle3rd_")]
    public float HpLowerLimitRate3rdBattle3rd { get; set; } = 0.01f;

    [JsonPropertyName("damageCutBuffHpTrigger2ndBattle_")]
    public int DamageCutBuffHpTrigger2ndBattle { get; set; } = 85;

    [JsonPropertyName("damageCutBuffHpTrigger3rdBattle3rd_")]
    public int DamageCutBuffHpTrigger3rdBattle3rd { get; set; } = 7;

    [JsonPropertyName("spArtsHpTrigger1st_")]
    public int SpArtsHpTrigger1st { get; set; } = 60;

    [JsonPropertyName("spArtsHpTrigger2nd_")]
    public int SpArtsHpTrigger2nd { get; set; } = 20;

    [JsonPropertyName("damageCutRate_")]
    public float DamageCutRate { get; set; } = 0.99f;

    [JsonPropertyName("damageTurnRate_")]
    public float DamageTurnRate { get; set; } = 0.9f;

    [JsonPropertyName("damageTurnRotY_")]
    public float DamageTurnRotY { get; set; } = 0.09f;

    [JsonPropertyName("guardEffectOffsetZ_")]
    public float GuardEffectOffsetZ { get; set; } = 1.5f;

    [JsonPropertyName("damageCutHitEffectCoolSec_")]
    public float DamageCutHitEffectCoolSec { get; set; } = 1f;

    [JsonPropertyName("lastDamageCutStunGaugeMaxRate_")]
    public float LastDamageCutStunGaugeMaxRate { get; set; } = 0.6f;

    [JsonPropertyName("damageCutBuffTextId_")]
    public string DamageCutBuffTextId { get; set; }

    [JsonPropertyName("shellDamageEmissiveInSec_")]
    public float ShellDamageEmissiveInSec { get; set; } = 0.1f;

    [JsonPropertyName("shellDamageEmissiveMaxSec_")]
    public float ShellDamageEmissiveMaxSec { get; set; } = 0.3f;

    [JsonPropertyName("shellDamageEmissiveOutSec_")]
    public float ShellDamageEmissiveOutSec { get; set; } = 0.2f;

    [JsonPropertyName("shellDamageEmissiveMin_")]
    public float ShellDamageEmissiveMin { get; set; } = 0.06f;

    [JsonPropertyName("shellDamageEmissiveMax_")]
    public float ShellDamageEmissiveMax { get; set; } = 1f;

    [JsonPropertyName("shellDamageEmissiveInEaseParam_")]
    public EaseParam ShellDamageEmissiveInEaseParam { get; set; }

    [JsonPropertyName("shellDamageEmissiveOutEaseParam_")]
    public EaseParam ShellDamageEmissiveOutEaseParam { get; set; }

    [JsonPropertyName("centerDistance_")]
    public float CenterDistance { get; set; } = 12f;

    [JsonPropertyName("battleAreaRadius_")]
    public float BattleAreaRadius { get; set; } = 48f;

    [JsonPropertyName("moveSpeedMax_")]
    public float MoveSpeedMax { get; set; } = 15f;

    [JsonPropertyName("moveRotDegSpeed_")]
    public float MoveRotDegSpeed { get; set; } = 20f;

    [JsonPropertyName("moveBlendAddDegSpeed_")]
    public float MoveBlendAddDegSpeed { get; set; } = 1f;

    [JsonPropertyName("moveSpeedChangeSec_")]
    public float MoveSpeedChangeSec { get; set; } = 2f;

    [JsonPropertyName("moveEffectOffsetY_")]
    public float MoveEffectOffsetY { get; set; } = 1.22f;

    [JsonPropertyName("moveAttackRadius_")]
    public float MoveAttackRadius { get; set; } = 6.5f;

    [JsonPropertyName("moveAttackRate_")]
    public float MoveAttackRate { get; set; } = 0.25f;

    [JsonPropertyName("moveAttackResetSec_")]
    public float MoveAttackResetSec { get; set; } = 1f;

    [JsonPropertyName("moveCoolSec_")]
    public float MoveCoolSec { get; set; } = 60f;

    [JsonPropertyName("moveCoolSecAddRandom_")]
    public float MoveCoolSecAddRandom { get; set; } = 10f;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.8f;

    [JsonPropertyName("turnRotY_")]
    public float TurnRotY { get; set; } = 0.02617995f;

    [JsonPropertyName("stageFrontDegreeY_")]
    public float StageFrontDegreeY { get; set; } = 175.6f;

    [JsonPropertyName("surfaceAnimCancelSec_")]
    public float SurfaceAnimCancelSec { get; set; } = 1.666f;

    [JsonPropertyName("archMoveturnRate_")]
    public float ArchMoveturnRate { get; set; } = 0.9f;

    [JsonPropertyName("archMoveturnRotY_")]
    public float ArchMoveturnRotY { get; set; } = 0.03490659f;

    [JsonPropertyName("posAdjustReturnSec_")]
    public float PosAdjustReturnSec { get; set; } = 1f;

    [JsonPropertyName("posAdjustEaseParam_")]
    public EaseParam PosAdjustEaseParam { get; set; }

    [JsonPropertyName("magmaLevelDefault_")]
    public float MagmaLevelDefault { get; set; } = 0f;

    [JsonPropertyName("magmaLevelLow_")]
    public float MagmaLevelLow { get; set; } = 1.3f;

    [JsonPropertyName("magmaLevelChangeSpeedDefault_")]
    public float MagmaLevelChangeSpeedDefault { get; set; } = 0.5f;

    [JsonPropertyName("magmaLevelChangeSpeedLow_")]
    public float MagmaLevelChangeSpeedLow { get; set; } = 0.4f;

    [JsonPropertyName("magmaLevelChangeRoarSec_")]
    public float MagmaLevelChangeRoarSec { get; set; } = 2f;

    [JsonPropertyName("magmaLevelEscapeSec_")]
    public float MagmaLevelEscapeSec { get; set; } = 4.2f;

    [JsonPropertyName("explosionMotionWaitSec_")]
    public float ExplosionMotionWaitSec { get; set; } = 999f;

    [JsonPropertyName("explosionWaitSec_")]
    public float ExplosionWaitSec { get; set; } = 1.6f;

    [JsonPropertyName("fireCoreWaitSec_")]
    public float FireCoreWaitSec { get; set; } = 5.5f;

    [JsonPropertyName("fireCoreOffsetY_")]
    public float FireCoreOffsetY { get; set; } = 20f;

    [JsonPropertyName("fireCoreScaleBegin_")]
    public float FireCoreScaleBegin { get; set; } = 2.5f;

    [JsonPropertyName("fireCoreScaleEnd_")]
    public float FireCoreScaleEnd { get; set; } = 4.5f;

    [JsonPropertyName("fireCoreScaleSubRate_")]
    public float FireCoreScaleSubRate { get; set; } = 0.6f;

    [JsonPropertyName("fireCoreScaleSubSec_")]
    public float FireCoreScaleSubSec { get; set; } = 0.75f;

    [JsonPropertyName("fireCoreScaleWaitSec_")]
    public float FireCoreScaleWaitSec { get; set; } = 1.2f;

    [JsonPropertyName("fireCoreScaleSubEaseParam_")]
    public EaseParam FireCoreScaleSubEaseParam { get; set; }

    [JsonPropertyName("fireCoreCompressEaseParam_")]
    public EaseParam FireCoreCompressEaseParam { get; set; }

    [JsonPropertyName("fireCoreCompressSec_")]
    public float FireCoreCompressSec { get; set; } = 0.7f;

    [JsonPropertyName("fireCoreCompressScaleRate_")]
    public float FireCoreCompressScaleRate { get; set; } = 0f;

    [JsonPropertyName("fireCoreCompressScaleWaitSec_")]
    public float FireCoreCompressScaleWaitSec { get; set; } = 0.85f;

    [JsonPropertyName("fireCoreCompressEffectWaitSec_")]
    public float FireCoreCompressEffectWaitSec { get; set; } = 0.001f;

    [JsonPropertyName("fireCoreParticleChangeWaitSec_")]
    public float FireCoreParticleChangeWaitSec { get; set; } = 3f;

    [JsonPropertyName("fireCoreRadius_")]
    public float FireCoreRadius { get; set; } = 10f;

    [JsonPropertyName("fireCoreLineVanishWaitSec_")]
    public float FireCoreLineVanishWaitSec { get; set; } = 0.8f;

    [JsonPropertyName("fireCoreLineOffset_")]
    public Vector4 FireCoreLineOffset { get; set; } = new Vector4(0f, 12f, 28f, 1f);

    [JsonPropertyName("spArtsCameraOffset_")]
    public Vector4 SpArtsCameraOffset { get; set; } = new Vector4(0f, 3f, 90f, 1f);

    [JsonPropertyName("spArtsCameraAddDegreeYHead_")]
    public float SpArtsCameraAddDegreeYHead { get; set; } = 0f;

    [JsonPropertyName("spArtsCameraAddDegreeYBody_")]
    public float SpArtsCameraAddDegreeYBody { get; set; } = 90f;

    [JsonPropertyName("spArtsCameraAddDegreeYTail_")]
    public float SpArtsCameraAddDegreeYTail { get; set; } = 90f;

    [JsonPropertyName("spArtsCameraWaitSec_")]
    public float SpArtsCameraWaitSec { get; set; } = 4.5f;

    [JsonPropertyName("spArtsCameraPanRate_")]
    public float SpArtsCameraPanRate { get; set; } = 0.2f;

    [JsonPropertyName("spArtsCameraMoveRate_")]
    public float SpArtsCameraMoveRate { get; set; } = 0.02f;

    [JsonPropertyName("spArtsCameraFovBegin_")]
    public float SpArtsCameraFovBegin { get; set; } = 60f;

    [JsonPropertyName("spArtsCameraFovEnd_")]
    public float SpArtsCameraFovEnd { get; set; } = 50f;

    [JsonPropertyName("spArtsCameraFovChangeSec_")]
    public float SpArtsCameraFovChangeSec { get; set; } = 1f;

    [JsonPropertyName("spArtsResetPosAddMinZ_")]
    public float SpArtsResetPosAddMinZ { get; set; } = 2f;

    [JsonPropertyName("spArtsResetPosAddMaxZ_")]
    public float SpArtsResetPosAddMaxZ { get; set; } = 5f;

    [JsonPropertyName("spArtsCameraDamageReactionRate_")]
    public float SpArtsCameraDamageReactionRate { get; set; } = 0.03f;

    [JsonPropertyName("spArtsCameraDamageReactionSec_")]
    public float SpArtsCameraDamageReactionSec { get; set; } = 2.75f;

    [JsonPropertyName("spArtsExplosionCameraOffset_")]
    public Vector4 SpArtsExplosionCameraOffset { get; set; } = new Vector4(0f, 10f, -50f, 1f);

    [JsonPropertyName("spArtsExplosionCameraTargetAddY_")]
    public float SpArtsExplosionCameraTargetAddY { get; set; } = -10f;

    [JsonPropertyName("spArtsExplosionCameraSec_")]
    public float SpArtsExplosionCameraSec { get; set; } = 7f;

    [JsonPropertyName("spArtsExplosionCameraMoveRate_")]
    public float SpArtsExplosionCameraMoveRate { get; set; } = 0.02f;

    [JsonPropertyName("spArtsExplosionMagmaAreaVanishSec_")]
    public float SpArtsExplosionMagmaAreaVanishSec { get; set; } = 5f;

    [JsonPropertyName("spArtsPlayerWarpPositions_")]
    public Vector4[] SpArtsPlayerWarpPositions { get; set; } = new Vector4[3];

    [JsonPropertyName("magmaLevelRaiseWaitSeconds_")]
    public float[] MagmaLevelRaiseWaitSeconds { get; set; } = new float[2];

    [JsonPropertyName("spartsExplosionAttackRates_")]
    public float[] SpartsExplosionAttackRates { get; set; } = new float[3];

    [JsonPropertyName("spartsGaugeTextId_")]
    public string SpartsGaugeTextId { get; set; } // cyan::inplace_string<32>

    [JsonPropertyName("nihillaSpartsGaugeTextId_")]
    public string NihillaSpartsGaugeTextId { get; set; } // cyan::inplace_string<32>

    [JsonPropertyName("magmaWaveFirstCoolSec_")]
    public float MagmaWaveFirstCoolSec { get; set; } = 100f;

    [JsonPropertyName("magmaWaveCoolSec_")]
    public float MagmaWaveCoolSec { get; set; } = 100f;

    [JsonPropertyName("magmaWaveAttackRate_")]
    public float MagmaWaveAttackRate { get; set; } = 3f;

    [JsonPropertyName("magmaWaveAreaVanishSec_")]
    public float MagmaWaveAreaVanishSec { get; set; } = 5f;

    [JsonPropertyName("magmaWaveMoveAnimId_")]
    public int MagmaWaveMoveAnimId { get; set; } = 80;

    [JsonPropertyName("magmaWaveMoveSlowRate_")]
    public float MagmaWaveMoveSlowRate { get; set; } = 0.5f;

    [JsonPropertyName("magmaWaveOffset_")]
    public Vector4 MagmaWaveOffset { get; set; } = new Vector4(0f, -1.5f, 15f, 1f);

    [JsonPropertyName("magmaWaveScale_")]
    public float MagmaWaveScale { get; set; } = 1f;

    [JsonPropertyName("magmaWaveCollisionNormalChangeSec_")]
    public float MagmaWaveCollisionNormalChangeSec { get; set; } = 6f;

    [JsonPropertyName("magmaWaveCollisionSpArtsChangeSec_")]
    public float MagmaWaveCollisionSpArtsChangeSec { get; set; } = 1f;

    [JsonPropertyName("magmaWaveCollisionAutoVanishSec_")]
    public float MagmaWaveCollisionAutoVanishSec { get; set; } = 5f;

    [JsonPropertyName("magmaWaveCollisionManualVanishSec_")]
    public float MagmaWaveCollisionManualVanishSec { get; set; } = 1f;

    [JsonPropertyName("magmaWaveAreaCheckPartsNumber_")]
    public int MagmaWaveAreaCheckPartsNumber { get; set; } = 3;

    [JsonPropertyName("magmaWaveAreaCheckBeginOffsetZ_")]
    public float MagmaWaveAreaCheckBeginOffsetZ { get; set; } = -5f;

    [JsonPropertyName("magmaWaveAreaCheckEndOffsetZ_")]
    public float MagmaWaveAreaCheckEndOffsetZ { get; set; } = 0f;

    [JsonPropertyName("magmaWaveAreaCheckWaitSec_")]
    public float MagmaWaveAreaCheckWaitSec { get; set; } = 0.2f;

    [JsonPropertyName("magmaWaveDiveMoveturnRate_")]
    public float MagmaWaveDiveMoveturnRate { get; set; } = 0.9f;

    [JsonPropertyName("magmaWaveDiveMoveturnRotY_")]
    public float MagmaWaveDiveMoveturnRotY { get; set; } = 0.08726647f;

    [JsonPropertyName("magmaWaveOdStartlSec_")]
    public float MagmaWaveOdStartlSec { get; set; } = 1.3f;

    [JsonPropertyName("magmaWaveOdCancelSec_")]
    public float MagmaWaveOdCancelSec { get; set; } = 4f;

    [JsonPropertyName("magmaWaveAttackCancelSec_")]
    public float MagmaWaveAttackCancelSec { get; set; } = 10f;

    [JsonPropertyName("magmaWaveAttackAnimRate_")]
    public float MagmaWaveAttackAnimRate { get; set; } = 1.5f;

    [JsonPropertyName("magmaWaveEscapeAnimRate_")]
    public float MagmaWaveEscapeAnimRate { get; set; } = 1.5f;

    [JsonPropertyName("magmaWaveEscapeStartSec_")]
    public float MagmaWaveEscapeStartSec { get; set; } = 0.833f;

    [JsonPropertyName("magmaWaveEscapeInterSec_")]
    public float MagmaWaveEscapeInterSec { get; set; } = 1f;

    [JsonPropertyName("magmaWaveEscapeCancelSec_")]
    public float MagmaWaveEscapeCancelSec { get; set; } = 4f;

    [JsonPropertyName("magmaWaveDiveOffsetZ_")]
    public float MagmaWaveDiveOffsetZ { get; set; } = 50f;

    [JsonPropertyName("magmaAreaCoolSec_")]
    public float MagmaAreaCoolSec { get; set; } = 60f;

    [JsonPropertyName("magmaAreaVanishSec_")]
    public float MagmaAreaVanishSec { get; set; } = 10f;

    [JsonPropertyName("magmaAreaRadius_")]
    public float MagmaAreaRadius { get; set; } = 13f;

    [JsonPropertyName("magmaAreaLeftAddRotY_")]
    public float MagmaAreaLeftAddRotY { get; set; } = -0.122274f;

    [JsonPropertyName("magmaAreaRightAddRotY_")]
    public float MagmaAreaRightAddRotY { get; set; } = 0.1223f;

    [JsonPropertyName("magmaAreaAddOffsetZ_")]
    public float MagmaAreaAddOffsetZ { get; set; } = 2.5f;

    [JsonPropertyName("magmaAreaHitListClearIntervalSec_")]
    public float MagmaAreaHitListClearIntervalSec { get; set; } = 0.5f;

    [JsonPropertyName("magmaAreaPosAdjustDist_")]
    public float MagmaAreaPosAdjustDist { get; set; } = 5f;

    [JsonPropertyName("cannonMoveSec_")]
    public float CannonMoveSec { get; set; } = 2f;

    [JsonPropertyName("cannonMagmaAreaVanishSec_")]
    public float CannonMagmaAreaVanishSec { get; set; } = 5f;

    [JsonPropertyName("cannonGravityScale_")]
    public float CannonGravityScale { get; set; } = 3f;

    [JsonPropertyName("cannonBeginWaitSec_")]
    public float CannonBeginWaitSec { get; set; } = 1f;

    [JsonPropertyName("cannonEndWaitSec_")]
    public float CannonEndWaitSec { get; set; } = 1f;

    [JsonPropertyName("cannonIntervalSec_")]
    public float CannonIntervalSec { get; set; } = 0.1f;

    [JsonPropertyName("cannonShotRadius_")]
    public float CannonShotRadius { get; set; } = 1f;

    [JsonPropertyName("cannonTargetRadius_")]
    public float CannonTargetRadius { get; set; } = 12f;

    [JsonPropertyName("waveCannonWaitSec_")]
    public float WaveCannonWaitSec { get; set; } = 2f;

    [JsonPropertyName("fireBallCancelFrame_")]
    public float FireBallCancelFrame { get; set; } = 90f;

    [JsonPropertyName("fireBallTargetDegreeMaxX_")]
    public float FireBallTargetDegreeMaxX { get; set; } = 20f;

    [JsonPropertyName("fireBallTargetOffsetZ_")]
    public float FireBallTargetOffsetZ { get; set; } = 0f;

    [JsonPropertyName("fireBallTurnOffsetDegree_")]
    public float FireBallTurnOffsetDegree { get; set; } = -1.2f;

    [JsonPropertyName("fireBallHandGroundCheckRadius_")]
    public float FireBallHandGroundCheckRadius { get; set; } = 2.5f;

    [JsonPropertyName("fireBallHandGroundCheckOffsets_")]
    public BindingList<Vector4> FireBallHandGroundCheckOffsets { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("fireBallAttackSignPartsOffset_")]
    public Vector4 FireBallAttackSignPartsOffset { get; set; } = new Vector4(0f, 5.44f, 20.74f, 1f);

    [JsonPropertyName("fireBallAttackSignPartsNo_")]
    public int FireBallAttackSignPartsNo { get; set; } = -1;

    [JsonPropertyName("fireBallGroundHandFireOffsetX_")]
    public float FireBallGroundHandFireOffsetX { get; set; } = 1.38f;

    [JsonPropertyName("fireWallRemoveCountMin_")]
    public int FireWallRemoveCountMin { get; set; } = 1;

    [JsonPropertyName("fireWallRemoveCountMax_")]
    public int FireWallRemoveCountMax { get; set; } = 1;

    [JsonPropertyName("fireWallVanishSec_")]
    public float FireWallVanishSec { get; set; } = 10f;

    [JsonPropertyName("fireWallOdAnimRate_")]
    public float FireWallOdAnimRate { get; set; } = 1.5f;

    [JsonPropertyName("fireWallOdCancelSec_")]
    public float FireWallOdCancelSec { get; set; } = 4.333f;

    [JsonPropertyName("stompComboStartSec_")]
    public float StompComboStartSec { get; set; } = 0.833f;

    [JsonPropertyName("stompComboInterSec_")]
    public float StompComboInterSec { get; set; } = 1.5f;

    [JsonPropertyName("stompComboCancelSec_")]
    public float StompComboCancelSec { get; set; } = 3.66667f;

    [JsonPropertyName("stompOdComboStartSec_")]
    public float StompOdComboStartSec { get; set; } = 1.667f;

    [JsonPropertyName("stompOdComboInterSec_")]
    public float StompOdComboInterSec { get; set; } = 0.667f;

    [JsonPropertyName("stompOdComboCancelSec_")]
    public float StompOdComboCancelSec { get; set; } = 3.166f;

    [JsonPropertyName("stompEndSec_")]
    public float StompEndSec { get; set; } = 8f;

    [JsonPropertyName("stompTurnRate_")]
    public float StompTurnRate { get; set; } = 0.8f;

    [JsonPropertyName("stompTurnMaxDegree_")]
    public float StompTurnMaxDegree { get; set; } = 0.974f;

    [JsonPropertyName("stompTurnOffsetDegree_")]
    public float StompTurnOffsetDegree { get; set; } = -10.027f;

    [JsonPropertyName("stompAdjustPosInterSec_")]
    public float StompAdjustPosInterSec { get; set; } = 2f;

    [JsonPropertyName("stompComboAdjustPosInterSec_")]
    public float StompComboAdjustPosInterSec { get; set; } = 0.5f;

    [JsonPropertyName("stompAdjustPosReturnSec_")]
    public float StompAdjustPosReturnSec { get; set; } = 6f;

    [JsonPropertyName("stompAdjustEaseParam_")]
    public EaseParam StompAdjustEaseParam { get; set; }

    [JsonPropertyName("stompOdSlowBeginSec_")]
    public float StompOdSlowBeginSec { get; set; } = 4f;

    [JsonPropertyName("stompOdSlowEndSec_")]
    public float StompOdSlowEndSec { get; set; } = 6f;

    [JsonPropertyName("stompOdSlowBeginRate_")]
    public float StompOdSlowBeginRate { get; set; } = 0.5f;

    [JsonPropertyName("stompOdSlowEaseParam_")]
    public EaseParam StompOdSlowEaseParam { get; set; }

    [JsonPropertyName("stompPosAdjustDist_")]
    public float StompPosAdjustDist { get; set; } = 5f;

    [JsonPropertyName("stompPosAdjustDistEventBattle_")]
    public float StompPosAdjustDistEventBattle { get; set; } = 7.5f;

    [JsonPropertyName("backHandBlowCoolSec_")]
    public float BackHandBlowCoolSec { get; set; } = 15f;

    [JsonPropertyName("backHandBlowPosAdjustDist_")]
    public float BackHandBlowPosAdjustDist { get; set; } = 5f;

    [JsonPropertyName("breathAnimStartSec_")]
    public float BreathAnimStartSec { get; set; } = 0f;

    [JsonPropertyName("breathAnimEndSec_")]
    public float BreathAnimEndSec { get; set; } = 6.333f;

    [JsonPropertyName("breathStartSec_")]
    public float BreathStartSec { get; set; } = 2.333f;

    [JsonPropertyName("breathEndSec_")]
    public float BreathEndSec { get; set; } = 5f;

    [JsonPropertyName("breathMinDegreeY_")]
    public float BreathMinDegreeY { get; set; } = -65f;

    [JsonPropertyName("breathMaxDegreeY_")]
    public float BreathMaxDegreeY { get; set; } = 73f;

    [JsonPropertyName("breathMinDegreeX_")]
    public float BreathMinDegreeX { get; set; } = 0f;

    [JsonPropertyName("breathMaxDegreeX_")]
    public float BreathMaxDegreeX { get; set; } = 18f;

    [JsonPropertyName("breathBeginDegreeX_")]
    public float BreathBeginDegreeX { get; set; } = 110f;

    [JsonPropertyName("breathRotXCycleScale_")]
    public float BreathRotXCycleScale { get; set; } = 2.1f;

    [JsonPropertyName("breathMagmaAreaVanishSec_")]
    public float BreathMagmaAreaVanishSec { get; set; } = 7.5f;

    [JsonPropertyName("breathParam_")]
    public EmHitBreathParam BreathParam { get; set; }

    [JsonPropertyName("breathAttackRate_")]
    public float BreathAttackRate { get; set; } = 1f;

    [JsonPropertyName("breathBreakRate_")]
    public float BreathBreakRate { get; set; } = 1f;

    [JsonPropertyName("odHpRateNormalNext_")]
    public float OdHpRateNormalNext { get; set; } = 0.1f;

    [JsonPropertyName("tackleCoolSec_")]
    public float TackleCoolSec { get; set; } = 20f;

    [JsonPropertyName("tacklePosAdjustDist_")]
    public float TacklePosAdjustDist { get; set; } = 7f;

    [JsonPropertyName("hammerCoolSec_")]
    public float HammerCoolSec { get; set; } = 20f;

    [JsonPropertyName("hammerMotionEndSec_")]
    public float HammerMotionEndSec { get; set; } = -1f;

    [JsonPropertyName("hammerExplosionSmallWaitSec_")]
    public float HammerExplosionSmallWaitSec { get; set; } = 1f;

    [JsonPropertyName("hammerPosAdjustDist_")]
    public float HammerPosAdjustDist { get; set; } = 7f;

    [JsonPropertyName("counterRockStartFrame_")]
    public float CounterRockStartFrame { get; set; } = 174f;

    [JsonPropertyName("counterRockEndFrame_")]
    public float CounterRockEndFrame { get; set; } = 196f;

    [JsonPropertyName("counterRockDegreeStart_")]
    public float CounterRockDegreeStart { get; set; } = 60f;

    [JsonPropertyName("counterRockDegreeEnd_")]
    public float CounterRockDegreeEnd { get; set; } = -60f;

    [JsonPropertyName("counterRockCount_")]
    public int CounterRockCount { get; set; } = 8;

    [JsonPropertyName("counterRockShotOffsetY_")]
    public float CounterRockShotOffsetY { get; set; } = 1.75f;

    [JsonPropertyName("counterRockDegreeX_")]
    public float CounterRockDegreeX { get; set; } = -30f;

    [JsonPropertyName("counterRockAddDegreeY_")]
    public float CounterRockAddDegreeY { get; set; } = 0f;

    [JsonPropertyName("counterRockScaleMin_")]
    public float CounterRockScaleMin { get; set; } = 2f;

    [JsonPropertyName("counterRockScaleMax_")]
    public float CounterRockScaleMax { get; set; } = 3.5f;

    [JsonPropertyName("counterPosAdjustDist_")]
    public float CounterPosAdjustDist { get; set; } = 7f;

    [JsonPropertyName("meteorAddPosRadius_")]
    public float MeteorAddPosRadius { get; set; } = 3f;

    [JsonPropertyName("meteorScale_")]
    public float MeteorScale { get; set; } = 0.5f;

    [JsonPropertyName("meteorSignRadius_")]
    public float MeteorSignRadius { get; set; } = 3.2f;

    [JsonPropertyName("meteorSignSec_")]
    public float MeteorSignSec { get; set; } = 2f;

    [JsonPropertyName("meteorMoveSpeed_")]
    public float MeteorMoveSpeed { get; set; } = 40f;

    [JsonPropertyName("meteorMinDistFromEnemy_")]
    public float MeteorMinDistFromEnemy { get; set; } = 20f;

    [JsonPropertyName("meteorHighStageDist_")]
    public float MeteorHighStageDist { get; set; } = 16f;

    [JsonPropertyName("bodyPressEndAnimStartSec_")]
    public float BodyPressEndAnimStartSec { get; set; } = 5.5833f;

    [JsonPropertyName("bodyPressEndAnimInterSec_")]
    public float BodyPressEndAnimInterSec { get; set; } = 1f;

    [JsonPropertyName("bodyPressSpArtsNormalHitSec_")]
    public float BodyPressSpArtsNormalHitSec { get; set; } = 2.916667f;

    [JsonPropertyName("bodyPressSpArtsCustomHitSec_")]
    public float BodyPressSpArtsCustomHitSec { get; set; } = 6.75f;

    [JsonPropertyName("bodyPressAfterDamageObjHitOffIndex_")]
    public float BodyPressAfterDamageObjHitOffIndex { get; set; } = 2f;

    [JsonPropertyName("bodyPressSpArtsDamageBeginInterSec_")]
    public float BodyPressSpArtsDamageBeginInterSec { get; set; } = 0.333f;

    [JsonPropertyName("bodyPressObjHitOffFlags_")]
    public BindingList<uint> BodyPressObjHitOffFlags { get; set; } = []; // std::vector<unsigned int>

    [JsonPropertyName("bodyPressSpArtsBeginOffsets_")]
    public BindingList<Vector4> BodyPressSpArtsBeginOffsets { get; set; } = [];

    [JsonPropertyName("bodyPressAttackSignParams_")]
    public BindingList<BodyPressAttackSign> BodyPressAttackSignParams { get; set; } = [];

    [JsonPropertyName("talkEventStunGaugeCoolSec_")]
    public float TalkEventStunGaugeCoolSec { get; set; } = 30f;

    [JsonPropertyName("talkEventStunGaugeRate_")]
    public float TalkEventStunGaugeRate { get; set; } = 0.5f;

    [JsonPropertyName("talkEventSetDamageCutWaitSec_")]
    public float TalkEventSetDamageCutWaitSec { get; set; } = 2f;

    [JsonPropertyName("talkEventRequestWaitSec_")]
    public float TalkEventRequestWaitSec { get; set; } = 0.75f;

    [JsonPropertyName("talkEventRequestLastWaitSec_")]
    public float TalkEventRequestLastWaitSec { get; set; } = 10f;

    [JsonPropertyName("talkEventBattleCutinWaitSec_")]
    public float TalkEventBattleCutinWaitSec { get; set; } = 0.01f;

    [JsonPropertyName("talkEventSpArtsFireBallAppearWaitSec_")]
    public float TalkEventSpArtsFireBallAppearWaitSec { get; set; } = 6.5f;

    [JsonPropertyName("battleCutinEffectSrcOffset_")]
    public Vector4 BattleCutinEffectSrcOffset { get; set; } = new Vector4(0f, 0.01f, 0f, 1f);

    [JsonPropertyName("battleCutinEffectDstOffset_")]
    public Vector4 BattleCutinEffectDstOffset { get; set; } = new Vector4(0f, 1f, 0.7f, 1f);

    [JsonPropertyName("battleCutinEffectSrcPartsNumber_")]
    public int BattleCutinEffectSrcPartsNumber { get; set; } = 0;

    [JsonPropertyName("battleCutinEffectDstPartsNumber_")]
    public int BattleCutinEffectDstPartsNumber { get; set; } = 913;

    [JsonPropertyName("ikWaistPartsNumber_")]
    public int IkWaistPartsNumber { get; set; } = -2;

    [JsonPropertyName("ikCheckPartsNoArmR_")]
    public int IkCheckPartsNoArmR { get; set; } = 1026;

    [JsonPropertyName("ikCheckPartsNoArmL_")]
    public int IkCheckPartsNoArmL { get; set; } = 1027;

    [JsonPropertyName("ikWaistAdjustHeight_")]
    public float IkWaistAdjustHeight { get; set; } = -5f;

    [JsonPropertyName("ikFingerOffsetY_")]
    public float IkFingerOffsetY { get; set; } = 0.8f;

    [JsonPropertyName("ikHandRotLimit_")]
    public float IkHandRotLimit { get; set; } = 0.5235988f;

    [JsonPropertyName("ikParams_")]
    public IkParam[] IkParams { get; set; } = new IkParam[3]; // std::array<Em7100Param::IkParam,3>

    [JsonPropertyName("event5st2ndBattleDamageCutOffSec_")]
    public float Event5st2ndBattleDamageCutOffSec { get; set; } = 4.2f;

    [JsonPropertyName("event5st3rdBattle2ndDamageCutOffSec_")]
    public float Event5st3rdBattle2ndDamageCutOffSec { get; set; } = 14.6f;

    [JsonPropertyName("event5st3rdBattle3rdDamageCutOffSec_")]
    public float Event5st3rdBattle3rdDamageCutOffSec { get; set; } = 6.8f;

    [JsonPropertyName("lockOnLengthChase_")]
    public float LockOnLengthChase { get; set; } = 10000f;

    [JsonPropertyName("lockOnLengthBattle_")]
    public float LockOnLengthBattle { get; set; } = 200f;

    [JsonPropertyName("lockOnUnderMagmaOffsetY_")]
    public float LockOnUnderMagmaOffsetY { get; set; } = -2f;

    [JsonPropertyName("lockOnAdjustStartRotY_")]
    public float LockOnAdjustStartRotY { get; set; } = 0.3926991f;

    [JsonPropertyName("lockOnAdjustEaseParam_")]
    public Em7100Param LockOnAdjustEaseParam { get; set; }

    [JsonPropertyName("nihillaSpArtsTextId_")]
    public string NihillaSpArtsTextId { get; set; }

    [JsonPropertyName("nihillaOdTextId_")]
    public string NihillaOdTextId { get; set; }

    [JsonPropertyName("nihillaOverDriveParam_")]
    public Em7100Param NihillaOverDriveParam { get; set; }

    [JsonPropertyName("nihillaOdAttackRateFirstTime_")]
    public float NihillaOdAttackRateFirstTime { get; set; } = 1.1f;

    [JsonPropertyName("nihillaOdDefenseRateFirstTime_")]
    public float NihillaOdDefenseRateFirstTime { get; set; } = 0.9f;

    [JsonPropertyName("nihillaOdAttackRateSecondTime_")]
    public float NihillaOdAttackRateSecondTime { get; set; } = 1.2f;

    [JsonPropertyName("nihillaOdDefenseRateSecondTime_")]
    public float NihillaOdDefenseRateSecondTime { get; set; } = 0.7f;

    [JsonPropertyName("nihillaShotHomingTargetOffsetY_")]
    public float NihillaShotHomingTargetOffsetY { get; set; } = 4.4f;

    [JsonPropertyName("nihillaShotSetHeight_")]
    public float NihillaShotSetHeight { get; set; } = 20f;

    [JsonPropertyName("nihillaShotSetDistance_")]
    public float NihillaShotSetDistance { get; set; } = 20f;

    [JsonPropertyName("nihillaShotSetStartRotY_")]
    public float NihillaShotSetStartRotY { get; set; } = -1.570796f;

    [JsonPropertyName("nihillaShotSetEndRotY_")]
    public float NihillaShotSetEndRotY { get; set; } = 1.570796f;

    [JsonPropertyName("nihillaShotFirstCoolSec_")]
    public float NihillaShotFirstCoolSec { get; set; } = 90f;

    [JsonPropertyName("nihillaShotCoolSec_")]
    public float NihillaShotCoolSec { get; set; } = 60f;

    [JsonPropertyName("nihillaShotMagmaAreaCount_")]
    public int NihillaShotMagmaAreaCount { get; set; } = 12;

    [JsonPropertyName("nihillaShotMagmaAreaRadius_")]
    public float NihillaShotMagmaAreaRadius { get; set; } = 4f;

    [JsonPropertyName("nihillaShotMagmaAreaSmallSizeRate_")]
    public float NihillaShotMagmaAreaSmallSizeRate { get; set; } = 0.35f;

    [JsonPropertyName("nihillaShotMagmaAreaVanishSec_")]
    public float NihillaShotMagmaAreaVanishSec { get; set; } = 5f;

    [JsonPropertyName("nihillaShotCheckGroundLengthStart_")]
    public float NihillaShotCheckGroundLengthStart { get; set; } = 2.5f;

    [JsonPropertyName("nihillaShotCheckGroundLengthEnd_")]
    public float NihillaShotCheckGroundLengthEnd { get; set; } = -6.5f;

    [JsonPropertyName("odAbilityWave1stPosSetWaitSec_")]
    public float OdAbilityWave1stPosSetWaitSec { get; set; } = 1f;

    [JsonPropertyName("odAbilityWave2ndPosSetWaitSec_")]
    public float OdAbilityWave2ndPosSetWaitSec { get; set; } = 1f;

    [JsonPropertyName("odAbilityWaveCheckBeginWaitSec_")]
    public float OdAbilityWaveCheckBeginWaitSec { get; set; } = 1.5f;

    [JsonPropertyName("odAbilityBreathPosSetWaitSec_")]
    public float OdAbilityBreathPosSetWaitSec { get; set; } = 0.01f;

    [JsonPropertyName("odAbilityBreathCheckBeginWaitSec_")]
    public float OdAbilityBreathCheckBeginWaitSec { get; set; } = 1.5f;

    [JsonPropertyName("odAbilityBreathBlockOffset_")]
    public Vector4 OdAbilityBreathBlockOffset { get; set; } = new Vector4(0f, 7f, 25.36f, 1f);

    [JsonPropertyName("nearCameraDistance_")]
    public float NearCameraDistance { get; set; } = 13f;

    [JsonPropertyName("nearCameraReturnSec_")]
    public float NearCameraReturnSec { get; set; } = 2f;

    [JsonPropertyName("nearCameraLookUpRotX_")]
    public float NearCameraLookUpRotX { get; set; } = -0.2181662f;

    [JsonPropertyName("buffCameraMoveRate_")]
    public float BuffCameraMoveRate { get; set; } = 0.02f;

    [JsonPropertyName("buffCameraOffset_")]
    public Vector4 BuffCameraOffset { get; set; } = new Vector4(15f, 5f, 40f, 1f);

    [JsonPropertyName("buffCameraWatchOffset_")]
    public Vector4 BuffCameraWatchOffset { get; set; } = new Vector4(0f, 10f, 0f, 1f);

    public Em7100Param()
    {
        Hp = 120000;
        Atk = 900;
        Break = 10;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 50;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
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
        CombatPower = 100;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 200f;
        Search2battleLength = 150f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 1f;
        AnimInterDefaultSec = 1f;
        DamageAnimInterDefaultSec = 0.3f;
        UiPartsNo = 0;
        UiOffsetY = 0f;
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
        CameraLength = 0f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 0f;
        EmissiveInitValue = 0.06f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = true;
        BossStunOffsetY = 0f;
    }

    public class IkParam
    {
        [JsonPropertyName("checkBeginOffsetY_")]
        public float CheckBeginOffsetY { get; set; } // Offset 0x8

        [JsonPropertyName("checkEndOffsetY_")]
        public float CheckEndOffsetY { get; set; } // Offset 0xC

        [JsonPropertyName("checkRadius_")]
        public float CheckRadius { get; set; } // Offset 0x10

        [JsonPropertyName("stickHeight_")]
        public float StickHeight { get; set; } // Offset 0x14

        public IkParam()
        {
        }
    }

    public class BodyPressAttackSign
    {
        [JsonPropertyName("offset_")]
        public Vector4 Offset { get; set; } // Offset 0x10

        [JsonPropertyName("radius_")]
        public float Radius { get; set; } // Offset 0x20

        [JsonPropertyName("dispSec_")]
        public float DispSec { get; set; } // Offset 0x24

        public BodyPressAttackSign()
        {
        }
    }
}

public class Em7100MagmaAreaParam
{
    [JsonPropertyName("locations_")]
    public BindingList<Location> Locations { get; set; } = []; // Offset 0x8

    public Em7100MagmaAreaParam()
    {
    }

    public class Location
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        [JsonPropertyName("obstaclePos_")]
        public Vector4 ObstaclePos { get; set; } // Offset 0x20

        [JsonPropertyName("degY_")]
        public float DegY { get; set; } // Offset 0x30

        [JsonPropertyName("radius_")]
        public float Radius { get; set; } // Offset 0x34

        [JsonPropertyName("addRadius_")]
        public float AddRadius { get; set; } // Offset 0x38

        [JsonPropertyName("addPosX_")]
        public float AddPosX { get; set; } // Offset 0x3C

        [JsonPropertyName("waitSec_")]
        public float WaitSec { get; set; } // Offset 0x40

        [JsonPropertyName("obstacleRadius_")]
        public float ObstacleRadius { get; set; } // Offset 0x44

        public Location()
        {
        }
    }
}

public class Em7100MoveParam
{
    [JsonPropertyName("offsets_")]
    public BindingList<LocationOffset>[] Offsets { get; set; } = new BindingList<LocationOffset>[2]; // Offset 0x10

    [JsonPropertyName("locationsArray_")]
    public BindingList<Location>[] LocationsArray { get; set; } = new BindingList<Location>[18]; // Offset 0x70

    [JsonPropertyName("magmaAreaLocationsArray_")]
    public BindingList<MagmaAreaLocation> MagmaAreaLocationsArray { get; set; } = []; // Offset 0x220

    [JsonPropertyName("fireWallLocations_")]
    public BindingList<FireWallLocation> FireWallLocations { get; set; } = []; // Offset 0x280

    [JsonPropertyName("locationIndicesArray_")]
    public BindingList<BindingList<int>>[] LocationIndicesArray { get; set; } = new BindingList<BindingList<int>>[4]; // Offset 0x298

    public Em7100MoveParam()
    {
    }

    public class LocationOffset
    {
        [JsonPropertyName("offset_")]
        public Vector4 Offset { get; set; } // Offset 0x10

        [JsonPropertyName("degY_")]
        public float DegY { get; set; } // Offset 0x20

        public LocationOffset()
        {
        }
    }

    public class Location
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        [JsonPropertyName("degY_")]
        public float DegY { get; set; } // Offset 0x20

        [JsonPropertyName("type_")]
        public int Type { get; set; } // Offset 0x24

        public Location()
        {
        }
    }

    public class MagmaAreaLocation
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x10

        [JsonPropertyName("radius_")]
        public float Radius { get; set; } // Offset 0x20

        [JsonPropertyName("randomAddRadius_")]
        public float RandomAddRadius { get; set; } // Offset 0x24

        public MagmaAreaLocation()
        {
        }
    }

    public class FireWallLocation
    {
        [JsonPropertyName("jumpOffsets_")]
        public Vector4[] JumpOffsets { get; set; } = new Vector4[2]; // Offset 0x10

        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; } // Offset 0x30

        [JsonPropertyName("degY_")]
        public float DegY { get; set; } // Offset 0x40

        [JsonPropertyName("group_")]
        public int Group { get; set; } // Offset 0x44

        [JsonPropertyName("type_")]
        public int Type { get; set; } // Offset 0x48

        [JsonPropertyName("size_")]
        public int Size { get; set; } // Offset 0x4C

        public FireWallLocation()
        {
        }
    }
}

public class Em7100ShellParam
{
    [JsonPropertyName("addDamageParam_")]
    public Em7100ShellParam AddDamageParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("pos_")]
    public Vector4 Pos { get; set; } // Offset 0x30

    [JsonPropertyName("degree_")]
    public Vector4 Degree { get; set; } // Offset 0x40

    [JsonPropertyName("partsNumber_")]
    public int PartsNumber { get; set; } // Offset 0x50

    [JsonPropertyName("shakePartsNumber_")]
    public int ShakePartsNumber { get; set; } // Offset 0x54

    [JsonPropertyName("objHitUniqueId_")]
    public int ObjHitUniqueId { get; set; } // Offset 0x58

    [JsonPropertyName("damageWorkIndex_")]
    public int DamageWorkIndex { get; set; } // Offset 0x5C

    [JsonPropertyName("lockOnIndex_")]
    public int LockOnIndex { get; set; } // Offset 0x60

    [JsonPropertyName("damageRadiusBreak_")]
    public float DamageRadiusBreak { get; set; } // Offset 0x64

    [JsonPropertyName("shellMeshName_")]
    public string ShellMeshName { get; set; } // Offset 0x70

    [JsonPropertyName("coverMeshName_")]
    public string CoverMeshName { get; set; } // Offset 0x90

    [JsonPropertyName("breakMeshName_")]
    public string BreakMeshName { get; set; } // Offset 0xB0

    [JsonPropertyName("id_")]
    public int Id { get; set; } // Offset 0x68

    public Em7100ShellParam()
    {
    }
}


public class Em7100HammerCrackParam
{
    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } // Offset 0x10

    [JsonPropertyName("offsetRotY_")]
    public float OffsetRotY { get; set; } // Offset 0x20

    [JsonPropertyName("partsNumber_")]
    public int PartsNumber { get; set; } // Offset 0x24

    [JsonPropertyName("isRightCrack_")]
    public bool IsRightCrack { get; set; } // Offset 0x28

    [JsonPropertyName("isShortCrack_")]
    public bool IsShortCrack { get; set; } // Offset 0x29

    public Em7100HammerCrackParam()
    {
    }
}