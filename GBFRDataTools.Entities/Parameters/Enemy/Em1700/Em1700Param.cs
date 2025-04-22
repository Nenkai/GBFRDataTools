using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

using static GBFRDataTools.Entities.Parameters.Enemy.Em2100.Em2100SpArtsRotationActionParam;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1700;

public class Em1700Param : EmBossBaseParam
{
    [JsonPropertyName("partsHPHead_")]
    public int PartsHPHead { get; set; } = 14000;

    [JsonPropertyName("dominionJustGuardStunRate_")]
    public float DominionJustGuardStunRate { get; set; } = 2f;

    [JsonPropertyName("dominionNormalStunRate_")]
    public float DominionNormalStunRate { get; set; } = 0.05f;

    [JsonPropertyName("dominionHighStunRate_")]
    public float DominionHighStunRate { get; set; } = 1.5f;

    [JsonPropertyName("dominionChanceStunRate_")]
    public float DominionChanceStunRate { get; set; } = 0.05f;

    [JsonPropertyName("chaosLineSignSec_")]
    public float ChaosLineSignSec { get; set; } = 5f;

    [JsonPropertyName("chaosLineRadius_")]
    public float ChaosLineRadius { get; set; } = 2.5f;

    [JsonPropertyName("chaosLineThunderNum_")]
    public int ChaosLineThunderNum { get; set; } = 4;

    [JsonPropertyName("chaosLineThunderExtendOffsetLength_")]
    public float ChaosLineThunderExtendOffsetLength { get; set; } = 4f;

    [JsonPropertyName("chaosLineThunderShrinkOffsetLength_")]
    public float ChaosLineThunderShrinkOffsetLength { get; set; } = 20f;

    [JsonPropertyName("clThunderLineCount_")]
    public int ClThunderLineCount { get; set; } = 10;

    [JsonPropertyName("clThunderCreateInterval_")]
    public float ClThunderCreateInterval { get; set; } = 0.1f;

    [JsonPropertyName("clThunderAddRotY_")]
    public float ClThunderAddRotY { get; set; } = 10f;

    [JsonPropertyName("clThunderRotY_")]
    public float ClThunderRotY { get; set; } = 90f;

    [JsonPropertyName("clThunderoffsetRotY_")]
    public float ClThunderoffsetRotY { get; set; } = 45f;

    [JsonPropertyName("clThunderdist_")]
    public float ClThunderdist { get; set; } = 7f;

    [JsonPropertyName("coolTimeScratchCombo_")]
    public float CoolTimeScratchCombo { get; set; } = 20f;

    [JsonPropertyName("coolTimeDiveScratch_")]
    public float CoolTimeDiveScratch { get; set; } = 30f;

    [JsonPropertyName("coolTimeTurnScratch_")]
    public float CoolTimeTurnScratch { get; set; } = 30f;

    [JsonPropertyName("coolTimeAttractScratch_")]
    public float CoolTimeAttractScratch { get; set; } = 60f;

    [JsonPropertyName("coolTimeAttractScratchLinkChance_")]
    public float CoolTimeAttractScratchLinkChance { get; set; } = 90f;

    [JsonPropertyName("coolTimeTailAttack_")]
    public float CoolTimeTailAttack { get; set; } = 30f;

    [JsonPropertyName("coolTimeBackStepAttack_")]
    public float CoolTimeBackStepAttack { get; set; } = 20f;

    [JsonPropertyName("coolTimeDiveRush_")]
    public float CoolTimeDiveRush { get; set; } = 25f;

    [JsonPropertyName("coolTimeZigzagRush_")]
    public float CoolTimeZigzagRush { get; set; } = 30f;

    [JsonPropertyName("coolTimeDempsey_")]
    public float CoolTimeDempsey { get; set; } = 35f;

    [JsonPropertyName("coolTimeChaosLine_")]
    public Vector2 CoolTimeChaosLine { get; set; } = new Vector2(30f, 20f);

    [JsonPropertyName("coolTimeUpper_")]
    public float CoolTimeUpper { get; set; } = 30f;

    [JsonPropertyName("coolTimeGiganticPulsar_")]
    public float CoolTimeGiganticPulsar { get; set; } = 40f;

    [JsonPropertyName("waveParam_")]
    public WaveParam WaveParam_ { get; set; }

    [JsonPropertyName("waveParamOD_")]
    public WaveParam WaveParamOD { get; set; }

    [JsonPropertyName("overDriveRate_")]
    public Vector2 OverDriveRate { get; set; } = new Vector2(1.05f, 1.1f);

    [JsonPropertyName("assembleAreaParam_")]
    public AssembleAreaParam AssembleAreaParam_ { get; set; }

    [JsonPropertyName("assembleAreaParamOD_")]
    public AssembleAreaParam AssembleAreaParamOD { get; set; }

    [JsonPropertyName("tiredInitRate_")]
    public int TiredInitRate { get; set; } = 100;

    [JsonPropertyName("tiredAddRate_")]
    public int TiredAddRate { get; set; } = 25;

    [JsonPropertyName("tiredForceCount_")]
    public int TiredForceCount { get; set; } = 4;

    [JsonPropertyName("doughnutAttackAttackRate_")]
    public float DoughnutAttackAttackRate { get; set; } = 1.2f;

    [JsonPropertyName("doughnutAttackStunRate_")]
    public float DoughnutAttackStunRate { get; set; } = 1.8f;

    [JsonPropertyName("doughnutAttackAttackRateOD_")]
    public float DoughnutAttackAttackRateOD { get; set; } = 0.9f;

    [JsonPropertyName("doughnutAttackStunRateOD_")]
    public float DoughnutAttackStunRateOD { get; set; } = 0.9f;

    public Em1700Param()
    {
        Hp = 300000;
        Atk = 2000;
        Break = 8;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
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
        HateUpdateTime = 5f;
        DamageToHateRate = 0.02f;
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
        CameraLength = 5f;
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

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WaveParam
    {
        [JsonPropertyName("initRadius_")]
        public float InitRadius { get; set; } // Offset 0x8

        [JsonPropertyName("endRadius_")]
        public float EndRadius { get; set; } // Offset 0xC

        [JsonPropertyName("waveWidth_")]
        public float WaveWidth { get; set; } // Offset 0x10

        [JsonPropertyName("height_")]
        public float Height { get; set; } // Offset 0x14

        [JsonPropertyName("signTime_")]
        public float SignTime { get; set; } // Offset 0x18

        [JsonPropertyName("time_")]
        public float Time { get; set; } // Offset 0x1C

        public WaveParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AssembleAreaParam
    {
        [JsonPropertyName("radius_")]
        public float Radius { get; set; } // Offset 0x8

        [JsonPropertyName("signTime_")]
        public float SignTime { get; set; } // Offset 0xC

        [JsonPropertyName("terminateTime_")]
        public float TerminateTime { get; set; } // Offset 0x10

        [JsonPropertyName("createThunderIntervalTime_")]
        public float CreateThunderIntervalTime { get; set; } // Offset 0x14

        [JsonPropertyName("playerIntervalTime_")]
        public float PlayerIntervalTime { get; set; } // Offset 0x18

        [JsonPropertyName("randomIntervalTime_")]
        public float RandomIntervalTime { get; set; } // Offset 0x1C

        [JsonPropertyName("margin_")]
        public float Margin { get; set; } // Offset 0x20

        public AssembleAreaParam()
        {
        }
    }
}
