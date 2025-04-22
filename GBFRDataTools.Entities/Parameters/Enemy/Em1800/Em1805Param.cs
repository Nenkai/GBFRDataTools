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

public class Em1805Param : Em1800Param
{
    [JsonPropertyName("clearAlreadyHitListTime_")]
    public float ClearAlreadyHitListTime { get; set; } = 2f;

    [JsonPropertyName("chargedMinionStepCheck_")]
    public float ChargedMinionStepCheck { get; set; } = 12f;

    [JsonPropertyName("chargedMinionStepCheckTime_")]
    public float ChargedMinionStepCheckTime { get; set; } = 15f;

    [JsonPropertyName("regenerationHpRate_")]
    public float RegenerationHpRate { get; set; } = 0.01f;

    [JsonPropertyName("regenerationCycleSec_")]
    public float RegenerationCycleSec { get; set; } = 1f;

    [JsonPropertyName("pursuitThunderNum_")]
    public int PursuitThunderNum { get; set; } = 2;

    [JsonPropertyName("pursuitThunderOdAddNum_")]
    public int PursuitThunderOdAddNum { get; set; } = 2;

    [JsonPropertyName("pursuitThunderHpRateAddNum_")]
    public int PursuitThunderHpRateAddNum { get; set; } = 2;

    [JsonPropertyName("pursuitThunderHpRate_")]
    public float PursuitThunderHpRate { get; set; } = 0.6f;

    [JsonPropertyName("pursuitThunderWait_")]
    public float PursuitThunderWait { get; set; } = 0.2f;

    [JsonPropertyName("pursuitThunderLength_")]
    public float PursuitThunderLength { get; set; } = 5f;

    [JsonPropertyName("pursuitThunderSearchingLength_")]
    public float PursuitThunderSearchingLength { get; set; } = 10f;

    [JsonPropertyName("pursuitThunderSearchingMove_")]
    public float PursuitThunderSearchingMove { get; set; } = 2.5f;

    [JsonPropertyName("dischargeAngTable_")]
    [Editable(false)]
    public BindingList<float> DischargeAngTable { get; set; } = [..Enumerable.Repeat(0, 8)]; // std::array<float, 8>

    [JsonPropertyName("dischargeAngOffsetTable_")]
    [Editable(false)]
    public BindingList<float> DischargeAngOffsetTable { get; set; } = [.. Enumerable.Repeat(0, 8)]; // std::array<float, 8>

    [JsonPropertyName("dischargeDelayTable")]
    [Editable(false)]
    public BindingList<float> DischargeDelayTable { get; set; } = [.. Enumerable.Repeat(0, 12)]; // std::array<float, 12>

    [JsonPropertyName("railgunCoolTimePhaseHp_")]
    [Editable(false)]
    public BindingList<float> RailgunCoolTimePhaseHp { get; set; } = [.. Enumerable.Repeat(0,4)]; // std::array<float,4>

    [JsonPropertyName("railgunCoolTimePhase_")]
    [Editable(false)]
    public BindingList<float> RailgunCoolTimePhase { get; set; } = [.. Enumerable.Repeat(0, 4)]; // std::array<float,4>

    [JsonPropertyName("dragonicSpellRecastTime_")]
    public float DragonicSpellRecastTime { get; set; } = 65f;

    [JsonPropertyName("attackParam_frontBeam_")]
    public BossAttackParam AttackParam_frontBeam { get; set; }

    [JsonPropertyName("beamLoopTime_")]
    public float BeamLoopTime { get; set; } = 3f;

    [JsonPropertyName("beamExplosionThunderLength_")]
    public float BeamExplosionThunderLength { get; set; } = 6f;

    [JsonPropertyName("beamExplosionThunderDelay_")]
    public float BeamExplosionThunderDelay { get; set; } = 1f;

    [JsonPropertyName("beamExplosionThunderVerticalFront_")]
    public float BeamExplosionThunderVerticalFront { get; set; } = 0f;

    [JsonPropertyName("beamExplosionThunderVerticalBack_")]
    public float BeamExplosionThunderVerticalBack { get; set; } = 180f;

    [JsonPropertyName("beamExplosionThunderHorizontalL_")]
    public float BeamExplosionThunderHorizontalL { get; set; } = 60f;

    [JsonPropertyName("beamExplosionThunderHorizontalR_")]
    public float BeamExplosionThunderHorizontalR { get; set; } = -60f;

    [JsonPropertyName("jumpBeamHomingRate_")]
    public float JumpBeamHomingRate { get; set; } = 0f;

    [JsonPropertyName("jumpBeamHomingAngleMax_")]
    public float JumpBeamHomingAngleMax { get; set; } = 7f;

    [JsonPropertyName("jumpBeamThreeProngedHpRate_")]
    public float JumpBeamThreeProngedHpRate { get; set; } = 0.4f;

    [JsonPropertyName("jumpBeamThreeProngedRate_")]
    [Editable(false)]
    public BindingList<float> JumpBeamThreeProngedRate { get; set; } = [.. Enumerable.Repeat(0, 3)]; // std::array<float,3>

    [JsonPropertyName("jumpBeamThreeProngedAng_")]
    [Editable(false)]
    public BindingList<float> JumpBeamThreeProngedAng { get; set; } = [.. Enumerable.Repeat(0, 3)]; // std::array<float,3>

    [JsonPropertyName("stepBeamAttackRate_")]
    public float StepBeamAttackRate { get; set; } = 1.2f;

    [JsonPropertyName("stepBeamAttackODRate_")]
    public float StepBeamAttackODRate { get; set; } = 1.2f;

    [JsonPropertyName("stepBeamBreakRate_")]
    public float StepBeamBreakRate { get; set; } = 1f;

    [JsonPropertyName("stepBeamHomingRate_")]
    public float StepBeamHomingRate { get; set; } = 0.1f;

    [JsonPropertyName("stepBeamHomingSideRate_")]
    public float StepBeamHomingSideRate { get; set; } = 0f;

    [JsonPropertyName("stepBeamLength_")]
    public float StepBeamLength { get; set; } = 128f;

    [JsonPropertyName("stepBeamRadius_")]
    public float StepBeamRadius { get; set; } = 1f;

    [JsonPropertyName("stepBeamExplosionDistance_")]
    public float StepBeamExplosionDistance { get; set; } = 6f;

    [JsonPropertyName("stepBeamExplosionWait_")]
    public float StepBeamExplosionWait { get; set; } = 1.1f;

    [JsonPropertyName("stepBeamThreeProngedHpRate_")]
    public float StepBeamThreeProngedHpRate { get; set; } = 0.4f;

    [JsonPropertyName("stepBeamThreeProngedRate_")]
    [Editable(false)]
    public BindingList<float> StepBeamThreeProngedRate { get; set; } = [.. Enumerable.Repeat(0, 3)]; // std::array<float,3>

    [JsonPropertyName("stepBeamThreeProngedAng_")]
    [Editable(false)]
    public BindingList<float> StepBeamThreeProngedAng { get; set; } = [.. Enumerable.Repeat(0, 3)]; // std::array<float,3>

    [JsonPropertyName("stepBeamMoveRate_")]
    public float StepBeamMoveRate { get; set; } = 1.5f;

    [JsonPropertyName("judgmentThunderTime_")]
    public float JudgmentThunderTime { get; set; } = 11f;

    [JsonPropertyName("judgmentThunderPlayerExplosionOffset_")]
    public float JudgmentThunderPlayerExplosionOffset { get; set; } = 4f;

    [JsonPropertyName("judgmentThunderPlayerExplosionWait_")]
    public float JudgmentThunderPlayerExplosionWait { get; set; } = 1f;

    [JsonPropertyName("judgmentThunderPlayerExplosion2ndWait_")]
    public float JudgmentThunderPlayerExplosion2ndWait { get; set; } = 3f;

    [JsonPropertyName("judgmentThunderInterruptSpreadDist_")]
    public float JudgmentThunderInterruptSpreadDist { get; set; } = 6f;

    [JsonPropertyName("judgmentThunderChainMoveSecondMax_")]
    public float JudgmentThunderChainMoveSecondMax { get; set; } = 3f;

    [JsonPropertyName("judgmentThunderChainRoundTripMoveSecondMax_")]
    public float JudgmentThunderChainRoundTripMoveSecondMax { get; set; } = 8f;

    [JsonPropertyName("judgmentThunderFallTrackingScalar_")]
    public float JudgmentThunderFallTrackingScalar { get; set; } = 0.07f;

    [JsonPropertyName("judgmentThunderWaitEndSecond_")]
    public float JudgmentThunderWaitEndSecond { get; set; } = 3f;

    [JsonPropertyName("judgmentThunderSacrificeWait_")]
    public float JudgmentThunderSacrificeWait { get; set; } = 2f;

    [JsonPropertyName("judgmentThunderSacrificeDirRate_")]
    public float JudgmentThunderSacrificeDirRate { get; set; } = 0.7f;

    [JsonPropertyName("summonCoolTime_")]
    public float SummonCoolTime { get; set; } = 600f;

    [JsonPropertyName("summonExplosionWait_")]
    public float SummonExplosionWait { get; set; } = 0.01f;

    [JsonPropertyName("summonSeedWait_")]
    public float SummonSeedWait { get; set; } = 0.5f;

    [JsonPropertyName("summonTimeDifference_")]
    public float SummonTimeDifference { get; set; } = 6f;

    [JsonPropertyName("summonSeedHpWeakened_")]
    public float SummonSeedHpWeakened { get; set; } = 0.35f;

    [JsonPropertyName("summonChargedSelfCheck")]
    public int SummonChargedSelfCheck { get; set; } = 0;

    [JsonPropertyName("summonDistStepCheck_")]
    public float SummonDistStepCheck { get; set; } = 15f;

    [JsonPropertyName("summonDefaultSpawnType_")]
    public int SummonDefaultSpawnType { get; set; } = 1;

    [JsonPropertyName("summonSpreadSpawnType_")]
    public int SummonSpreadSpawnType { get; set; } = 600;

    [JsonPropertyName("summonSpreadHpRate_")]
    public float SummonSpreadHpRate { get; set; } = 0.6f;

    [JsonPropertyName("summonSeedOffset_")]
    [Editable(false)]
    public BindingList<Vector2> SummonSeedOffset { get; set; } = [.. Enumerable.Repeat(new Vector2(), 4)]; // std::array<Hw::cVec2,6>

    [JsonPropertyName("summonSeedIndividualWait_")]
    [Editable(false)]
    public BindingList<float> SummonSeedIndividualWait { get; set; } = [.. Enumerable.Repeat(0, 8)]; // std::array<float,8>

    [JsonPropertyName("seedAttackCenterMoveCoefficient_")]
    public float SeedAttackCenterMoveCoefficient { get; set; } = 0.025f;

    [JsonPropertyName("seedAttackChargedSelfModeTime_")]
    public float SeedAttackChargedSelfModeTime { get; set; } = 25f;

    [JsonPropertyName("seedAttackChargedMinionModeTime_")]
    public float SeedAttackChargedMinionModeTime { get; set; } = 18f;

    [JsonPropertyName("seedChainRadius_")]
    public float SeedChainRadius { get; set; } = 0.25f;

    [JsonPropertyName("seedChainHeight_")]
    public float SeedChainHeight { get; set; } = 1f;

    [JsonPropertyName("seedChainAttackRate_")]
    public float SeedChainAttackRate { get; set; } = 1.1f;

    [JsonPropertyName("seedChainBreakRate_")]
    public float SeedChainBreakRate { get; set; } = 1f;

    [JsonPropertyName("seedRotationCenterSparkMaxRadius_")]
    public float SeedRotationCenterSparkMaxRadius { get; set; } = 0f;

    [JsonPropertyName("seedRotationCenterFallMaxRadius_")]
    public float SeedRotationCenterFallMaxRadius { get; set; } = 0f;

    [JsonPropertyName("seedRotationCenterMoveSpeed_")]
    public float SeedRotationCenterMoveSpeed { get; set; } = 0.01f;

    [JsonPropertyName("seedRotationCenterWaitTime_")]
    public float SeedRotationCenterWaitTime { get; set; } = 3f;

    [JsonPropertyName("seedAttackMaintainTime_")]
    public float SeedAttackMaintainTime { get; set; } = 10f;

    [JsonPropertyName("seedAttackExtensionTime_")]
    public float SeedAttackExtensionTime { get; set; } = 10f;

    [JsonPropertyName("seedAttackSparkRadiusTime_")]
    public float SeedAttackSparkRadiusTime { get; set; } = 2f;

    [JsonPropertyName("seedAttackSparkRadiusMaxVariation_")]
    public float SeedAttackSparkRadiusMaxVariation { get; set; } = 0f;

    [JsonPropertyName("seedAttackSparkRadiusWait_")]
    public float SeedAttackSparkRadiusWait { get; set; } = 3f;

    [JsonPropertyName("railgunBeamAttackRate_")]
    public float RailgunBeamAttackRate { get; set; } = 1f;

    [JsonPropertyName("railgunBeamBreakRate_")]
    public float RailgunBeamBreakRate { get; set; } = 2f;

    [JsonPropertyName("railgunBeamLength_")]
    public float RailgunBeamLength { get; set; } = 40f;

    [JsonPropertyName("railgunBeamRadius_")]
    public float RailgunBeamRadius { get; set; } = 3f;

    [JsonPropertyName("railgunHpRate_")]
    public float RailgunHpRate { get; set; } = 0.8f;

    [JsonPropertyName("ruinCoolTimeList_")]
    [Editable(false)]
    public BindingList<float> RuinCoolTimeList { get; set; } = [.. Enumerable.Repeat(0, 4)]; // std::array<float,4>

    [JsonPropertyName("ruinCoolTimeHpList_")]
    [Editable(false)]
    public BindingList<float> RuinCoolTimeHpList { get; set; } = [.. Enumerable.Repeat(0, 4)]; // std::array<float,4>

    [JsonPropertyName("ruinSeedCheck_")]
    public int RuinSeedCheck { get; set; } = 7;

    [JsonPropertyName("ruinSeedCheckTime_")]
    public float RuinSeedCheckTime { get; set; } = 15f;

    [JsonPropertyName("ruinDragonicSpellShortened_")]
    public float RuinDragonicSpellShortened { get; set; } = 20f;

    [JsonPropertyName("ruinSummonSeedExtension_")]
    public float RuinSummonSeedExtension { get; set; } = 10f;

    [JsonPropertyName("sacrificeActivationTime_")]
    public float SacrificeActivationTime { get; set; } = 1f;

    [JsonPropertyName("sacrificeCheckDistance_")]
    public float SacrificeCheckDistance { get; set; } = 5f;

    [JsonPropertyName("sacrificeWaveCastTime_")]
    public float SacrificeWaveCastTime { get; set; } = 10f;

    [JsonPropertyName("startCircleWaveTime_")]
    public float StartCircleWaveTime { get; set; } = 1.5f;

    [JsonPropertyName("sacrificeBreakRate_")]
    public float SacrificeBreakRate { get; set; } = 1f;

    [JsonPropertyName("triBeamMaxMoveSec_")]
    public float TriBeamMaxMoveSec { get; set; } = 2f;

    [JsonPropertyName("triBeamMinMoveSec_")]
    public float TriBeamMinMoveSec { get; set; } = 1f;

    [JsonPropertyName("triBeamHomingRate_")]
    public float TriBeamHomingRate { get; set; } = 0.025f;

    [JsonPropertyName("triBeamMaxMoveRate_")]
    public float TriBeamMaxMoveRate { get; set; } = 2f;

    [JsonPropertyName("triBeamMinMoveRate_")]
    public float TriBeamMinMoveRate { get; set; } = 1f;

    [JsonPropertyName("triBeamAddMoveRate_")]
    public float TriBeamAddMoveRate { get; set; } = 0.1f;

    [JsonPropertyName("triBeamHomingTouchDownRate_")]
    public float TriBeamHomingTouchDownRate { get; set; } = 0.1f;

    [JsonPropertyName("triBeamThreeProngedHpRate_")]
    public float TriBeamThreeProngedHpRate { get; set; } = 0.4f;

    [JsonPropertyName("triBeamThreeProngedRate_")]
    [Editable(false)]
    public BindingList<float> TriBeamThreeProngedRate { get; set; } = [.. Enumerable.Repeat(0, 3)]; // std::array<float,3>

    [JsonPropertyName("triBeamThreeProngedAng_")]
    [Editable(false)]
    public BindingList<float> TriBeamThreeProngedAng { get; set; } = [.. Enumerable.Repeat(0, 3)]; // std::array<float,3>

    [JsonPropertyName("triBeamSightSignTime_")]
    public float TriBeamSightSignTime { get; set; } = 2f;

    [JsonPropertyName("triBeamSightSignRectW_")]
    public float TriBeamSightSignRectW { get; set; } = 4f;

    [JsonPropertyName("triBeamSightSignRectH_")]
    public float TriBeamSightSignRectH { get; set; } = 50f;

    [JsonPropertyName("triBeamSeedAttackSightSignTime_")]
    public float TriBeamSeedAttackSightSignTime { get; set; } = 0.5f;

    [JsonPropertyName("triBeamSparkMoveAng_")]
    [Editable(false)]
    public BindingList<float> TriBeamSparkMoveAng { get; set; } = [.. Enumerable.Repeat(0, 6)]; // std::array<float,6>

    [JsonPropertyName("triBeamSparkMoveOffsetAng_")]
    [Editable(false)]
    public BindingList<float> TriBeamSparkMoveOffsetAng { get; set; } = [.. Enumerable.Repeat(0, 6)]; // std::array<float,6>

    [JsonPropertyName("triBeamSparkSignList_")]
    [Editable(false)]
    public BindingList<bool> TriBeamSparkSignList { get; set; } = [.. Enumerable.Repeat(false, 6)]; // std::array<bool,6>

    [JsonPropertyName("triBeamSparkWidthList_")]
    [Editable(false)]
    public BindingList<float> TriBeamSparkWidthList { get; set; } = [.. Enumerable.Repeat(0, 6)]; // std::array<float,6>

    [JsonPropertyName("seedAttackSparkRotationParams_")]
    public SeedAttackParam SeedAttackSparkRotationParams { get; set; }

    [JsonPropertyName("seedAttackFallRotationParams_")]
    public SeedAttackParam SeedAttackFallRotationParams { get; set; }

    [JsonPropertyName("seedAttackChainRotationParams_")]
    public SeedAttackParam SeedAttackChainRotationParams { get; set; }

    [JsonPropertyName("seedAttackTriChainParams_")]
    public SeedAttackParam SeedAttackTriChainParams { get; set; }

    [JsonPropertyName("seedAttackTriFallParams_")]
    public SeedAttackParam SeedAttackTriFallParams { get; set; }

    [JsonPropertyName("seedAttackTriSparkParams_")]
    public SeedAttackParam SeedAttackTriSparkParams { get; set; }

    [JsonPropertyName("seedAttackJudgmentThunderParams_")]
    public SeedAttackParam SeedAttackJudgmentThunderParams { get; set; }

    public Em1805Param()
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
        AnimRateODAILevel1 = new Vector2(1.05f, 1.1f);
        AnimRateODAILevel2 = new Vector2(1.05f, 1.1f);
        AnimRateODAILevel3 = new Vector2(1.05f, 1.1f);
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
    public class SeedAttackParam
    {
        [JsonPropertyName("seedActionType_")]
        public int SeedActionType { get; set; } // Offset 0x8

        [JsonPropertyName("seedPlacementType_")]
        public int SeedPlacementType { get; set; } // Offset 0xC

        [JsonPropertyName("moveSecondMaxAllSet_")]
        public bool MoveSecondMaxAllSet { get; set; } // Offset 0x10

        [JsonPropertyName("moveSecondMax_")]
        public float MoveSecondMax { get; set; } // Offset 0x14

        [JsonPropertyName("seedPlacementParam_")]
        public BindingList<SeedPlacementParam> SeedPlacementParam_ { get; set; } // Offset 0x18

        public SeedAttackParam()
        {
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class SeedPlacementParam
        {
            [JsonPropertyName("setMoveType_")]
            public int SetMoveType { get; set; } // Offset 0x8

            [JsonPropertyName("beginPos_")]
            public Vector3 BeginPos { get; set; } // Offset 0xC

            [JsonPropertyName("endPos_")]
            public Vector3 EndPos { get; set; } // Offset 0x18

            [JsonPropertyName("moveSecondMax_")]
            public float MoveSecondMax { get; set; } // Offset 0x24

            [JsonPropertyName("waitSecond_")]
            public float WaitSecond { get; set; } // Offset 0x28

            [JsonPropertyName("beginCalcRotation_")]
            public bool BeginCalcRotation { get; set; } // Offset 0x2C

            [JsonPropertyName("beginRotationRadius_")]
            public float BeginRotationRadius { get; set; } // Offset 0x30

            [JsonPropertyName("beginRotationAngle_")]
            public float BeginRotationAngle { get; set; } // Offset 0x34

            [JsonPropertyName("endCalcRotation_")]
            public bool EndCalcRotation { get; set; } // Offset 0x38

            [JsonPropertyName("endRotationRadius_")]
            public float EndRotationRadius { get; set; } // Offset 0x3C

            [JsonPropertyName("endRotationAngle_")]
            public float EndRotationAngle { get; set; } // Offset 0x40

            [JsonPropertyName("easeParam_")]
            public EaseParam EaseParam { get; set; } // Offset 0xCF543FFA

            public SeedPlacementParam()
            {
            }
        }
    }
}