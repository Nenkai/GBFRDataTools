using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7400;

public class Em7404Param : Em7400CoreParam
{
    [JsonPropertyName("hpRateNormal_")]
    public float HpRateNormal { get; set; } = 0.15f;

    [JsonPropertyName("hpRateOverDrive_")]
    public float HpRateOverDrive { get; set; } = 0.35f;

    [JsonPropertyName("hpRateBreak_")]
    public float HpRateBreak { get; set; } = 0.2f;

    [JsonPropertyName("barrierSize_")]
    public float BarrierSize { get; set; } = 4.6f;

    [JsonPropertyName("barrierHeight_")]
    public float BarrierHeight { get; set; } = 1f;

    [JsonPropertyName("appearRiseWaitSec_")]
    public float AppearRiseWaitSec { get; set; } = 1f;

    [JsonPropertyName("barrierChargeSec_")]
    public float BarrierChargeSec { get; set; } = 5f;

    [JsonPropertyName("barrierChargeMinSec_")]
    public float BarrierChargeMinSec { get; set; } = 2f;

    [JsonPropertyName("barrierCreateEndSec_")]
    public float BarrierCreateEndSec { get; set; } = 1f;

    [JsonPropertyName("barrierBreakStartSec_")]
    public float BarrierBreakStartSec { get; set; } = 1f;

    [JsonPropertyName("barrierBreakEndSec_")]
    public float BarrierBreakEndSec { get; set; } = 10f;

    [JsonPropertyName("waveChargeCameraSec_")]
    public float WaveChargeCameraSec { get; set; } = 2f;

    [JsonPropertyName("waveCreateEndSec_")]
    public float WaveCreateEndSec { get; set; } = 5f;

    [JsonPropertyName("subCoreRiseUpDelayMaxSec_")]
    public float SubCoreRiseUpDelayMaxSec { get; set; } = 2f;

    [JsonPropertyName("subCoreFallDownDelayMinSec_")]
    public float SubCoreFallDownDelayMinSec { get; set; } = 0.3f;

    [JsonPropertyName("subCoreFallDownDelayMaxSec_")]
    public float SubCoreFallDownDelayMaxSec { get; set; } = 1f;

    [JsonPropertyName("waveChargeShotEndRemainSec_")]
    public float WaveChargeShotEndRemainSec { get; set; } = 5f;

    [JsonPropertyName("odAbilityTextId_")]
    public string OdAbilityTextId { get; set; }

    [JsonPropertyName("aiLevelParams_")]
    [Editable(false)]
    public BindingList<AiLevelParam> AiLevelParams { get; set; } = [..Enumerable.Repeat(new AiLevelParam(), 5)];

    [JsonPropertyName("rollingBeamStartSec_")]
    public float RollingBeamStartSec { get; set; } = 1.5f;

    [JsonPropertyName("rollingBeamEndSec_")]
    public float RollingBeamEndSec { get; set; } = 0.5f;

    [JsonPropertyName("rollingBeamLength_")]
    public float RollingBeamLength { get; set; } = 30f;

    [JsonPropertyName("rollingBeamAttackRate_")]
    public float RollingBeamAttackRate { get; set; } = 0.8f;

    [JsonPropertyName("rollingBeamBreakRate_")]
    public float RollingBeamBreakRate { get; set; } = 0.8f;

    [JsonPropertyName("rollingBeamParamTable_")]
    public BindingList<RollingBeamParamSet> RollingBeamParamTable { get; set; } = [];

    [JsonPropertyName("missileRaiseIntervalSec_")]
    public float MissileRaiseIntervalSec { get; set; } = 0.2f;

    [JsonPropertyName("missileRaiseDistMin_")]
    public float MissileRaiseDistMin { get; set; } = 35f;

    [JsonPropertyName("missileRaiseDistMax_")]
    public float MissileRaiseDistMax { get; set; } = 200f;

    [JsonPropertyName("missileRaiseRotX_")]
    public float MissileRaiseRotX { get; set; } = 15f;

    [JsonPropertyName("missileFallSpeed_")]
    public float MissileFallSpeed { get; set; } = 30f;

    public Em7404Param()
    {
        Hp = 330000;
        Atk = 15;
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
        CombatPower = 100;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 1;
        LinkAttackCameraDistRate = 1f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = -1;
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
    public class AiLevelParam
    {
        [JsonPropertyName("waveChargeSec_")]
        public float WaveChargeSec { get; set; } // Offset 0x8

        [JsonPropertyName("chargerSubCoreNum_")]
        public int ChargerSubCoreNum { get; set; } // Offset 0xC

        [JsonPropertyName("reflectorSubCoreNum_")]
        public int ReflectorSubCoreNum { get; set; } // Offset 0x10

        [JsonPropertyName("rollingBeamCoolSec_")]
        public float RollingBeamCoolSec { get; set; } // Offset 0x14

        [JsonPropertyName("rollingBeamPatterns_")]
        public BindingList<int> RollingBeamPatterns { get; set; } = []; // std::vector<int> - Offset 0x18

        [JsonPropertyName("waveChargeShotIntervalSec_")]
        public float WaveChargeShotIntervalSec { get; set; } // Offset 0x30

        [JsonPropertyName("waveChargeShotSetSec_")]
        public float WaveChargeShotSetSec { get; set; } // Offset 0x34

        [JsonPropertyName("waveChargeShotNum_")]
        public int WaveChargeShotNum { get; set; } // Offset 0x38

        [JsonPropertyName("barrierBreakEndHpRate_")]
        public float BarrierBreakEndHpRate { get; set; } // Offset 0x3C

        public AiLevelParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class RollingBeamParamSet
    {
        [JsonPropertyName("params_")]
        public BindingList<RollingBeamParam> Params { get; set; } = []; // Offset 0x10

        [JsonPropertyName("height_")]
        public float Height { get; set; } // Offset 0x8

        [JsonPropertyName("rotX_")]
        public float RotX { get; set; } // Offset 0xC

        public RollingBeamParamSet()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class RollingBeamParam
    {
        [JsonPropertyName("rotX_")]
        public float RotX { get; set; } // Offset 0x8

        [JsonPropertyName("rotEndX_")]
        public float RotEndX { get; set; } // Offset 0xC

        [JsonPropertyName("rotY_")]
        public float RotY { get; set; } // Offset 0x10

        [JsonPropertyName("rotEndY_")]
        public float RotEndY { get; set; } // Offset 0x14

        [JsonPropertyName("height_")]
        public float Height { get; set; } // Offset 0x18

        [JsonPropertyName("heightEnd_")]
        public float HeightEnd { get; set; } // Offset 0x1C

        [JsonPropertyName("rollingSec_")]
        public float RollingSec { get; set; } // Offset 0x20

        public RollingBeamParam()
        {
        }
    }
}