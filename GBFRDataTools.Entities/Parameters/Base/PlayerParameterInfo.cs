using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class PlayerParameterInfo : CharaParameterBase
{
    [JsonPropertyName("maxLvHp_")]
    public int MaxLvHp { get; set; }

    [JsonPropertyName("maxLvAtk_")]
    public int MaxLvAtk { get; set; }

    [JsonPropertyName("maxLvDef_")]
    public float MaxLvDef { get; set; }

    [JsonPropertyName("maxLvExp_")]
    public int MaxLvExp { get; set; }

    [JsonPropertyName("criticalBaseRate_")]
    public float CriticalBaseRate { get; set; }

    [JsonPropertyName("baseBreakPower_")]
    public int BaseBreakPower { get; set; }

    [JsonPropertyName("limitDamageRate_")]
    public float LimitDamageRate { get; set; }

    [JsonPropertyName("limitSpecialArtsDamageRate_")]
    public float LimitSpecialArtsDamageRate { get; set; }

    [JsonPropertyName("limitAbilityDamageRate_")]
    public float LimitAbilityDamageRate { get; set; }

    [JsonPropertyName("aiMoveNotargetDistance_")]
    public float AiMoveNotargetDistance { get; set; }

    [JsonPropertyName("damageLimitNormalAttack_")]
    public int DamageLimitNormalAttack { get; set; }

    [JsonPropertyName("damageLimitNormalAttack2_")]
    public int DamageLimitNormalAttack2 { get; set; }

    [JsonPropertyName("damageLimitSpecialAttack_")]
    public int DamageLimitSpecialAttack { get; set; }

    [JsonPropertyName("damageLimitAbility01_")]
    public int DamageLimitAbility01 { get; set; }

    [JsonPropertyName("damageLimitAbility02_")]
    public int DamageLimitAbility02 { get; set; }

    [JsonPropertyName("damageLimitAbility03_")]
    public int DamageLimitAbility03 { get; set; }

    [JsonPropertyName("damageLimitAbility04_")]
    public int DamageLimitAbility04 { get; set; }

    [JsonPropertyName("damageLimitAbility05_")]
    public int DamageLimitAbility05 { get; set; }

    [JsonPropertyName("damageLimitAbility06_")]
    public int DamageLimitAbility06 { get; set; }

    [JsonPropertyName("damageLimitAbility07_")]
    public int DamageLimitAbility07 { get; set; }

    [JsonPropertyName("damageLimitAbility08_")]
    public int DamageLimitAbility08 { get; set; }

    [JsonPropertyName("damageLimitLinkAttack_")]
    public int DamageLimitLinkAttack { get; set; }

    [JsonPropertyName("damageLimitSpecialArtsStart_")]
    public int DamageLimitSpecialArtsStart { get; set; }

    [JsonPropertyName("damageLimitSpecialArts_")]
    public int DamageLimitSpecialArts { get; set; }

    [JsonPropertyName("damageLimitDataList_")]
    public PlayerDamageLimitParameter DamageLimitDataList { get; set; }

    [JsonPropertyName("eyeCtrlParam_")]
    public PlayerParameterInfo EyeCtrlParam { get; set; }
}
