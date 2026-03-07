using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Weapon.We7000;

public class We7003Param : EnemyParameterInfo
{
    [JsonPropertyName("aiLevelParams_")]
    public AILevelParam[] AiLevelParams { get; set; } = new AILevelParam[5];

    [JsonPropertyName("shockWaveParam_")]
    public We7003ShockWaveParam ShockWaveParam { get; set; }

    public We7003Param()
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
        DamageToHateRate = 0.02f;
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
        public float StartSec { get; set; } // Offset 0xC

        public AILevelParam()
        {
        }
    }
}

public class We7003ShockWaveParam
{
    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x18

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x1C

    [JsonPropertyName("startRadius_")]
    public float StartRadius { get; set; } // Offset 0x8

    [JsonPropertyName("endRadius_")]
    public float EndRadius { get; set; } // Offset 0xC

    [JsonPropertyName("scaleSec_")]
    public float ScaleSec { get; set; } // Offset 0x10

    [JsonPropertyName("chargeSec_")]
    public float ChargeSec { get; set; } // Offset 0x14

    [JsonPropertyName("waitSecondWaveShotSec_")]
    public float WaitSecondWaveShotSec { get; set; } // Offset 0x20

    public We7003ShockWaveParam()
    {
    }
}