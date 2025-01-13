using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl0800Param : PlayerParameterInfo
{
    [JsonPropertyName("limitBonus_MaxAtkRate_Lv0_")]
    public float LimitBonus_MaxAtkRate_Lv0 { get; set; } = 15f;

    [JsonPropertyName("limitBonus_IncreaseAtkRate_Lv0_")]
    public float LimitBonus_IncreaseAtkRate_Lv0 { get; set; } = 3f;

    [JsonPropertyName("limitBonus_AttackHitCountMax_Lv0_")]
    public int LimitBonus_AttackHitCountMax_Lv0 { get; set; } = 10;

    [JsonPropertyName("limitBonus_MaxAtkRate_Lv1_")]
    public float LimitBonus_MaxAtkRate_Lv1 { get; set; } = 20f;

    [JsonPropertyName("limitBonus_IncreaseAtkRate_Lv1_")]
    public float LimitBonus_IncreaseAtkRate_Lv1 { get; set; } = 4f;

    [JsonPropertyName("limitBonus_AttackHitCountMax_Lv1_")]
    public int LimitBonus_AttackHitCountMax_Lv1 { get; set; } = 10;

    [JsonPropertyName("limitBonus_MaxAtkRate_Lv2_")]
    public float LimitBonus_MaxAtkRate_Lv2 { get; set; } = 25f;

    [JsonPropertyName("limitBonus_IncreaseAtkRate_Lv2_")]
    public float LimitBonus_IncreaseAtkRate_Lv2 { get; set; } = 5f;

    [JsonPropertyName("limitBonus_AttackHitCountMax_Lv2_")]
    public int LimitBonus_AttackHitCountMax_Lv2 { get; set; } = 10;

    [JsonPropertyName("limitBonus_MaxAtkRate_Lv3_")]
    public float LimitBonus_MaxAtkRate_Lv3 { get; set; } = 30f;

    [JsonPropertyName("limitBonus_IncreaseAtkRate_Lv3_")]
    public float LimitBonus_IncreaseAtkRate_Lv3 { get; set; } = 6f;

    [JsonPropertyName("limitBonus_AttackHitCountMax_Lv3_")]
    public int LimitBonus_AttackHitCountMax_Lv3 { get; set; } = 10;

    [JsonPropertyName("frontStepCheckAngle_")]
    public float FrontStepCheckAngle { get; set; } = 30f;

    [JsonPropertyName("backStepCheckAngle_")]
    public float BackStepCheckAngle { get; set; } = 45f;

    [JsonPropertyName("inputStepDirDecideThreshold_")]
    public float InputStepDirDecideThreshold { get; set; } = 150f;

    [JsonPropertyName("stepTargetSelectParam_")]
    public PlayerLockOnParameter StepTargetSelectParam { get; set; }

    [JsonPropertyName("stepContinueTargetSelectParam_")]
    public PlayerLockOnParameter StepContinueTargetSelectParam { get; set; }

    public Pl0800Param()
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
        MaxLvDef = 1.05f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 0.7999999f;
        LimitSpecialArtsDamageRate = 0.6f;
        LimitAbilityDamageRate = 0.7999999f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 3999;
        DamageLimitNormalAttack2 = 29999;
        DamageLimitSpecialAttack = 9999;
        DamageLimitAbility01 = 34999;
        DamageLimitAbility02 = 9999;
        DamageLimitAbility03 = 14999;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 89999;
        DamageLimitAbility06 = 49999;
        DamageLimitAbility07 = 1;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 39999;
    }
}
