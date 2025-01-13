using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl2100Param : PlayerParameterInfo
{
    [JsonPropertyName("addGaugeHit_Just2nd_")]
    public float AddGaugeHit_Just2nd { get; set; } = 15f;

    [JsonPropertyName("addGaugeHit_Just3rd_")]
    public float AddGaugeHit_Just3rd { get; set; } = 18f;

    [JsonPropertyName("addGaugeHit_Just5th_")]
    public float AddGaugeHit_Just5th { get; set; } = 22f;

    [JsonPropertyName("addGaugeHit_Just6th_")]
    public float AddGaugeHit_Just6th { get; set; } = 28f;

    [JsonPropertyName("addGaugeHit_Just7th_")]
    public float AddGaugeHit_Just7th { get; set; } = 32f;

    [JsonPropertyName("addGaugeHit_Miss_Finish_")]
    public float AddGaugeHit_Miss_Finish { get; set; } = 25f;

    [JsonPropertyName("addGaugeHit_AllJustFinish_")]
    public float AddGaugeHit_AllJustFinish { get; set; } = 58.62f;

    [JsonPropertyName("addGaugeHit_AllJustFinish_Miss_")]
    public float AddGaugeHit_AllJustFinish_Miss { get; set; } = 25f;

    [JsonPropertyName("addGaugeHit_AirAttack_3rd_")]
    public float AddGaugeHit_AirAttack_3rd { get; set; } = 40f;

    [JsonPropertyName("addGaugeHit_Ability2_")]
    public float AddGaugeHit_Ability2 { get; set; } = 80f;

    [JsonPropertyName("addGaugeHit_Ability3_")]
    public float AddGaugeHit_Ability3 { get; set; } = 80f;

    [JsonPropertyName("addGaugeHit_Ability5_")]
    public float AddGaugeHit_Ability5 { get; set; } = 120f;

    [JsonPropertyName("addGaugeHit_Ability6_")]
    public float AddGaugeHit_Ability6 { get; set; } = 80f;

    [JsonPropertyName("addGaugeHit_Ability6_Failure_")]
    public float AddGaugeHit_Ability6_Failure { get; set; } = 60f;

    [JsonPropertyName("addGaugeHit_Ability7_")]
    public float AddGaugeHit_Ability7 { get; set; } = 0f;

    [JsonPropertyName("addGaugeHit_Ability7_Finish_")]
    public float AddGaugeHit_Ability7_Finish { get; set; } = 1000f;

    [JsonPropertyName("addGaugeHit_LinkAttack_")]
    public float AddGaugeHit_LinkAttack { get; set; } = 50f;

    [JsonPropertyName("addGaugeHit_LinkAttack_Transform_")]
    public float AddGaugeHit_LinkAttack_Transform { get; set; } = 50f;

    [JsonPropertyName("addGaugeAvoid_JustStep_")]
    public float AddGaugeAvoid_JustStep { get; set; } = 60f;

    [JsonPropertyName("gaugeDecreaseValue_")]
    public float GaugeDecreaseValue { get; set; } = 0.51f;

    [JsonPropertyName("justComboAxcel_")]
    public float JustComboAxcel { get; set; } = 0.06f;

    [JsonPropertyName("isCheckSpeedLimit_")]
    public bool IsCheckSpeedLimit { get; set; } = true;

    [JsonPropertyName("speedLimitRate_")]
    public float SpeedLimitRate { get; set; } = 1.66f;

    [JsonPropertyName("justComboMaxNum_")]
    public int JustComboMaxNum { get; set; } = 10;

    [JsonPropertyName("justComboMaxNumTransform_")]
    public int JustComboMaxNumTransform { get; set; } = 23;

    [JsonPropertyName("inputStepDirDecideThreshold_")]
    public float InputStepDirDecideThreshold { get; set; } = 150f;

    [JsonPropertyName("isChangeAtkRate_")]
    public bool IsChangeAtkRate { get; set; } = false;

    [JsonPropertyName("coefficient_")]
    public float Coefficient { get; set; } = 1f;

    [JsonPropertyName("subGauge_TransformStep_")]
    public float SubGauge_TransformStep { get; set; } = 40f;

    [JsonPropertyName("rapidAttackTime_")]
    public float RapidAttackTime { get; set; } = 2.4f;

    [JsonPropertyName("isAddChargeRate_")]
    public bool IsAddChargeRate { get; set; } = false;

    [JsonPropertyName("divisionValue_")]
    public float DivisionValue { get; set; } = 0f;

    [JsonPropertyName("chargeCancelMinimumTime_")]
    public float ChargeCancelMinimumTime { get; set; } = 0f;

    [JsonPropertyName("magicSwotdRushMoveTimeLimit_")]
    public float MagicSwotdRushMoveTimeLimit { get; set; } = 1f;

    [JsonPropertyName("stepTargetSelectParam_")]
    public Pl2100Param StepTargetSelectParam { get; set; }

    [JsonPropertyName("rushMoveCutRate_NoEnemy_")]
    public float RushMoveCutRate_NoEnemy { get; set; } = 0.5f;

    [JsonPropertyName("rushMoveCutRate_Front_")]
    public float RushMoveCutRate_Front { get; set; } = 0.35f;

    [JsonPropertyName("rushMoveMaxRate_Front_")]
    public float RushMoveMaxRate_Front { get; set; } = 1.5f;

    [JsonPropertyName("rushMoveCutRate_NoEnemy_Transform_")]
    public float RushMoveCutRate_NoEnemy_Transform { get; set; } = 0.6f;

    [JsonPropertyName("rushMoveCutRate_Front_Transform_")]
    public float RushMoveCutRate_Front_Transform { get; set; } = 0.4f;

    [JsonPropertyName("rushMoveMaxRate_Front_Transform_")]
    public float RushMoveMaxRate_Front_Transform { get; set; } = 1.5f;

    [JsonPropertyName("attackJust3rdMoveDist_")]
    public float AttackJust3rdMoveDist { get; set; } = 2.1f;

    [JsonPropertyName("abilityHealHpBaseAmount_")]
    public float AbilityHealHpBaseAmount { get; set; } = 50f;

    [JsonPropertyName("abilityHealLimit_")]
    public float AbilityHealLimit { get; set; } = 13000f;

    [JsonPropertyName("abilityHealHpBaseAmountTransform_")]
    public float AbilityHealHpBaseAmountTransform { get; set; } = 100f;

    [JsonPropertyName("abilityHealLimitTransform_")]
    public float AbilityHealLimitTransform { get; set; } = 100000f;

    [JsonPropertyName("stepBuffTime_")]
    public float StepBuffTime { get; set; } = 10f;

    [JsonPropertyName("stepBuffRate_")]
    public float StepBuffRate { get; set; } = 2f;

    [JsonPropertyName("linkAttackDistTransform_")]
    public float LinkAttackDistTransform { get; set; } = 40f;

    [JsonPropertyName("linkAttackDistNPC_")]
    public float LinkAttackDistNPC { get; set; } = 40f;

    [JsonPropertyName("magicSwotdLinkAttackTimeLimit_")]
    public float MagicSwotdLinkAttackTimeLimit { get; set; } = 2f;

    [JsonPropertyName("assistEnhancedFinishRange_")]
    public float AssistEnhancedFinishRange { get; set; } = 15f;

    [JsonPropertyName("assistTransformRange_")]
    public float AssistTransformRange { get; set; } = 12f;

    [JsonPropertyName("assistEndAtkGaugeRate_")]
    public float AssistEndAtkGaugeRate { get; set; } = 0.05f;

    [JsonPropertyName("photoModeImpossibleFrame_")]
    public int PhotoModeImpossibleFrame { get; set; } = 3;

    [JsonPropertyName("useHealAbilityHpRate_")]
    public float UseHealAbilityHpRate { get; set; } = 0.5f;

    public Pl2100Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 75;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        MaxLvHp = 30000;
        MaxLvAtk = 240;
        MaxLvDef = 6f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 1f;
        LimitSpecialArtsDamageRate = 1f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 11999;
        DamageLimitNormalAttack2 = 34999;
        DamageLimitSpecialAttack = 74999;
        DamageLimitAbility01 = 1;
        DamageLimitAbility02 = 12999;
        DamageLimitAbility03 = 29999;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 179999;
        DamageLimitAbility06 = 64999;
        DamageLimitAbility07 = 12999;
        DamageLimitAbility08 = 34999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 15999;
    }
}
