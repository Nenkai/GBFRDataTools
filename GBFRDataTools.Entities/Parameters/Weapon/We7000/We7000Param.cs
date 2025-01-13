using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Weapon.We7000;

public class We7000Param : EnemyParameterInfo
{
    [JsonPropertyName("darkWaveParam_")]
    public We7000DarkWaveParam DarkWaveParam { get; set; }

    [JsonPropertyName("darkWaveShotParam_")]
    public We7000DarkWaveShotParam DarkWaveShotParam { get; set; }

    [JsonPropertyName("aiLevelParams_")]
    public AILevelParam[] AiLevelParams { get; set; } = new AILevelParam[5];

    public We7000Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 3;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 10;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
        HateRateBackAngle = 0;
        HateRateDamage = 0;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 0;
        HateUpdateTime = 10f;
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
        IsDisableAerialDownReaction = false;
    }

    public class SelfDestructionParam
    {
        [JsonPropertyName("signSec_")]
        public float SignSec { get; set; } // Offset 0x8

        [JsonPropertyName("startCountdownMinSec_")]
        public float StartCountdownMinSec { get; set; } // Offset 0xC

        [JsonPropertyName("startCountdownMaxSec_")]
        public float StartCountdownMaxSec { get; set; } // Offset 0x10

        public SelfDestructionParam()
        {
        }
    }


    public class AILevelParam
    {
        [JsonPropertyName("attackIntervalMinSec_")]
        public float AttackIntervalMinSec { get; set; } // Offset 0x8

        [JsonPropertyName("attackIntervalMaxSec_")]
        public float AttackIntervalMaxSec { get; set; } // Offset 0xC

        [JsonPropertyName("selfDestructionParam_")]
        public SelfDestructionParam SelfDestructionParam { get; set; } // Offset 0xCF543FFA

        public AILevelParam()
        {
        }
    }
}

public class We7000DarkWaveParam
{
    [JsonPropertyName("intervalAttackSecMin_")]
    public float IntervalAttackSecMin { get; set; } // Offset 0x8

    [JsonPropertyName("intervalAttackSecMax_")]
    public float IntervalAttackSecMax { get; set; } // Offset 0xC

    [JsonPropertyName("afeterShotWaitSec_")]
    public float AfeterShotWaitSec { get; set; } // Offset 0x10

    public We7000DarkWaveParam()
    {
    }
}


public class We7000DarkWaveShotParam
{
    [JsonPropertyName("attackVfxSize_")]
    public float AttackVfxSize { get; set; } // Offset 0x8

    [JsonPropertyName("offsetAttackVfxCount_")]
    public int OffsetAttackVfxCount { get; set; } // Offset 0xC

    public We7000DarkWaveShotParam()
    {
    }
}