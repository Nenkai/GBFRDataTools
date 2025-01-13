using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Parameters.Weapon.We2100;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em2100;

public class Em2100Param : EmBossBaseParam
{
    [JsonPropertyName("weaponGuardRate_")]
    public float WeaponGuardRate { get; set; } = 0f;

    [JsonPropertyName("wearSowrdKnockBackRate_")]
    public float WearSowrdKnockBackRate { get; set; } = 0.13f;

    [JsonPropertyName("wearSowrdStopSlowTimer_")]
    public int WearSowrdStopSlowTimer { get; set; } = 10;

    [JsonPropertyName("barrierBreakHitStopSec_")]
    public float BarrierBreakHitStopSec { get; set; } = 0.7f;

    [JsonPropertyName("animRateOD_")]
    public float AnimRateOD { get; set; } = 1.2f;

    [JsonPropertyName("runAwaySec_")]
    public float RunAwaySec { get; set; } = 15f;

    [JsonPropertyName("phaseParam_")]
    public PhaseParam[] PhaseParam_ { get; set; } = new PhaseParam[3]; // std::array<Em2100Param::PhaseParam,3>

    [JsonPropertyName("aiLevelParams_")]
    public AILevelParam[] AiLevelParams { get; set; } = new AILevelParam[5]; // std::array<Em2100Param::AILevelParam,5>

    [JsonPropertyName("aiParam_")]
    public AIParam AiParam { get; set; }

    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("flyActionParam_")]
    public Em2100FlyActionParam FlyActionParam { get; set; }

    [JsonPropertyName("wearAttackActionParam_")]
    public Em2100WearAttackActionParam WearAttackActionParam { get; set; }

    [JsonPropertyName("superiorWeaponRecoveryActionParam_")]
    public Em2100SuperiorWeaponRecoveryActionParam SuperiorWeaponRecoveryActionParam { get; set; }

    [JsonPropertyName("odAbilityActionParam_")]
    public Em2100ODAbilityActionParam OdAbilityActionParam { get; set; }

    [JsonPropertyName("spArtsActionParam_")]
    public Em2100SpArtsActionParam SpArtsActionParam { get; set; }

    [JsonPropertyName("arrowRainVirticalParam_")]
    public Em2100ArrowRainVirticalParam ArrowRainVirticalParam { get; set; }

    [JsonPropertyName("arrowRainAreaParam_")]
    public Em2100ArrowRainAreaParam ArrowRainAreaParam { get; set; }

    [JsonPropertyName("we2100Param_")]
    public We2100Param We2100Param { get; set; }

    [JsonPropertyName("eyeCtrlParam_")]
    public EyeControlParam EyeCtrlParam { get; set; }

    [JsonPropertyName("donutVfxDefaultSpeed_")]
    public float DonutVfxDefaultSpeed { get; set; } = 6.58f;

    [JsonPropertyName("donutAdjustParams_")]
    public BindingList<SwordAttackAdjustParam> DonutAdjustParams { get; set; } = [];

    [JsonPropertyName("guillotineAdjustParams_")]
    public BindingList<SwordAttackAdjustParam> GuillotineAdjustParams { get; set; } = [];

    [JsonPropertyName("wearSwordHpFate_")]
    public int WearSwordHpFate { get; set; } = 110;

    [JsonPropertyName("wearSwordHpPl2300FateEpisode_")]
    public int WearSwordHpPl2300FateEpisode { get; set; } = 35;

    [JsonPropertyName("combatPower6st_")]
    public int CombatPower6st { get; set; } = 50;

    [JsonPropertyName("hateLessCombatPower_")]
    public float HateLessCombatPower { get; set; } = 50f;

    [JsonPropertyName("hatePinch_")]
    public float HatePinch { get; set; } = 1000f;

    [JsonPropertyName("spArtsHpRate6st_")]
    public int SpArtsHpRate6st { get; set; } = 50;

    [JsonPropertyName("hpRate6stMemberDie_")]
    public float HpRate6stMemberDie { get; set; } = 0.8f;

    [JsonPropertyName("odBlockMoveSpeed7st_")]
    public float OdBlockMoveSpeed7st { get; set; } = 15f;

    [JsonPropertyName("odBlockMoveEaseParam7st_")]
    public Em2100Param OdBlockMoveEaseParam7st { get; set; }

    [JsonPropertyName("odBlockArrowRainNum_")]
    public int OdBlockArrowRainNum { get; set; } = 6;

    [JsonPropertyName("odBlockArrowRainICenterIndex_")]
    public int OdBlockArrowRainICenterIndex { get; set; } = 2;

    [JsonPropertyName("odBlockArrowRainScale_")]
    public float OdBlockArrowRainScale { get; set; } = 2.5f;

    [JsonPropertyName("odBlockArrowRainOffset_")]
    public Vector4 OdBlockArrowRainOffset { get; set; } = new Vector4(-22f, -2.5f, 15f, 1f);

    [JsonPropertyName("odBlockArrowRainRotY_")]
    public float OdBlockArrowRainRotY { get; set; } = 1.570796f;

    [JsonPropertyName("odBlockArrowRainIntervalRate_")]
    public float OdBlockArrowRainIntervalRate { get; set; } = 1.25f;

    [JsonPropertyName("odBlockArrowRainRandomWaitSec_")]
    public float OdBlockArrowRainRandomWaitSec { get; set; } = 0.1f;

    [JsonPropertyName("odBlockArrowRainRandomRate_")]
    public float OdBlockArrowRainRandomRate { get; set; } = 0.2f;

    [JsonPropertyName("odBlockArrowRainAnimBeginRemainSec_")]
    public float OdBlockArrowRainAnimBeginRemainSec { get; set; } = 1f;

    [JsonPropertyName("odBlockArrowRainAttackWaitSec_")]
    public float OdBlockArrowRainAttackWaitSec { get; set; } = 0.69f;

    [JsonPropertyName("odBlockArrowRainExitWaitSec_")]
    public float OdBlockArrowRainExitWaitSec { get; set; } = 0.31f;

    [JsonPropertyName("odBlockSwordWhipAttackBeginRemainSec_")]
    public float OdBlockSwordWhipAttackBeginRemainSec { get; set; } = 0f;

    [JsonPropertyName("moveSpeed7st_")]
    public float MoveSpeed7st { get; set; } = 20f;

    [JsonPropertyName("moveAccel7st_")]
    public float MoveAccel7st { get; set; } = 20f;

    [JsonPropertyName("rotSpeed7st_")]
    public float RotSpeed7st { get; set; } = 0.1745329f;

    [JsonPropertyName("emLinkAttackTalkEventWaitSec_")]
    public float EmLinkAttackTalkEventWaitSec { get; set; } = 1.666f;

    [JsonPropertyName("emLinkAttackEffectWaitSecLaunch_")]
    public float EmLinkAttackEffectWaitSecLaunch { get; set; } = 0.4f;

    [JsonPropertyName("emLinkAttackEffectWaitSecFinish_")]
    public float EmLinkAttackEffectWaitSecFinish { get; set; } = 0.2f;

    [JsonPropertyName("emLinkAttackFinishHitEffectPartsNo_")]
    public int EmLinkAttackFinishHitEffectPartsNo { get; set; } = 3;

    [JsonPropertyName("emLinkAttackFinishHitEffectOffset_")]
    public Vector4 EmLinkAttackFinishHitEffectOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f);

    [JsonPropertyName("emLinkAttackFinishOffset_")]
    public Vector4 EmLinkAttackFinishOffset { get; set; } = new Vector4(0f, 0f, -2f, 1f);

    [JsonPropertyName("emLinkAttackFinishMoveEaseParam_")]
    public Em2100Param EmLinkAttackFinishMoveEaseParam { get; set; }

    [JsonPropertyName("emLinkAttackSpDamageCutOffWaitSec_")]
    public float EmLinkAttackSpDamageCutOffWaitSec { get; set; } = 0.75f;

    [JsonPropertyName("spArtsMotionParam_")]
    public Em2100SpArtsMotionParam SpArtsMotionParam { get; set; }

    [JsonPropertyName("spArtsCombinationParam_")]
    public Em2100SpArtsCombinationParam SpArtsCombinationParam { get; set; }

    public Em2100Param()
    {
        Hp = 200000;
        Atk = 1000;
        Break = 10;
        Def = 0f;
        Endurance = 10;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 20;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 10;
        HateRateBackAngle = 20;
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
        CombatPower = 70;
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
        CameraLength = 1.5f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = true;
        BossStunOffsetY = 0f;
    }

    public class PhaseParam
    {
        [JsonPropertyName("phaseEndHpRate_")]
        public float PhaseEndHpRate { get; set; }

        [JsonPropertyName("overDriveHpRate_")]
        public float OverDriveHpRate { get; set; }

        public PhaseParam()
        {
        }
    }


    public class SwordAttackAdjustParam
    {
        [JsonPropertyName("adjustSetType_")]
        public int AdjustSetType { get; set; }

        [JsonPropertyName("adjustYRange_")]
        public float AdjustYRange { get; set; }

        public SwordAttackAdjustParam()
        {
        }
    }


    public class AILevelParam
    {
        [JsonPropertyName("wearSwordBreakValue_")]
        public int WearSwordBreakValue { get; set; }

        [JsonPropertyName("recoverWearSwordMaxSec_")]
        public float RecoverWearSwordMaxSec { get; set; }

        [JsonPropertyName("recoverWearSwordMinSec_")]
        public float RecoverWearSwordMinSec { get; set; }

        [JsonPropertyName("recoverWearSwordMaxDamageRate_")]
        public int RecoverWearSwordMaxDamageRate { get; set; }

        [JsonPropertyName("wearSwordAttackIntervalSec_")]
        public float WearSwordAttackIntervalSec { get; set; }

        [JsonPropertyName("wearSwordFunnelStabSec_")]
        public float WearSwordFunnelStabSec { get; set; }

        [JsonPropertyName("wearSwordSpearStabSec_")]
        public float WearSwordSpearStabSec { get; set; }

        [JsonPropertyName("wearSwordWheelStabSec_")]
        public float WearSwordWheelStabSec { get; set; }

        [JsonPropertyName("wearSwordCounterNum_")]
        public int WearSwordCounterNum { get; set; }

        [JsonPropertyName("maxParallelAttackNum_")]
        public int MaxParallelAttackNum { get; set; }

        [JsonPropertyName("wearSwordCounterMinCheckDamage_")]
        public int WearSwordCounterMinCheckDamage { get; set; }

        [JsonPropertyName("wearSwordCounterMaxCheckDamage_")]
        public int WearSwordCounterMaxCheckDamage { get; set; }

        [JsonPropertyName("parallelAttackInvervalSec_")]
        public float ParallelAttackInvervalSec { get; set; }

        [JsonPropertyName("parallelAttackDelaySec_")]
        public float ParallelAttackDelaySec { get; set; }

        [JsonPropertyName("attackActionIntervalSec_")]
        public float AttackActionIntervalSec { get; set; }

        [JsonPropertyName("throwSwordInvervalSec_")]
        public float ThrowSwordInvervalSec { get; set; }

        [JsonPropertyName("swordWhipCount_")]
        public int SwordWhipCount { get; set; }

        [JsonPropertyName("superiorWeaponRecoveryIntervalSec_")]
        public float SuperiorWeaponRecoveryIntervalSec { get; set; }

        [JsonPropertyName("odDonutParam_")]
        public Em2100DonutActionParam OdDonutParam { get; set; }

        [JsonPropertyName("odArrowRainParam_")]
        public Em2100ODArrowRainParam OdArrowRainParam { get; set; }

        [JsonPropertyName("spArtsRotationParam_")]
        public Em2100SpArtsRotationActionParam SpArtsRotationParam { get; set; }

        [JsonPropertyName("spArtsActionParam_")]
        public Em2100SpArtsActionParam SpArtsActionParam { get; set; }

        [JsonPropertyName("spArtsWeaponActionParam_")]
        public Em2100SpArtsWeaponActionParam SpArtsWeaponActionParam { get; set; }

        [JsonPropertyName("spArtsCombinationWheelMoveSpeed_")]
        public float SpArtsCombinationWheelMoveSpeed { get; set; }

        [JsonPropertyName("spArtsCombinationWheelMoveAccel_")]
        public float SpArtsCombinationWheelMoveAccel { get; set; }

        [JsonPropertyName("spArtsCombinationDoorAnimRate_")]
        public float SpArtsCombinationDoorAnimRate { get; set; }

        public AILevelParam()
        {
        }
    }

    public class AIParam
    {
        [JsonPropertyName("actionList_")]
        public BindingList<BindingList<Action>> ActionList { get; set; } = []; // std::array<std::vector<Em2100Param::AIParam::Action>, 8>

        public AIParam()
        {
        }

        public class Condition
        {
            [JsonPropertyName("condition_")]
            public int Condition_ { get; set; }

            [JsonPropertyName("isReverseSuccess_")]
            public bool IsReverseSuccess { get; set; }

            [JsonPropertyName("isAndCondition_")]
            public bool IsAndCondition { get; set; }

            public Condition()
            {
            }
        }

        public class Action
        {
            [JsonPropertyName("actionId_")]
            public int ActionId { get; set; }

            [JsonPropertyName("probability_")]
            public int Probability { get; set; }

            [JsonPropertyName("useCoolTime_")]
            public bool UseCoolTime { get; set; }

            [JsonPropertyName("intervalSec_")]
            public float IntervalSec { get; set; }

            [JsonPropertyName("conditions_")]
            public BindingList<Condition> Conditions { get; set; } = []; // std::vector<Em2100Param::AIParam::Condition>

            public Action()
            {
            }
        }
    }
}

public class Em2100DonutActionParam
{
    [JsonPropertyName("donuts_")]
    public BindingList<Donut> Donuts { get; set; } = []; // std::vector<Em2100DonutActionParam::Donut>

    public Em2100DonutActionParam()
    {
    }

    public class Donut
    {
        [JsonPropertyName("activeDelaySec_")]
        public float ActiveDelaySec { get; set; }

        [JsonPropertyName("expandSpeed_")]
        public float ExpandSpeed { get; set; }

        [JsonPropertyName("readySec_")]
        public float ReadySec { get; set; }

        [JsonPropertyName("type_")]
        public int Type { get; set; }

        public Donut()
        {
        }
    }
}

public class Em2100ODArrowRainParam
{
    [JsonPropertyName("meteorsAreaRadius_")]
    public float MeteorsAreaRadius { get; set; }

    [JsonPropertyName("attackNum_")]
    public int AttackNum { get; set; }

    [JsonPropertyName("attackIntervalSec_")]
    public float AttackIntervalSec { get; set; }

    [JsonPropertyName("targetCount_")]
    public int TargetCount { get; set; }

    public Em2100ODArrowRainParam()
    {
    }
}


public class Em2100SpArtsActionParam
{
    [JsonPropertyName("spArtsRate1st_")]
    public int SpArtsRate1st { get; set; }

    [JsonPropertyName("spArtsRate2nd_")]
    public int SpArtsRate2nd { get; set; }

    [JsonPropertyName("wallAlphaDistNear_")]
    public float WallAlphaDistNear { get; set; }

    [JsonPropertyName("wallAlphaDistFar_")]
    public float WallAlphaDistFar { get; set; }

    [JsonPropertyName("wallAttackStartFrame_")]
    public int WallAttackStartFrame { get; set; }

    [JsonPropertyName("wallAttackStartSizeOffsetInner_")]
    public float WallAttackStartSizeOffsetInner { get; set; }

    [JsonPropertyName("wallAttackStartSizeOffsetOuter_")]
    public float WallAttackStartSizeOffsetOuter { get; set; }

    [JsonPropertyName("wallAttackKeepSizeOffsetInner_")]
    public float WallAttackKeepSizeOffsetInner { get; set; }

    [JsonPropertyName("wallAttackKeepSizeOffsetOuter_")]
    public float WallAttackKeepSizeOffsetOuter { get; set; }

    public Em2100SpArtsActionParam()
    {
    }
}


public class Em2100SpArtsWeaponActionParam
{
    [JsonPropertyName("actionParams_")]
    public BindingList<ActionParam> ActionParams { get; set; } = []; // std::vector<Em2100SpArtsWeaponActionParam::ActionParam>

    public Em2100SpArtsWeaponActionParam()
    {
    }

    public class ActionParam
    {
        [JsonPropertyName("type_")]
        public int Type { get; set; }

        [JsonPropertyName("startSec_")]
        public float StartSec { get; set; }

        [JsonPropertyName("fireWaitSec_")]
        public float FireWaitSec { get; set; }

        [JsonPropertyName("angleY_")]
        public int AngleY { get; set; }

        [JsonPropertyName("speed_")]
        public float Speed { get; set; }

        [JsonPropertyName("time_")]
        public float Time { get; set; }

        public ActionParam()
        {
        }
    }
}

public class Em2100SpArtsRotationActionParam
{
    [JsonPropertyName("rotationWaves_")]
    public BindingList<WavesParam> RotationWaves { get; set; } = []; // std::vector<Em2100SpArtsRotationActionParam::WavesParam>

    public Em2100SpArtsRotationActionParam()
    {
    }

    public class RotationSwordParam
    {
        [JsonPropertyName("initRotationY_")]
        public float InitRotationY { get; set; }

        [JsonPropertyName("rotationSpeed_")]
        public float RotationSpeed { get; set; }

        [JsonPropertyName("type_")]
        public int Type { get; set; }

        public RotationSwordParam()
        {
        }
    }

    public class WavesParam
    {
        [JsonPropertyName("rotations_")]
        public BindingList<RotationSwordParam> Rotations { get; set; } = []; // std::vector<Em2100SpArtsRotationActionParam::RotationSwordParam>

        [JsonPropertyName("activeDelaySec_")]
        public float ActiveDelaySec { get; set; }

        [JsonPropertyName("rotationWaitSec_")]
        public float RotationWaitSec { get; set; }

        [JsonPropertyName("rotationSec_")]
        public float RotationSec { get; set; }

        public WavesParam()
        {
        }
    }
}

public class Em2100FlyActionParam
{
    [JsonPropertyName("staySec_")]
    public float StaySec { get; set; }

    public Em2100FlyActionParam()
    {
    }
}

public class Em2100WearAttackActionParam
{
    [JsonPropertyName("wearAttackIntervalSec_")]
    public float WearAttackIntervalSec { get; set; }

    public Em2100WearAttackActionParam()
    {
    }
}

public class Em2100SuperiorWeaponRecoveryActionParam
{
    [JsonPropertyName("moveToOwnerEaseParam_")]
    public Em2100SuperiorWeaponRecoveryActionParam MoveToOwnerEaseParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("recoveryAnimWaitFrame_")]
    public float RecoveryAnimWaitFrame { get; set; } // Offset 0x18

    [JsonPropertyName("moveToOwnerFrame_")]
    public float MoveToOwnerFrame { get; set; } // Offset 0x1C

    [JsonPropertyName("superiorWeaponDist_")]
    public float SuperiorWeaponDist { get; set; } // Offset 0x28

    [JsonPropertyName("offsetAngleY_")]
    public float OffsetAngleY { get; set; } // Offset 0x20

    [JsonPropertyName("addAngleY_")]
    public float AddAngleY { get; set; } // Offset 0x24

    [JsonPropertyName("waitMotInterSec_")]
    public float WaitMotInterSec { get; set; } // Offset 0x30

    [JsonPropertyName("afterRevivalSec_")]
    public float AfterRevivalSec { get; set; } // Offset 0x2C

    public Em2100SuperiorWeaponRecoveryActionParam()
    {
    }
}


public class Em2100AttackParam
{
    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } // Offset 0x10

    [JsonPropertyName("size_")]
    public Vector4 Size { get; set; } // Offset 0x20

    [JsonPropertyName("degree_")]
    public Vector4 Degree { get; set; } // Offset 0x30

    [JsonPropertyName("shape_")]
    public int Shape { get; set; } // Offset 0x40

    [JsonPropertyName("direction_")]
    public int Direction { get; set; } // Offset 0x44

    [JsonPropertyName("globalType_")]
    public int GlobalType { get; set; } // Offset 0x48

    [JsonPropertyName("type_")]
    public int Type { get; set; } // Offset 0x4C

    [JsonPropertyName("reaction_")]
    public int Reaction { get; set; } // Offset 0x50

    [JsonPropertyName("hitFlag_")]
    public ulong HitFlag { get; set; } // Offset 0x58

    [JsonPropertyName("categoryFlag_")]
    public int CategoryFlag { get; set; } // Offset 0x60

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x68

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x6C

    [JsonPropertyName("hitStopSecond_")]
    public float HitStopSecond { get; set; } // Offset 0x70

    [JsonPropertyName("knockBackRate_")]
    public float KnockBackRate { get; set; } // Offset 0x74

    [JsonPropertyName("damageMovementRate_")]
    public float DamageMovementRate { get; set; } // Offset 0x78

    [JsonPropertyName("damageMovementRateY_")]
    public float DamageMovementRateY { get; set; } // Offset 0x7C

    [JsonPropertyName("isSwept_")]
    public bool IsSwept { get; set; } // Offset 0x80

    public Em2100AttackParam()
    {
    }
}


public class Em2100ODAbilityActionParam
{
    [JsonPropertyName("meteorStrikeFireSec_")]
    public float MeteorStrikeFireSec { get; set; } // Offset 0x10

    [JsonPropertyName("meteorStrikeIntervalSec_")]
    public float MeteorStrikeIntervalSec { get; set; } // Offset 0x14

    [JsonPropertyName("meteorStrikeOffsetDist_")]
    public float MeteorStrikeOffsetDist { get; set; } // Offset 0x18

    [JsonPropertyName("meteorStrikeDist_")]
    public float MeteorStrikeDist { get; set; } // Offset 0x1C

    [JsonPropertyName("meteorStrikeAttackRadius_")]
    public float MeteorStrikeAttackRadius { get; set; } // Offset 0x20

    [JsonPropertyName("meteorStrikeOffsetAttackSignDispSec_")]
    public float MeteorStrikeOffsetAttackSignDispSec { get; set; } // Offset 0x24

    [JsonPropertyName("meteorAtkParam_")]
    public Em2100ODAbilityActionParam MeteorAtkParam { get; set; } // Offset 0xCF543FFA

    public Em2100ODAbilityActionParam()
    {
    }
}


public class Em2100ArrowRainVirticalParam
{
    [JsonPropertyName("createIntervalSec_")]
    public float CreateIntervalSec { get; set; } // Offset 0x8

    [JsonPropertyName("maxCreateNum_")]
    public int MaxCreateNum { get; set; } // Offset 0xC

    public Em2100ArrowRainVirticalParam()
    {
    }
}


public class Em2100ArrowRainAreaParam
{
    [JsonPropertyName("createIntervalSec_")]
    public float CreateIntervalSec { get; set; } // Offset 0x8

    [JsonPropertyName("maxCreateNum_")]
    public int MaxCreateNum { get; set; } // Offset 0xC

    public Em2100ArrowRainAreaParam()
    {
    }
}

public class Em2100SpArtsMotionParam
{
    [JsonPropertyName("motParams_")]
    public BindingList<MotParam> MotParams { get; set; } = []; // Offset 0x8

    public Em2100SpArtsMotionParam()
    {
    }

    public class MotParam
    {
        [JsonPropertyName("motId_")]
        public string MotId { get; set; } // Offset 0x8

        [JsonPropertyName("isLoop_")]
        public bool IsLoop { get; set; } // Offset 0x28

        [JsonPropertyName("playSec_")]
        public float PlaySec { get; set; } // Offset 0x2C

        [JsonPropertyName("interSec_")]
        public float InterSec { get; set; } // Offset 0x30

        public MotParam()
        {
        }
    }
}





public class Em2100SpArtsCombinationParam
{
    [JsonPropertyName("hpRates_")]
    public BindingList<float> HpRates { get; set; } = []; // Offset 0x10

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } // Offset 0x30

    [JsonPropertyName("rotY_")]
    public float RotY { get; set; } // Offset 0x40

    [JsonPropertyName("attackWheelSec_")]
    public float AttackWheelSec { get; set; } // Offset 0x44

    [JsonPropertyName("attackWheelHitListClearSec_")]
    public float AttackWheelHitListClearSec { get; set; } // Offset 0x48

    [JsonPropertyName("swordSetRotZ_")]
    public float SwordSetRotZ { get; set; } // Offset 0x4C

    [JsonPropertyName("swordSetScale_")]
    public float SwordSetScale { get; set; } // Offset 0x50

    [JsonPropertyName("swordPlacements_")]
    public BindingList<SwordPlacement> SwordPlacements { get; set; } = []; // Offset 0x58

    [JsonPropertyName("swordIdleHeight_")]
    public float SwordIdleHeight { get; set; } // Offset 0x70

    [JsonPropertyName("swordIdleSec_")]
    public float SwordIdleSec { get; set; } // Offset 0x74

    [JsonPropertyName("swordFallSec_")]
    public float SwordFallSec { get; set; } // Offset 0x78

    [JsonPropertyName("swordFallEaseParam_")]
    public Em2100SpArtsCombinationParam SwordFallEaseParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("swordRotSpeed_")]
    public float SwordRotSpeed { get; set; } // Offset 0x90

    [JsonPropertyName("swordMoveWaitSec_")]
    public float SwordMoveWaitSec { get; set; } // Offset 0x94

    [JsonPropertyName("swordSpreadSignSec_")]
    public float SwordSpreadSignSec { get; set; } // Offset 0x98

    [JsonPropertyName("swordSpreadWaitSec_")]
    public float SwordSpreadWaitSec { get; set; } // Offset 0x9C

    [JsonPropertyName("swordSpreadDist_")]
    public float SwordSpreadDist { get; set; } // Offset 0xA0

    [JsonPropertyName("swordSpreadSpeed_")]
    public float SwordSpreadSpeed { get; set; } // Offset 0xA4

    [JsonPropertyName("doorSetCount_")]
    public int DoorSetCount { get; set; } // Offset 0xA8

    [JsonPropertyName("doorRotSec_")]
    public float DoorRotSec { get; set; } // Offset 0xAC

    [JsonPropertyName("doorExpandRotZStart_")]
    public float DoorExpandRotZStart { get; set; } // Offset 0xB0

    [JsonPropertyName("doorExpandRotZAdd_")]
    public float DoorExpandRotZAdd { get; set; } // Offset 0xB4

    [JsonPropertyName("doorEndRotZStart_")]
    public float DoorEndRotZStart { get; set; } // Offset 0xB8

    [JsonPropertyName("doorEndRotZAdd_")]
    public float DoorEndRotZAdd { get; set; } // Offset 0xBC

    [JsonPropertyName("doorPassSeRotYAdd_")]
    public float DoorPassSeRotYAdd { get; set; } // Offset 0xC0

    [JsonPropertyName("doorPassSeIntervalSec_")]
    public float DoorPassSeIntervalSec { get; set; } // Offset 0xC4

    [JsonPropertyName("donutSetParams_")]
    public BindingList<DonutSetParam> DonutSetParams { get; set; } = []; // Offset 0xC8

    [JsonPropertyName("donutVfxWaitSec_")]
    public float DonutVfxWaitSec { get; set; } // Offset 0xE0

    [JsonPropertyName("donutVfxOffsetY_")]
    public float DonutVfxOffsetY { get; set; } // Offset 0xE4

    [JsonPropertyName("wallEndSec_")]
    public float WallEndSec { get; set; } // Offset 0xE8

    [JsonPropertyName("wallAlphaDistFar_")]
    public float WallAlphaDistFar { get; set; } // Offset 0xF0

    [JsonPropertyName("wallAlphaDistNear_")]
    public float WallAlphaDistNear { get; set; } // Offset 0xEC

    public Em2100SpArtsCombinationParam()
    {
    }

    public class SwordPlacement
    {
        [JsonPropertyName("setRotY_")]
        public float SetRotY { get; set; } // Offset 0x8

        [JsonPropertyName("setDist_")]
        public float SetDist { get; set; } // Offset 0xC

        [JsonPropertyName("setPosOffsetY_")]
        public float SetPosOffsetY { get; set; } // Offset 0x10

        [JsonPropertyName("setRotOffsetY_")]
        public float SetRotOffsetY { get; set; } // Offset 0x14

        [JsonPropertyName("moveRadius_")]
        public float MoveRadius { get; set; } // Offset 0x18

        [JsonPropertyName("isMoveClockwise_")]
        public bool IsMoveClockwise { get; set; } // Offset 0x1C

        public SwordPlacement()
        {
        }
    }


    public class DonutSetParam
    {
        [JsonPropertyName("waitSec_")]
        public float WaitSec { get; set; } // Offset 0x8

        [JsonPropertyName("attackWaitSec_")]
        public float AttackWaitSec { get; set; } // Offset 0xC

        [JsonPropertyName("speed_")]
        public float Speed { get; set; } // Offset 0x10

        [JsonPropertyName("offsetY_")]
        public float OffsetY { get; set; } // Offset 0x14

        public DonutSetParam()
        {
        }
    }
}


