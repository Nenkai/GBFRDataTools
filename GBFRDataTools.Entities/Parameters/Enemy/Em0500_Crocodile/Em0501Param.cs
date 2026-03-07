using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0500_Crocodile;

public class Em0501Param : EmCrocodileBaseParam
{
    [JsonPropertyName("rockCrushNumArmor_")]
    public int RockCrushNumArmor { get; set; } = 12;

    [JsonPropertyName("iceArmorBreakValue_")]
    public int IceArmorBreakValue { get; set; } = 150;

    [JsonPropertyName("iceArmorDamageRate_")]
    public float IceArmorDamageRate { get; set; } = 0.8f;

    [JsonPropertyName("iceArmorFrozenTime_")]
    public float IceArmorFrozenTime { get; set; } = 30f;

    [JsonPropertyName("iceArmorReactionDamageRush_")]
    public Vector4 IceArmorReactionDamageRush { get; set; } = new Vector4(15f, 5f, 5f, 3f);

    [JsonPropertyName("iceArmorReactionDamageRushHigh_")]
    public Vector4 IceArmorReactionDamageRushHigh { get; set; } = new Vector4(20f, 10f, 10f, 5f);

    [JsonPropertyName("iceArmorReactionDamageRolling_")]
    public Vector4 IceArmorReactionDamageRolling { get; set; } = new Vector4(10f, 10f, 10f, 10f);

    [JsonPropertyName("iciclesCount_")]
    public int IciclesCount { get; set; } = 3;

    [JsonPropertyName("iciclesCountBoost_")]
    public int IciclesCountBoost { get; set; } = 6;

    [JsonPropertyName("iciclesAddDistance_")]
    public float IciclesAddDistance { get; set; } = 5f;

    [JsonPropertyName("iciclesDistanceClamp_")]
    public Vector2 IciclesDistanceClamp { get; set; } = new Vector2(15f, 25f);

    [JsonPropertyName("iciclesAngleMax_")]
    public float IciclesAngleMax { get; set; } = 10f;

    [JsonPropertyName("iciclesRandomWidth_")]
    public Vector2 IciclesRandomWidth { get; set; } = new Vector2(5f, 7f);

    [JsonPropertyName("iceBallScatterBone_")]
    public int IceBallScatterBone { get; set; } = 773;

    [JsonPropertyName("iceBallScatterHeight_")]
    public Vector2 IceBallScatterHeight { get; set; } = new Vector2(-1f, 0f);

    [JsonPropertyName("iceBallScatterRotX_")]
    public Vector2 IceBallScatterRotX { get; set; } = new Vector2(1f, 2f);

    [JsonPropertyName("iceBallScatterAngle_")]
    public Vector2 IceBallScatterAngle { get; set; } = new Vector2(25f, 30f);

    public Em0501Param()
    {
        Hp = 150000;
        Atk = 1000;
        Break = 8;
        Def = 0f;
        Endurance = 1;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 0;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 15;
        HateRateFarPlayerPerSec = 25;
        HateRateFrontAngle = 0;
        HateRateBackAngle = 5;
        HateRateDamage = 55;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 5;
        HateUpdateTime = 5f;
        DamageToHateRate = 0.2f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 65;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 0.75f;
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
        IsCallExplodeBodyPresageDefaultVfx = false;
        IsDisableAerialDownReaction = true;
        CameraLength = 0f;
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
        PartsBreakHp = new Vector3(1500f, 1200f, 1200f);
        HighVoltageRushAtkRate = new Vector2(2.5f, 2.5f);
        HighVoltagePushUpAtkRate = new Vector2(3f, 3f);
        RollingFinalRushAtkRate = new Vector2(3.5f, 3.5f);
        AddMotionRate = 1f;
        StrongAnimInterpSec = 0.4166667f;
        OverDriveAnimRateAILv3_4 = new Vector2(1.05f, 1.1f);
        OverDriveHpRateAILv3_4 = new Vector4(0.25f, 0.15f, 0.25f, 0.15f);
        OverDriveHpRateTutorial = new Vector4(0.1f, 0.3f, 0.2f, 0.3f);
        CoolTimeMeleeCombo = new Vector2(1f, 1f);
        CoolTimeMeleeComboOD = new Vector2(60f, 60f);
        CoolTimeMeleeComboTutorial = new Vector2(60f, 30f);
        CoolTimeBite = new Vector2(30f, 30f);
        CoolTimeShot = new Vector2(25f, 25f);
        CoolTimeVacuumBite = new Vector2(22f, 22f);
        CoolTimeRushPushUp = new Vector2(18f, 0f);
        CoolTimeRushPushUpTutorial = new Vector2(18f, 18f);
        CoolTimeWatching = new Vector2(60f, 0f);
        CoolTimeJumpRush = new Vector2(45f, 45f);
        EntanglePlNum = 3;
        SlamCheckCount = 5;
        HighVoltageRushCount = 2;
        SpreadShotAngle = 30f;
        GayserRadialDivRot = 60f;
        GayserAddLength = 30f;
        GayserInitLength = new Vector2(30f, 30f);
        GayserNoSetLengthEm0500 = 0f;
        GayserNoSetLengthGayser = 0f;
        GayserNoSetLengthInitPos = 6f;
        GayserRandPos = 2f;
        GayserLineMax = 1;
        GayserInitDelayTime = new Vector2(0f, 1f);
        GayserInitDelayDistance = new Vector2(0f, 100f);
        GayserRockHp = 3;
        GayserRockBreak = 20;
        RockCrushNum = 5;
        RockCrushRange = new Vector2(15f, 35f);
        RockCrushPosRand = 0.5f;
        RockCrushDisengageRange = 5f;
        RockCrushTime = new Vector2(1f, 2.1f);
        RollingAnimBlendAnglePerRate = 1.5f;
        RollingAnimBlendAddRate = 0.05f;
        RollingEffectRate = 0.5f;
        TutorialStunGauge = 1000f;
        TutorialHpLimit = new Vector4(0.9f, 0.7f, 0.4f, 1f);
        TutorialNoMoveAction = 0.45f;
    }
}
