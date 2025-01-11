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

public class Pl2000Param : PlayerParameterInfo
{
    [JsonPropertyName("dragonChangeTime_")]
    public float DragonChangeTime { get; set; }

    [JsonPropertyName("chargeAttackCombo1_")]
    public float ChargeAttackCombo1 { get; set; }

    [JsonPropertyName("chargeAttackCombo2_")]
    public float ChargeAttackCombo2 { get; set; }

    [JsonPropertyName("chargeAttackCombo3_")]
    public float ChargeAttackCombo3 { get; set; }

    [JsonPropertyName("chargeAttackCombo4_")]
    public float ChargeAttackCombo4 { get; set; }

    [JsonPropertyName("shot_L_RotX_")]
    public float Shot_L_RotX { get; set; }

    [JsonPropertyName("shot_L_RotY_")]
    public float Shot_L_RotY { get; set; }

    [JsonPropertyName("shot_H_RotX_")]
    public float Shot_H_RotX { get; set; }

    [JsonPropertyName("shot_H_RotY_")]
    public float Shot_H_RotY { get; set; }

    [JsonPropertyName("ability_healRate")]
    public float Ability_healRate { get; set; }

    [JsonPropertyName("beamRotX")]
    public float BeamRotX { get; set; }

    [JsonPropertyName("beamStartRotY")]
    public float BeamStartRotY { get; set; }

    [JsonPropertyName("beamAddRotY")]
    public float BeamAddRotY { get; set; }

    [JsonPropertyName("beamLength_")]
    public float BeamLength { get; set; }

    [JsonPropertyName("beamBombInterval_")]
    public float BeamBombInterval { get; set; }

    [JsonPropertyName("dragonLvUpRateAttack_")]
    public float DragonLvUpRateAttack { get; set; }

    [JsonPropertyName("dragonLvUpRatePowerAttack_")]
    public float DragonLvUpRatePowerAttack { get; set; }

    [JsonPropertyName("linkTimeAbilityCoolTimeBonus_NormalAttack_")]
    public float LinkTimeAbilityCoolTimeBonus_NormalAttack { get; set; }

    [JsonPropertyName("linkTimeAbilityCoolTimeBonus_PowerAttack_")]
    public float LinkTimeAbilityCoolTimeBonus_PowerAttack { get; set; }
}
