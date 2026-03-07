using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Weapon.We2100;

public class We2110Param : SuperiorWeaponParam
{
    [JsonPropertyName("shotActionParam_")]
    public We2110ShotActionParam ShotActionParam { get; set; }

    [JsonPropertyName("strongShotParam_")]
    public We2110StrongShotParam StrongShotParam { get; set; }

    [JsonPropertyName("spArtsShotParam_")]
    public We2110StrongShotParam SpArtsShotParam { get; set; }

    [JsonPropertyName("spArtsFinishShotParam_")]
    public We2110StrongShotParam SpArtsFinishShotParam { get; set; }

    [JsonPropertyName("aiLevelParams_")]
    public AILevelParam[] AiLevelParams { get; set; } = new AILevelParam[5];

    [JsonPropertyName("laserAttackRadius_")]
    public float LaserAttackRadius { get; set; } = 0.05f;

    public We2110Param()
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
        [JsonPropertyName("attackIntervalSec_")]
        public float AttackIntervalSec { get; set; } // Offset 0x8

        [JsonPropertyName("enableRedAction_")]
        public bool EnableRedAction { get; set; } // Offset 0xC

        [JsonPropertyName("redActionIntervalSec_")]
        public float RedActionIntervalSec { get; set; } // Offset 0x10

        public AILevelParam()
        {
        }
    }
}

public class We2110ShotActionParam
{
    [JsonPropertyName("nearShotChargeSec_")]
    public float NearShotChargeSec { get; set; } // Offset 0x8

    [JsonPropertyName("farShotChargeSec_")]
    public float FarShotChargeSec { get; set; } // Offset 0xC

    [JsonPropertyName("waitShotSec_")]
    public float WaitShotSec { get; set; } // Offset 0x10

    [JsonPropertyName("nearShotAttackFlashWaitSec_")]
    public float NearShotAttackFlashWaitSec { get; set; } // Offset 0x14

    [JsonPropertyName("farShotAttackFlashWaitSec_")]
    public float FarShotAttackFlashWaitSec { get; set; } // Offset 0x18

    public We2110ShotActionParam()
    {
    }
}

public class We2110StrongShotParam
{
    [JsonPropertyName("chargeSec_")]
    public float ChargeSec { get; set; } // Offset 0x8

    [JsonPropertyName("aimSec_")]
    public float AimSec { get; set; } // Offset 0xC

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } // Offset 0x10

    [JsonPropertyName("bulletLength_")]
    public float BulletLength { get; set; } // Offset 0x14

    [JsonPropertyName("waitFireSec_")]
    public float WaitFireSec { get; set; } // Offset 0x1C

    [JsonPropertyName("shotAfterWaitSec_")]
    public float ShotAfterWaitSec { get; set; } // Offset 0x18

    [JsonPropertyName("ricohetList_")]
    public BindingList<We2110Ricochet> RicohetList { get; set; } = []; // Offset 0x30

    [JsonPropertyName("targetOffsetZ_")]
    public float TargetOffsetZ { get; set; } // Offset 0x20

    [JsonPropertyName("attackFlashWaitSec_")]
    public float AttackFlashWaitSec { get; set; } // Offset 0x24

    [JsonPropertyName("isFirstAimPlayer_")]
    public bool IsFirstAimPlayer { get; set; } // Offset 0x28

    [JsonPropertyName("isLastAimPlayer_")]
    public bool IsLastAimPlayer { get; set; } // Offset 0x29

    [JsonPropertyName("offsetType_")]
    public int OffsetType { get; set; } // Offset 0x2C

    public We2110StrongShotParam()
    {
    }

    public class We2110ShotLocation
    {
        [JsonPropertyName("location_")]
        public Vector4 Location { get; set; } // Offset 0x10

        public We2110ShotLocation()
        {
        }
    }

    public class We2110Ricochet
    {
        [JsonPropertyName("locations_")]
        public BindingList<We2110ShotLocation> Locations { get; set; } = []; // Offset 0x8

        public We2110Ricochet()
        {
        }
    }
}



