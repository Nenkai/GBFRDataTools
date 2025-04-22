using GBFRDataTools.Entities.Parameters.Base;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7500;

public class Em75a0Param : EnemyParameterInfo
{
    [JsonPropertyName("isUseStartPos_")]
    public bool IsUseStartPos { get; set; } = true;

    [JsonPropertyName("isAutoMoveByEaseOnly_")]
    public bool IsAutoMoveByEaseOnly { get; set; } = true;

    [JsonPropertyName("initAttackWaitTime_")]
    public float InitAttackWaitTime { get; set; } = 7f;

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0.2f;

    [JsonPropertyName("autoMoveDistLimit_")]
    public float AutoMoveDistLimit { get; set; } = 80f;

    [JsonPropertyName("defaultStartPos_")]
    public Vector4 DefaultStartPos { get; set; } = new Vector4(0f, 240f, 60f, 1f);

    [JsonPropertyName("lv_")]
    public int Lv { get; set; } = 40;

    [JsonPropertyName("lvByUltimate_")]
    public int LvByUltimate { get; set; } = 115;

    [JsonPropertyName("initHp_")]
    public int InitHp { get; set; } = 750000;

    [JsonPropertyName("attackBasePow_")]
    public int AttackBasePow { get; set; } = 15000;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f;

    [JsonPropertyName("attackCounterInterval_")]
    public float AttackCounterInterval { get; set; } = 20f;

    [JsonPropertyName("enableHpRate_CounterAtk_")]
    public float EnableHpRate_CounterAtk { get; set; } = 0.75f;

    [JsonPropertyName("laserChargeTime_")]
    public float LaserChargeTime { get; set; } = 2.5f;

    [JsonPropertyName("laserAttackTime_")]
    public float LaserAttackTime { get; set; } = 0.7f;

    [JsonPropertyName("laserTurnStopTime_")]
    public float LaserTurnStopTime { get; set; } = 3f;

    [JsonPropertyName("laserTurnStopDelay_")]
    public float LaserTurnStopDelay { get; set; } = 3f;

    [JsonPropertyName("counterLaserTurnStopTime_")]
    public float CounterLaserTurnStopTime { get; set; } = 2f;

    [JsonPropertyName("counterLaserTurnStopDelay_")]
    public float CounterLaserTurnStopDelay { get; set; } = 2.5f;

    [JsonPropertyName("counterHpTrigger_")]
    public BindingList<float> CounterHpTrigger { get; set; } = [..Enumerable.Repeat(0, 2)];

    [JsonPropertyName("motParam_Laser_")]
    public MotNameParam MotParam_Laser { get; set; }

    [JsonPropertyName("barrierHpRate_")]
    public float BarrierHpRate { get; set; } = 8f;

    [JsonPropertyName("barrierHpTrigger_")]
    [Editable(false)]
    public BindingList<float> BarrierHpTrigger { get; set; } = [.. Enumerable.Repeat(0, 2)];

    [JsonPropertyName("rno_")]
    [Editable(false)]
    public BindingList<int> Rno { get; set; } = [.. Enumerable.Repeat(0, 5)];

    [JsonPropertyName("minDist_")]
    [Editable(false)]
    public BindingList<float> MinDist { get; set; } = [.. Enumerable.Repeat(0, 5)];

    [JsonPropertyName("maxDist_")]
    [Editable(false)]
    public BindingList<float> MaxDist { get; set; } = [.. Enumerable.Repeat(0, 5)];

    [JsonPropertyName("percent_")]
    [Editable(false)]
    public BindingList<int> Percent { get; set; } = [.. Enumerable.Repeat(0, 5)];

    [JsonPropertyName("selectDisableTime_")]
    [Editable(false)]
    public BindingList<float> SelectDisableTime { get; set; } = [.. Enumerable.Repeat(0, 5)];

    [JsonPropertyName("afterWaitTime_")]
    [Editable(false)]
    public BindingList<float> AfterWaitTime { get; set; } = [.. Enumerable.Repeat(0, 5)];

    [JsonPropertyName("dmgBlowSpeed_")]
    public float DmgBlowSpeed { get; set; } = 1.5f;

    [JsonPropertyName("dmgBlowStopRate_")]
    public float DmgBlowStopRate { get; set; } = 0.98f;

    public Em75a0Param()
    {
        Hp = 6000;
        Atk = 3000;
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
        IsDisableAerialDownReaction = false;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MotNameParam
    {
        [JsonPropertyName("motName01_")]
        public string MotName01 { get; set; } // Offset 0x8

        [JsonPropertyName("motName02_")]
        public string MotName02 { get; set; } // Offset 0x18

        [JsonPropertyName("motName03_")]
        public string MotName03 { get; set; } // Offset 0x28

        public MotNameParam()
        {
        }
    }
}