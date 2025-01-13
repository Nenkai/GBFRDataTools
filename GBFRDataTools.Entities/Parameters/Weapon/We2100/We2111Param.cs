using System.ComponentModel;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Weapon.We2100;

public class We2111Param : SuperiorWeaponParam
{
    [JsonPropertyName("thunderBreakActionParam_")]
    public We2111ThunderBreakActionParam ThunderBreakActionParam { get; set; }

    [JsonPropertyName("consecutiveActionParam_")]
    public We2111ThunderBreakActionParam ConsecutiveActionParam { get; set; }

    [JsonPropertyName("spArtsFinishActionParam_")]
    public We2111ThunderBreakActionParam SpArtsFinishActionParam { get; set; }

    [JsonPropertyName("strikeActionParam_")]
    public We2111StrikeActionParam StrikeActionParam { get; set; }

    [JsonPropertyName("canAttackInvervalSec_")]
    public float CanAttackInvervalSec { get; set; } = 5f;

    [JsonPropertyName("aiLevelParams_")]
    public AILevelParam[] AiLevelParams { get; set; } = new AILevelParam[5];

    public We2111Param()
    {
        Hp = 2500;
        Atk = 10;
        Break = 10;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 100;
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
        CombatPower = 0;
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
    }

    public class AILevelParam
    {
        [JsonPropertyName("attackIntervalSec_")]
        public float AttackIntervalSec { get; set; } // Offset 0x8

        [JsonPropertyName("enableRedAction_")]
        public bool EnableRedAction { get; set; } // Offset 0xC

        [JsonPropertyName("redActionIntervalSec_")]
        public float RedActionIntervalSec { get; set; } // Offset 0x10

        [JsonPropertyName("strikeAttackChanceSec_")]
        public float StrikeAttackChanceSec { get; set; } // Offset 0x14

        [JsonPropertyName("thunderBreakAttackChanceSec_")]
        public float ThunderBreakAttackChanceSec { get; set; } // Offset 0x18

        public AILevelParam()
        {
        }
    }
}

public class We2111ThunderBreakActionParam
{
    [JsonPropertyName("canAttackIntervalSec_")]
    public float CanAttackIntervalSec { get; set; } // Offset 0x8

    [JsonPropertyName("shockwaveRadius_")]
    public float ShockwaveRadius { get; set; } // Offset 0xC

    [JsonPropertyName("thunders_")]
    public /* We2111ThunderBreakActionParam::ThundersArray */ BindingList<Thunders> Thunders_ { get; set; } = []; // Offset 0x20

    [JsonPropertyName("strikeOffsetDist_")]
    public float StrikeOffsetDist { get; set; } // Offset 0x10

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x14

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x18

    [JsonPropertyName("attackWaitSec_")]
    public float AttackWaitSec { get; set; } // Offset 0x1C

    public We2111ThunderBreakActionParam()
    {
    }

    public class Thunders
    {
        [JsonPropertyName("thunderWaitSec_")]
        public float ThunderWaitSec { get; set; } // Offset 0x8

        [JsonPropertyName("thunderNum_")]
        public int ThunderNum { get; set; } // Offset 0xC

        [JsonPropertyName("thunderDist_")]
        public float ThunderDist { get; set; } // Offset 0x10

        [JsonPropertyName("offsetAngle_")]
        public float OffsetAngle { get; set; } // Offset 0x14

        public Thunders()
        {
        }
    }
}

public class We2111StrikeActionParam
{
    [JsonPropertyName("shockwaveRadius_")]
    public float ShockwaveRadius { get; set; } // Offset 0x8

    [JsonPropertyName("strikeOffsetDist_")]
    public float StrikeOffsetDist { get; set; } // Offset 0xC

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x10

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x14

    [JsonPropertyName("attackWaitSec_")]
    public float AttackWaitSec { get; set; } // Offset 0x18

    public We2111StrikeActionParam()
    {
    }
}