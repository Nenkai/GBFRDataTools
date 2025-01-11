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

public class Pl1700Param : PlayerParameterInfo
{
    [JsonPropertyName("chargeAtkRateIncrease_")]
    public float ChargeAtkRateIncrease { get; set; }

    [JsonPropertyName("chargeBreakRateIncrease_")]
    public float ChargeBreakRateIncrease { get; set; }

    [JsonPropertyName("adversityAtkRateIncrease_")]
    public float AdversityAtkRateIncrease { get; set; }

    [JsonPropertyName("adversityBreakRateIncrease_")]
    public float AdversityBreakRateIncrease { get; set; }

    [JsonPropertyName("coveredActionDamageCountMax_")]
    public int CoveredActionDamageCountMax { get; set; }

    [JsonPropertyName("coveredActionAddAtkMaxRate_")]
    public float CoveredActionAddAtkMaxRate { get; set; }

    [JsonPropertyName("coveredActionAddBreakMaxRate_")]
    public float CoveredActionAddBreakMaxRate { get; set; }

    [JsonPropertyName("uniqueAtkBuffRate_")]
    public float UniqueAtkBuffRate { get; set; }

    [JsonPropertyName("uniqueDeffenceBuffRate_")]
    public float UniqueDeffenceBuffRate { get; set; }

    [JsonPropertyName("uniqueBuffEffectiveSec_")]
    public float UniqueBuffEffectiveSec { get; set; }

    [JsonPropertyName("systemGageMaxLv2_")]
    public float SystemGageMaxLv2 { get; set; }

    [JsonPropertyName("systemGageMaxLv3_")]
    public float SystemGageMaxLv3 { get; set; }

    [JsonPropertyName("nochargeGageAddRate_")]
    public float NochargeGageAddRate { get; set; }

    [JsonPropertyName("addAttackHitGage_XY_")]
    public float AddAttackHitGage_XY { get; set; }

    [JsonPropertyName("addAttackHitGage_XYY_")]
    public float AddAttackHitGage_XYY { get; set; }

    [JsonPropertyName("addAttackHitGage_XXY_")]
    public float AddAttackHitGage_XXY { get; set; }

    [JsonPropertyName("addAttackHitGage_XXYY_")]
    public float AddAttackHitGage_XXYY { get; set; }

    [JsonPropertyName("addAttackHitGage_XXXY_")]
    public float AddAttackHitGage_XXXY { get; set; }

    [JsonPropertyName("addAttackHitGage_XXXYY_")]
    public float AddAttackHitGage_XXXYY { get; set; }

    [JsonPropertyName("addAttackHitGage_LinkAttack_")]
    public float AddAttackHitGage_LinkAttack { get; set; }

    [JsonPropertyName("autoDecreaseStartWaitSec_")]
    public float AutoDecreaseStartWaitSec { get; set; }

    [JsonPropertyName("autoDecreasePoint_")]
    public float AutoDecreasePoint { get; set; }

    [JsonPropertyName("linkTimeDamageLimit_")]
    public float LinkTimeDamageLimit { get; set; }
}
