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

public class Pl1000Param : PlayerParameterInfo
{
    [JsonPropertyName("chargeSpeedRate_1Combo_")]
    public float ChargeSpeedRate_1Combo { get; set; } = 0.65f;

    [JsonPropertyName("chargeSpeedRate_2Combo_")]
    public float ChargeSpeedRate_2Combo { get; set; } = 0.5f;

    [JsonPropertyName("chargeSpeedRate_3Combo_")]
    public float ChargeSpeedRate_3Combo { get; set; } = 0.35f;

    [JsonPropertyName("chargeSpeedRate_4Combo_")]
    public float ChargeSpeedRate_4Combo { get; set; } = 0.2f;

    [JsonPropertyName("cyclon_RotY_")]
    public float Cyclon_RotY { get; set; } = 90f;

    [JsonPropertyName("cyclon_SetDist_")]
    public float Cyclon_SetDist { get; set; } = 6.5f;

    public Pl1000Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 75;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4.8f;
        HitSEMinBreak = 0.05f;
        MaxLvHp = 30000;
        MaxLvAtk = 240;
        MaxLvDef = 1.05f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 2f;
        LimitSpecialArtsDamageRate = 0.7999999f;
        LimitAbilityDamageRate = 0.9f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 19999;
        DamageLimitNormalAttack2 = 79999;
        DamageLimitSpecialAttack = 24999;
        DamageLimitAbility01 = 84999;
        DamageLimitAbility02 = 1;
        DamageLimitAbility03 = 1;
        DamageLimitAbility04 = 24999;
        DamageLimitAbility05 = 1;
        DamageLimitAbility06 = 19999;
        DamageLimitAbility07 = 54999;
        DamageLimitAbility08 = 9999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 24999;
    }
}
