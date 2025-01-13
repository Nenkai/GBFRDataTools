using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Weapon.We2100;

public class We2112Param : SuperiorWeaponParam
{
    [JsonPropertyName("healActionParam_")]
    public We2112HealActionParam HealActionParam { get; set; }

    [JsonPropertyName("damageAreaActionParam_")]
    public We2112DamageAreaActionParam DamageAreaActionParam { get; set; }

    [JsonPropertyName("spArtsFinishActionParam_")]
    public We2112DamageAreaActionParam SpArtsFinishActionParam { get; set; }

    [JsonPropertyName("aiLevelParams_")]
    public AILevelParam[] AiLevelParams { get; set; } = new AILevelParam[5];

    [JsonPropertyName("damageAreaAttackAddSize_")]
    public float DamageAreaAttackAddSize { get; set; } = -0.5f;

    public We2112Param()
    {
        Hp = 2000;
        Atk = 10;
        Break = 10;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 0;
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
        [JsonPropertyName("healIntervalSec_")]
        public float HealIntervalSec { get; set; } // Offset 0x8

        [JsonPropertyName("healChargeSec_")]
        public float HealChargeSec { get; set; } // Offset 0xC

        [JsonPropertyName("damageAreaCount_")]
        public int DamageAreaCount { get; set; } // Offset 0x10

        public AILevelParam()
        {
        }
    }
}




public class We2112HealActionParam
{
    [JsonPropertyName("healAmount_")]
    public int HealAmount { get; set; } // Offset 0x8

    [JsonPropertyName("healWaitSec_")]
    public float HealWaitSec { get; set; } // Offset 0xC

    public We2112HealActionParam()
    {
    }
}


public class We2112DamageAreaLocationParam
{
    [JsonPropertyName("locationsList_")]
    public BindingList<Locations> LocationsList { get; set; } = []; // Offset 0x8

    public We2112DamageAreaLocationParam()
    {
    }

    public class Locations
    {
        [JsonPropertyName("locations_")]
        public BindingList<Vector4> Locations_ { get; set; } = []; // Offset 0x8

        public Locations()
        {
        }
    }
}

public class We2112DamageAreaActionParam
{
    [JsonPropertyName("radius_")]
    public float Radius { get; set; } // Offset 0xC

    [JsonPropertyName("damageAreaRadius_")]
    public float DamageAreaRadius { get; set; } // Offset 0x8

    [JsonPropertyName("chargeSec_")]
    public float ChargeSec { get; set; } // Offset 0x10

    [JsonPropertyName("attackSec_")]
    public float AttackSec { get; set; } // Offset 0x14

    [JsonPropertyName("offsetType_")]
    public int OffsetType { get; set; } // Offset 0x18

    [JsonPropertyName("isLocationParam_")]
    public bool IsLocationParam { get; set; } // Offset 0x1C

    [JsonPropertyName("location_")]
    public We2112DamageAreaActionParam Location { get; set; } // Offset 0xCF543FFA

    public We2112DamageAreaActionParam()
    {
    }
}