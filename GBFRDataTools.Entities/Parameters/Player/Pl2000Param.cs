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

public class Pl2000Param : PlayerParameterInfo
{
    [JsonPropertyName("dragonChangeTime_")]
    public float DragonChangeTime { get; set; } = 50f;

    [JsonPropertyName("chargeAttackCombo1_")]
    public float ChargeAttackCombo1 { get; set; } = 3f;

    [JsonPropertyName("chargeAttackCombo2_")]
    public float ChargeAttackCombo2 { get; set; } = 2.25f;

    [JsonPropertyName("chargeAttackCombo3_")]
    public float ChargeAttackCombo3 { get; set; } = 1.5f;

    [JsonPropertyName("chargeAttackCombo4_")]
    public float ChargeAttackCombo4 { get; set; } = 0.5f;

    [JsonPropertyName("shot_L_RotX_")]
    public float Shot_L_RotX { get; set; } = -30f;

    [JsonPropertyName("shot_L_RotY_")]
    public float Shot_L_RotY { get; set; } = 45f;

    [JsonPropertyName("shot_H_RotX_")]
    public float Shot_H_RotX { get; set; } = -45f;

    [JsonPropertyName("shot_H_RotY_")]
    public float Shot_H_RotY { get; set; } = 30f;

    [JsonPropertyName("ability_healRate")]
    public float Ability_healRate { get; set; } = 0.15f;

    [JsonPropertyName("beamRotX")]
    public float BeamRotX { get; set; } = 5f;

    [JsonPropertyName("beamStartRotY")]
    public float BeamStartRotY { get; set; } = 90f;

    [JsonPropertyName("beamAddRotY")]
    public float BeamAddRotY { get; set; } = -5f;

    [JsonPropertyName("beamLength_")]
    public float BeamLength { get; set; } = 20f;

    [JsonPropertyName("beamBombInterval_")]
    public float BeamBombInterval { get; set; } = 0.05f;

    [JsonPropertyName("dragonLvUpRateAttack_")]
    public float DragonLvUpRateAttack { get; set; } = 1.01f;

    [JsonPropertyName("dragonLvUpRatePowerAttack_")]
    public float DragonLvUpRatePowerAttack { get; set; } = 1.01f;

    [JsonPropertyName("linkTimeAbilityCoolTimeBonus_NormalAttack_")]
    public float LinkTimeAbilityCoolTimeBonus_NormalAttack { get; set; } = 0.2f;

    [JsonPropertyName("linkTimeAbilityCoolTimeBonus_PowerAttack_")]
    public float LinkTimeAbilityCoolTimeBonus_PowerAttack { get; set; } = 0.2f;

    public Pl2000Param()
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
        LimitDamageRate = 1.1f;
        LimitSpecialArtsDamageRate = 0.7999999f;
        LimitAbilityDamageRate = 4f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 14999;
        DamageLimitNormalAttack2 = 49999;
        DamageLimitSpecialAttack = 7999;
        DamageLimitAbility01 = 24999;
        DamageLimitAbility02 = 99999;
        DamageLimitAbility03 = 54999;
        DamageLimitAbility04 = 19999;
        DamageLimitAbility05 = 1;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 1;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 29999;
    }
}
