using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7600;

public class Em76a0Param : EnemyParameterInfo
{
    [JsonPropertyName("isUseStartPos_")]
    public bool IsUseStartPos { get; set; } = true;

    [JsonPropertyName("isLvHide_")]
    public bool IsLvHide { get; set; } = false;

    [JsonPropertyName("isAutoMoveByEaseOnly_")]
    public bool IsAutoMoveByEaseOnly { get; set; } = true;

    [JsonPropertyName("initAttackWaitTime_")]
    public float InitAttackWaitTime { get; set; } = 3f;

    [JsonPropertyName("defaultStartPos_")]
    public Vector4 DefaultStartPos { get; set; } = new Vector4(50f, 200.58f, 100f, 1f);

    [JsonPropertyName("lv_")]
    public int Lv { get; set; } = 100;

    [JsonPropertyName("lvByUltimate_")]
    public int LvByUltimate { get; set; } = 150;

    [JsonPropertyName("initHp_")]
    public int InitHp { get; set; } = 10000000;

    [JsonPropertyName("attackBasePow_")]
    public int AttackBasePow { get; set; } = 90000;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.1f;

    [JsonPropertyName("attackCounterInterval_")]
    public float AttackCounterInterval { get; set; } = 20f;

    [JsonPropertyName("enableHpRate_CounterAtk_")]
    public float EnableHpRate_CounterAtk { get; set; } = 0.7f;

    [JsonPropertyName("dpsCheckStartHpRate_")]
    public float DpsCheckStartHpRate { get; set; } = 0.5f;

    [JsonPropertyName("dpsCheckTime_")]
    public float DpsCheckTime { get; set; } = 60f;

    [JsonPropertyName("dpsCheckSuccessHpRate_")]
    public float DpsCheckSuccessHpRate { get; set; } = 0.4f;

    [JsonPropertyName("shootingModeStartHpRate_")]
    public float[] ShootingModeStartHpRate { get; set; } = new float[2]; // std::array<float,2>

    [JsonPropertyName("lastShootingModeStartHpRate_")]
    public float LastShootingModeStartHpRate { get; set; } = 0f;

    [JsonPropertyName("attackDisableTimeByShooting1stEnd_")]
    public float AttackDisableTimeByShooting1stEnd { get; set; } = 5f;

    [JsonPropertyName("attackDisableTimeByShooting2ndEnd_")]
    public float AttackDisableTimeByShooting2ndEnd { get; set; } = 1f;

    [JsonPropertyName("rno_")]
    public int[] Rno { get; set; } = new int[6]; // std::array<int,6>

    [JsonPropertyName("minDist_")]
    public float[] MinDist { get; set; } = new float[6]; // std::array<float,6>

    [JsonPropertyName("maxDist_")]
    public float[] MaxDist { get; set; } = new float[6]; // std::array<float,6>

    [JsonPropertyName("percent_")]
    public float[] Percent { get; set; } = new float[6]; // std::array<int,6>

    [JsonPropertyName("selectDisableTime_")]
    public float[] SelectDisableTime { get; set; } = new float[6]; // std::array<float,6>

    [JsonPropertyName("reactionStartRate_")]
    public float ReactionStartRate { get; set; } = 999999f;

    [JsonPropertyName("addReactionRateDisableTime_")]
    public float AddReactionRateDisableTime { get; set; } = 600f;

    [JsonPropertyName("bindTimeSec_")]
    public float BindTimeSec { get; set; } = 10f;

    [JsonPropertyName("firstMeleeDamageCutRate_")]
    public float FirstMeleeDamageCutRate { get; set; } = 0.5f;

    [JsonPropertyName("meleeAttackAdjustDist_")]
    public float MeleeAttackAdjustDist { get; set; } = 80f;

    [JsonPropertyName("counterComboIntervalSec_")]
    public float CounterComboIntervalSec { get; set; } = 30f;

    [JsonPropertyName("rushAttackBranchDist_")]
    public float RushAttackBranchDist { get; set; } = 200f;

    [JsonPropertyName("forceKillAttackCancelHpRate_")]
    public float ForceKillAttackCancelHpRate { get; set; } = 0.03f;

    [JsonPropertyName("forceKillAttackInterval_")]
    public float ForceKillAttackInterval { get; set; } = 7f;

    [JsonPropertyName("hyperRushHpTrigger_")]
    public BindingList<float> HyperRushHpTrigger { get; set; } = []; // std::array<float,2>

    [JsonPropertyName("isDrawhyperRushArea_")]
    public bool IsDrawhyperRushArea { get; set; } = false;

    [JsonPropertyName("hyperRushIntervalSec_")]
    public float HyperRushIntervalSec { get; set; } = 3f;

    [JsonPropertyName("hyperRushAtkWidth_")]
    public float HyperRushAtkWidth { get; set; } = 450f;

    [JsonPropertyName("bigEnergyBallHpTrigger_")]
    public float BigEnergyBallHpTrigger { get; set; } = 0.5f;

    [JsonPropertyName("bigEnergyBallEndHpTrigger_")]
    public float BigEnergyBallEndHpTrigger { get; set; } = 0.4f;

    [JsonPropertyName("bigEnergyBallStopEventStartInterval_")]
    public float BigEnergyBallStopEventStartInterval { get; set; } = 2f;

    [JsonPropertyName("bigEnergyBallSoundPos_")]
    public Vector4 BigEnergyBallSoundPos { get; set; } = new Vector4(0f, 1400f, 800f, 1f);

    [JsonPropertyName("fadeOutFrameByShootingEnd_")]
    public int FadeOutFrameByShootingEnd { get; set; } = 30;

    [JsonPropertyName("shootingAtkLimitList_")]
    public BindingList<ShootingAtkLimitParam> ShootingAtkLimitList { get; set; } = []; // std::vector<Em76a0Param::ShootingAtkLimitParam>

    [JsonPropertyName("lineLaserSetParam_")]
    public BindingList<LaserParamArray> LineLaserSetParam { get; set; } = []; // Em76a0Param::LaserParamArray

    [JsonPropertyName("showActionNameSecForceKillAttack_")]
    public float ShowActionNameSecForceKillAttack { get; set; } = 3f;

    [JsonPropertyName("showActionNameSecEnergyBallAttack_")]
    public float ShowActionNameSecEnergyBallAttack { get; set; } = 4f;

    [JsonPropertyName("showActionNameSecHyperRush_")]
    public float ShowActionNameSecHyperRush { get; set; } = 4.5f;

    [JsonPropertyName("showActionNameSecSynchrotron_")]
    public float ShowActionNameSecSynchrotron { get; set; } = 3f;

    [JsonPropertyName("showActionNameSecEventSceneBleath_")]
    public float ShowActionNameSecEventSceneBleath { get; set; } = 3.5f;

    public Em76a0Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 75;
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
        CombatPower = 50;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
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

    public class ShootingAtkLimitParam
    {
        [JsonPropertyName("nowRno_")]
        public int NowRno { get; set; }

        [JsonPropertyName("limitAtkRno_")]
        public BindingList<ShootingAtkLimitParam> LimitAtkRno { get; set; } = [];

        public ShootingAtkLimitParam()
        {
        }
    }

    public class LaserParam
    {
        [JsonPropertyName("pos_")]
        public Vector4 Pos { get; set; }

        [JsonPropertyName("rotZ_")]
        public float RotZ { get; set; }

        [JsonPropertyName("intervalSec_")]
        public float IntervalSec { get; set; }

        public LaserParam()
        {
        }
    }


    public class LaserParamArray
    {
        [JsonPropertyName("laserArray_")]
        public BindingList<LaserParam> LaserArray { get; set; } = [];

        [JsonPropertyName("useShootingPartNum_")]
        public int UseShootingPartNum { get; set; }

        public LaserParamArray()
        {
        }
    }

}