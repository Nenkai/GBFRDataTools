using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Base;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.Json.Serialization;

using static GBFRDataTools.Entities.Parameters.Enemy.Em7600.Em76a0Param;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7300;

public class Em7300Param : EmBossBaseParam
{
    [JsonPropertyName("lockOnParamPower_")]
    public EmLockOnParam LockOnParamPower { get; set; }

    [JsonPropertyName("collisionParamPower_")]
    public CharaCollisionParam CollisionParamPower { get; set; }

    [JsonPropertyName("addDamageParamSpeed_")]
    public EmAddDamageParam AddDamageParamSpeed { get; set; }

    [JsonPropertyName("addDamageParamPower_")]
    public EmAddDamageParam AddDamageParamPower { get; set; }

    [JsonPropertyName("powerDamageCutRate_")]
    public float PowerDamageCutRate { get; set; } = 0.4f;

    [JsonPropertyName("powerDamageUpBuffRate_")]
    public float PowerDamageUpBuffRate { get; set; } = 0.2f;

    [JsonPropertyName("waitActionCount_")]
    [Editable(false)]
    public BindingList<int> WaitActionCount { get; set; } = [..Enumerable.Repeat(0, 4)];

    [JsonPropertyName("timeline0_")]
    public int Timeline0 { get; set; } = 80;

    [JsonPropertyName("timeline1_")]
    public int Timeline1 { get; set; } = 65;

    [JsonPropertyName("timeline2_")]
    public int Timeline2 { get; set; } = 60;

    [JsonPropertyName("timeline3_")]
    public int Timeline3 { get; set; } = 40;

    [JsonPropertyName("timeline4_")]
    public int Timeline4 { get; set; } = 25;

    [JsonPropertyName("timeline5_")]
    public int Timeline5 { get; set; } = 0;

    [JsonPropertyName("timeline6_")]
    public int Timeline6 { get; set; } = 20;

    [JsonPropertyName("timeline7_")]
    public int Timeline7 { get; set; } = 0;

    [JsonPropertyName("overDrive1stRate_")]
    public Vector4 OverDrive1stRate { get; set; } = new Vector4(1f, 1f, 1f, 1.05f);

    [JsonPropertyName("overDrive2ndRate_")]
    public Vector4 OverDrive2ndRate { get; set; } = new Vector4(1f, 1f, 1.05f, 1.05f);

    [JsonPropertyName("overDrive3rdRate_")]
    public Vector4 OverDrive3rdRate { get; set; } = new Vector4(1f, 1.05f, 1.05f, 1.05f);

    [JsonPropertyName("iceBlockSizeScale_")]
    public float IceBlockSizeScale { get; set; } = 2f;

    [JsonPropertyName("iceBlockSizeHeight_")]
    public float IceBlockSizeHeight { get; set; } = 4f;

    [JsonPropertyName("iceBlockSizeRadius_")]
    public float IceBlockSizeRadius { get; set; } = 2f;

    [JsonPropertyName("iceBlockRadius_")]
    public Vector2 IceBlockRadius { get; set; } = new Vector2(17.5f, 35f);

    [JsonPropertyName("iceBlockBeginAngle_")]
    public Vector2 IceBlockBeginAngle { get; set; } = new Vector2(45f, 22.5f);

    [JsonPropertyName("iceBlockAngle_")]
    public Vector2 IceBlockAngle { get; set; } = new Vector2(90f, 45f);

    [JsonPropertyName("spArtsIceBlockRadius_")]
    public Vector2 SpArtsIceBlockRadius { get; set; } = new Vector2(12.5f, 25f);

    [JsonPropertyName("spArtsIceBlockBeginAngle_")]
    public Vector2 SpArtsIceBlockBeginAngle { get; set; } = new Vector2(60f, 105f);

    [JsonPropertyName("spArtsIceBlockAngle_")]
    public Vector2 SpArtsIceBlockAngle { get; set; } = new Vector2(120f, 120f);

    [JsonPropertyName("iceBlockAppearDelayTime_")]
    public Vector2 IceBlockAppearDelayTime { get; set; } = new Vector2(0f, 0.5f);

    [JsonPropertyName("iceBlockBreakDownTime_")]
    public float IceBlockBreakDownTime { get; set; } = 0.25f;

    [JsonPropertyName("iceBlockTerminateWaitTime_")]
    public float IceBlockTerminateWaitTime { get; set; } = 3f;

    [JsonPropertyName("iceBlockTerminateAlphaTime_")]
    public float IceBlockTerminateAlphaTime { get; set; } = 1f;

    [JsonPropertyName("manastepFrontLRAngle_")]
    public float ManastepFrontLRAngle { get; set; } = 45f;

    [JsonPropertyName("coolTimeFangAttack_")]
    public Vector4 CoolTimeFangAttack { get; set; } = new Vector4(20f, 10f, 0f, 0f);

    [JsonPropertyName("coolTimeHugeIceBlock_")]
    public Vector4 CoolTimeHugeIceBlock { get; set; } = new Vector4(90f, 180f, 240f, 300f);

    [JsonPropertyName("coolTimeDoubleSlash_")]
    public Vector2 CoolTimeDoubleSlash { get; set; } = new Vector2(20f, 5f);

    [JsonPropertyName("coolTimeTurnTail_")]
    public Vector2 CoolTimeTurnTail { get; set; } = new Vector2(30f, 20f);

    [JsonPropertyName("coolTimeSomersaultTail_")]
    public Vector2 CoolTimeSomersaultTail { get; set; } = new Vector2(40f, 30f);

    [JsonPropertyName("coolTimeMoonsaultHorn_")]
    public Vector2 CoolTimeMoonsaultHorn { get; set; } = new Vector2(25f, 0f);

    [JsonPropertyName("coolTimeIceAndLaser_")]
    public Vector2 CoolTimeIceAndLaser { get; set; } = new Vector2(50f, 15f);

    [JsonPropertyName("coolTimeSpeedCounter_")]
    public Vector2 CoolTimeSpeedCounter { get; set; } = new Vector2(30f, 30f);

    [JsonPropertyName("coolTimeCleaveLaser_")]
    public Vector2 CoolTimeCleaveLaser { get; set; } = new Vector2(60f, 60f);

    [JsonPropertyName("coolTimeTurnShovel_")]
    public Vector2 CoolTimeTurnShovel { get; set; } = new Vector2(20f, 20f);

    [JsonPropertyName("coolTimeIceDrop_")]
    public Vector2 CoolTimeIceDrop { get; set; } = new Vector2(35f, 35f);

    [JsonPropertyName("coolTimeNarrowDust_")]
    public Vector2 CoolTimeNarrowDust { get; set; } = new Vector2(50f, 50f);

    [JsonPropertyName("coolTimePowerCounter_")]
    public Vector2 CoolTimePowerCounter { get; set; } = new Vector2(30f, 30f);

    [JsonPropertyName("coolTimeDiamondDust_")]
    public Vector2 CoolTimeDiamondDust { get; set; } = new Vector2(60f, 60f);

    [JsonPropertyName("turnTailSmokeOffset1_")]
    public Vector3 TurnTailSmokeOffset1 { get; set; } = new Vector3(0f, 0f, -13f);

    [JsonPropertyName("turnTailSmokeOffset2_")]
    public Vector3 TurnTailSmokeOffset2 { get; set; } = new Vector3(9f, 0f, -9f);

    [JsonPropertyName("turnTailSmokeOffset3_")]
    public Vector3 TurnTailSmokeOffset3 { get; set; } = new Vector3(13f, 0f, 0f);

    [JsonPropertyName("turnTailSmokeRotY_")]
    public Vector3 TurnTailSmokeRotY { get; set; } = new Vector3(90f, 45f, 0f);

    [JsonPropertyName("iciclesDanceStartAngle_")]
    public float IciclesDanceStartAngle { get; set; } = 110f;

    [JsonPropertyName("iciclesDanceRangeAngle_")]
    public float IciclesDanceRangeAngle { get; set; } = 280f;

    [JsonPropertyName("iciclesDanceNum_")]
    [Editable(false)]
    public BindingList<int> IciclesDanceNum { get; set; } = [.. Enumerable.Repeat(0, 4)];

    [JsonPropertyName("iciclesDanceOffset_")]
    public Vector4 IciclesDanceOffset { get; set; } = new Vector4(0f, 1.5f, 6.5f, 1f);

    [JsonPropertyName("sweptLaserParam_")]
    public LaserParam SweptLaserParam { get; set; }

    [JsonPropertyName("verticalLaserParam_")]
    public LaserParam VerticalLaserParam { get; set; }

    [JsonPropertyName("scoopingNum_")]
    [Editable(false)]
    public BindingList<int> ScoopingNum { get; set; } = [.. Enumerable.Repeat(0, 4)];

    [JsonPropertyName("scoopingPosOffset_")]
    public Vector4 ScoopingPosOffset { get; set; } = new Vector4(0f, 0f, 5f, 1f);

    [JsonPropertyName("scoopingPosRand_")]
    public float ScoopingPosRand { get; set; } = 2f;

    [JsonPropertyName("scoopingRotOffset_")]
    public Vector2 ScoopingRotOffset { get; set; } = new Vector2(-18f, 10f);

    [JsonPropertyName("scoopingRotRandX_")]
    public float ScoopingRotRandX { get; set; } = 2f;

    [JsonPropertyName("scoopingRotRandY_")]
    public Vector4 ScoopingRotRandY { get; set; } = new Vector4(15f, 15f, 15f, 15f);

    [JsonPropertyName("iceDropPosOffset_")]
    public Vector4 IceDropPosOffset { get; set; } = new Vector4(0f, 0f, 3f, 1f);

    [JsonPropertyName("iceDropAngleRotX_")]
    public float IceDropAngleRotX { get; set; } = -60f;

    [JsonPropertyName("iceDropSplashHeight_")]
    public float IceDropSplashHeight { get; set; } = 30f;

    [JsonPropertyName("iceDropSplashNum_")]
    [Editable(false)]
    public BindingList<int> IceDropSplashNum { get; set; } = [.. Enumerable.Repeat(0, 4)];

    [JsonPropertyName("iceDropSplashDistMin_")]
    public float IceDropSplashDistMin { get; set; } = 3f;

    [JsonPropertyName("iceDropSplashDistMax_")]
    public Vector4 IceDropSplashDistMax { get; set; } = new Vector4(21f, 21f, 25f, 25f);

    [JsonPropertyName("iceDropSplashAddDist_")]
    public float IceDropSplashAddDist { get; set; } = 8f;

    [JsonPropertyName("iceDropSplashWaitTimeMax_")]
    public float IceDropSplashWaitTimeMax { get; set; } = 0.5f;

    [JsonPropertyName("iceDropSplashPlNonOverlapDist_")]
    public float IceDropSplashPlNonOverlapDist { get; set; } = 5f;

    [JsonPropertyName("groundWaveAttackRate_")]
    public float GroundWaveAttackRate { get; set; } = 0.9f;

    [JsonPropertyName("groundWaveHeight_")]
    public float GroundWaveHeight { get; set; } = 1f;

    [JsonPropertyName("groundWaveRadius_")]
    public Vector2 GroundWaveRadius { get; set; } = new Vector2(5f, 30f);

    [JsonPropertyName("groundWaveTime_")]
    public Vector2 GroundWaveTime { get; set; } = new Vector2(3.5f, 1.45f);

    [JsonPropertyName("diamondDustEndRadius_")]
    public float DiamondDustEndRadius { get; set; } = 50f;

    [JsonPropertyName("diamondDustWidht_")]
    public float DiamondDustWidht { get; set; } = 5f;

    [JsonPropertyName("diamondDustScaleTime_")]
    public float DiamondDustScaleTime { get; set; } = 0.8f;

    [JsonPropertyName("diamondDusSpeedCurve_")]
    public GuiImportableCurve<float> DiamondDusSpeedCurve { get; set; }

    [JsonPropertyName("odPowerArtsIcePosOffset_")]
    public Vector4 OdPowerArtsIcePosOffset { get; set; } = new Vector4(0f, 0f, 10f, 1f);

    [JsonPropertyName("odPowerArtsFrontDist_")]
    public float OdPowerArtsFrontDist { get; set; } = 6f;

    [JsonPropertyName("odPowerArtsMinDist_")]
    public float OdPowerArtsMinDist { get; set; } = 2f;

    [JsonPropertyName("odPowerArtsFragFallDist_")]
    public float OdPowerArtsFragFallDist { get; set; } = 10f;

    [JsonPropertyName("odPowerArtsFragFallAngle_")]
    public float OdPowerArtsFragFallAngle { get; set; } = 45f;

    [JsonPropertyName("powerOdAbilityParam_")]
    public OdAbilityParam PowerOdAbilityParam { get; set; }

    [JsonPropertyName("blizzardAreaRadius_")]
    public float BlizzardAreaRadius { get; set; } = 32.5f;

    [JsonPropertyName("blizzardAreaSpeed_")]
    public float BlizzardAreaSpeed { get; set; } = 0f;

    [JsonPropertyName("blizzardAreaSpeedScale_")]
    public float BlizzardAreaSpeedScale { get; set; } = 0.5f;

    [JsonPropertyName("stageCenterPos_")]
    public Vector4 StageCenterPos { get; set; } = new Vector4(770f, 97f, 141.4f, 1f);

    [JsonPropertyName("stageCornerDist_")]
    public float StageCornerDist { get; set; } = 32f;

    [JsonPropertyName("typeChangeCameraBone_")]
    public int TypeChangeCameraBone { get; set; } = -1;

    [JsonPropertyName("typeChangeCameraTime_")]
    public float TypeChangeCameraTime { get; set; } = 4f;

    [JsonPropertyName("typeChangeCameraRotSpeed_")]
    public float TypeChangeCameraRotSpeed { get; set; } = 5f;

    [JsonPropertyName("textId_speedFinish_")]
    public string TextId_speedFinish { get; set; }

    [JsonPropertyName("textId_powerFinish_")]
    public string TextId_powerFinish { get; set; }

    [JsonPropertyName("textId_speedOdArts_")]
    public string TextId_speedOdArts { get; set; }

    [JsonPropertyName("textId_powerOdArts_")]
    public string TextId_powerOdArts { get; set; }

    [JsonPropertyName("textId_spArts_")]
    public string TextId_spArts { get; set; }

    [JsonPropertyName("textId_spArtsFinish_")]
    public string TextId_spArtsFinish { get; set; }

    [JsonPropertyName("fangHpPercent_")]
    public Vector4 FangHpPercent { get; set; } = new Vector4(0.5f, 0.5f, 0.75f, 0.75f);

    [JsonPropertyName("fangShowHpGaugeDistance_")]
    public float FangShowHpGaugeDistance { get; set; } = 15f;

    [JsonPropertyName("fangIdleMotionRate_")]
    public float FangIdleMotionRate { get; set; } = 2f;

    [JsonPropertyName("fangDeadHitStop_")]
    public int FangDeadHitStop { get; set; } = 5;

    [JsonPropertyName("fangInnerOffset_")]
    public Vector4 FangInnerOffset { get; set; } = new Vector4(3f, 8f, 2f, 1f);

    [JsonPropertyName("fangOuterOffset_")]
    public Vector4 FangOuterOffset { get; set; } = new Vector4(8f, 2f, -2f, 1f);

    [JsonPropertyName("fangStockInnerOffset_")]
    public Vector4 FangStockInnerOffset { get; set; } = new Vector4(0.5f, 9f, 0f, 1f);

    [JsonPropertyName("fangStockOuterOffset_")]
    public Vector4 FangStockOuterOffset { get; set; } = new Vector4(1.5f, 9.2f, 0f, 1f);

    [JsonPropertyName("fangLaserPosLength_")]
    public Vector4 FangLaserPosLength { get; set; } = new Vector4(8f, 10f, 9f, 1f);

    [JsonPropertyName("fangLaserAngle_")]
    public Vector4 FangLaserAngle { get; set; } = new Vector4(15f, 0f, -10f, 1f);

    [JsonPropertyName("fangLaserAddY_")]
    public Vector4 FangLaserAddY { get; set; } = new Vector4(3f, 5f, 1f, 1f);

    [JsonPropertyName("fangLaserShotOffset_")]
    public Vector4 FangLaserShotOffset { get; set; } = new Vector4(4f, 0f, -4f, 1f);

    [JsonPropertyName("fangLaserMultipleAddPosLength_")]
    public float FangLaserMultipleAddPosLength { get; set; } = 0f;

    [JsonPropertyName("fangLaserMultipleAddAngle_")]
    public float FangLaserMultipleAddAngle { get; set; } = -20f;

    [JsonPropertyName("fangLaserMultipleAddAddY_")]
    public float FangLaserMultipleAddAddY { get; set; } = 0f;

    [JsonPropertyName("fangChargeLaserHeight_")]
    public float FangChargeLaserHeight { get; set; } = 8f;

    [JsonPropertyName("fangIdle_SpeedMax_")]
    public float FangIdle_SpeedMax { get; set; } = 20f;

    [JsonPropertyName("fangIdle_SpeedMin_")]
    public float FangIdle_SpeedMin { get; set; } = 1f;

    [JsonPropertyName("fangIdle_SpeedAdd_")]
    public float FangIdle_SpeedAdd { get; set; } = 1f;

    [JsonPropertyName("fangIdle_SpeedSub_")]
    public float FangIdle_SpeedSub { get; set; } = 0.65f;

    [JsonPropertyName("fangIdle_BorderDist")]
    public float FangIdle_BorderDist { get; set; } = 5f;

    [JsonPropertyName("fangIdle_StopDist_")]
    public float FangIdle_StopDist { get; set; } = 0.5f;

    [JsonPropertyName("mainStoryDemoHpLimitPer_")]
    public float MainStoryDemoHpLimitPer { get; set; } = 80f;

    [JsonPropertyName("neckCtrlParamPower_")]
    public EmNeckCtrlParam NeckCtrlParamPower { get; set; }

    public Em7300Param()
    {
        Hp = 450000;
        Atk = 1000;
        Break = 10;
        Def = 0f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 25;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 25;
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
        IsEnableSyncWeaponAnim = false;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
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
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class LaserParam
    {
        [JsonPropertyName("maxLength_")]
        public float MaxLength { get; set; } // Offset 0x8

        [JsonPropertyName("speed_")]
        public float Speed { get; set; } // Offset 0xC

        [JsonPropertyName("attackRate_")]
        public float AttackRate { get; set; } // Offset 0x10

        [JsonPropertyName("breakRate_")]
        public float BreakRate { get; set; } // Offset 0x14

        [JsonPropertyName("attackRadius_")]
        public float AttackRadius { get; set; } // Offset 0x18

        [JsonPropertyName("bgHitRadius_")]
        public float BgHitRadius { get; set; } // Offset 0x1C

        [JsonPropertyName("bgHitAddY_")]
        public float BgHitAddY { get; set; } // Offset 0x20

        [JsonPropertyName("rootAttackRadius_")]
        public float RootAttackRadius { get; set; } // Offset 0x24

        [JsonPropertyName("hitUpdateTime_")]
        public float HitUpdateTime { get; set; } // Offset 0x28

        public LaserParam()
        {
        }
    }
}