using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0900_Statue;

public class Em0900Param : EmStatueBaseParam
{
    [JsonPropertyName("wideSwingCoolTime_")]
    public float WideSwingCoolTime { get; set; } = 10f;

    [JsonPropertyName("handsAttackCoolTime_")]
    public float HandsAttackCoolTime { get; set; } = 10f;

    [JsonPropertyName("fireBeamCoolTime_")]
    public float FireBeamCoolTime { get; set; } = 10f;

    [JsonPropertyName("drillRippleCoolTime_")]
    public float DrillRippleCoolTime { get; set; } = 15f;

    [JsonPropertyName("arrowTackleCoolTime_")]
    public float ArrowTackleCoolTime { get; set; } = 15f;

    [JsonPropertyName("coreLightBurnCoolTime_")]
    public float CoreLightBurnCoolTime { get; set; } = 1f;

    [JsonPropertyName("crossFireBeamCoolTime_")]
    public float CrossFireBeamCoolTime { get; set; } = 20f;

    [JsonPropertyName("canStartLongRangeAttack_")]
    public bool CanStartLongRangeAttack { get; set; } = true;

    [JsonPropertyName("coreLightBurnUsePer_")]
    public int CoreLightBurnUsePer { get; set; } = 0;

    [JsonPropertyName("fireBeamAtkRate_")]
    public float FireBeamAtkRate { get; set; } = 1.8f;

    [JsonPropertyName("fireBeamBreakRate_")]
    public float FireBeamBreakRate { get; set; } = 1.8f;

    [JsonPropertyName("fireBeamBurnSec_")]
    public float FireBeamBurnSec { get; set; } = 5f;

    [JsonPropertyName("fireBeamBurnRate_")]
    public float FireBeamBurnRate { get; set; } = 1f;

    [JsonPropertyName("wallParam_")]
    public Param WallParam { get; set; }

    [JsonPropertyName("wallSpaceDist_")]
    public float WallSpaceDist { get; set; } = 3.5f;

    [JsonPropertyName("wallCheckSpaceDist_")]
    public float WallCheckSpaceDist { get; set; } = 1.7f;

    [JsonPropertyName("wallCreateNormalDeg_")]
    public float WallCreateNormalDeg { get; set; } = 70f;

    [JsonPropertyName("fireWaveNum_")]
    public int FireWaveNum { get; set; } = 8;

    [JsonPropertyName("fireWaveOffsetLength_")]
    public float FireWaveOffsetLength { get; set; } = 0.5f;

    public Em0900Param()
    {
        Hp = 10000;
        Atk = 100;
        Break = 5;
        Def = 0f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 35;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 15;
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
        CombatPower = 55;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0.25f;
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
        IsDisableAerialDownReaction = false;
        ScaleParam = 0.55f;
        DamageReactionBreakValue = 0f;
        CoreLightOffSec = 3.7f;
        AttackCoolTime = 2f;
        StepCoolTime = 3f;
        CoreLightUpGuardRate = 0.5f;
        CoreLightUpGuardBreakRate = 0.4f;
        CoreLightUpKnockBackRate = 0f;
        CoreLightUpCounterRate = 4f;
        CoreLightUpGuardUi = false;
        CoreLightUpGuardEffect = true;
        CoreLightUpGuardSe = true;
        CoreLightAlphaRate = 0.5f;
        CoreLightOnEmissiveRate = 1f;
        CoreLightOffEmissiveRate = 0.01f;
        DrillFlyMoveStopRangeXZ = 0.5f;
        DrillFlyMoveSpdXZ = 45f;
    }

    public class Param
    {
        [JsonPropertyName("atkSize_")]
        public Vector4 AtkSize { get; set; } // Offset 0x10

        [JsonPropertyName("atkRate_")]
        public float AtkRate { get; set; } // Offset 0x20

        [JsonPropertyName("burnSec_")]
        public float BurnSec { get; set; } // Offset 0x28

        [JsonPropertyName("burnRate_")]
        public float BurnRate { get; set; } // Offset 0x2C

        [JsonPropertyName("breakRate_")]
        public float BreakRate { get; set; } // Offset 0x24

        [JsonPropertyName("multiHitSec_")]
        public float MultiHitSec { get; set; } // Offset 0x30

        [JsonPropertyName("wallAliveSec_")]
        public float WallAliveSec { get; set; } // Offset 0x34

        [JsonPropertyName("wallAtkWaitSec_")]
        public float WallAtkWaitSec { get; set; } // Offset 0x38

        [JsonPropertyName("estId_")]
        public int EstId { get; set; } // Offset 0x3C

        public Param()
        {
        }
    }
}
