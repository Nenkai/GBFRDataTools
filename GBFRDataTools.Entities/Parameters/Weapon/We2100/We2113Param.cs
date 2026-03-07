using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Weapon.We2100;

public class We2113Param : SuperiorWeaponParam
{
    [JsonPropertyName("comboActionParam_")]
    public We2113ComboActionParam ComboActionParam { get; set; }

    [JsonPropertyName("stabActionParam_")]
    public We2113StabActionParam StabActionParam { get; set; }

    [JsonPropertyName("rushActionParam_")]
    public We2113RushActionParam RushActionParam { get; set; }

    [JsonPropertyName("spArtsFinishParam_")]
    public We2113RushComboActionParam SpArtsFinishParam { get; set; }

    [JsonPropertyName("weaponOwnerAttackHateRate_")]
    public float WeaponOwnerAttackHateRate { get; set; } = 100f;

    [JsonPropertyName("weaponOwnerAttackHateCloseRange_")]
    public float WeaponOwnerAttackHateCloseRange { get; set; } = 0f;

    [JsonPropertyName("weaponOwnerAttackHateFarRange_")]
    public float WeaponOwnerAttackHateFarRange { get; set; } = 20f;

    [JsonPropertyName("aiLevelParams_")]
    public AILevelParam[] AiLevelParams { get; set; } = new AILevelParam[5];

    public We2113Param()
    {
        Hp = 2500;
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
        [JsonPropertyName("attackIntervalSec_")]
        public float AttackIntervalSec { get; set; } // Offset 0x8

        public AILevelParam()
        {
        }
    }
}

public class We2113RushComboActionParam
{
    [JsonPropertyName("moveParam_")]
    public SuperiorWeMoveParam MoveParam { get; set; } // Offset 0xCF543FFA

    public We2113RushComboActionParam()
    {
    }
}


public class We2113ComboActionParam
{
    [JsonPropertyName("canAttackDist_")]
    public float CanAttackDist { get; set; } // Offset 0x8

    [JsonPropertyName("maxMoveRateZ_")]
    public float MaxMoveRateZ { get; set; } // Offset 0xC

    public We2113ComboActionParam()
    {
    }
}


public class We2113StabActionParam
{
    [JsonPropertyName("waitStabSec_")]
    public float WaitStabSec { get; set; } // Offset 0x10

    [JsonPropertyName("stabGroundSec_")]
    public float StabGroundSec { get; set; } // Offset 0x14

    [JsonPropertyName("stabSpeed_")]
    public float StabSpeed { get; set; } // Offset 0x18

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x1C

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x20

    [JsonPropertyName("groundAdjustRotXSec_")]
    public float GroundAdjustRotXSec { get; set; } // Offset 0x24

    [JsonPropertyName("groundedOffset_")]
    public Vector4 GroundedOffset { get; set; } // Offset 0x30

    public We2113StabActionParam()
    {
    }
}


public class We2113RushActionParam
{
    [JsonPropertyName("rushWaitSec_")]
    public float RushWaitSec { get; set; } // Offset 0x8

    [JsonPropertyName("rushDistMin_")]
    public float RushDistMin { get; set; } // Offset 0xC

    [JsonPropertyName("rushDistMax_")]
    public float RushDistMax { get; set; } // Offset 0x10

    [JsonPropertyName("rushSpeed_")]
    public float RushSpeed { get; set; } // Offset 0x14

    [JsonPropertyName("rushEndDist_")]
    public float RushEndDist { get; set; } // Offset 0x18

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x1C

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x20

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } // Offset 0x24

    [JsonPropertyName("turnSpeedRotY_")]
    public float TurnSpeedRotY { get; set; } // Offset 0x28

    [JsonPropertyName("rushStopSec_")]
    public float RushStopSec { get; set; } // Offset 0x2C

    [JsonPropertyName("rushStopAnimWaitSec_")]
    public float RushStopAnimWaitSec { get; set; } // Offset 0x30

    [JsonPropertyName("rushStopAnimInterSec_")]
    public float RushStopAnimInterSec { get; set; } // Offset 0x34

    public We2113RushActionParam()
    {
    }
}
