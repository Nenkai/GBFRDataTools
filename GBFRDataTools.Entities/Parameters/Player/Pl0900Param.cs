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

public class Pl0900Param : PlayerParameterInfo
{
    [JsonPropertyName("addBraveGageHit_LinkAttack_")]
    public float AddBraveGageHit_LinkAttack { get; set; } = 600f;

    [JsonPropertyName("addBraveGageHit_XXX_")]
    public float AddBraveGageHit_XXX { get; set; } = 200f;

    [JsonPropertyName("addBraveGageHit_XYY_")]
    public float AddBraveGageHit_XYY { get; set; } = 400f;

    [JsonPropertyName("addBraveGageHit_XXYY_")]
    public float AddBraveGageHit_XXYY { get; set; } = 500f;

    [JsonPropertyName("addBraveGageHit_XXXYY_")]
    public float AddBraveGageHit_XXXYY { get; set; } = 500f;

    [JsonPropertyName("addBraveGageGuard_")]
    public float AddBraveGageGuard { get; set; } = 150f;

    [JsonPropertyName("guardPointDamageCutRate_")]
    public float GuardPointDamageCutRate { get; set; } = 0.25f;

    [JsonPropertyName("finishAtkHitArmorKeepSec_")]
    public float FinishAtkHitArmorKeepSec { get; set; } = 10f;

    [JsonPropertyName("linkTimeAtkRate_")]
    public float LinkTimeAtkRate { get; set; } = 0.2f;

    [JsonPropertyName("linkTimeDamageLimit_")]
    public float LinkTimeDamageLimit { get; set; } = 0.7999999f;

    public Pl0900Param()
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
        LimitDamageRate = 1.5f;
        LimitSpecialArtsDamageRate = 1f;
        LimitAbilityDamageRate = 3f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 22999;
        DamageLimitNormalAttack2 = 74999;
        DamageLimitSpecialAttack = 44999;
        DamageLimitAbility01 = 1;
        DamageLimitAbility02 = 19999;
        DamageLimitAbility03 = 1;
        DamageLimitAbility04 = 49999;
        DamageLimitAbility05 = 64999;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 299999;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 259999;
    }
}
