using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Parameters.Enemy.Em2100;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em2200;

public class Em2200Param : EmBossBaseParam
{
    [JsonPropertyName("aiLevelParams_")]
    public Em2200AILevelParam[] AiLevelParams { get; set; } = new Em2200AILevelParam[5]; // std::array<Em2200AILevelParam,5>

    [JsonPropertyName("guardEnableAngle_")]
    public float GuardEnableAngle { get; set; } = 120f;

    [JsonPropertyName("guardDamageRate_")]
    public float GuardDamageRate { get; set; } = 0.1f;

    [JsonPropertyName("guardKnockBackRate_")]
    public float GuardKnockBackRate { get; set; } = 0.2f;

    [JsonPropertyName("damageTime_")]
    public float DamageTime { get; set; } = 3f;

    [JsonPropertyName("moveFowardOffset_")]
    public float MoveFowardOffset { get; set; } = 10f;

    [JsonPropertyName("turnSpeedGuard_")]
    public float TurnSpeedGuard { get; set; } = 360f;

    [JsonPropertyName("turnSpeedAttack_")]
    public float TurnSpeedAttack { get; set; } = 360f;

    [JsonPropertyName("guardMinTime_")]
    public float GuardMinTime { get; set; } = 3f;

    [JsonPropertyName("guardMaxTime_")]
    public float GuardMaxTime { get; set; } = 3f;

    [JsonPropertyName("cqcAttackLongRangeRate_")]
    public int CqcAttackLongRangeRate { get; set; } = 50;

    [JsonPropertyName("cqcAttackMiddleDistance_")]
    public float CqcAttackMiddleDistance { get; set; } = 5f;

    [JsonPropertyName("cqcAttackLongDistance_")]
    public float CqcAttackLongDistance { get; set; } = 20f;

    [JsonPropertyName("cqcAttackLongRangeSpeedMin_")]
    public float CqcAttackLongRangeSpeedMin { get; set; } = 1f;

    [JsonPropertyName("cqcAttackLongRangeSpeedMax_")]
    public float CqcAttackLongRangeSpeedMax { get; set; } = 3f;

    [JsonPropertyName("cqcAttackLongRangeHoming_")]
    public float CqcAttackLongRangeHoming { get; set; } = 0.8f;

    [JsonPropertyName("cqcAttackLongRangeDegree_")]
    public float CqcAttackLongRangeDegree { get; set; } = 60f;

    [JsonPropertyName("cqcAttackFirstTurnUpDegree_")]
    public float CqcAttackFirstTurnUpDegree { get; set; } = 60f;

    [JsonPropertyName("cqcAttackFirstTurnUpRate_")]
    public float CqcAttackFirstTurnUpRate { get; set; } = 1.4f;

    [JsonPropertyName("counterAttackWaitMinTime_")]
    public float CounterAttackWaitMinTime { get; set; } = 2f;

    [JsonPropertyName("counterAttackWaitMaxTime_")]
    public float CounterAttackWaitMaxTime { get; set; } = 2f;

    [JsonPropertyName("counterJumpPlaceCount_")]
    public int CounterJumpPlaceCount { get; set; } = 1;

    [JsonPropertyName("counterJumpPlaceOffsetX_")]
    public float CounterJumpPlaceOffsetX { get; set; } = 2f;

    [JsonPropertyName("counterJumpPlaceOffsetZ_")]
    public float CounterJumpPlaceOffsetZ { get; set; } = 1f;

    [JsonPropertyName("counterShotPlaceCount_")]
    public int CounterShotPlaceCount { get; set; } = 21;

    [JsonPropertyName("counterShotPlaceInterval_")]
    public float CounterShotPlaceInterval { get; set; } = 0.12f;

    [JsonPropertyName("counterShotPlaceOffsetZ_")]
    public float CounterShotPlaceOffsetZ { get; set; } = 3f;

    [JsonPropertyName("counterShotFirstWaitTime_")]
    public float CounterShotFirstWaitTime { get; set; } = 0.01f;

    [JsonPropertyName("counterShotFirstOffsetZ_")]
    public float CounterShotFirstOffsetZ { get; set; } = 5f;

    [JsonPropertyName("rushThrustSignBeginTime_")]
    public float RushThrustSignBeginTime { get; set; } = 0.3f;

    [JsonPropertyName("rushJumpMaxDistance_")]
    public float RushJumpMaxDistance { get; set; } = 50f;

    [JsonPropertyName("rushJumpPowerY_")]
    public float RushJumpPowerY { get; set; } = 0.5f;

    [JsonPropertyName("rushJumpGravity_")]
    public float RushJumpGravity { get; set; } = 0.015f;

    [JsonPropertyName("rushSlashSignBeginTime_")]
    public float RushSlashSignBeginTime { get; set; } = 0.3f;

    [JsonPropertyName("shotAttackThresoldRange_")]
    public float ShotAttackThresoldRange { get; set; } = 10f;

    [JsonPropertyName("shotAttackSignBeginTime_")]
    public float ShotAttackSignBeginTime { get; set; } = 0.3f;

    [JsonPropertyName("shotAttackOffsetDistance_")]
    public float ShotAttackOffsetDistance { get; set; } = -10f;

    [JsonPropertyName("rushThrustWaitChanceTime_")]
    public float RushThrustWaitChanceTime { get; set; } = 0.84f;

    [JsonPropertyName("rushThrustChanceTime_")]
    public float RushThrustChanceTime { get; set; } = 1.7f;

    [JsonPropertyName("rushJumpWaitChanceTime_")]
    public float RushJumpWaitChanceTime { get; set; } = 0.7f;

    [JsonPropertyName("rushJumpChanceTime_")]
    public float RushJumpChanceTime { get; set; } = 1.7f;

    [JsonPropertyName("rushSlashWaitChanceTime_")]
    public float RushSlashWaitChanceTime { get; set; } = 0.67f;

    [JsonPropertyName("rushSlashChanceTime_")]
    public float RushSlashChanceTime { get; set; } = 1.7f;

    [JsonPropertyName("shotAttackWaitChanceTime_")]
    public float ShotAttackWaitChanceTime { get; set; } = 0.27f;

    [JsonPropertyName("shotAttackChanceTime_")]
    public float ShotAttackChanceTime { get; set; } = 0f;

    [JsonPropertyName("rushThrustSheathedFrame_")]
    public int RushThrustSheathedFrame { get; set; } = 10;

    [JsonPropertyName("rushJumpSheathedFrame_")]
    public int RushJumpSheathedFrame { get; set; } = 20;

    [JsonPropertyName("rushSlashSheathedFrame_")]
    public int RushSlashSheathedFrame { get; set; } = 20;

    [JsonPropertyName("eachParam_")]
    public Em2200EachParam EachParam { get; set; }

    [JsonPropertyName("specialAttackParam_")]
    public Em2200SpecialAttackParam SpecialAttackParam { get; set; }

    [JsonPropertyName("odAbilitySignAddTime_")]
    public float OdAbilitySignAddTime { get; set; } = 0.05f;

    [JsonPropertyName("odAbilityFallSpeed_")]
    public float OdAbilityFallSpeed { get; set; } = 50f;

    [JsonPropertyName("odAbilityDashMinDist_")]
    public float OdAbilityDashMinDist { get; set; } = 10f;

    [JsonPropertyName("odAbilityDashTurnSpeed_")]
    public float OdAbilityDashTurnSpeed { get; set; } = 360f;

    [JsonPropertyName("odAbilityAttackParam_")]
    public Em2200OdAbilityAttackParam OdAbilityAttackParam { get; set; }

    [JsonPropertyName("specialArtsCameraAimRotMax_")]
    public float SpecialArtsCameraAimRotMax { get; set; } = 6.283185f;

    [JsonPropertyName("specialArtsCameraAimMoveRate_")]
    public float SpecialArtsCameraAimMoveRate { get; set; } = 0.3f;

    [JsonPropertyName("specialArtsCameraAimMoveRotMax_")]
    public float SpecialArtsCameraAimMoveRotMax { get; set; } = 0.5235988f;

    [JsonPropertyName("aiAvoidMoveDistance_")]
    public float AiAvoidMoveDistance { get; set; } = 10f;

    [JsonPropertyName("aiAvoidMovedWaitSec_")]
    public float AiAvoidMovedWaitSec { get; set; } = 2f;

    [JsonPropertyName("aiAvoidCancelWaitSec_")]
    public float AiAvoidCancelWaitSec { get; set; } = 0.2f;

    [JsonPropertyName("aiAvoidSafetyRadius_")]
    public float AiAvoidSafetyRadius { get; set; } = 4f;

    [JsonPropertyName("aiAvoidCollisionRadius_")]
    public float AiAvoidCollisionRadius { get; set; } = 2f;

    [JsonPropertyName("changeDragonModeBgmStartFrame_")]
    public int ChangeDragonModeBgmStartFrame { get; set; } = 95;

    [JsonPropertyName("reviveTime_")]
    public float ReviveTime { get; set; } = 40f;

    [JsonPropertyName("eventRushJumpHpRateMax_")]
    public int EventRushJumpHpRateMax { get; set; } = 85;

    [JsonPropertyName("eventRushJumpHpRateMin_")]
    public int EventRushJumpHpRateMin { get; set; } = 55;

    [JsonPropertyName("eventRushJumpStartFrame_")]
    public int EventRushJumpStartFrame { get; set; } = 8;

    [JsonPropertyName("stepMotionDistance_")]
    public float StepMotionDistance { get; set; } = 15f;

    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("linkParam1st_")]
    public EmLinkAttackParam LinkParam1st { get; set; }

    [JsonPropertyName("linkParam3st_")]
    public EmLinkAttackParam LinkParam3st { get; set; }

    [JsonPropertyName("hlHateParams_")]
    public EmLinkAttackParam HlHateParams { get; set; }

    public Em2200Param()
    {
        Hp = 530000;
        Atk = 450;
        Break = 10;
        Def = 1f;
        Endurance = 10;
        Exp = 20;
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
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 0.2f;
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
        IsEnableSyncWeaponAnim = true;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = true;
        CameraLength = 0f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 0f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
    }

    public class AILevelParam
    {
        [JsonPropertyName("commonDarknessEnable_")]
        public bool CommonDarknessEnable { get; set; }

        [JsonPropertyName("counterBashMinCount_")]
        public int CounterBashMinCount { get; set; }

        [JsonPropertyName("counterBashMaxCount_")]
        public int CounterBashMaxCount { get; set; }

        [JsonPropertyName("counterAttackRate_")]
        public int CounterAttackRate { get; set; }

        [JsonPropertyName("counterAttackRateEvent_")]
        public int CounterAttackRateEvent { get; set; }

        [JsonPropertyName("counterJumpRate_")]
        public int CounterJumpRate { get; set; }

        [JsonPropertyName("cqcAttackUseFlag_")]
        public int CqcAttackUseFlag { get; set; }

        [JsonPropertyName("mainAttackAddChanceTime_")]
        public float MainAttackAddChanceTime { get; set; }

        [JsonPropertyName("rushThrustReadyTime_")]
        public float RushThrustReadyTime { get; set; }

        [JsonPropertyName("rushThrustHomingTime_")]
        public float RushThrustHomingTime { get; set; }

        [JsonPropertyName("rushThrustMoveSpeed_")]
        public float RushThrustMoveSpeed { get; set; }

        [JsonPropertyName("rushSlashReadyTime_")]
        public float RushSlashReadyTime { get; set; }

        [JsonPropertyName("rushSlashHomingTime_")]
        public float RushSlashHomingTime { get; set; }

        [JsonPropertyName("rushSlashMoveSpeed_")]
        public float RushSlashMoveSpeed { get; set; }

        [JsonPropertyName("shotAttackReadyTime_")]
        public float ShotAttackReadyTime { get; set; }

        [JsonPropertyName("shotAttackHomingTime_")]
        public float ShotAttackHomingTime { get; set; }

        [JsonPropertyName("shotAttackBulletSpeed_")]
        public float ShotAttackBulletSpeed { get; set; }

        [JsonPropertyName("shotAttackBlastWait_")]
        public float ShotAttackBlastWait { get; set; }

        [JsonPropertyName("rushJumpReadyTime_")]
        public float RushJumpReadyTime { get; set; }

        [JsonPropertyName("rushJumpHomingTime_")]
        public float RushJumpHomingTime { get; set; }

        [JsonPropertyName("counterAttackDelayTime_")]
        public float CounterAttackDelayTime { get; set; }

        [JsonPropertyName("counterJumpUseFlag_")]
        public int CounterJumpUseFlag { get; set; }

        [JsonPropertyName("revengeCounterBashRate_")]
        public int RevengeCounterBashRate { get; set; }

        [JsonPropertyName("revengeCounterShotRate_")]
        public int RevengeCounterShotRate { get; set; }

        [JsonPropertyName("revengeCounterAttackRate_")]
        public int RevengeCounterAttackRate { get; set; }

        [JsonPropertyName("revengeCounterAttackRateEvent_")]
        public int RevengeCounterAttackRateEvent { get; set; }

        [JsonPropertyName("specialAttackUseFlag_")]
        public int SpecialAttackUseFlag { get; set; }

        [JsonPropertyName("specialAttackMainRange_")]
        public float SpecialAttackMainRange { get; set; }

        [JsonPropertyName("specialAttackSubRange_")]
        public float SpecialAttackSubRange { get; set; }

        [JsonPropertyName("specialAttackIntervalTime_")]
        public float SpecialAttackIntervalTime { get; set; }

        [JsonPropertyName("specialAttackContinueCount_")]
        public int SpecialAttackContinueCount { get; set; }

        [JsonPropertyName("specialAttackFirstSubCount_")]
        public int SpecialAttackFirstSubCount { get; set; }

        [JsonPropertyName("specialAttackSecondSubCount_")]
        public int SpecialAttackSecondSubCount { get; set; }

        [JsonPropertyName("odAbilityDashSpeed_")]
        public float OdAbilityDashSpeed { get; set; }

        [JsonPropertyName("odAbilityStrikeMainType_")]
        public int OdAbilityStrikeMainType { get; set; }

        [JsonPropertyName("odAbilityStrikeSubCount_")]
        public int OdAbilityStrikeSubCount { get; set; }

        [JsonPropertyName("odAbilityStrikeSubTime_")]
        public float OdAbilityStrikeSubTime { get; set; }

        [JsonPropertyName("odAbilityStrikeSubSignTime_")]
        public float OdAbilityStrikeSubSignTime { get; set; }

        [JsonPropertyName("odAbilityFinishMainType_")]
        public int OdAbilityFinishMainType { get; set; }

        [JsonPropertyName("odAbilityFinishMainRadius_")]
        public float OdAbilityFinishMainRadius { get; set; }

        [JsonPropertyName("odAbilityFinishMainTime_")]
        public float OdAbilityFinishMainTime { get; set; }

        [JsonPropertyName("odAbilityFinishSubEnable_")]
        public bool OdAbilityFinishSubEnable { get; set; }

        [JsonPropertyName("odAbilityFinishSubInterval_")]
        public float OdAbilityFinishSubInterval { get; set; }

        [JsonPropertyName("odAbilityFinishSubSignTime_")]
        public float OdAbilityFinishSubSignTime { get; set; }

        [JsonPropertyName("odAbilityDiffusionRadius_")]
        public float OdAbilityDiffusionRadius { get; set; }

        [JsonPropertyName("odAbilityDiffusionSignTime_")]
        public float OdAbilityDiffusionSignTime { get; set; }

        [JsonPropertyName("odAbilityDiffusionInterval")]
        public float OdAbilityDiffusionInterval { get; set; }

        [JsonPropertyName("odAbilityDiffusionDistance_")]
        public float OdAbilityDiffusionDistance { get; set; }

        [JsonPropertyName("walkActionTime_")]
        public Vector2 WalkActionTime { get; set; }

        [JsonPropertyName("odRushAttackCount_")]
        public int OdRushAttackCount { get; set; }

        [JsonPropertyName("damageReactionValue_")]
        public int[] DamageReactionValue { get; set; } = new int[2]; // std::array<int,2>
    }
}

public class Em2200AILevelParam
{
    [JsonPropertyName("commonDarknessEnable_")]
    public bool CommonDarknessEnable { get; set; } // Offset 0x8

    [JsonPropertyName("counterBashMinCount_")]
    public int CounterBashMinCount { get; set; } // Offset 0xC

    [JsonPropertyName("counterBashMaxCount_")]
    public int CounterBashMaxCount { get; set; } // Offset 0x10

    [JsonPropertyName("counterAttackRate_")]
    public int CounterAttackRate { get; set; } // Offset 0x14

    [JsonPropertyName("counterAttackRateEvent_")]
    public int CounterAttackRateEvent { get; set; } // Offset 0x18

    [JsonPropertyName("counterJumpRate_")]
    public int CounterJumpRate { get; set; } // Offset 0x1C

    [JsonPropertyName("cqcAttackUseFlag_")]
    public int CqcAttackUseFlag { get; set; } // Offset 0x20

    [JsonPropertyName("mainAttackAddChanceTime_")]
    public float MainAttackAddChanceTime { get; set; } // Offset 0x24

    [JsonPropertyName("rushThrustReadyTime_")]
    public float RushThrustReadyTime { get; set; } // Offset 0x28

    [JsonPropertyName("rushThrustHomingTime_")]
    public float RushThrustHomingTime { get; set; } // Offset 0x2C

    [JsonPropertyName("rushThrustMoveSpeed_")]
    public float RushThrustMoveSpeed { get; set; } // Offset 0x30

    [JsonPropertyName("rushSlashReadyTime_")]
    public float RushSlashReadyTime { get; set; } // Offset 0x34

    [JsonPropertyName("rushSlashHomingTime_")]
    public float RushSlashHomingTime { get; set; } // Offset 0x38

    [JsonPropertyName("rushSlashMoveSpeed_")]
    public float RushSlashMoveSpeed { get; set; } // Offset 0x3C

    [JsonPropertyName("shotAttackReadyTime_")]
    public float ShotAttackReadyTime { get; set; } // Offset 0x40

    [JsonPropertyName("shotAttackHomingTime_")]
    public float ShotAttackHomingTime { get; set; } // Offset 0x44

    [JsonPropertyName("shotAttackBulletSpeed_")]
    public float ShotAttackBulletSpeed { get; set; } // Offset 0x48

    [JsonPropertyName("shotAttackBlastWait_")]
    public float ShotAttackBlastWait { get; set; } // Offset 0x4C

    [JsonPropertyName("rushJumpReadyTime_")]
    public float RushJumpReadyTime { get; set; } // Offset 0x50

    [JsonPropertyName("rushJumpHomingTime_")]
    public float RushJumpHomingTime { get; set; } // Offset 0x54

    [JsonPropertyName("counterAttackDelayTime_")]
    public float CounterAttackDelayTime { get; set; } // Offset 0x58

    [JsonPropertyName("counterJumpUseFlag_")]
    public int CounterJumpUseFlag { get; set; } // Offset 0x5C

    [JsonPropertyName("revengeCounterBashRate_")]
    public int RevengeCounterBashRate { get; set; } // Offset 0x60

    [JsonPropertyName("revengeCounterShotRate_")]
    public int RevengeCounterShotRate { get; set; } // Offset 0x64

    [JsonPropertyName("revengeCounterAttackRate_")]
    public int RevengeCounterAttackRate { get; set; } // Offset 0x68

    [JsonPropertyName("revengeCounterAttackRateEvent_")]
    public int RevengeCounterAttackRateEvent { get; set; } // Offset 0x6C

    [JsonPropertyName("specialAttackUseFlag_")]
    public int SpecialAttackUseFlag { get; set; } // Offset 0x70

    [JsonPropertyName("specialAttackMainRange_")]
    public float SpecialAttackMainRange { get; set; } // Offset 0x74

    [JsonPropertyName("specialAttackSubRange_")]
    public float SpecialAttackSubRange { get; set; } // Offset 0x78

    [JsonPropertyName("specialAttackIntervalTime_")]
    public float SpecialAttackIntervalTime { get; set; } // Offset 0x7C

    [JsonPropertyName("specialAttackContinueCount_")]
    public int SpecialAttackContinueCount { get; set; } // Offset 0x80

    [JsonPropertyName("specialAttackFirstSubCount_")]
    public int SpecialAttackFirstSubCount { get; set; } // Offset 0x84

    [JsonPropertyName("specialAttackSecondSubCount_")]
    public int SpecialAttackSecondSubCount { get; set; } // Offset 0x88

    [JsonPropertyName("odAbilityDashSpeed_")]
    public float OdAbilityDashSpeed { get; set; } // Offset 0x8C

    [JsonPropertyName("odAbilityStrikeMainType_")]
    public int OdAbilityStrikeMainType { get; set; } // Offset 0x90

    [JsonPropertyName("odAbilityStrikeSubCount_")]
    public int OdAbilityStrikeSubCount { get; set; } // Offset 0x94

    [JsonPropertyName("odAbilityStrikeSubTime_")]
    public float OdAbilityStrikeSubTime { get; set; } // Offset 0x98

    [JsonPropertyName("odAbilityStrikeSubSignTime_")]
    public float OdAbilityStrikeSubSignTime { get; set; } // Offset 0x9C

    [JsonPropertyName("odAbilityFinishMainType_")]
    public int OdAbilityFinishMainType { get; set; } // Offset 0xA0

    [JsonPropertyName("odAbilityFinishMainRadius_")]
    public float OdAbilityFinishMainRadius { get; set; } // Offset 0xA4

    [JsonPropertyName("odAbilityFinishMainTime_")]
    public float OdAbilityFinishMainTime { get; set; } // Offset 0xA8

    [JsonPropertyName("odAbilityFinishSubEnable_")]
    public bool OdAbilityFinishSubEnable { get; set; } // Offset 0xAC

    [JsonPropertyName("odAbilityFinishSubInterval_")]
    public float OdAbilityFinishSubInterval { get; set; } // Offset 0xB0

    [JsonPropertyName("odAbilityFinishSubSignTime_")]
    public float OdAbilityFinishSubSignTime { get; set; } // Offset 0xB4

    [JsonPropertyName("odAbilityDiffusionRadius_")]
    public float OdAbilityDiffusionRadius { get; set; } // Offset 0xB8

    [JsonPropertyName("odAbilityDiffusionSignTime_")]
    public float OdAbilityDiffusionSignTime { get; set; } // Offset 0xBC

    [JsonPropertyName("odAbilityDiffusionInterval")]
    public float OdAbilityDiffusionInterval { get; set; } // Offset 0xC0

    [JsonPropertyName("odAbilityDiffusionDistance_")]
    public float OdAbilityDiffusionDistance { get; set; } // Offset 0xC4

    [JsonPropertyName("walkActionTime_")]
    public Vector2 WalkActionTime { get; set; } // Offset 0xC8

    [JsonPropertyName("odRushAttackCount_")]
    public int OdRushAttackCount { get; set; } // Offset 0xD0

    [JsonPropertyName("damageReactionValue_")]
    public EmDamageReactionGaugeParam DamageReactionValue { get; set; } // Offset 0xD4

    public Em2200AILevelParam()
    {
    }

    public class HateParams
    {
        [JsonPropertyName("hateRateClosePlayer_")]
        public int HateRateClosePlayer { get; set; } // Offset 0x8

        [JsonPropertyName("hateRateFarPlayer_")]
        public int HateRateFarPlayer { get; set; } // Offset 0xC

        [JsonPropertyName("hateRateClosePlayerPerSec_")]
        public int HateRateClosePlayerPerSec { get; set; } // Offset 0x10

        [JsonPropertyName("hateRateFarPlayerPerSec_")]
        public int HateRateFarPlayerPerSec { get; set; } // Offset 0x14

        [JsonPropertyName("hateRateFrontAngle_")]
        public int HateRateFrontAngle { get; set; } // Offset 0x18

        [JsonPropertyName("hateRateBackAngle_")]
        public int HateRateBackAngle { get; set; } // Offset 0x1C

        [JsonPropertyName("hateRateDamage_")]
        public int HateRateDamage { get; set; } // Offset 0x20

        [JsonPropertyName("hateRateManualPlayer_")]
        public int HateRateManualPlayer { get; set; } // Offset 0x24

        [JsonPropertyName("hateRateHighHpPlayer_")]
        public int HateRateHighHpPlayer { get; set; } // Offset 0x28

        [JsonPropertyName("hateRateLowHpPlayer_")]
        public int HateRateLowHpPlayer { get; set; } // Offset 0x2C

        [JsonPropertyName("hateRateTargetCountManyPlayer_")]
        public int HateRateTargetCountManyPlayer { get; set; } // Offset 0x30

        [JsonPropertyName("hateRateTargetCountFewPlayer_")]
        public int HateRateTargetCountFewPlayer { get; set; } // Offset 0x34

        [JsonPropertyName("hateRateHelpPlayer_")]
        public int HateRateHelpPlayer { get; set; } // Offset 0x38

        [JsonPropertyName("hateRateLastTargetPlayer_")]
        public int HateRateLastTargetPlayer { get; set; } // Offset 0x3C

        [JsonPropertyName("hateRateFirstTargetPlayer_")]
        public int HateRateFirstTargetPlayer { get; set; } // Offset 0x40

        [JsonPropertyName("badStatusHateRateMap_")]
        public uint[] BadStatusHateRateMap { get; set; } // TODO: std::unordered_map<unsigned int, int> - Offset 0x48

        [JsonPropertyName("hateUpdateTime_")]
        public float HateUpdateTime { get; set; } // Offset 0x88

        [JsonPropertyName("damageToHateRate_")]
        public float DamageToHateRate { get; set; } // Offset 0x8C

        [JsonPropertyName("damageHateDecPerSec_")]
        public float DamageHateDecPerSec { get; set; } // Offset 0x90

        [JsonPropertyName("closeHateIncRate_")]
        public float CloseHateIncRate { get; set; } // Offset 0x94

        [JsonPropertyName("closeHateDecRate_")]
        public float CloseHateDecRate { get; set; } // Offset 0x98

        [JsonPropertyName("farHateIncRate_")]
        public float FarHateIncRate { get; set; } // Offset 0x9C

        [JsonPropertyName("farHateDecRate_")]
        public float FarHateDecRate { get; set; } // Offset 0xA0

        public HateParams()
        {
        }
    }
}

public class Em2200EachParam
{
    [JsonPropertyName("rushJumpSignAddFrameJump_")]
    public int RushJumpSignAddFrameJump { get; set; } // Offset 0x8

    [JsonPropertyName("rushJumpSignAddFrameLand_")]
    public int RushJumpSignAddFrameLand { get; set; } // Offset 0xC

    [JsonPropertyName("rushJumpStrikeRadius_")]
    public float RushJumpStrikeRadius { get; set; } // Offset 0x10

    [JsonPropertyName("rushSlashOffsetDistance_")]
    public float RushSlashOffsetDistance { get; set; } // Offset 0x14

    [JsonPropertyName("rushSlashOffsetRotY_")]
    public float RushSlashOffsetRotY { get; set; } // Offset 0x18

    public Em2200EachParam()
    {
    }
}


public class Em2200SpecialAttackParam
{
    [JsonPropertyName("specialAttackFirstSignTime_")]
    public float SpecialAttackFirstSignTime { get; set; } // Offset 0x8

    [JsonPropertyName("specialAttackSecondSignTime")]
    public float SpecialAttackSecondSignTime { get; set; } // Offset 0xC

    [JsonPropertyName("specialAttackDistanceRate")]
    public float SpecialAttackDistanceRate { get; set; } // Offset 0x10

    [JsonPropertyName("specialAttackOffsetRate")]
    public float SpecialAttackOffsetRate { get; set; } // Offset 0x14

    public Em2200SpecialAttackParam()
    {
    }
}


public class Em2200OdAbilityAttackParam
{
    [JsonPropertyName("odAbilityStrikeMainOffset_")]
    public float OdAbilityStrikeMainOffset { get; set; } // Offset 0x8

    [JsonPropertyName("odAbilityStrikeMainRange_")]
    public float[] OdAbilityStrikeMainRange { get; set; } = new float[2]; // Offset 0xC

    [JsonPropertyName("odAbilityStrikeSubRadius_")]
    public float OdAbilityStrikeSubRadius { get; set; } // Offset 0x14

    [JsonPropertyName("odAbilityStrikeSubBeginTime_")]
    public float OdAbilityStrikeSubBeginTime { get; set; } // Offset 0x18

    [JsonPropertyName("odAbilityStrikeSubSpread_")]
    public float OdAbilityStrikeSubSpread { get; set; } // Offset 0x1C

    [JsonPropertyName("odAbilityDashExplodeDistance_")]
    public float OdAbilityDashExplodeDistance { get; set; } // Offset 0x20

    [JsonPropertyName("odAbilityDashExplodeWaitTime_")]
    public float OdAbilityDashExplodeWaitTime { get; set; } // Offset 0x24

    [JsonPropertyName("odAbilityFinishSubRadius_")]
    public float OdAbilityFinishSubRadius { get; set; } // Offset 0x28

    [JsonPropertyName("odAbilityFinishSubTime_")]
    public float OdAbilityFinishSubTime { get; set; } // Offset 0x2C

    [JsonPropertyName("odAbilityDiffusionCount_")]
    public int OdAbilityDiffusionCount { get; set; } // Offset 0x30

    [JsonPropertyName("odAbilityDiffusionGain_")]
    public int OdAbilityDiffusionGain { get; set; } // Offset 0x34

    [JsonPropertyName("odAbilityDiffusionTimes_")]
    public int OdAbilityDiffusionTimes { get; set; } // Offset 0x38

    [JsonPropertyName("odAbilityDiffusionPoint_")]
    public float OdAbilityDiffusionPoint { get; set; } // Offset 0x3C

    public Em2200OdAbilityAttackParam()
    {
    }
}