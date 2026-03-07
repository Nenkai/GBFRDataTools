using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Weapon.We7000;

public class We7001Param : EnemyParameterInfo
{
    [JsonPropertyName("aiLevelParams_")]
    public AILevelParam[] AiLevelParams { get; set; } = new AILevelParam[5];

    [JsonPropertyName("meteorParam_")]
    public We7001MeteorParam MeteorParam { get; set; }

    [JsonPropertyName("ragnarokBuffMeteorParam_")]
    public We7001MeteorParam RagnarokBuffMeteorParam { get; set; }

    [JsonPropertyName("flameFloorParam_")]
    public We7001FlameFloorParam FlameFloorParam { get; set; }

    [JsonPropertyName("ragnarokBuffFlameFloorParam_")]
    public We7001FlameFloorParam RagnarokBuffFlameFloorParam { get; set; }

    [JsonPropertyName("attackMeteorRange_")]
    public float AttackMeteorRange { get; set; } = 20f;

    public We7001Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 3;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 30;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
        HateRateBackAngle = 0;
        HateRateDamage = 70;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 0;
        HateUpdateTime = 1f;
        DamageToHateRate = 0.2f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 50;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0.5f;
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
    }

    public class AILevelParam
    {
        [JsonPropertyName("attackIntervalSec_")]
        public float AttackIntervalSec { get; set; } // Offset 0x8

        [JsonPropertyName("startSec_")]
        public float StartSec { get; set; } // Offset 0x10

        [JsonPropertyName("flameFloorAttackSec_")]
        public float FlameFloorAttackSec { get; set; } // Offset 0x14

        [JsonPropertyName("flameFloorBurnSec_")]
        public float FlameFloorBurnSec { get; set; } // Offset 0x18

        public AILevelParam()
        {
        }
    }
}

public class We7001MeteorParam
{
    [JsonPropertyName("chaseSpeed_")]
    public float ChaseSpeed { get; set; } // Offset 0x8

    [JsonPropertyName("attackSec_")]
    public float AttackSec { get; set; } // Offset 0xC

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } // Offset 0x10

    [JsonPropertyName("fallSec_")]
    public float FallSec { get; set; } // Offset 0x14

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x18

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x1C

    public We7001MeteorParam()
    {
    }
}


public class We7001FlameFloorParam
{
    [JsonPropertyName("attackSec_")]
    public float AttackSec { get; set; } // Offset 0x8

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } // Offset 0xC

    public We7001FlameFloorParam()
    {
    }
}