using System.ComponentModel;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7200;

public class Em7201Param : EmBossBaseParam
{
    [JsonPropertyName("partsParam_")]
    public PartsParam PartsParam_ { get; set; }

    [JsonPropertyName("selfMoveStormTime_")]
    public float SelfMoveStormTime { get; set; } = 60f;

    [JsonPropertyName("whirlWindTime_")]
    public float WhirlWindTime { get; set; } = 20f;

    [JsonPropertyName("furyBlade_")]
    public float FuryBlade { get; set; } = 60f;

    [JsonPropertyName("tripleBlade_")]
    public float TripleBlade { get; set; } = 25f;

    [JsonPropertyName("galeToOutsideTime_")]
    public float GaleToOutsideTime { get; set; } = 30f;

    [JsonPropertyName("galeToSelfTime_")]
    public float GaleToSelfTime { get; set; } = 30f;

    [JsonPropertyName("aimPLStormTime_")]
    public float AimPLStormTime { get; set; } = 20f;

    [JsonPropertyName("spinCutTime_")]
    public float SpinCutTime { get; set; } = 25f;

    [JsonPropertyName("stepTime_")]
    public float StepTime { get; set; } = 10f;

    [JsonPropertyName("causeODAbilityFirstTime_")]
    public float CauseODAbilityFirstTime { get; set; } = 0f;

    [JsonPropertyName("causeODAbilityNotFirstTime_")]
    public float CauseODAbilityNotFirstTime { get; set; } = 120f;

    [JsonPropertyName("recoverArmorTime_")]
    public float RecoverArmorTime { get; set; } = 180f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 0.2f;

    [JsonPropertyName("isOKSpArtsHpRate_")]
    public float IsOKSpArtsHpRate { get; set; } = 0.1f;

    [JsonPropertyName("nihiraPushStormTime_")]
    public float NihiraPushStormTime { get; set; } = 60f;

    [JsonPropertyName("nihiraEventHpRate_")]
    public float NihiraEventHpRate { get; set; } = 0.1f;

    public Em7201Param()
    {
        Hp = 500000;
        Atk = 320;
        Break = 10;
        Def = 1f;
        Endurance = 10;
        Exp = 10;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 20;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 10;
        HateRateBackAngle = 20;
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
        CameraLength = 4.5f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0f;
        OdAttackRateFirstTime = 1.2f;
        OdDefenseRateFirstTime = 0.7f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PartsParam
    {
        [JsonPropertyName("frontArmorHp_")]
        public int FrontArmorHp { get; set; } // Offset 0x8

        [JsonPropertyName("backArmorHp_")]
        public int BackArmorHp { get; set; } // Offset 0xC

        [JsonPropertyName("rightArmHp_")]
        public int RightArmHp { get; set; } // Offset 0x10

        [JsonPropertyName("leftArmHp_")]
        public int LeftArmHp { get; set; } // Offset 0x14

        [JsonPropertyName("headArmHp_")]
        public int HeadArmHp { get; set; } // Offset 0x18

        [JsonPropertyName("downPartsCount_")]
        public int DownPartsCount { get; set; } // Offset 0x1C

        [JsonPropertyName("aiLevelPartsDamageRate_")]
        public float AiLevelPartsDamageRate { get; set; } // Offset 0x20

    }
}