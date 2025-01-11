using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl2100Param : PlayerParameterInfo
{
    [JsonPropertyName("addGaugeHit_Just2nd_")]
    public float AddGaugeHit_Just2nd { get; set; }

    [JsonPropertyName("addGaugeHit_Just3rd_")]
    public float AddGaugeHit_Just3rd { get; set; }

    [JsonPropertyName("addGaugeHit_Just5th_")]
    public float AddGaugeHit_Just5th { get; set; }

    [JsonPropertyName("addGaugeHit_Just6th_")]
    public float AddGaugeHit_Just6th { get; set; }

    [JsonPropertyName("addGaugeHit_Just7th_")]
    public float AddGaugeHit_Just7th { get; set; }

    [JsonPropertyName("addGaugeHit_Miss_Finish_")]
    public float AddGaugeHit_Miss_Finish { get; set; }

    [JsonPropertyName("addGaugeHit_AllJustFinish_")]
    public float AddGaugeHit_AllJustFinish { get; set; }

    [JsonPropertyName("addGaugeHit_AllJustFinish_Miss_")]
    public float AddGaugeHit_AllJustFinish_Miss { get; set; }

    [JsonPropertyName("addGaugeHit_AirAttack_3rd_")]
    public float AddGaugeHit_AirAttack_3rd { get; set; }

    [JsonPropertyName("addGaugeHit_Ability2_")]
    public float AddGaugeHit_Ability2 { get; set; }

    [JsonPropertyName("addGaugeHit_Ability3_")]
    public float AddGaugeHit_Ability3 { get; set; }

    [JsonPropertyName("addGaugeHit_Ability5_")]
    public float AddGaugeHit_Ability5 { get; set; }

    [JsonPropertyName("addGaugeHit_Ability6_")]
    public float AddGaugeHit_Ability6 { get; set; }

    [JsonPropertyName("addGaugeHit_Ability6_Failure_")]
    public float AddGaugeHit_Ability6_Failure { get; set; }

    [JsonPropertyName("addGaugeHit_Ability7_")]
    public float AddGaugeHit_Ability7 { get; set; }

    [JsonPropertyName("addGaugeHit_Ability7_Finish_")]
    public float AddGaugeHit_Ability7_Finish { get; set; }

    [JsonPropertyName("addGaugeHit_LinkAttack_")]
    public float AddGaugeHit_LinkAttack { get; set; }

    [JsonPropertyName("addGaugeHit_LinkAttack_Transform_")]
    public float AddGaugeHit_LinkAttack_Transform { get; set; }

    [JsonPropertyName("addGaugeAvoid_JustStep_")]
    public float AddGaugeAvoid_JustStep { get; set; }

    [JsonPropertyName("gaugeDecreaseValue_")]
    public float GaugeDecreaseValue { get; set; }

    [JsonPropertyName("justComboAxcel_")]
    public float JustComboAxcel { get; set; }

    [JsonPropertyName("isCheckSpeedLimit_")]
    public bool IsCheckSpeedLimit { get; set; }

    [JsonPropertyName("speedLimitRate_")]
    public float SpeedLimitRate { get; set; }

    [JsonPropertyName("justComboMaxNum_")]
    public int JustComboMaxNum { get; set; }

    [JsonPropertyName("justComboMaxNumTransform_")]
    public int JustComboMaxNumTransform { get; set; }

    [JsonPropertyName("inputStepDirDecideThreshold_")]
    public float InputStepDirDecideThreshold { get; set; }

    [JsonPropertyName("isChangeAtkRate_")]
    public bool IsChangeAtkRate { get; set; }

    [JsonPropertyName("coefficient_")]
    public float Coefficient { get; set; }

    [JsonPropertyName("subGauge_TransformStep_")]
    public float SubGauge_TransformStep { get; set; }

    [JsonPropertyName("rapidAttackTime_")]
    public float RapidAttackTime { get; set; }

    [JsonPropertyName("isAddChargeRate_")]
    public bool IsAddChargeRate { get; set; }

    [JsonPropertyName("divisionValue_")]
    public float DivisionValue { get; set; }

    [JsonPropertyName("chargeCancelMinimumTime_")]
    public float ChargeCancelMinimumTime { get; set; }

    [JsonPropertyName("magicSwotdRushMoveTimeLimit_")]
    public float MagicSwotdRushMoveTimeLimit { get; set; }

    [JsonPropertyName("stepTargetSelectParam_")]
    public PlayerLockOnParameter StepTargetSelectParam { get; set; }

    [JsonPropertyName("rushMoveCutRate_NoEnemy_")]
    public float RushMoveCutRate_NoEnemy { get; set; }

    [JsonPropertyName("rushMoveCutRate_Front_")]
    public float RushMoveCutRate_Front { get; set; }

    [JsonPropertyName("rushMoveMaxRate_Front_")]
    public float RushMoveMaxRate_Front { get; set; }

    [JsonPropertyName("rushMoveCutRate_NoEnemy_Transform_")]
    public float RushMoveCutRate_NoEnemy_Transform { get; set; }

    [JsonPropertyName("rushMoveCutRate_Front_Transform_")]
    public float RushMoveCutRate_Front_Transform { get; set; }

    [JsonPropertyName("rushMoveMaxRate_Front_Transform_")]
    public float RushMoveMaxRate_Front_Transform { get; set; }

    [JsonPropertyName("attackJust3rdMoveDist_")]
    public float AttackJust3rdMoveDist { get; set; }

    [JsonPropertyName("abilityHealHpBaseAmount_")]
    public float AbilityHealHpBaseAmount { get; set; }

    [JsonPropertyName("abilityHealLimit_")]
    public float AbilityHealLimit { get; set; }

    [JsonPropertyName("abilityHealHpBaseAmountTransform_")]
    public float AbilityHealHpBaseAmountTransform { get; set; }

    [JsonPropertyName("abilityHealLimitTransform_")]
    public float AbilityHealLimitTransform { get; set; }

    [JsonPropertyName("stepBuffTime_")]
    public float StepBuffTime { get; set; }

    [JsonPropertyName("stepBuffRate_")]
    public float StepBuffRate { get; set; }

    [JsonPropertyName("linkAttackDistTransform_")]
    public float LinkAttackDistTransform { get; set; }

    [JsonPropertyName("linkAttackDistNPC_")]
    public float LinkAttackDistNPC { get; set; }

    [JsonPropertyName("magicSwotdLinkAttackTimeLimit_")]
    public float MagicSwotdLinkAttackTimeLimit { get; set; }

    [JsonPropertyName("assistEnhancedFinishRange_")]
    public float AssistEnhancedFinishRange { get; set; }

    [JsonPropertyName("assistTransformRange_")]
    public float AssistTransformRange { get; set; }

    [JsonPropertyName("assistEndAtkGaugeRate_")]
    public float AssistEndAtkGaugeRate { get; set; }

    [JsonPropertyName("photoModeImpossibleFrame_")]
    public int PhotoModeImpossibleFrame { get; set; }

    [JsonPropertyName("useHealAbilityHpRate_")]
    public float UseHealAbilityHpRate { get; set; }
}
