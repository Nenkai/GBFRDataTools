using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0500_Crocodile;

public class Em0502Param : EmCrocodileBaseParam
{
    [JsonPropertyName("burnTime_")]
    public float BurnTime { get; set; } = 15f;

    [JsonPropertyName("magmaMaxCount_")]
    public int MagmaMaxCount { get; set; } = 30;

    [JsonPropertyName("magmaSpawnNonOverlapDist_")]
    public float MagmaSpawnNonOverlapDist { get; set; } = 5.5f;

    [JsonPropertyName("magmaPoolDestroyOverlapDist_")]
    public float MagmaPoolDestroyOverlapDist { get; set; } = 3f;

    [JsonPropertyName("magmaSplashDist_")]
    public float MagmaSplashDist { get; set; } = 5f;

    [JsonPropertyName("magmaManageCheckDist_")]
    public float MagmaManageCheckDist { get; set; } = 25f;

    [JsonPropertyName("magmaManageCheckCount_")]
    public int MagmaManageCheckCount { get; set; } = 2;

    [JsonPropertyName("magmaManageCoolTime_")]
    public Vector2 MagmaManageCoolTime { get; set; } = new Vector2(60f, 0f);

    [JsonPropertyName("magmaManageCoolTimeReset_")]
    public Vector4 MagmaManageCoolTimeReset { get; set; } = new Vector4(5f, 10f, 100f, 100f);

    [JsonPropertyName("magmaTargetRushPushUp_")]
    public Vector2 MagmaTargetRushPushUp { get; set; } = new Vector2(45f, 50f);

    [JsonPropertyName("magmaTargetRushUpAddDist_")]
    public float MagmaTargetRushUpAddDist { get; set; } = 2f;

    [JsonPropertyName("magmaTargetBite_")]
    public Vector2 MagmaTargetBite { get; set; } = new Vector2(30f, 25f);

    [JsonPropertyName("discreteGayserAddLength_")]
    public float DiscreteGayserAddLength { get; set; } = 50f;

    [JsonPropertyName("discreteGayserInitLength_")]
    public Vector2 DiscreteGayserInitLength { get; set; } = new Vector2(20f, 30f);

    [JsonPropertyName("discreteGayserLineMax_")]
    public int DiscreteGayserLineMax { get; set; } = 1;

    [JsonPropertyName("magmaVomitAngle_")]
    public float MagmaVomitAngle { get; set; } = 140f;

    [JsonPropertyName("magmaVomitDistMinMax_")]
    public Vector2 MagmaVomitDistMinMax { get; set; } = new Vector2(10f, 25f);

    [JsonPropertyName("magmaVomitAddDist_")]
    public float MagmaVomitAddDist { get; set; } = 7f;

    [JsonPropertyName("magmaWaveSpreadAngle_")]
    public float MagmaWaveSpreadAngle { get; set; } = 60f;

    [JsonPropertyName("magmaShovelAngle_")]
    public float MagmaShovelAngle { get; set; } = 120f;

    [JsonPropertyName("magmaShovelDistMinMax_")]
    public Vector2 MagmaShovelDistMinMax { get; set; } = new Vector2(15f, 25f);

    [JsonPropertyName("slamMagmaBaseOffset_")]
    public Vector4 SlamMagmaBaseOffset { get; set; } = new Vector4(2f, 0f, 3.8f, 1f);

    [JsonPropertyName("slamMagmaPlTargetWidth_")]
    public Vector2 SlamMagmaPlTargetWidth { get; set; } = new Vector2(3f, 10f);

    [JsonPropertyName("slamMagmaPlTargetAngle_")]
    public float SlamMagmaPlTargetAngle { get; set; } = 120f;

    [JsonPropertyName("slamMagmaRotY_")]
    public Vector3 SlamMagmaRotY { get; set; } = new Vector3(0f, 80f, -80f);

    [JsonPropertyName("slamMagmaRotYRandWidth_")]
    public float SlamMagmaRotYRandWidth { get; set; } = 10f;

    [JsonPropertyName("slamMagmaDistWidth_")]
    public Vector2 SlamMagmaDistWidth { get; set; } = new Vector2(4f, 7f);

    [JsonPropertyName("rollingFeverMaxLv")]
    public int RollingFeverMaxLv { get; set; } = 3;

    [JsonPropertyName("rollingFeverSizeScale_")]
    public Vector2 RollingFeverSizeScale { get; set; } = new Vector2(1f, 0.02f);

    [JsonPropertyName("rollingFeverSpeedScale_")]
    public Vector2 RollingFeverSpeedScale { get; set; } = new Vector2(0.7f, 0.2f);

    [JsonPropertyName("rollingFeverDamageScale_")]
    public Vector2 RollingFeverDamageScale { get; set; } = new Vector2(2.5f, 0.25f);

    [JsonPropertyName("redHotRevivalMagmaRange_")]
    public float RedHotRevivalMagmaRange { get; set; } = 3.5f;

    public Em0502Param()
    {
        Hp = 250000;
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
        EmissiveInitValue = 0.1f;
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
        HighVoltageRushCount = 1;
        SpreadShotAngle = 30f;
        GayserRadialDivRot = 45f;
        GayserAddLength = 12f;
        GayserInitLength = new Vector2(10f, 20f);
        GayserNoSetLengthEm0500 = 7f;
        GayserNoSetLengthGayser = 10f;
        GayserNoSetLengthInitPos = 6f;
        GayserRandPos = 3f;
        GayserLineMax = 3;
        GayserInitDelayTime = new Vector2(0f, 1f);
        GayserInitDelayDistance = new Vector2(0f, 100f);
        GayserRockHp = 1;
        GayserRockBreak = 30;
        RockCrushNum = 12;
        RockCrushRange = new Vector2(15f, 35f);
        RockCrushPosRand = 0.5f;
        RockCrushDisengageRange = 5f;
        RockCrushTime = new Vector2(1.6f, 2.1f);
        RollingAnimBlendAnglePerRate = 1.5f;
        RollingAnimBlendAddRate = 0.05f;
        RollingEffectRate = 0.5f;
        TutorialStunGauge = 1000f;
        TutorialHpLimit = new Vector4(0.9f, 0.7f, 0.4f, 1f);
        TutorialNoMoveAction = 0.45f;
    }
}
