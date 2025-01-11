using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl1300Param : PlayerParameterInfo
{
    [JsonPropertyName("multiLockSpeed_")]
    public float MultiLockSpeed { get; set; }

    [JsonPropertyName("slashDashSpeed_")]
    public float SlashDashSpeed { get; set; }

    [JsonPropertyName("slashDashTime_")]
    public float SlashDashTime { get; set; }

    [JsonPropertyName("counterComboCutNum_")]
    public int CounterComboCutNum { get; set; }

    [JsonPropertyName("illusionBuffBaseTime_")]
    public float IllusionBuffBaseTime { get; set; }

    [JsonPropertyName("illusionBuff_Time_")]
    public float IllusionBuff_Time { get; set; }

    [JsonPropertyName("illusionBuff_Distance_")]
    public float IllusionBuff_Distance { get; set; }

    [JsonPropertyName("justComboAxcel_")]
    public float JustComboAxcel { get; set; }

    [JsonPropertyName("justComboMaxNum_")]
    public int JustComboMaxNum { get; set; }

    [JsonPropertyName("justComboAtkHitScale_")]
    public BindingList<float> JustComboAtkHitScale { get; set; } = []; // std::array<float,4>

    [JsonPropertyName("uniqueAtkBuffRate")]
    public BindingList<float> uniqueAtkBuffRate { get; set; } = []; // std::array<float,4>

    [JsonPropertyName("limitBonusDoubleAtkDelay_")]
    public float LimitBonusDoubleAtkDelay { get; set; }

    [JsonPropertyName("limitBonusDoubleAtkBuffTime_")]
    public BindingList<float> LimitBonusDoubleAtkBuffTime { get; set; } = []; // std::array<float,3>

    [JsonPropertyName("spArtsBonusDamageRad_")]
    public float SpArtsBonusDamageRad { get; set; }
}
