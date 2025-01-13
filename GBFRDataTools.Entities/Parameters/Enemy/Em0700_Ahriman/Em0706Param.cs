using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0700_Ahriman;

public class Em0706Param : EmBossBaseParam
{
    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; }

    [JsonPropertyName("baseHeight_")]
    public float BaseHeight { get; set; } = 0f;

    [JsonPropertyName("meleeAttackHeight_")]
    public float MeleeAttackHeight { get; set; } = 0f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1.5f;

    [JsonPropertyName("fallGroundCheckStartHeight_")]
    public float FallGroundCheckStartHeight { get; set; } = 1f;

    [JsonPropertyName("flyCollisionParam_")]
    public CharaCollisionParam FlyCollisionParam { get; set; }

    [JsonPropertyName("overDriveHpRateAILv4_")]
    public Vector4 OverDriveHpRateAILv4 { get; set; } = new Vector4(0.25f, 0.15f, 0.25f, 0.15f);

    [JsonPropertyName("overDriveAnimRateAILv3_")]
    public Vector2 OverDriveAnimRateAILv3 { get; set; } = new Vector2(1f, 1.07f);

    [JsonPropertyName("overDriveAnimRateAILv4_")]
    public Vector2 OverDriveAnimRateAILv4 { get; set; } = new Vector2(1.07f, 1.1f);

    [JsonPropertyName("isIcePillarNeverDie_")]
    public bool IsIcePillarNeverDie { get; set; } = true;

    [JsonPropertyName("isIcePillarDamageCut_")]
    public bool IsIcePillarDamageCut { get; set; } = true;

    [JsonPropertyName("icePillarDamageCutRate_")]
    public float IcePillarDamageCutRate { get; set; } = 0.05f;

    [JsonPropertyName("checkWallLength_")]
    public float CheckWallLength { get; set; } = 3f;

    [JsonPropertyName("checkWallTargetDist_")]
    public float CheckWallTargetDist { get; set; } = 8f;

    [JsonPropertyName("checkWallDist_")]
    public float CheckWallDist { get; set; } = 9f;

    [JsonPropertyName("startPosFarDistLimit_")]
    public float StartPosFarDistLimit { get; set; } = 35f;

    [JsonPropertyName("checkCornerSec_")]
    public float CheckCornerSec { get; set; } = 10f;

    [JsonPropertyName("hitEyePosOffset_")]
    public Vector4 HitEyePosOffset { get; set; } = new Vector4(0f, 0f, 0.5f, 1f);

    [JsonPropertyName("hitEyeAreaDeg_")]
    public float HitEyeAreaDeg { get; set; } = 85f;

    [JsonPropertyName("hitEyeAreaHeightDeg_")]
    public float HitEyeAreaHeightDeg { get; set; } = 45f;

    [JsonPropertyName("hitIcePillarReactionFirst_")]
    public bool HitIcePillarReactionFirst { get; set; } = true;

    [JsonPropertyName("hitIcePillarReactionCountMax_")]
    public int HitIcePillarReactionCountMax { get; set; } = 3;

    [JsonPropertyName("hitIcePillarReactionBaseCount_")]
    public int HitIcePillarReactionBaseCount { get; set; } = 2;

    [JsonPropertyName("hitIcePillarReactionAddCount_")]
    public int HitIcePillarReactionAddCount { get; set; } = 1;

    [JsonPropertyName("laserNum_")]
    public int LaserNum { get; set; } = 3;

    [JsonPropertyName("laserSwingWideParam_")]
    public EmAhrimanBaseLaserParam LaserSwingWideParam { get; set; }

    [JsonPropertyName("laserSwingHeightParam_")]
    public EmAhrimanBaseLaserParam LaserSwingHeightParam { get; set; }

    [JsonPropertyName("laserSpinParam_")]
    public EmAhrimanBaseLaserParam LaserSpinParam { get; set; }

    [JsonPropertyName("laserHomingParam_")]
    public EmAhrimanBaseLaserParam LaserHomingParam { get; set; }

    [JsonPropertyName("tackleHomingAngle_")]
    public float TackleHomingAngle { get; set; } = 10f;

    [JsonPropertyName("tackleHomingRateMin_")]
    public float TackleHomingRateMin { get; set; } = 0.1f;

    [JsonPropertyName("tackleHomingRateMinLength_")]
    public float TackleHomingRateMinLength { get; set; } = 0.1f;

    [JsonPropertyName("tackleHomingRateMaxLength_")]
    public float TackleHomingRateMaxLength { get; set; } = 12f;

    [JsonPropertyName("tackleFrontWallAngle_")]
    public float TackleFrontWallAngle { get; set; } = 95f;

    [JsonPropertyName("tackleBodyTipOffset_")]
    public Vector4 TackleBodyTipOffset { get; set; } = new Vector4(0f, 2.5f, 3.5f, 1f);

    [JsonPropertyName("tackleFlyHeightGroundOffset_")]
    public float TackleFlyHeightGroundOffset { get; set; } = 0.6f;

    [JsonPropertyName("tackleFlyParam_")]
    public CharaFlyParam TackleFlyParam { get; set; }

    [JsonPropertyName("checkHitIcePillarFrontArea_")]
    public float CheckHitIcePillarFrontArea { get; set; } = 60f;

    [JsonPropertyName("attackSisnStartOffset_")]
    public Vector4 AttackSisnStartOffset { get; set; } = new Vector4(0f, 0f, 2f, 1f);

    [JsonPropertyName("attackSisnEndOffset_")]
    public Vector4 AttackSisnEndOffset { get; set; } = new Vector4(0f, -1.7f, 25f, 1f);

    [JsonPropertyName("attackSignDisplaySec_")]
    public float AttackSignDisplaySec { get; set; } = 0.05f;

    [JsonPropertyName("meleeHomingAngle_")]
    public float MeleeHomingAngle { get; set; } = 5f;

    [JsonPropertyName("meleeHomingRate_")]
    public float MeleeHomingRate { get; set; } = 1f;

    [JsonPropertyName("meleeMotionMoveRateXZ_")]
    public Vector4 MeleeMotionMoveRateXZ { get; set; } = new Vector4(1f, 1f, 1f, 1f);

    [JsonPropertyName("meleeMotionMoveRateY_")]
    public Vector4 MeleeMotionMoveRateY { get; set; } = new Vector4(1f, 1f, 1f, 1f);

    [JsonPropertyName("meleeMotionStartSec_")]
    public Vector4 MeleeMotionStartSec { get; set; } = new Vector4(0f, 0f, 0f, 1f);

    [JsonPropertyName("meleeMotionCancelSec_")]
    public Vector4 MeleeMotionCancelSec { get; set; } = new Vector4(1.3f, 1.3f, -1f, 1f);

    [JsonPropertyName("meleeIsNoHitEnd_")]
    public bool MeleeIsNoHitEnd { get; set; } = false;

    [JsonPropertyName("meleeIsChangeTarget_")]
    public bool MeleeIsChangeTarget { get; set; } = false;

    [JsonPropertyName("icePillarMotionMoveRateY_")]
    public float IcePillarMotionMoveRateY { get; set; } = 0.4f;

    [JsonPropertyName("icePillarActionHomingAngle_")]
    public float IcePillarActionHomingAngle { get; set; } = 10f;

    [JsonPropertyName("icePillarActionBackMoveLength_")]
    public float IcePillarActionBackMoveLength { get; set; } = 10f;

    [JsonPropertyName("icePillarActionBackMoveSec_")]
    public float IcePillarActionBackMoveSec { get; set; } = 1.5f;

    [JsonPropertyName("hugeIcePillarCreateRange_")]
    public Vector2 HugeIcePillarCreateRange { get; set; } = new Vector2(8f, 25f);

    [JsonPropertyName("hugeIcePillarGroundCheckHeight_")]
    public Vector2 HugeIcePillarGroundCheckHeight { get; set; } = new Vector2(2f, -30f);

    [JsonPropertyName("hugeIcePillarCheckWallLength_")]
    public float HugeIcePillarCheckWallLength { get; set; } = 9f;

    [JsonPropertyName("hugeIcePillarCheckWallOffsetY_")]
    public float HugeIcePillarCheckWallOffsetY { get; set; } = 1f;

    [JsonPropertyName("hugeIcePillarWallDistOffset_")]
    public float HugeIcePillarWallDistOffset { get; set; } = 2f;

    [JsonPropertyName("hugeIcePillarCheckWallMax_")]
    public int HugeIcePillarCheckWallMax { get; set; } = 6;

    [JsonPropertyName("icePillarNum_")]
    public int IcePillarNum { get; set; } = 4;

    [JsonPropertyName("icePillarRange_")]
    public Vector2 IcePillarRange { get; set; } = new Vector2(9f, 20f);

    [JsonPropertyName("icePillarPosRand_")]
    public float IcePillarPosRand { get; set; } = 1f;

    [JsonPropertyName("icePillarDisengageRange_")]
    public float IcePillarDisengageRange { get; set; } = 6f;

    [JsonPropertyName("icePillarFallTime_")]
    public float IcePillarFallTime { get; set; } = 0.1f;

    [JsonPropertyName("icePillarWallCheckDist_")]
    public float IcePillarWallCheckDist { get; set; } = 5f;

    [JsonPropertyName("icePillarCreateHeight_")]
    public float IcePillarCreateHeight { get; set; } = 20f;

    [JsonPropertyName("icePillarDamageRate_")]
    public float IcePillarDamageRate { get; set; } = 0.05f;

    [JsonPropertyName("icePillarHugeDamageRate_")]
    public float IcePillarHugeDamageRate { get; set; } = 0.03f;

    [JsonPropertyName("icePillarTriggerHpPerList_")]
    public BindingList<int> IcePillarTriggerHpPerList { get; set; } = []; // std::vector<int>

    [JsonPropertyName("waveOffsetLength_")]
    public float WaveOffsetLength { get; set; } = 3f;

    [JsonPropertyName("waveNum_")]
    public int WaveNum { get; set; } = 8;

    [JsonPropertyName("useWaveAiLevel_")]
    public int UseWaveAiLevel { get; set; } = 3;

    [JsonPropertyName("attackCoolTime_")]
    public float AttackCoolTime { get; set; } = 1f;

    [JsonPropertyName("meleeCoolTime_")]
    public Vector4 MeleeCoolTime { get; set; } = new Vector4(5f, 5f, 5f, 1f);

    [JsonPropertyName("swingLaserCoolTime_")]
    public Vector4 SwingLaserCoolTime { get; set; } = new Vector4(15f, 15f, 25f, 1f);

    [JsonPropertyName("stompCoolTime_")]
    public Vector4 StompCoolTime { get; set; } = new Vector4(35f, 35f, 60f, 1f);

    [JsonPropertyName("tackleCoolTime_")]
    public Vector4 TackleCoolTime { get; set; } = new Vector4(10f, 10f, 10f, 1f);

    [JsonPropertyName("summonCoolTime_")]
    public float SummonCoolTime { get; set; } = 35f;

    [JsonPropertyName("tailShotCoolTime_")]
    public Vector4 TailShotCoolTime { get; set; } = new Vector4(15f, 15f, 25f, 1f);

    [JsonPropertyName("stepCoolTime_")]
    public float StepCoolTime { get; set; } = 20f;

    [JsonPropertyName("homingLaserCoolTime_")]
    public Vector4 HomingLaserCoolTime { get; set; } = new Vector4(15f, 15f, 15f, 1f);

    [JsonPropertyName("defaultAttackCoolTime_")]
    public float DefaultAttackCoolTime { get; set; } = 30f;

    [JsonPropertyName("summonActionVoiceDelaySec_")]
    public float SummonActionVoiceDelaySec { get; set; } = 1f;

    [JsonPropertyName("openSummonAiLevel_")]
    public int OpenSummonAiLevel { get; set; } = 3;

    [JsonPropertyName("damageReactionGauge_")]
    public Em0706Param DamageReactionGauge { get; set; }

    [JsonPropertyName("heavyDamageReactionScale_")]
    public float HeavyDamageReactionScale { get; set; } = 3f;

    [JsonPropertyName("bodyHitBreakPowerRate_")]
    public float BodyHitBreakPowerRate { get; set; } = 0.7f;

    public Em0706Param()
    {
        Hp = 250000;
        Atk = 1000;
        Break = 8;
        Def = 1f;
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
        CombatPower = 65;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
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
        CameraLength = 4.5f;
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
}
