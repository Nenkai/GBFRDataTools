using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Parameters.Enemy.Em7000;

namespace GBFRDataTools.Entities.Parameters.Weapon.We7000;

public class We7002Param : EnemyParameterInfo
{
    [JsonPropertyName("aiLevelParams_")]
    public AILevelParam[] AiLevelParams { get; set; } = new AILevelParam[5];

    [JsonPropertyName("iceShotActionParam_")]
    public We7002IceShotActionParam IceShotActionParam { get; set; }

    [JsonPropertyName("iceShotStrongActionParam_")]
    public We7002IceShotActionParam IceShotStrongActionParam { get; set; }

    [JsonPropertyName("ragnarokBuffIceShotActionParam_")]
    public We7002IceShotActionParam RagnarokBuffIceShotActionParam { get; set; }

    [JsonPropertyName("ragnarokBuffIceShotStrongActionParam_")]
    public We7002IceShotActionParam RagnarokBuffIceShotStrongActionParam { get; set; }

    public We7002Param()
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
        CombatPower = 30;
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

public class We7002IceBulletParam
{
    [JsonPropertyName("dispAttackSignSec_")]
    public float DispAttackSignSec { get; set; } // Offset 0x8

    [JsonPropertyName("shotSpeed_")]
    public float ShotSpeed { get; set; } // Offset 0xC

    public We7002IceBulletParam()
    {
    }
}


public class We7002IceShotActionParam
{
    [JsonPropertyName("iceBulletParam_")]
    public We7002IceBulletParam IceBulletParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("shotPosList_")]
    public Em7001PositionListParam ShotPosList { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("shotWaitIntervalSec_")]
    public float ShotWaitIntervalSec { get; set; } // Offset 0x38

    public We7002IceShotActionParam()
    {
    }
}