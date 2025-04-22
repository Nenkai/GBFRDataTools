using GBFRDataTools.Entities.Parameters.Base;

using System.ComponentModel;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7200;

public class Em7200Param : EmBossBaseParam
{
    [JsonPropertyName("partsBody_")]
    public PartsParam PartsBody { get; set; }

    [JsonPropertyName("partsHead_")]
    public PartsParam PartsHead { get; set; }

    [JsonPropertyName("partsArmR_")]
    public PartsParam PartsArmR { get; set; }

    [JsonPropertyName("partsArmL_")]
    public PartsParam PartsArmL { get; set; }

    [JsonPropertyName("partsWaist_")]
    public PartsParam PartsWaist { get; set; }

    [JsonPropertyName("partsLegFR_")]
    public PartsParam PartsLegFR { get; set; }

    [JsonPropertyName("partsLegFL_")]
    public PartsParam PartsLegFL { get; set; }

    [JsonPropertyName("partsLegBR_")]
    public PartsParam PartsLegBR { get; set; }

    [JsonPropertyName("partsLegBL_")]
    public PartsParam PartsLegBL { get; set; }

    [JsonPropertyName("downPartsCount_")]
    public int DownPartsCount { get; set; } = 4;

    [JsonPropertyName("aiLevelPartsDamageRate_")]
    public float AiLevelPartsDamageRate { get; set; } = 0.17f;

    [JsonPropertyName("stunDamageRate")]
    public float StunDamageRate { get; set; } = 1.5f;

    [JsonPropertyName("isOKSpArtsHpRate_")]
    public float IsOKSpArtsHpRate { get; set; } = 0.6f;

    [JsonPropertyName("limitHpRate_")]
    public float LimitHpRate { get; set; } = 0.4f;

    [JsonPropertyName("swordStormCoolTime_")]
    public float SwordStormCoolTime { get; set; } = 30f;

    [JsonPropertyName("recoverArmorTime_")]
    public float RecoverArmorTime { get; set; } = 180f;

    [JsonPropertyName("galeActionTime_")]
    public float GaleActionTime { get; set; } = 25f;

    [JsonPropertyName("stationaryStormTime_")]
    public float StationaryStormTime { get; set; } = 60f;

    [JsonPropertyName("causeODAbilityFirstTime_")]
    public float CauseODAbilityFirstTime { get; set; } = 0f;

    [JsonPropertyName("causeODAbilityNotFirstTime_")]
    public float CauseODAbilityNotFirstTime { get; set; } = 120f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 0.2f;

    public Em7200Param()
    {
        Hp = 500000;
        Atk = 320;
        Break = 10;
        Def = 0f;
        Endurance = 10;
        Exp = 10;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 15;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 35;
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
        CombatPower = 100;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 1f;
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
        IsEnableSyncWeaponAnim = true;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = true;
        CameraLength = 4f;
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
    public class PartsParam
    {
        [JsonPropertyName("armor_")]
        public int Armor { get; set; } // Offset 0x8

        public PartsParam()
        {
        }
    }
}