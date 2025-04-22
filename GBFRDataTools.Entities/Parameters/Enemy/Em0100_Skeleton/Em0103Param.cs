using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0100_Skeleton;

public class Em0103Param : EmLargeSkeletonBaseParam
{
    [JsonPropertyName("frotstbiteEmberActiveSec_LowLevelAi_")]
    public float FrotstbiteEmberActiveSec_LowLevelAi { get; set; } = 2f;

    [JsonPropertyName("frotstbiteEmberActiveSec_HighLevelAi_")]
    public float FrotstbiteEmberActiveSec_HighLevelAi { get; set; } = 5f;

    [JsonPropertyName("frostbiteGasActiveSec_")]
    public float FrostbiteGasActiveSec { get; set; } = 2f;

    [JsonPropertyName("slashShotComboCoolSec_")]
    public float SlashShotComboCoolSec { get; set; } = 15f;

    [JsonPropertyName("icePillerNum_")]
    public int IcePillerNum { get; set; } = 10;

    [JsonPropertyName("icePillerRectLength_")]
    public int IcePillerRectLength { get; set; } = 20;

    [JsonPropertyName("icePillerRectWidth_")]
    public int IcePillerRectWidth { get; set; } = 12;

    [JsonPropertyName("walkApproachThrowSummonCoolSec")]
    public float WalkApproachThrowSummonCoolSec { get; set; } = 10f;

    [JsonPropertyName("byWallStepCoolSec_")]
    public float ByWallStepCoolSec { get; set; } = 30f;

    [JsonPropertyName("backStepFrostColumnsCoolSec_LowLevelAi_")]
    public float BackStepFrostColumnsCoolSec_LowLevelAi { get; set; } = 30f;

    [JsonPropertyName("backStepFrostColumnsCoolSec_HighLevelAi_")]
    public float BackStepFrostColumnsCoolSec_HighLevelAi { get; set; } = 30f;

    [JsonPropertyName("frostColumnsCombo2ndCoolSec_")]
    public float FrostColumnsCombo2ndCoolSec { get; set; } = 45f;

    [JsonPropertyName("frostColumnsCombo3rdCoolSec_")]
    public float FrostColumnsCombo3rdCoolSec { get; set; } = 45f;

    [JsonPropertyName("frostColumnsSignSec_LowLevelAi_")]
    public float FrostColumnsSignSec_LowLevelAi { get; set; } = 2f;

    [JsonPropertyName("frostColumnsSignSec_MediumLevelAi_")]
    public float FrostColumnsSignSec_MediumLevelAi { get; set; } = 1f;

    [JsonPropertyName("frostColumnsSignSec_HighLevelAi_")]
    public float FrostColumnsSignSec_HighLevelAi { get; set; } = 0.3f;

    [JsonPropertyName("frostColumnsHeightUpper_")]
    public float FrostColumnsHeightUpper { get; set; } = 3f;

    [JsonPropertyName("frostColumnsHeightLower_")]
    public float FrostColumnsHeightLower { get; set; } = 5f;

    [JsonPropertyName("frostColumnsTrunkParams_LowLevelAi_")]
    public BindingList<FrostColumnsBranchParam> FrostColumnsTrunkParams_LowLevelAi { get; set; } = []; // std::vector<Em0103Param::FrostColumnsBranchParam>

    [JsonPropertyName("frostColumnsTrunkParams_HighLevelAi_")]
    public BindingList<FrostColumnsBranchParam> FrostColumnsTrunkParams_HighLevelAi { get; set; } = []; // std::vector<Em0103Param::FrostColumnsBranchParam>

    [JsonPropertyName("frostColumnsBranchParams_LowLevelAi_")]
    public BindingList<FrostColumnsBranchParam> FrostColumnsBranchParams_LowLevelAi { get; set; } = []; // std::vector<Em0103Param::FrostColumnsBranchParam>

    [JsonPropertyName("frostColumnsBranchParams_MediumLevelAi_")]
    public BindingList<FrostColumnsBranchParam> FrostColumnsBranchParams_MediumLevelAi { get; set; } = []; // std::vector<Em0103Param::FrostColumnsBranchParam>

    [JsonPropertyName("frostColumnsBranchParams_HighLevelAi_")]
    public BindingList<FrostColumnsBranchParam> FrostColumnsBranchParams_HighLevelAi { get; set; } = []; // std::vector<Em0103Param::FrostColumnsBranchParam>

    [JsonPropertyName("frostcolumnsAttackRate_")]
    public float FrostcolumnsAttackRate { get; set; } = 0.4f;

    [JsonPropertyName("counterSlashShotAttackRate_")]
    public float CounterSlashShotAttackRate { get; set; } = 0.6f;

    public Em0103Param()
    {
        Hp = 430000;
        Atk = 1500;
        Break = 8;
        Def = 1f;
        Endurance = 50;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 25;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 25;
        HateRateBackAngle = 5;
        HateRateDamage = 100;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 25;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 0;
        HateUpdateTime = 1f;
        DamageToHateRate = 1f;
        DamageHateDecPerSec = 10f;
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
        AnimInterDefaultSec = 0.2f;
        DamageAnimInterDefaultSec = 0f;
        UiPartsNo = 5;
        UiOffsetY = 0.6f;
        BasicHitStopTimeRate = 0.5f;
        DamageReactionHitStopTimeRate = 1f;
        SuperArmorHitStopTimeRate = 0.1f;
        AttackerHitStopTimeRate = 0f;
        AddReactionHitstopFrameMin = -1f;
        AddReactionHitstopFrameMax = -1f;
        AddReactionWeightRateMin = -1f;
        AddReactionWeightRateMax = -1f;
        AddReactionWeightRateAI = -1f;
        AddReactionInterSec = -1f;
        IsEyeLookingAtLockOn = false;
        LookingAtPartsNo = 5;
        IsEnableSyncWeaponAnim = true;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = false;
        IsDisableAerialDownReaction = true;
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
        SummonNum_LevelAi1 = 2;
        SummonNum_LevelAi2 = 4;
        SummonNum_LevelAi3 = 6;
        SummonNum_LevelAi4 = 8;
        SummonCoolSec_LevelAi1 = 180f;
        SummonCoolSec_LevelAi2 = 60f;
        SummonCoolSec_LevelAi3 = 45f;
        SummonCoolSec_LevelAi4 = 30f;
        ThrowSummonNum = 2;
        WarpTargetWaitSec = 1f;
        WarpTargetBindSec = 6f;
        WarpTargetSignSec_LowLevelAi = 5f;
        WarpTargetSignSec_HighLevelAi = 2f;
        WarpTargetOffsetLength = 4f;
        SlashShotSpeed_LowLevelAi = 10f;
        SlashShotSpeed_HighLevelAi = 30f;
        OdAbilityCoolTimeSec = 60f;
        OdAbilitySummonCount_LowLevelAi = 6;
        OdAbilitySummonCount_HighLevelAi = 11;
        OdAbilitySummonWaitSec_LowLevelAi = 1f;
        OdAbilitySummonWaitSec_HighLevelAi = 0.7f;
        OdAbilityWaveSpreadSec_LowLevelAi = 2f;
        OdAbilityWaveSpreadSec_HighLevelAi = 2f;
        OdAbilityWaveWaitSec_LowLevelAi = 2f;
        OdAbilityWaveWaitSec_HighLevelAi = 2f;
        OdAbilitySummonRadius = 50f;
        OdAbilityWaveRadius = 30f;
        AttackModeSec_LevelAi1 = 30f;
        AttackModeCoolSec_LevelAi1 = 0f;
        OdAbilityWaveAttackRate = 0.1f;
        SlashShotAttackRate = 1f;
        OdAbilityWaveBreakRate = 1f;
        SlashShotBreakRate = 1f;
        CounterSlowRate_LowLevelAi = 0.6f;
        CounterSlowRate_HighLevelAi = 1f;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FrostColumnsBranchParam
    {
        [JsonPropertyName("offsetX_")]
        public float OffsetX { get; set; }

        [JsonPropertyName("offsetZ_")]
        public float OffsetZ { get; set; }

        [JsonPropertyName("degreeY_")]
        public float DegreeY { get; set; }

        [JsonPropertyName("length_")]
        public float Length { get; set; }

        [JsonPropertyName("width_")]
        public float Width { get; set; }

        [JsonPropertyName("id_")]
        public int Id { get; set; }

        [JsonPropertyName("parentId_")]
        public int ParentId { get; set; }
    }
}
