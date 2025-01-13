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

public class Pl1700Param : PlayerParameterInfo
{
    [JsonPropertyName("chargeAtkRateIncrease_")]
    public float ChargeAtkRateIncrease { get; set; } = 0f;

    [JsonPropertyName("chargeBreakRateIncrease_")]
    public float ChargeBreakRateIncrease { get; set; } = 0f;

    [JsonPropertyName("adversityAtkRateIncrease_")]
    public float AdversityAtkRateIncrease { get; set; } = 1.5f;

    [JsonPropertyName("adversityBreakRateIncrease_")]
    public float AdversityBreakRateIncrease { get; set; } = 1.5f;

    [JsonPropertyName("coveredActionDamageCountMax_")]
    public int CoveredActionDamageCountMax { get; set; } = 5;

    [JsonPropertyName("coveredActionAddAtkMaxRate_")]
    public float CoveredActionAddAtkMaxRate { get; set; } = 25f;

    [JsonPropertyName("coveredActionAddBreakMaxRate_")]
    public float CoveredActionAddBreakMaxRate { get; set; } = 25f;

    [JsonPropertyName("uniqueAtkBuffRate_")]
    public float UniqueAtkBuffRate { get; set; } = 0.2f;

    [JsonPropertyName("uniqueDeffenceBuffRate_")]
    public float UniqueDeffenceBuffRate { get; set; } = 0.2f;

    [JsonPropertyName("uniqueBuffEffectiveSec_")]
    public float UniqueBuffEffectiveSec { get; set; } = 30f;

    [JsonPropertyName("systemGageMaxLv2_")]
    public float SystemGageMaxLv2 { get; set; } = 1000f;

    [JsonPropertyName("systemGageMaxLv3_")]
    public float SystemGageMaxLv3 { get; set; } = 1500f;

    [JsonPropertyName("nochargeGageAddRate_")]
    public float NochargeGageAddRate { get; set; } = 0.3f;

    [JsonPropertyName("addAttackHitGage_XY_")]
    public float AddAttackHitGage_XY { get; set; } = 300f;

    [JsonPropertyName("addAttackHitGage_XYY_")]
    public float AddAttackHitGage_XYY { get; set; } = 400f;

    [JsonPropertyName("addAttackHitGage_XXY_")]
    public float AddAttackHitGage_XXY { get; set; } = 400f;

    [JsonPropertyName("addAttackHitGage_XXYY_")]
    public float AddAttackHitGage_XXYY { get; set; } = 500f;

    [JsonPropertyName("addAttackHitGage_XXXY_")]
    public float AddAttackHitGage_XXXY { get; set; } = 700f;

    [JsonPropertyName("addAttackHitGage_XXXYY_")]
    public float AddAttackHitGage_XXXYY { get; set; } = 700f;

    [JsonPropertyName("addAttackHitGage_LinkAttack_")]
    public float AddAttackHitGage_LinkAttack { get; set; } = 800f;

    [JsonPropertyName("autoDecreaseStartWaitSec_")]
    public float AutoDecreaseStartWaitSec { get; set; } = 10f;

    [JsonPropertyName("autoDecreasePoint_")]
    public float AutoDecreasePoint { get; set; } = 3f;

    [JsonPropertyName("linkTimeDamageLimit_")]
    public float LinkTimeDamageLimit { get; set; } = 0.6f;

    public Pl1700Param()
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
        LimitDamageRate = 1f;
        LimitSpecialArtsDamageRate = 1f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 14999;
        DamageLimitNormalAttack2 = 249999;
        DamageLimitSpecialAttack = 39999;
        DamageLimitAbility01 = 64999;
        DamageLimitAbility02 = 49999;
        DamageLimitAbility03 = 89999;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 1;
        DamageLimitAbility06 = 99999;
        DamageLimitAbility07 = 29999;
        DamageLimitAbility08 = 299999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 4999;
    }
}
