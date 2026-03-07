using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl1300Param : PlayerParameterInfo
{
    [JsonPropertyName("multiLockSpeed_")]
    public float MultiLockSpeed { get; set; } = 0.3f;

    [JsonPropertyName("slashDashSpeed_")]
    public float SlashDashSpeed { get; set; } = 1f;

    [JsonPropertyName("slashDashTime_")]
    public float SlashDashTime { get; set; } = 0.15f;

    [JsonPropertyName("counterComboCutNum_")]
    public int CounterComboCutNum { get; set; } = 4;

    [JsonPropertyName("illusionBuffBaseTime_")]
    public float IllusionBuffBaseTime { get; set; } = 30f;

    [JsonPropertyName("illusionBuff_Time_")]
    public float IllusionBuff_Time { get; set; } = 10f;

    [JsonPropertyName("illusionBuff_Distance_")]
    public float IllusionBuff_Distance { get; set; } = 100f;

    [JsonPropertyName("justComboAxcel_")]
    public float JustComboAxcel { get; set; } = 0.06f;

    [JsonPropertyName("justComboMaxNum_")]
    public int JustComboMaxNum { get; set; } = 10;

    [JsonPropertyName("justComboAtkHitScale_")]
    [Editable(false)]
    public BindingList<float> JustComboAtkHitScale { get; set; } = [.. Enumerable.Repeat<float>(0, 4).ToList()]; // std::array<float,4>

    [JsonPropertyName("uniqueAtkBuffRate")]
    [Editable(false)]
    public BindingList<float> UniqueAtkBuffRate { get; set; } = [.. Enumerable.Repeat<float>(0,4).ToList()]; // std::array<float,4>

    [JsonPropertyName("limitBonusDoubleAtkDelay_")]
    public float LimitBonusDoubleAtkDelay { get; set; } = 2f;

    [JsonPropertyName("limitBonusDoubleAtkBuffTime_")]
    public BindingList<float> LimitBonusDoubleAtkBuffTime { get; set; } = [.. Enumerable.Repeat<float>(0, 3).ToList()]; // std::array<float,3>

    [JsonPropertyName("spArtsBonusDamageRad_")]
    public float SpArtsBonusDamageRad { get; set; } = 0.5f;

    public Pl1300Param()
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
        LimitDamageRate = 0.6f;
        LimitSpecialArtsDamageRate = 0.6f;
        LimitAbilityDamageRate = 0.7f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 3999;
        DamageLimitNormalAttack2 = 29999;
        DamageLimitSpecialAttack = 9999;
        DamageLimitAbility01 = 14999;
        DamageLimitAbility02 = 7999;
        DamageLimitAbility03 = 1;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 24999;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 29999;
        DamageLimitAbility08 = 69999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 19999;
    }
}
