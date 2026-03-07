using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class EmDamageReactionCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmDamageReactionCondition);

    [JsonPropertyName("damageReactionStrHash_")]
    public DamageReactionStr DamageReactionStrHash { get; set; }

    public override string GetCaption()
    {
        return DamageReactionStrHash.ToString();
    }
}

public enum DamageReactionStr : uint
{
    [Display(Order = 0)]
    Type0_681569D8 = 0x681569D8,

    [Display(Order = 1)]
    Type1_A5C86FB1 = 0xA5C86FB1,

    [Display(Order = 2)]
    Type2_D226E939 = 0xD226E939,

    [Display(Order = 3)]
    Type3_851FB3EE = 0x851FB3EE,

    [Display(Order = 4)]
    Type4_62A8580D = 0x62A8580D,

    [Display(Order = 5)]
    Type5_C0C2B73F = 0xC0C2B73F,

    [Display(Order = 6)]
    Type6_251B6F6C = 0x251B6F6C,

    [Display(Order = 7)]
    Type7_97F8A897 = 0x97F8A897,

    [Display(Order = 8)]
    Type8_0EF1F92D = 0x0EF1F92D,

    [Display(Order = 9)]
    Type9_79F6C9BB = 0x79F6C9BB,

    [Display(Order = 10)]
    Type10_3B794280 = 0x3B794280,

    [Display(Order = 11)]
    Type11_D63E2E44 = 0xD63E2E44,

    [Display(Order = 12)]
    Type12_220B66B0 = 0x220B66B0,

    [Display(Order = 100)]
    None = 0,
}
