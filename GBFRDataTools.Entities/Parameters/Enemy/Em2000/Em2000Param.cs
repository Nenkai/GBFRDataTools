using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using static GBFRDataTools.Entities.Parameters.Enemy.Em2100.Em2100Param;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em2000;

public class Em2000Param : EmBossBaseParam
{
    [JsonPropertyName("specialArtsTriggerHpRate1st_")]
    public int SpecialArtsTriggerHpRate1st { get; set; } = 60;

    [JsonPropertyName("specialArtsTriggerHpRate2nd_")]
    public int SpecialArtsTriggerHpRate2nd { get; set; } = 20;

    [JsonPropertyName("specialArtsDerivedExplodeScale_")]
    public float SpecialArtsDerivedExplodeScale { get; set; } = 1.5f;

    [JsonPropertyName("specialArtsCameraStartRotMax_")]
    public float SpecialArtsCameraStartRotMax { get; set; } = 6.283185f;

    [JsonPropertyName("specialArtsCameraStartMoveRate_")]
    public float SpecialArtsCameraStartMoveRate { get; set; } = 0.3f;

    [JsonPropertyName("specialArtsCameraStartMoveRotMax_")]
    public float SpecialArtsCameraStartMoveRotMax { get; set; } = 0.5235988f;

    [JsonPropertyName("phaseParam_")]
    [Editable(false)]
    public BindingList<PhaseParam> PhaseParam_ { get; set; } = [.. Enumerable.Repeat(new PhaseParam(), 2)];  // std::array<Em2000Param::PhaseParam,2>

    [JsonPropertyName("popOutMaxHeightEm")]
    public float PopOutMaxHeightEm { get; set; } = 12f;

    [JsonPropertyName("popOutDistXZEm")]
    public float PopOutDistXZEm { get; set; } = 8f;

    [JsonPropertyName("popOutRollingRateEm")]
    public float PopOutRollingRateEm { get; set; } = 3f;

    [JsonPropertyName("popOutMaxHeightPl")]
    public float PopOutMaxHeightPl { get; set; } = 4f;

    [JsonPropertyName("popOutDistXZPl")]
    public float PopOutDistXZPl { get; set; } = 15f;

    [JsonPropertyName("popOutRollingRatePl")]
    public float PopOutRollingRatePl { get; set; } = 2f;

    [JsonPropertyName("tacklePickUpWaitMinSec_")]
    public float TacklePickUpWaitMinSec { get; set; } = 1f;

    [JsonPropertyName("tacklePickUpWaitMaxSec_")]
    public float TacklePickUpWaitMaxSec { get; set; } = 3f;

    [JsonPropertyName("tacklePickUpWaitMinDist_")]
    public float TacklePickUpWaitMinDist { get; set; } = 4f;

    [JsonPropertyName("tacklePickUpWaitMaxDist_")]
    public float TacklePickUpWaitMaxDist { get; set; } = 10f;

    [JsonPropertyName("stompQuakeCoolSec_")]
    public float StompQuakeCoolSec { get; set; } = 20f;

    [JsonPropertyName("stompQuakeAttackWaitSec_")]
    public float StompQuakeAttackWaitSec { get; set; } = 1.5f;

    [JsonPropertyName("stompQuakeAttackMeleeWaitSec_")]
    public float StompQuakeAttackMeleeWaitSec { get; set; } = 1.5f;

    [JsonPropertyName("stompQuakeBranchParams_")]
    public BindingList<StompQuakeBranchParam> StompQuakeBranchParams { get; set; } = []; // std::vector<Em2000Param::StompQuakeBranchParam>

    [JsonPropertyName("stompQuakeBranchMeleeParams_")]
    public BindingList<StompQuakeBranchParam> StompQuakeBranchMeleeParams { get; set; }

    [JsonPropertyName("tackleMoveLength_")]
    public float TackleMoveLength { get; set; } = 15f;

    [JsonPropertyName("stepMovementRate_")]
    public float StepMovementRate { get; set; } = 2f;

    [JsonPropertyName("stepMovementRateOD_")]
    public float StepMovementRateOD { get; set; } = 2.5f;

    [JsonPropertyName("forceComboFinishCoolSec_")]
    public float ForceComboFinishCoolSec { get; set; } = 30f;

    [JsonPropertyName("odAttackPowerRate_")]
    public float OdAttackPowerRate { get; set; } = 1f;

    [JsonPropertyName("additionalExplodeDelaySec_")]
    public float AdditionalExplodeDelaySec { get; set; } = 1.5f;

    [JsonPropertyName("swingDownAttackRate_")]
    public float SwingDownAttackRate { get; set; } = 2.5f;

    [JsonPropertyName("throwSpearPlAttackPower_")]
    public float ThrowSpearPlAttackPower { get; set; } = 25f;

    [JsonPropertyName("throwSpearBelowSpearLandingAttackRate_")]
    public float ThrowSpearBelowSpearLandingAttackRate { get; set; } = 1.2f;

    [JsonPropertyName("throwSpearBelowCenterExplodeAttackRate_")]
    public float ThrowSpearBelowCenterExplodeAttackRate { get; set; } = 3f;

    [JsonPropertyName("throwSpearBelowCrackExplodeAttackRate_")]
    public float ThrowSpearBelowCrackExplodeAttackRate { get; set; } = 2.5f;

    [JsonPropertyName("throwSpearTargetSpearLandingAttackRate_")]
    public float ThrowSpearTargetSpearLandingAttackRate { get; set; } = 2f;

    [JsonPropertyName("counterCenterExplodeAttackRate_")]
    public float CounterCenterExplodeAttackRate { get; set; } = 3f;

    [JsonPropertyName("counterCrackExplodeAttackRate_")]
    public float CounterCrackExplodeAttackRate { get; set; } = 2.5f;

    [JsonPropertyName("odAbilityEarthWaveAttackRate_")]
    public float OdAbilityEarthWaveAttackRate { get; set; } = 2f;

    [JsonPropertyName("odAbilitySlashWaveAttackRate_")]
    public float OdAbilitySlashWaveAttackRate { get; set; } = 2f;

    [JsonPropertyName("spArtsSpearLandingAttackRate_")]
    public float SpArtsSpearLandingAttackRate { get; set; } = 1.2f;

    [JsonPropertyName("spArtsCenterExplodeAttackRate_")]
    public float SpArtsCenterExplodeAttackRate { get; set; } = 6.5f;

    [JsonPropertyName("spArtsCrackExplodeAttackRate_")]
    public float SpArtsCrackExplodeAttackRate { get; set; } = 5f;

    [JsonPropertyName("counterCenterExplodeBreakRate_")]
    public float CounterCenterExplodeBreakRate { get; set; } = 3f;

    [JsonPropertyName("counterCrackExplodeBreakRate_")]
    public float CounterCrackExplodeBreakRate { get; set; } = 2.5f;

    [JsonPropertyName("stompQuakeBreakRate_")]
    public float StompQuakeBreakRate { get; set; } = 1f;

    [JsonPropertyName("eyeCtrlParam_")]
    public EyeControlParam EyeCtrlParam { get; set; }

    [JsonPropertyName("hpRate6stNormal_")]
    public float HpRate6stNormal { get; set; } = 0.2f;

    [JsonPropertyName("hpRate6stOverDrive_")]
    public float HpRate6stOverDrive { get; set; } = 0.2f;

    [JsonPropertyName("hpRate6stBreak_")]
    public float HpRate6stBreak { get; set; } = 0.03f;

    [JsonPropertyName("combatPower6st_")]
    public int CombatPower6st { get; set; } = 50;

    [JsonPropertyName("hateLessCombatPower_")]
    public float HateLessCombatPower { get; set; } = 50f;

    [JsonPropertyName("hatePinch_")]
    public float HatePinch { get; set; } = 1000f;

    [JsonPropertyName("spArtsHpRate6st_")]
    public int SpArtsHpRate6st { get; set; } = 50;

    [JsonPropertyName("hpRate6stMemberDie_")]
    public float HpRate6stMemberDie { get; set; } = 0.8f;

    [JsonPropertyName("specialAttackCoolSec6st_")]
    public float SpecialAttackCoolSec6st { get; set; } = 10f;

    [JsonPropertyName("emLinkAttackEffectWaitSecLaunch_")]
    public float EmLinkAttackEffectWaitSecLaunch { get; set; } = 0.5f;

    [JsonPropertyName("emLinkAttackEffectWaitSecFinish_")]
    public float EmLinkAttackEffectWaitSecFinish { get; set; } = 0.2f;

    [JsonPropertyName("emLinkAttackFinishHitEffectPartsNo_")]
    public int EmLinkAttackFinishHitEffectPartsNo { get; set; } = 3;

    [JsonPropertyName("emLinkAttackFinishHitEffectOffset_")]
    public Vector4 EmLinkAttackFinishHitEffectOffset { get; set; } = new Vector4(0f, -1.4f, -2f, 1f);

    [JsonPropertyName("spArtsCombinationHpRates_")]
    public BindingList<float> SpArtsCombinationHpRates { get; set; } = []; // std::vector<float>

    [JsonPropertyName("spArtsCombinationTextId_")]
    public string SpArtsCombinationTextId { get; set; } // cyan::inplace_string<32>

    [JsonPropertyName("spArtsCombinationStartOfsY_")]
    public float SpArtsCombinationStartOfsY { get; set; } = 10f;

    [JsonPropertyName("spArtsCombinationStartOfsZ_")]
    public float SpArtsCombinationStartOfsZ { get; set; } = -1.5f;

    [JsonPropertyName("spArtsCombinationStartRotOfsY_")]
    public float SpArtsCombinationStartRotOfsY { get; set; } = 3.141593f;

    [JsonPropertyName("spArtsCombinationShotIntervalSec_")]
    public float SpArtsCombinationShotIntervalSec { get; set; } = 0.75f;

    [JsonPropertyName("spArtsCombinationSlashDanceSec_")]
    public float SpArtsCombinationSlashDanceSec { get; set; } = 11f;

    [JsonPropertyName("spArtsCombinationBeginThrowRate_")]
    public float SpArtsCombinationBeginThrowRate { get; set; } = 0.3f;

    [JsonPropertyName("spArtsCombinationThrowTargetOfsX_")]
    public float SpArtsCombinationThrowTargetOfsX { get; set; } = 0.16f;

    [JsonPropertyName("spArtsCombinationThrowTargetOfsZ_")]
    public float SpArtsCombinationThrowTargetOfsZ { get; set; } = 0f;

    [JsonPropertyName("spArtsCombinationWearSwordsWatchWaitSec_")]
    public float SpArtsCombinationWearSwordsWatchWaitSec { get; set; } = 2.5f;

    [JsonPropertyName("spArtsCombinationWearSwordsWatchSec_")]
    public float SpArtsCombinationWearSwordsWatchSec { get; set; } = 4f;

    [JsonPropertyName("spArtsCombinationSpearLandingSec_")]
    public float SpArtsCombinationSpearLandingSec { get; set; } = 4f;

    public Em2000Param()
    {
        Hp = 330000;
        Atk = 400;
        Break = 10;
        Def = 0f;
        Endurance = 10;
        Exp = 20;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 0;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 15;
        HateRateFarPlayerPerSec = 25;
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
        CloseHateIncRate = 0.06f;
        CloseHateDecRate = 0.1f;
        FarHateIncRate = 0.03f;
        FarHateDecRate = 0.05f;
        CombatPower = 70;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 1000f;
        Search2battleLength = 10f;
        EnemySize = 1;
        LinkAttackCameraDistRate = 0.25f;
        AnimInterDefaultSec = 0.2f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 0.6f;
        BasicHitStopTimeRate = 0.2f;
        DamageReactionHitStopTimeRate = 1f;
        SuperArmorHitStopTimeRate = 1f;
        AttackerHitStopTimeRate = 1f;
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
        CameraLength = 1.5f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = true;
        BossStunOffsetY = 0f;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class StompQuakeBranchParam
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

        public StompQuakeBranchParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PhaseParam
    {
        [JsonPropertyName("attackPowerRate_")]
        public float AttackPowerRate { get; set; }

        [JsonPropertyName("abilityCoolTimeSec_")]
        public float AbilityCoolTimeSec { get; set; }

        [JsonPropertyName("followMissCount_")]
        public int FollowMissCount { get; set; }

        [JsonPropertyName("attackCountToStrongAttack_")]
        public int AttackCountToStrongAttack { get; set; }

        [JsonPropertyName("odAbilityCoolTimeSec_")]
        public float OdAbilityCoolTimeSec { get; set; }

        [JsonPropertyName("odAbilityLoopMaxCount_")]
        public int OdAbilityLoopMaxCount { get; set; }

        [JsonPropertyName("odAbilityCoolTimeSecOD_")]
        public float OdAbilityCoolTimeSecOD { get; set; }

        [JsonPropertyName("odAbilityLoopMaxCountOD_")]
        public int OdAbilityLoopMaxCountOD { get; set; }

        [JsonPropertyName("aiLevelParams_")]
        public BindingList<AiLevelParam> AiLevelParams { get; set; } = [];

        public PhaseParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AiLevelParam
    {
        [JsonPropertyName("throwSpearSpeed_")]
        public float ThrowSpearSpeed { get; set; }

        [JsonPropertyName("throwSpearBackProbability_")]
        public int ThrowSpearBackProbability { get; set; }

        [JsonPropertyName("throwSpearCoolTimeSec_")]
        public float ThrowSpearCoolTimeSec { get; set; }

        [JsonPropertyName("stepCoolTimeSec_")]
        public float StepCoolTimeSec { get; set; }

        [JsonPropertyName("spearBreakSec_")]
        public float SpearBreakSec { get; set; }

        [JsonPropertyName("tackleMoveSpeed_")]
        public float TackleMoveSpeed { get; set; }

        [JsonPropertyName("jumpCounterGravityRate_")]
        public float JumpCounterGravityRate { get; set; }

        [JsonPropertyName("jumpCounterFallSpeed_")]
        public float JumpCounterFallSpeed { get; set; }

        [JsonPropertyName("shotActionCountMax_")]
        public int ShotActionCountMax { get; set; }

        [JsonPropertyName("spearAbilitySwitchCount_")]
        public int SpearAbilitySwitchCount { get; set; }

        [JsonPropertyName("spearAbilityMoveSpeed_")]
        public float SpearAbilityMoveSpeed { get; set; }

        [JsonPropertyName("spearAbilityMoveSpeedOD_")]
        public float SpearAbilityMoveSpeedOD { get; set; }

        [JsonPropertyName("spearAbilitySwitchMotionSpeed_")]
        public float SpearAbilitySwitchMotionSpeed { get; set; }

        [JsonPropertyName("spearAbilitySwitchMotionSpeedOD_")]
        public float SpearAbilitySwitchMotionSpeedOD { get; set; }

        [JsonPropertyName("earthWaveMoveSec_")]
        public float EarthWaveMoveSec { get; set; }

        [JsonPropertyName("slashWaveMoveSec_")]
        public float SlashWaveMoveSec { get; set; }

        [JsonPropertyName("slashWaveOneceShotNum_")]
        public int SlashWaveOneceShotNum { get; set; }

        [JsonPropertyName("earthWaveOneceShotNum_")]
        public int EarthWaveOneceShotNum { get; set; }

        [JsonPropertyName("isOdAbilitySwingDown_")]
        public bool IsOdAbilitySwingDown { get; set; }

        [JsonPropertyName("spArtsCombinationSlashSpeed_")]
        public float SpArtsCombinationSlashSpeed { get; set; }

        public AiLevelParam()
        {
        }
    }
}

