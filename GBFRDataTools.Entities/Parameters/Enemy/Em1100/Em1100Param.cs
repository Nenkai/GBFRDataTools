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

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1100;

public class Em1100Param : EnemyParameterInfo
{
    [JsonPropertyName("swordHp_")]
    public int SwordHp { get; set; } = 150;

    [JsonPropertyName("guardSec_")]
    public float GuardSec { get; set; } = 2f;

    [JsonPropertyName("guardKnockBackRate_")]
    public float GuardKnockBackRate { get; set; } = 0.11f;

    [JsonPropertyName("guardSwordScale_")]
    public float GuardSwordScale { get; set; } = 1.3f;

    [JsonPropertyName("guardSwordWeakRate_")]
    public float GuardSwordWeakRate { get; set; } = 3f;

    [JsonPropertyName("swordRecoverySec_")]
    public float SwordRecoverySec { get; set; } = 3.5f;

    [JsonPropertyName("counterAttackProbability_")]
    public int CounterAttackProbability { get; set; } = 100;

    [JsonPropertyName("stepAnimMoveRateXZ_")]
    public float StepAnimMoveRateXZ { get; set; } = 1.8f;

    [JsonPropertyName("stepAnimMoveRateY_")]
    public float StepAnimMoveRateY { get; set; } = 1f;

    [JsonPropertyName("avoidAnimMoveRateY_")]
    public float AvoidAnimMoveRateY { get; set; } = 1f;

    [JsonPropertyName("avoidAnimMoveRateXZ_")]
    public float AvoidAnimMoveRateXZ { get; set; } = 1.4f;

    [JsonPropertyName("aiLevelParams_")]
    [Editable(false)]
    public BindingList<AILevelParam> AiLevelParams { get; set; } = [.. Enumerable.Repeat(new AILevelParam(), 5).ToList()]; // std::array<Em1100Param::AILevelParam,5>>

    [JsonPropertyName("boomerangWavyAttackParam_")]
    public BoomerangWavyAttackParam BoomerangWavyAttackParam_ { get; set; }

    [JsonPropertyName("boormerangAttackParam_")]
    public BoomerangWavyAttackParam BoormerangAttackParam { get; set; }

    [JsonPropertyName("counterAttackParam_")]
    public new Em1100AttackParam CounterAttackParam_ { get; set; }

    public Em1100Param()
    {
        Hp = 2300;
        Atk = 80;
        Break = 3;
        Def = 1f;
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
        HateRateDamage = 25;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 25;
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
        CombatPower = 35;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
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
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AILevelParam
    {
        [JsonPropertyName("isBoomerangWavyAddEffect_")]
        public bool IsBoomerangWavyAddEffect { get; set; }

        [JsonPropertyName("deffenceDebuff_")]
        public int DeffenceDebuff { get; set; }

        [JsonPropertyName("deffenceDebuffSec_")]
        public float DeffenceDebuffSec { get; set; }

        public AILevelParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BoomerangWavyAttackParam : Em1100AttackParam
    {
        [JsonPropertyName("combinationMin_")]
        public int CombinationMin { get; set; } // Offset 0x8

        [JsonPropertyName("combinationMax_")]
        public int CombinationMax { get; set; } // Offset 0xC

        [JsonPropertyName("baseStartSec_")]
        public float BaseStartSec { get; set; } // Offset 0x10

        [JsonPropertyName("throwDiffSec_")]
        public float ThrowDiffSec { get; set; } // Offset 0x14

        [JsonPropertyName("enableRange_")]
        public float EnableRange { get; set; } // Offset 0x18

        public BoomerangWavyAttackParam()
        {
        }
    }

    public class Em1100AttackParam : CounterAttackParam
    {
        [JsonPropertyName("attackRate_")]
        public float AttackRate { get; set; } // Offset 0x8

        [JsonPropertyName("breakRate_")]
        public float BreakRate { get; set; } // Offset 0xC

        [JsonPropertyName("damgeMovementRate_")]
        public float DamgeMovementRate { get; set; } // Offset 0x10

        [JsonPropertyName("damgeMovementRateY_")]
        public float DamgeMovementRateY { get; set; } // Offset 0x14

        [JsonPropertyName("knockBackRate_")]
        public float KnockBackRate { get; set; } // Offset 0x18

        [JsonPropertyName("reaction_")]
        public int Reaction { get; set; } // Offset 0x1C

        public Em1100AttackParam()
        {
        }
    }

}
