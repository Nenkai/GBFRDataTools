using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl0800Param : PlayerParameterInfo
{
    [JsonPropertyName("limitBonus_MaxAtkRate_Lv0_")]
    public float LimitBonus_MaxAtkRate_Lv0 { get; set; }

    [JsonPropertyName("limitBonus_IncreaseAtkRate_Lv0_")]
    public float LimitBonus_IncreaseAtkRate_Lv0 { get; set; }

    [JsonPropertyName("limitBonus_AttackHitCountMax_Lv0_")]
    public int LimitBonus_AttackHitCountMax_Lv0 { get; set; }

    [JsonPropertyName("limitBonus_MaxAtkRate_Lv1_")]
    public float LimitBonus_MaxAtkRate_Lv1 { get; set; }

    [JsonPropertyName("limitBonus_IncreaseAtkRate_Lv1_")]
    public float LimitBonus_IncreaseAtkRate_Lv1 { get; set; }

    [JsonPropertyName("limitBonus_AttackHitCountMax_Lv1_")]
    public int LimitBonus_AttackHitCountMax_Lv1 { get; set; }

    [JsonPropertyName("limitBonus_MaxAtkRate_Lv2_")]
    public float LimitBonus_MaxAtkRate_Lv2 { get; set; }

    [JsonPropertyName("limitBonus_IncreaseAtkRate_Lv2_")]
    public float LimitBonus_IncreaseAtkRate_Lv2 { get; set; }

    [JsonPropertyName("limitBonus_AttackHitCountMax_Lv2_")]
    public int LimitBonus_AttackHitCountMax_Lv2 { get; set; }

    [JsonPropertyName("limitBonus_MaxAtkRate_Lv3_")]
    public float LimitBonus_MaxAtkRate_Lv3 { get; set; }

    [JsonPropertyName("limitBonus_IncreaseAtkRate_Lv3_")]
    public float LimitBonus_IncreaseAtkRate_Lv3 { get; set; }

    [JsonPropertyName("limitBonus_AttackHitCountMax_Lv3_")]
    public int LimitBonus_AttackHitCountMax_Lv3 { get; set; }

    [JsonPropertyName("frontStepCheckAngle_")]
    public float FrontStepCheckAngle { get; set; }

    [JsonPropertyName("backStepCheckAngle_")]
    public float BackStepCheckAngle { get; set; }

    [JsonPropertyName("inputStepDirDecideThreshold_")]
    public float InputStepDirDecideThreshold { get; set; }

    [JsonPropertyName("stepTargetSelectParam_")]
    public PlayerLockOnParameter StepTargetSelectParam { get; set; }

    [JsonPropertyName("stepContinueTargetSelectParam_")]
    public PlayerLockOnParameter StepContinueTargetSelectParam { get; set; }
}
