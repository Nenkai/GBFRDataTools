using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Parameters.Enemy.Em2200;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em2300;

public class Em2300Param : EmBossBaseParam
{
    [JsonPropertyName("aiLevelParams_")]
    [Editable(false)]
    public BindingList<Em2200AILevelParam> AiLevelParams { get; set; } = [.. Enumerable.Repeat(new Em2200AILevelParam(), 5)]; // std::array<Em2200AILevelParam,5>

    [JsonPropertyName("dragonAiLevelParams_")]
    [Editable(false)]
    public BindingList<AILevelParam> DragonAiLevelParams { get; set; } = [.. Enumerable.Repeat(new AILevelParam(), 5)]; // std::array<Em2300Param::AILevelParam,5>

    [JsonPropertyName("coolTime8stSpArtsOdAbility_")]
    public float CoolTime8stSpArtsOdAbility { get; set; } = 10f;

    [JsonPropertyName("dpsCheck8stSuccessRate_")]
    public int DpsCheck8stSuccessRate { get; set; } = 20;

    [JsonPropertyName("dpsCheck8stGainRate_")]
    public float DpsCheck8stGainRate { get; set; } = 2f;

    [JsonPropertyName("dpsCheck8stCoolTime_")]
    public float DpsCheck8stCoolTime { get; set; } = 0.5f;

    [JsonPropertyName("overDrive8stParam_")]
    public OverDriveParam OverDrive8stParam { get; set; }

    [JsonPropertyName("dragonComboRate_")]
    public int DragonComboRate { get; set; } = 100;

    [JsonPropertyName("dragonComboHomingSpeed_")]
    public float DragonComboHomingSpeed { get; set; } = 3f;

    [JsonPropertyName("dragonComboStartFrameThrust_")]
    public int DragonComboStartFrameThrust { get; set; } = 25;

    [JsonPropertyName("dragonComboStartFrameJump_")]
    public int DragonComboStartFrameJump { get; set; } = 60;

    [JsonPropertyName("dragonComboStartFrameSlash_")]
    public int DragonComboStartFrameSlash { get; set; } = 0;

    [JsonPropertyName("dragonComboStartFrameShot_")]
    public int DragonComboStartFrameShot { get; set; } = 5;

    [JsonPropertyName("dragonComboSelectRatioThrust_")]
    [Editable(false)]
    public BindingList<int> DragonComboSelectRatioThrust { get; set; } = [.. Enumerable.Repeat(0 ,2)]; // std::array<int,2>

    [JsonPropertyName("dragonComboSelectRatioSlash_")]
    [Editable(false)]
    public BindingList<int> DragonComboSelectRatioSlash { get; set; } = [.. Enumerable.Repeat(0 ,2)]; // std::array<int,2>

    [JsonPropertyName("dragonComboSelectRatioShot_")]
    [Editable(false)]
    public BindingList<int> DragonComboSelectRatioShot { get; set; } = [..Enumerable.Repeat(0, 2)]; // std::array<int,2>

    [JsonPropertyName("cqcAttackTurnRate_")]
    public float CqcAttackTurnRate { get; set; } = 8f;

    [JsonPropertyName("dragonShotAttackInitDegree_")]
    public float DragonShotAttackInitDegree { get; set; } = 45f;

    [JsonPropertyName("dragonShotAttackLastDegree_")]
    public float DragonShotAttackLastDegree { get; set; } = 1f;

    [JsonPropertyName("dragonShotAttackLastInterval_")]
    public float DragonShotAttackLastInterval { get; set; } = 2f;

    [JsonPropertyName("thWaySlashAttackWallWidth_")]
    public float ThWaySlashAttackWallWidth { get; set; } = 6f;

    [JsonPropertyName("thWaySlashAttackWallHeight_")]
    public float ThWaySlashAttackWallHeight { get; set; } = 7f;

    [JsonPropertyName("thWaySlashAttackWallDepth_")]
    public float ThWaySlashAttackWallDepth { get; set; } = 70f;

    [JsonPropertyName("roarAttackSpeed_")]
    public float RoarAttackSpeed { get; set; } = 700f;

    [JsonPropertyName("roarAttackLength_")]
    public float RoarAttackLength { get; set; } = 40f;

    [JsonPropertyName("roarAttackRadius_")]
    public float RoarAttackRadius { get; set; } = 0.5f;

    [JsonPropertyName("roarAttackOffsetZ_")]
    public float RoarAttackOffsetZ { get; set; } = 1.8f;

    [JsonPropertyName("roarAttackAdjustZ_")]
    public float RoarAttackAdjustZ { get; set; } = 0f;

    [JsonPropertyName("roarAttackRotX_")]
    public float RoarAttackRotX { get; set; } = 5f;

    [JsonPropertyName("roarAttackBeginRotY_")]
    public float RoarAttackBeginRotY { get; set; } = 60f;

    [JsonPropertyName("roarAttackEndRotY_")]
    public float RoarAttackEndRotY { get; set; } = -60f;

    [JsonPropertyName("roarAttackOdEndRotY_")]
    public float RoarAttackOdEndRotY { get; set; } = -120f;

    [JsonPropertyName("roarAttackExplodeWait_")]
    public float RoarAttackExplodeWait { get; set; } = 1.5f;

    [JsonPropertyName("roarAttackExplodeWidth_")]
    public float RoarAttackExplodeWidth { get; set; } = 5f;

    [JsonPropertyName("roarAttackExplodeDepth_")]
    public float RoarAttackExplodeDepth { get; set; } = 2f;

    [JsonPropertyName("rushThrustExplodeStartFrame_")]
    public int RushThrustExplodeStartFrame { get; set; } = 25;

    [JsonPropertyName("rushThrustExplodeEndFrame_")]
    public int RushThrustExplodeEndFrame { get; set; } = 5;

    [JsonPropertyName("rushJumpSlashCount_")]
    public int RushJumpSlashCount { get; set; } = 8;

    [JsonPropertyName("rushJumpSlashOffsetZ_")]
    public float RushJumpSlashOffsetZ { get; set; } = 2f;

    [JsonPropertyName("rushSlashOffsetRotZ_")]
    public float RushSlashOffsetRotZ { get; set; } = 10f;

    [JsonPropertyName("eachParam_")]
    public Em2200EachParam EachParam { get; set; }

    [JsonPropertyName("specialAttackParam_")]
    public Em2200SpecialAttackParam SpecialAttackParam { get; set; }

    [JsonPropertyName("odAbilityAttackParam_")]
    public Em2200OdAbilityAttackParam OdAbilityAttackParam { get; set; }

    [JsonPropertyName("ogiAttackTriggerHpRate1st_")]
    public int OgiAttackTriggerHpRate1st { get; set; } = 60;

    [JsonPropertyName("ogiAttackTriggerHpRate2nd_")]
    public int OgiAttackTriggerHpRate2nd { get; set; } = 20;

    [JsonPropertyName("ogiAttackTriggerHpRate8st_")]
    public int OgiAttackTriggerHpRate8st { get; set; } = 20;

    [JsonPropertyName("ogiAttackCollisionSize1st_")]
    public float OgiAttackCollisionSize1st { get; set; } = 35f;

    [JsonPropertyName("ogiAttackCollisionSize2nd_")]
    public float OgiAttackCollisionSize2nd { get; set; } = 35f;

    [JsonPropertyName("ogiAttackCollisionOffset_")]
    public float OgiAttackCollisionOffset { get; set; } = -18f;

    [JsonPropertyName("ogiAttackCollision6stOffset_")]
    public float OgiAttackCollision6stOffset { get; set; } = 15f;

    [JsonPropertyName("ogiAttackPillarBreakRadius_")]
    public float OgiAttackPillarBreakRadius { get; set; } = 10f;

    [JsonPropertyName("ogiAttackRushCycleCount_")]
    public int OgiAttackRushCycleCount { get; set; } = 2;

    [JsonPropertyName("ogiAttackStartCameraRotX_")]
    public float OgiAttackStartCameraRotX { get; set; } = 5f;

    [JsonPropertyName("ogiJumpPointNumber_")]
    public int OgiJumpPointNumber { get; set; } = 6;

    [JsonPropertyName("ogiJumpMainOffset_")]
    public float OgiJumpMainOffset { get; set; } = 1.2f;

    [JsonPropertyName("ogiJumpMainRange_")]
    [Editable(false)]
    public BindingList<float> OgiJumpMainRange { get; set; } = [..Enumerable.Repeat(0, 2)]; // std::array<float, 2>

    [JsonPropertyName("ogiJumpSlowRateSection_")]
    public BindingList<int> OgiJumpSlowRateSection { get; set; } = [.. Enumerable.Repeat(0, 2)]; // std::array<int, 2>

    [JsonPropertyName("ogiBarrageInitPointNumer_")]
    public int OgiBarrageInitPointNumer { get; set; } = 10;

    [JsonPropertyName("ogiBarrageInitOffsetZ_")]
    public float OgiBarrageInitOffsetZ { get; set; } = 1f;

    [JsonPropertyName("ogiBarrageBeginPointNumber_")]
    public int OgiBarrageBeginPointNumber { get; set; } = 10;

    [JsonPropertyName("ogiBarrageBeginOffsetY_")]
    public float OgiBarrageBeginOffsetY { get; set; } = 10f;

    [JsonPropertyName("ogiBarrageBeginOffsetR_")]
    public Vector4 OgiBarrageBeginOffsetR { get; set; } = new Vector4(0.1f, 0.1f, 0.1f, 0f);

    [JsonPropertyName("ogiBarrageBeginTime_")]
    public float OgiBarrageBeginTime { get; set; } = 1.3f;

    [JsonPropertyName("ogiBarrageDstPointNumber_")]
    public int OgiBarrageDstPointNumber { get; set; } = 20;

    [JsonPropertyName("ogiBarrageWaitTime_")]
    public float OgiBarrageWaitTime { get; set; } = 0.1f;

    [JsonPropertyName("ogiBarrageShootTime_")]
    public float OgiBarrageShootTime { get; set; } = 1.3f;

    [JsonPropertyName("ogiBarrageImpactSize_")]
    public float OgiBarrageImpactSize { get; set; } = 2f;

    [JsonPropertyName("ogiAttackRushTurnSpeed_")]
    public float OgiAttackRushTurnSpeed { get; set; } = 1f;

    [JsonPropertyName("ogiAttackRushTurnDistance_")]
    public float OgiAttackRushTurnDistance { get; set; } = 5f;

    [JsonPropertyName("ogiAttackRushTrackFreq_")]
    public int OgiAttackRushTrackFreq { get; set; } = 1;

    [JsonPropertyName("ogiAttackRushTrackDistRate_")]
    public float OgiAttackRushTrackDistRate { get; set; } = 0.5f;

    [JsonPropertyName("ogiAttackRushTrackDegree_")]
    public float OgiAttackRushTrackDegree { get; set; } = 35f;

    [JsonPropertyName("ogiAttackClawMarkPosMin_")]
    public float OgiAttackClawMarkPosMin { get; set; } = 0.3f;

    [JsonPropertyName("ogiAttackClawMarkPosMax_")]
    public float OgiAttackClawMarkPosMax { get; set; } = 0.8f;

    [JsonPropertyName("ogiAttackClawMarkLengthMin_")]
    public float OgiAttackClawMarkLengthMin { get; set; } = 5f;

    [JsonPropertyName("ogiAttackClawMarkLengthMax_")]
    public float OgiAttackClawMarkLengthMax { get; set; } = 7f;

    [JsonPropertyName("ogiAttackShotWaitTime_")]
    public float OgiAttackShotWaitTime { get; set; } = 2f;

    [JsonPropertyName("ogiAttackShotSpeed_")]
    public float OgiAttackShotSpeed { get; set; } = 50f;

    [JsonPropertyName("ogiAttackShotRadius_")]
    public float OgiAttackShotRadius { get; set; } = 0.8f;

    [JsonPropertyName("ogiAttackShotOffsetZ_")]
    public float OgiAttackShotOffsetZ { get; set; } = 0.8f;

    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    public Em2300Param()
    {
        Hp = 10000;
        Atk = 100;
        Break = 10;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 15;
        HateRateFarPlayer = 25;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
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
        CombatPower = 70;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 1000f;
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
        IsDisableAerialDownReaction = true;
        CameraLength = 0f;
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
    public class AILevelParam
    {
        [JsonPropertyName("barrageAttackDivisionCount_")]
        public int BarrageAttackDivisionCount { get; set; } // Offset 0x8

        [JsonPropertyName("barrageAttack2ndFlag_")]
        public int BarrageAttack2ndFlag { get; set; } // Offset 0xC

        [JsonPropertyName("barrageAttackBulletSpeed_")]
        public float BarrageAttackBulletSpeed { get; set; } // Offset 0x10

        [JsonPropertyName("dragonShotSpeed_")]
        public float DragonShotSpeed { get; set; } // Offset 0x14

        [JsonPropertyName("dragonShotCounts_")]
        public BindingList<int> DragonShotCounts { get; set; } = []; // std::array<int,3>

        [JsonPropertyName("thWaySlashAttackSignTime_")]
        public float ThWaySlashAttackSignTime { get; set; } // Offset 0x18

        [JsonPropertyName("roarAttackCoolTime_")]
        public float RoarAttackCoolTime { get; set; } // Offset 0x1C

        [JsonPropertyName("roarAttackReadyTime_")]
        public float RoarAttackReadyTime { get; set; } // Offset 0x20

        [JsonPropertyName("roarAttackTurnRound_")]
        public int RoarAttackTurnRound { get; set; } // Offset 0x24

        [JsonPropertyName("roarAttackExplodeLength_")]
        public float RoarAttackExplodeLength { get; set; } // Offset 0x28

        [JsonPropertyName("roarAttackExplodeRangeType_")]
        public int RoarAttackExplodeRangeType { get; set; } // Offset 0x2C

        [JsonPropertyName("rushThrustExplodeFlag_")]
        public int RushThrustExplodeFlag { get; set; } // Offset 0x30

        [JsonPropertyName("rushJumpSlashFlag_")]
        public int RushJumpSlashFlag { get; set; } // Offset 0x34

        [JsonPropertyName("shotAttackDisableFlag_")]
        public int ShotAttackDisableFlag { get; set; } // Offset 0x38

        [JsonPropertyName("odRushChainDisableFlag_")]
        public int OdRushChainDisableFlag { get; set; } // Offset 0x3C

        [JsonPropertyName("odRushChainAlwaysFlag_")]
        public int OdRushChainAlwaysFlag { get; set; } // Offset 0x40

        [JsonPropertyName("ogiBarrageBulletCount_")]
        public int OgiBarrageBulletCount { get; set; } // Offset 0x44

        [JsonPropertyName("ogiBarrageBulletSpeed_")]
        public float OgiBarrageBulletSpeed { get; set; } // Offset 0x48

        [JsonPropertyName("ogiAttackJumpMainType_")]
        public int OgiAttackJumpMainType { get; set; } // Offset 0x4C

        [JsonPropertyName("ogiAttackRushCountFirst_")]
        public int OgiAttackRushCountFirst { get; set; } // Offset 0x50

        [JsonPropertyName("ogiAttackRushCountSecond_")]
        public int OgiAttackRushCountSecond { get; set; } // Offset 0x54

        [JsonPropertyName("ogiAttackRushClawMarkCount_")]
        public int OgiAttackRushClawMarkCount { get; set; } // Offset 0x58

        [JsonPropertyName("ogiAttackRushMoveSpeed_")]
        public float OgiAttackRushMoveSpeed { get; set; } // Offset 0x5C

        [JsonPropertyName("ogiAttackRushEnableClaw_")]
        public bool OgiAttackRushEnableClaw { get; set; } // Offset 0x60

        [JsonPropertyName("ogiJumpSlowRate_")]
        public float OgiJumpSlowRate { get; set; } // Offset 0x64

        public AILevelParam()
        {
        }
    }
}