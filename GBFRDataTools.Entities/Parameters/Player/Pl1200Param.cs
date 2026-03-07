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

public class Pl1200Param : PlayerParameterInfo
{
    [JsonPropertyName("addAtkRatByLinkTimeRapidSlash_")]
    public float AddAtkRatByLinkTimeRapidSlash { get; set; } = 0.1f;

    public Pl1200Param()
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
        LimitSpecialArtsDamageRate = 0.7999999f;
        LimitAbilityDamageRate = 0.7999999f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 6999;
        DamageLimitNormalAttack2 = 39999;
        DamageLimitSpecialAttack = 14999;
        DamageLimitAbility01 = 1;
        DamageLimitAbility02 = 19999;
        DamageLimitAbility03 = 34999;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 1;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 14999;
        DamageLimitAbility08 = 14999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 129999;
    }
}
