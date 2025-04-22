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

public class Pl2200Param : PlayerParameterInfo
{
    [JsonPropertyName("swordShineGageDecreasePoint_")]
    public float SwordShineGageDecreasePoint { get; set; } = 0.85f;

    [JsonPropertyName("swordShineAutoDecreaseStopSec_")]
    public float SwordShineAutoDecreaseStopSec { get; set; } = 2f;

    [JsonPropertyName("inifinitoCreareSwordNum_")]
    public int InifinitoCreareSwordNum { get; set; } = 7;

    [JsonPropertyName("inifinitoCreareSwordRadius_")]
    public float InifinitoCreareSwordRadius { get; set; } = 10f;

    [JsonPropertyName("swordGodApeearingSec_")]
    public float SwordGodApeearingSec { get; set; } = 1.6f;

    [JsonPropertyName("gageIncreaseDataList_")]
    public BindingList<GageAddParam> GageIncreaseDataList { get; set; } = []; // std::vector<Pl2200Param::GageAddParam>

    [JsonPropertyName("linkAttack_SwordGodGageIncrement_")]
    public float LinkAttack_SwordGodGageIncrement { get; set; } = 250f;

    [JsonPropertyName("linkAttack_SwordShineGageIncrement_")]
    public float LinkAttack_SwordShineGageIncrement { get; set; } = 500f;

    [JsonPropertyName("swordGodGageResetGraseSec_")]
    public float SwordGodGageResetGraseSec { get; set; } = 2f;

    [JsonPropertyName("ability08RetrySec_")]
    public float Ability08RetrySec { get; set; } = 20f;

    public Pl2200Param()
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
        MaxLvDef = 2f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 1f;
        LimitSpecialArtsDamageRate = 1f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 11999;
        DamageLimitNormalAttack2 = 99999;
        DamageLimitSpecialAttack = 29999;
        DamageLimitAbility01 = 9999;
        DamageLimitAbility02 = 19999;
        DamageLimitAbility03 = 44999;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 29999;
        DamageLimitAbility06 = 34999;
        DamageLimitAbility07 = 1;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 34999;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class GageAddParam // Pl2200Param::GageAddParam
    {
        [JsonPropertyName("actionID_")]
        public int ActionID { get; set; }

        [JsonPropertyName("swordGodGageIncrease_")]
        public float SwordGodGageIncrease { get; set; }

        [JsonPropertyName("swordShineGageIncrease_")]
        public float SwordShineGageIncrease { get; set; }

    }
}
