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

public class Em1806Param : Em1800Param
{
    [JsonPropertyName("centerMoveWaitSec_")]
    public float CenterMoveWaitSec { get; set; } = 30f;

    [JsonPropertyName("centerPointOffset_")]
    public Vector4 CenterPointOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f);

    [JsonPropertyName("auraRebootSec_")]
    public float AuraRebootSec { get; set; } = 5f;

    [JsonPropertyName("auraBreakRebootSec_")]
    public float AuraBreakRebootSec { get; set; } = 13.3f;

    [JsonPropertyName("auraChainBurstRebootSec_")]
    public float AuraChainBurstRebootSec { get; set; } = 7.2f;

    [JsonPropertyName("auraLinkFinishRebootSec_")]
    public float AuraLinkFinishRebootSec { get; set; } = 2.2f;

    [JsonPropertyName("auraSpReactionRebootSec_")]
    public float AuraSpReactionRebootSec { get; set; } = 2.7f;

    [JsonPropertyName("auraDamageCutPer_")]
    public int AuraDamageCutPer { get; set; } = 50;

    [JsonPropertyName("auraBreakPowerCutPer_")]
    public int AuraBreakPowerCutPer { get; set; } = 75;

    [JsonPropertyName("auraAddDamageMotWeightRate_")]
    public float AuraAddDamageMotWeightRate { get; set; } = 0.5f;

    [JsonPropertyName("notWearAuraDamageRate_")]
    public float NotWearAuraDamageRate { get; set; } = 1f;

    [JsonPropertyName("firstAuraSec_")]
    public float FirstAuraSec { get; set; } = 13f;

    [JsonPropertyName("breathDebuffTime_")]
    public float BreathDebuffTime { get; set; } = 30f;

    [JsonPropertyName("breathDebuffValue_")]
    public float BreathDebuffValue { get; set; } = 50f;

    [JsonPropertyName("clowAndTailDebuffTime_")]
    public float ClowAndTailDebuffTime { get; set; } = 10f;

    [JsonPropertyName("attackDebuffShortTime_")]
    public float AttackDebuffShortTime { get; set; } = 30f;

    [JsonPropertyName("attackDebuffTime_")]
    public float AttackDebuffTime { get; set; } = 60f;

    [JsonPropertyName("attackDebuffValue_")]
    public float AttackDebuffValue { get; set; } = 20f;

    [JsonPropertyName("banAbilityTime_")]
    public Vector2 BanAbilityTime { get; set; } = new Vector2(30f, 8f);

    [JsonPropertyName("banSpArtsTime_")]
    public float BanSpArtsTime { get; set; } = 30f;

    [JsonPropertyName("mySlowDebuffTime_")]
    public float MySlowDebuffTime { get; set; } = 6f;

    [JsonPropertyName("mySlowDebuffMinTime_")]
    public float MySlowDebuffMinTime { get; set; } = 2f;

    [JsonPropertyName("mySlowDebuffResistanceTime_")]
    public float MySlowDebuffResistanceTime { get; set; } = 2f;

    [JsonPropertyName("bhcShotRotMax_")]
    public float BhcShotRotMax { get; set; } = 45f;

    [JsonPropertyName("bhcShotTargetOffsetDist_")]
    public Vector2 BhcShotTargetOffsetDist { get; set; } = new Vector2(15f, 15f);

    [JsonPropertyName("bhcShotMaxDist_")]
    public Vector2 BhcShotMaxDist { get; set; } = new Vector2(30f, 30f);

    [JsonPropertyName("bhcShotMinDist_")]
    public Vector2 BhcShotMinDist { get; set; } = new Vector2(8f, 5f);

    [JsonPropertyName("bhcInhaleInsideParam_")]
    public Vector2 BhcInhaleInsideParam { get; set; } = new Vector2(5f, 5f);

    [JsonPropertyName("bhcInhaleCenterParam_")]
    public Vector2 BhcInhaleCenterParam { get; set; } = new Vector2(12f, 12f);

    [JsonPropertyName("bhcInhaleOutsideParam_")]
    public Vector2 BhcInhaleOutsideParam { get; set; } = new Vector2(15f, 15f);

    [JsonPropertyName("bhcWaveAtkRate_")]
    public float BhcWaveAtkRate { get; set; } = 1.5f;

    [JsonPropertyName("bhcWaveBreakRate_")]
    public float BhcWaveBreakRate { get; set; } = 1.5f;

    [JsonPropertyName("bhcWaveRad_")]
    public float BhcWaveRad { get; set; } = 0.4f;

    [JsonPropertyName("bhcWaveHeight_")]
    public float BhcWaveHeight { get; set; } = 0.6f;

    [JsonPropertyName("bhcPowTimerRateNum_")]
    public int BhcPowTimerRateNum { get; set; } = -1;

    [JsonPropertyName("bhcPowCaleMoveRate_")]
    public float BhcPowCaleMoveRate { get; set; } = 0.03f;

    [JsonPropertyName("bhcWaveRange_")]
    public Vector2 BhcWaveRange { get; set; } = new Vector2(2f, 30f);

    [JsonPropertyName("bhcWaveTime_")]
    public Vector2 BhcWaveTime { get; set; } = new Vector2(1.5f, 2.8f);

    [JsonPropertyName("bhcWaveEffectId_")]
    public int BhcWaveEffectId { get; set; } = 2520;

    [JsonPropertyName("stepBhcCoolTimeCutRate_")]
    public float StepBhcCoolTimeCutRate { get; set; } = 0.3f;

    [JsonPropertyName("codWaveAtkRate_")]
    public float CodWaveAtkRate { get; set; } = 2f;

    [JsonPropertyName("codWaveBreakRate_")]
    public float CodWaveBreakRate { get; set; } = 2f;

    [JsonPropertyName("codWaveRad_")]
    public float CodWaveRad { get; set; } = 0.4f;

    [JsonPropertyName("codWaveHeight_")]
    public float CodWaveHeight { get; set; } = 0.6f;

    [JsonPropertyName("codWaveRange_")]
    public Vector2 CodWaveRange { get; set; } = new Vector2(3.5f, 30f);

    [JsonPropertyName("codWaveTime_")]
    public float CodWaveTime { get; set; } = 1.5f;

    [JsonPropertyName("codWaveEffectId_")]
    public int CodWaveEffectId { get; set; } = -1;

    [JsonPropertyName("frontBreathParam_")]
    public Em1806AuraBreathParam FrontBreathParam { get; set; }

    [JsonPropertyName("frontBreathShotSec_")]
    public float FrontBreathShotSec { get; set; } = 0f;

    [JsonPropertyName("frontBreathHomingRate_")]
    public float FrontBreathHomingRate { get; set; } = 1f;

    [JsonPropertyName("frontBreathHomingAngle_")]
    public float FrontBreathHomingAngle { get; set; } = 2f;

    [JsonPropertyName("frontBreathStepHomingRate_")]
    public float FrontBreathStepHomingRate { get; set; } = 1f;

    [JsonPropertyName("frontBreathStepHomingAngle_")]
    public float FrontBreathStepHomingAngle { get; set; } = 5f;

    [JsonPropertyName("frontBreathHugeParam_")]
    public Em1806AuraBreathParam FrontBreathHugeParam { get; set; }

    [JsonPropertyName("frontBreathHugeShotSec_")]
    public float FrontBreathHugeShotSec { get; set; } = 0.5f;

    [JsonPropertyName("swingBreathParam_")]
    public Em1806AuraBreathParam SwingBreathParam { get; set; }

    [JsonPropertyName("swingBreathHomingParam_")]
    public Vector2 SwingBreathHomingParam { get; set; } = new Vector2(1f, 2f);

    [JsonPropertyName("swingBreathSecondHomingParam_")]
    public Vector2 SwingBreathSecondHomingParam { get; set; } = new Vector2(1f, 2f);

    [JsonPropertyName("rollBreathParam_")]
    public Em1806AuraBreathParam RollBreathParam { get; set; }

    [JsonPropertyName("rollAuraBreathUseHpPercent_")]
    public int RollAuraBreathUseHpPercent { get; set; } = 20;

    [JsonPropertyName("rollBreathBombAtkRate_")]
    public float RollBreathBombAtkRate { get; set; } = 10f;

    [JsonPropertyName("rollBreathBombBreakRate_")]
    public float RollBreathBombBreakRate { get; set; } = 10f;

    [JsonPropertyName("rollBreathBombPosOffset_")]
    public Vector4 RollBreathBombPosOffset { get; set; } = new Vector4(2f, 0f, -1f, 1f);

    [JsonPropertyName("rollBreathBombRad_")]
    public float RollBreathBombRad { get; set; } = 60f;

    [JsonPropertyName("rollBreathBombAttackSec_")]
    public float RollBreathBombAttackSec { get; set; } = 2f;

    [JsonPropertyName("rollBreathBombMultiHitSec_")]
    public float RollBreathBombMultiHitSec { get; set; } = 2f;

    [JsonPropertyName("dpsCheckHpRate_")]
    public float DpsCheckHpRate { get; set; } = 0.3f;

    [JsonPropertyName("breathChargeSec_")]
    public float BreathChargeSec { get; set; } = 30f;

    [JsonPropertyName("dpsCheckEndWaitSec_")]
    public float DpsCheckEndWaitSec { get; set; } = 2f;

    [JsonPropertyName("breathOmenSecondVerSec_")]
    public float BreathOmenSecondVerSec { get; set; } = 10f;

    [JsonPropertyName("breathOmenThirdVerSec_")]
    public float BreathOmenThirdVerSec { get; set; } = 3f;

    [JsonPropertyName("downLoopSec_")]
    public float DownLoopSec { get; set; } = 4f;

    [JsonPropertyName("chargeEffectChangeRate_")]
    public float ChargeEffectChangeRate { get; set; } = 0.25f;

    [JsonPropertyName("dpsCheckAddDamageMotWeightRate_")]
    public float DpsCheckAddDamageMotWeightRate { get; set; } = 1f;

    [JsonPropertyName("dpsAddDmgMotSecLength_")]
    public float DpsAddDmgMotSecLength { get; set; } = 5f;

    [JsonPropertyName("dpsCheckDeadPresageSec_")]
    public float DpsCheckDeadPresageSec { get; set; } = 0.3f;

    [JsonPropertyName("crownWaveOdPhase1Params_")]
    public BindingList<CrownWaveParam> CrownWaveOdPhase1Params { get; set; } = []; // std::vector<Em1806Param::CrownWaveParam>

    [JsonPropertyName("crownWaveOdPhase2Params_")]
    public BindingList<CrownWaveParam> CrownWaveOdPhase2Params { get; set; } = []; // std::vector<Em1806Param::CrownWaveParam>

    [JsonPropertyName("waitMagicCircleicSec_")]
    public float WaitMagicCircleicSec { get; set; } = 0.5f;

    [JsonPropertyName("odMagicStartEstId_")]
    public int OdMagicStartEstId { get; set; } = 5150;

    [JsonPropertyName("odMagicVanishEstId_")]
    public int OdMagicVanishEstId { get; set; } = 5151;

    [JsonPropertyName("crownWaveMultiHitSec_")]
    public float CrownWaveMultiHitSec { get; set; } = 5f;

    [JsonPropertyName("hugeBhcMoveSpeed_")]
    public float HugeBhcMoveSpeed { get; set; } = 0.7f;

    [JsonPropertyName("hugeBhcAttackRate_")]
    public float HugeBhcAttackRate { get; set; } = 2f;

    [JsonPropertyName("hugeBhcBreakRate_")]
    public float HugeBhcBreakRate { get; set; } = 2f;

    [JsonPropertyName("hugeBhcAttackRadius_")]
    public float HugeBhcAttackRadius { get; set; } = 5f;

    [JsonPropertyName("hugeBhcMinScale_")]
    public float HugeBhcMinScale { get; set; } = 0.5f;

    [JsonPropertyName("hugeBhcMaxScale_")]
    public float HugeBhcMaxScale { get; set; } = 1.2f;

    [JsonPropertyName("hugeBhcScaleShrinkSec_")]
    public float HugeBhcScaleShrinkSec { get; set; } = 1.5f;

    [JsonPropertyName("hugeBhcScaleExpansionSec_")]
    public float HugeBhcScaleExpansionSec { get; set; } = 0.5f;

    [JsonPropertyName("hugeBhcScaleBackBaseSec_")]
    public float HugeBhcScaleBackBaseSec { get; set; } = 1f;

    [JsonPropertyName("hugeBhcMultiHitSec_")]
    public float HugeBhcMultiHitSec { get; set; } = 2f;

    [JsonPropertyName("inhaleInsideParam_")]
    public Vector2 InhaleInsideParam { get; set; } = new Vector2(12f, 8f);

    [JsonPropertyName("inhaleCenterParam_")]
    public Vector2 InhaleCenterParam { get; set; } = new Vector2(32f, 18f);

    [JsonPropertyName("inhaleOutsideParam_")]
    public Vector2 InhaleOutsideParam { get; set; } = new Vector2(100f, 36f);

    [JsonPropertyName("inhaleInsideFinishParam_")]
    public Vector2 InhaleInsideFinishParam { get; set; } = new Vector2(10f, 8f);

    [JsonPropertyName("inhaleCenterFinishParam_")]
    public Vector2 InhaleCenterFinishParam { get; set; } = new Vector2(32f, 12f);

    [JsonPropertyName("inhaleOutsideFinishParam_")]
    public Vector2 InhaleOutsideFinishParam { get; set; } = new Vector2(100f, 36f);

    [JsonPropertyName("inhaleWaitSec_")]
    public float InhaleWaitSec { get; set; } = 1f;

    [JsonPropertyName("inhaleEndSec_")]
    public float InhaleEndSec { get; set; } = 0f;

    [JsonPropertyName("crownWaveWaitSec_")]
    public float CrownWaveWaitSec { get; set; } = 1.5f;

    [JsonPropertyName("inhaleWaitSubSec_")]
    public float InhaleWaitSubSec { get; set; } = 0f;

    [JsonPropertyName("crownWaveWaitSubSec_")]
    public float CrownWaveWaitSubSec { get; set; } = 0f;

    [JsonPropertyName("crownWaveLastWaitSec_")]
    public float CrownWaveLastWaitSec { get; set; } = 2f;

    [JsonPropertyName("finishOmenRadius_")]
    public float FinishOmenRadius { get; set; } = 13f;

    [JsonPropertyName("finishOmenDispSec_")]
    public float FinishOmenDispSec { get; set; } = 3.5f;

    [JsonPropertyName("seedSummonNum_")]
    public int SeedSummonNum { get; set; } = 4;

    [JsonPropertyName("seedKillNum_")]
    public int SeedKillNum { get; set; } = 6;

    [JsonPropertyName("seedSetType_")]
    public int SeedSetType { get; set; } = 1;

    [JsonPropertyName("isDeadPlayerSummonTarget_")]
    public bool IsDeadPlayerSummonTarget { get; set; } = true;

    [JsonPropertyName("summonDelayFrame_")]
    public int SummonDelayFrame { get; set; } = 6;

    [JsonPropertyName("isFirstSummonBombSeed_")]
    public bool IsFirstSummonBombSeed { get; set; } = false;

    [JsonPropertyName("oneFrameOneSeed_")]
    public bool OneFrameOneSeed { get; set; } = true;

    [JsonPropertyName("isCancelSpArtsSummon_")]
    public bool IsCancelSpArtsSummon { get; set; } = false;

    [JsonPropertyName("spawnArea1_")]
    public SeedSpawnParam SpawnArea1 { get; set; }

    [JsonPropertyName("spawnArea2_")]
    public SeedSpawnParam SpawnArea2 { get; set; }

    [JsonPropertyName("spawnArea3_")]
    public SeedSpawnParam SpawnArea3 { get; set; }

    [JsonPropertyName("spawnArea4_")]
    public SeedSpawnParam SpawnArea4 { get; set; }

    [JsonPropertyName("spawnArea5_")]
    public SeedSpawnParam SpawnArea5 { get; set; }

    [JsonPropertyName("spawnArea6_")]
    public SeedSpawnParam SpawnArea6 { get; set; }

    [JsonPropertyName("atkParam_chaseMagicCircle_")]
    public BossAttackParam AtkParam_chaseMagicCircle { get; set; }

    [JsonPropertyName("atkParam_chaseMagicCircleODWeapon_")]
    public BossAttackParam AtkParam_chaseMagicCircleODWeapon { get; set; }

    [JsonPropertyName("chaseMagicCircleAddSlowDebuff_")]
    public bool ChaseMagicCircleAddSlowDebuff { get; set; } = true;

    [JsonPropertyName("chaseMagicCircleOdAddSlowDebuff_")]
    public bool ChaseMagicCircleOdAddSlowDebuff { get; set; } = true;

    [JsonPropertyName("chaseMagicCircleSlowTime_")]
    public Vector2 ChaseMagicCircleSlowTime { get; set; } = new Vector2(3f, 3f);

    [JsonPropertyName("chaseMagicCircleSlowRate_")]
    public Vector2 ChaseMagicCircleSlowRate { get; set; } = new Vector2(0.5f, 0.5f);

    [JsonPropertyName("bombSeedCrownWaveParam_")]
    public CrownWaveParam BombSeedCrownWaveParam { get; set; }

    [JsonPropertyName("bombSeedInnerCrownWaveParam_")]
    public CrownWaveParam BombSeedInnerCrownWaveParam { get; set; }

    [JsonPropertyName("bombSeedSlowCrownWaveParam_")]
    public CrownWaveParam BombSeedSlowCrownWaveParam { get; set; }

    [JsonPropertyName("flyingBreathParam_")]
    public EmHitBreathParam FlyingBreathParam { get; set; }

    [JsonPropertyName("attackParam_flyingBreath_")]
    public BossAttackParam AttackParam_flyingBreath { get; set; }

    [JsonPropertyName("flyingBreathMaxMoveSec_")]
    public float FlyingBreathMaxMoveSec { get; set; } = 2f;

    [JsonPropertyName("flyingBreathMinMoveSec_")]
    public float FlyingBreathMinMoveSec { get; set; } = 1f;

    [JsonPropertyName("flyingBreathHomingRate_")]
    public float FlyingBreathHomingRate { get; set; } = 0.025f;

    [JsonPropertyName("flyingBreathMaxMoveRate_")]
    public float FlyingBreathMaxMoveRate { get; set; } = 2f;

    [JsonPropertyName("flyingBreathMinMoveRate_")]
    public float FlyingBreathMinMoveRate { get; set; } = 1f;

    [JsonPropertyName("flyingBreathAddMoveRate_")]
    public float FlyingBreathAddMoveRate { get; set; } = 0.1f;

    [JsonPropertyName("firstUseSwingAuraBreath_")]
    public bool FirstUseSwingAuraBreath { get; set; } = false;

    [JsonPropertyName("firstUseClawActionType_")]
    public int FirstUseClawActionType { get; set; } = 0;

    [JsonPropertyName("firstUseCycleActionType_")]
    public int FirstUseCycleActionType { get; set; } = 0;

    [JsonPropertyName("coolTimeSummon_")]
    public float CoolTimeSummon { get; set; } = 20f;

    [JsonPropertyName("coolTimeStepBhc_")]
    public float CoolTimeStepBhc { get; set; } = 20f;

    [JsonPropertyName("coolTimeCallOfDarkness_")]
    public float CoolTimeCallOfDarkness { get; set; } = 20f;

    [JsonPropertyName("coolTimeRollAuraBreath_")]
    public float CoolTimeRollAuraBreath { get; set; } = 30f;

    [JsonPropertyName("coolTimeClaw_")]
    public float CoolTimeClaw { get; set; } = 5f;

    [JsonPropertyName("coolTimeTackle_")]
    public float CoolTimeTackle { get; set; } = 5f;

    [JsonPropertyName("coolTimeBreath_")]
    public float CoolTimeBreath { get; set; } = 4f;

    [JsonPropertyName("coolTimeAuraBreath_")]
    public float CoolTimeAuraBreath { get; set; } = 15f;

    [JsonPropertyName("coolTimeBhc_")]
    public float CoolTimeBhc { get; set; } = 10f;

    [JsonPropertyName("coolTimeFrontAction_")]
    public float CoolTimeFrontAction { get; set; } = 5f;

    public Em1806Param()
    {
        Hp = 400000;
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
        IsDeleteMagicCircleEvent = false;
        AnimRateODAILevel1 = new Vector2(1.05f, 1.1f);
        AnimRateODAILevel2 = new Vector2(1.05f, 1.1f);
        AnimRateODAILevel3 = new Vector2(1.05f, 1.1f);
        AnimRateODAILevel4 = new Vector2(1.05f, 1.1f);
        OverDriveHpRateAILv1_2 = new Vector4(0.15f, 0.25f, 0.1f, 1f);
        ForceOverDriveHpRate = 25;
        MeteorHpTriggerFirst = 70;
        MeteorHpTriggerSecond = 30;
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
        FireBallDistance = 0f;
        FireBallTargetOffsetY = 0f;
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
        BreathRetreatSpeed = 0f;
        BreakPartsValue = 1500f;
        ByTheWallDistance = 20f;
        ByTheWallStepMag = 1f;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SeedSpawnParam
    {
        [JsonPropertyName("seedSpawnBaseOffset_")]
        public Vector4 SeedSpawnBaseOffset { get; set; } // Offset 0x10

        [JsonPropertyName("seedSpawnTargetCheckDist_")]
        public float SeedSpawnTargetCheckDist { get; set; } // Offset 0x20

        public SeedSpawnParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CrownWaveParam
    {
        [JsonPropertyName("waveAttackRate_")]
        public float WaveAttackRate { get; set; }

        [JsonPropertyName("waveBreakRate_")]
        public float WaveBreakRate { get; set; }

        [JsonPropertyName("convexAttackRate_")]
        public float ConvexAttackRate { get; set; }

        [JsonPropertyName("convexBreakRate_")]
        public float ConvexBreakRate { get; set; }

        [JsonPropertyName("waveEstId_")]
        public int WaveEstId { get; set; }

        [JsonPropertyName("convexEstId_")]
        public int ConvexEstId { get; set; }

        [JsonPropertyName("convexEffectHeightOffset_")]
        public float ConvexEffectHeightOffset { get; set; }

        [JsonPropertyName("convexSeDefName_")]
        public string ConvexSeDefName { get; set; }

        [JsonPropertyName("waveSeDefName_")]
        public string WaveSeDefName { get; set; }

        [JsonPropertyName("convexHeight_")]
        public float ConvexHeight { get; set; }

        [JsonPropertyName("convexRadius_")]
        public float ConvexRadius { get; set; }

        [JsonPropertyName("convexHeightOffset_")]
        public float ConvexHeightOffset { get; set; }

        [JsonPropertyName("waveHeight_")]
        public float WaveHeight { get; set; }

        [JsonPropertyName("waveRadius_")]
        public float WaveRadius { get; set; }

        [JsonPropertyName("startRadius_")]
        public float StartRadius { get; set; }

        [JsonPropertyName("endRadius_")]
        public float EndRadius { get; set; }

        [JsonPropertyName("time_")]
        public float Time { get; set; }

        [JsonPropertyName("baseRotOffsetY_")]
        public float BaseRotOffsetY { get; set; }

        [JsonPropertyName("powTimerRateNum_")]
        public int PowTimerRateNum { get; set; }

        [JsonPropertyName("convexParam_")]
        public BindingList<ConvexParam> ConvexParam_ { get; set; } = []; // std::vector<Em1806Param::CrownWaveParam::ConvexParam>

        public CrownWaveParam()
        {
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class ConvexParam
        {
            [JsonPropertyName("startAngle_")]
            public float StartAngle { get; set; }

            [JsonPropertyName("rollSpdStart_")]
            public float RollSpdStart { get; set; }

            [JsonPropertyName("rollSpdEnd_")]
            public float RollSpdEnd { get; set; }

            [JsonPropertyName("changeSpdTime_")]
            public float ChangeSpdTime { get; set; }

            public ConvexParam()
            {
            }
        }
    }
}
