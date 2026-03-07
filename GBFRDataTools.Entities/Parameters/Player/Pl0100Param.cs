using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl0100Param : PlayerParameterInfo
{
    [JsonPropertyName("classLvResetWaitSec_")]
    public float ClassLvResetWaitSec { get; set; } = 3f;

    [JsonPropertyName("clearAllRegenerateRateLv1_")]
    public float ClearAllRegenerateRateLv1 { get; set; } = 3f;

    [JsonPropertyName("clearAllRegenerateRateLv2_")]
    public float ClearAllRegenerateRateLv2 { get; set; } = 3.5f;

    [JsonPropertyName("clearAllRegenerateRateLv3_")]
    public float ClearAllRegenerateRateLv3 { get; set; } = 4f;

    [JsonPropertyName("clearAllRegenerateRateLv4_")]
    public float ClearAllRegenerateRateLv4 { get; set; } = 4.5f;

    [JsonPropertyName("clearAllRegenerateSecLv1_")]
    public float ClearAllRegenerateSecLv1 { get; set; } = 20f;

    [JsonPropertyName("clearAllRegenerateSecLv2_")]
    public float ClearAllRegenerateSecLv2 { get; set; } = 20f;

    [JsonPropertyName("clearAllRegenerateSecLv3_")]
    public float ClearAllRegenerateSecLv3 { get; set; } = 20f;

    [JsonPropertyName("clearAllRegenerateSecLv4_")]
    public float ClearAllRegenerateSecLv4 { get; set; } = 20f;

    [JsonPropertyName("reviveHealHpRateLv1_")]
    public float ReviveHealHpRateLv1 { get; set; } = 30f;

    [JsonPropertyName("reviveHealHpRateLv2_")]
    public float ReviveHealHpRateLv2 { get; set; } = 50f;

    [JsonPropertyName("reviveHealHpRateLv3_")]
    public float ReviveHealHpRateLv3 { get; set; } = 70f;

    [JsonPropertyName("reviveHealHpRateLv4_")]
    public float ReviveHealHpRateLv4 { get; set; } = 100f;

    [JsonPropertyName("abilityCoolTimeReduceSec_")]
    public float AbilityCoolTimeReduceSec { get; set; } = 1f;

    public Pl0100Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 75;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 3.4f;
        HitSEMinBreak = 0.05f;
        MaxLvHp = 30000;
        MaxLvAtk = 240;
        MaxLvDef = 1.05f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 1f;
        LimitSpecialArtsDamageRate = 0.9f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 9999;
        DamageLimitNormalAttack2 = 9999;
        DamageLimitSpecialAttack = 29999;
        DamageLimitAbility01 = 19999;
        DamageLimitAbility02 = 39999;
        DamageLimitAbility03 = 14999;
        DamageLimitAbility04 = 14999;
        DamageLimitAbility05 = 14999;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 1;
        DamageLimitAbility08 = 89999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 64999;
    }
}
