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

public class Pl1100Param : PlayerParameterInfo
{
    [JsonPropertyName("eyeEmissiveRate_")]
    public float EyeEmissiveRate { get; set; } = 0.03f;

    [JsonPropertyName("fullFaceHelmEyeEmissiveRate_")]
    public float FullFaceHelmEyeEmissiveRate { get; set; } = 50f;

    public Pl1100Param()
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
        LimitDamageRate = 2.2f;
        LimitSpecialArtsDamageRate = 0.6f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 19999;
        DamageLimitNormalAttack2 = 29999;
        DamageLimitSpecialAttack = 49999;
        DamageLimitAbility01 = 54999;
        DamageLimitAbility02 = 64999;
        DamageLimitAbility03 = 1;
        DamageLimitAbility04 = 84999;
        DamageLimitAbility05 = 1;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 69999;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 89999;
    }
}
