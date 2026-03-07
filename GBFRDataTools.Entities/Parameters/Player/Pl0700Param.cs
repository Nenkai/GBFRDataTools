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

public class Pl0700Param : PlayerParameterInfo
{
    [JsonPropertyName("benedictionHealHpBaseAmount_Lv1_")]
    public float BenedictionHealHpBaseAmount_Lv1 { get; set; } = 30f;

    [JsonPropertyName("benedictionHealHpBaseAmount_Lv2_")]
    public float BenedictionHealHpBaseAmount_Lv2 { get; set; } = 40f;

    [JsonPropertyName("benedictionHealHpBaseAmount_Lv3_")]
    public float BenedictionHealHpBaseAmount_Lv3 { get; set; } = 50f;

    [JsonPropertyName("benedictionHealHpBaseAmount_Lv4_")]
    public float BenedictionHealHpBaseAmount_Lv4 { get; set; } = 60f;

    [JsonPropertyName("benedictionRegenerateHpBaseAmount_Lv2_")]
    public float BenedictionRegenerateHpBaseAmount_Lv2 { get; set; } = 3f;

    [JsonPropertyName("benedictionRegenerateHpBaseAmount_Lv3_")]
    public float BenedictionRegenerateHpBaseAmount_Lv3 { get; set; } = 4f;

    [JsonPropertyName("benedictionRegenerateHpBaseAmount_Lv4_")]
    public float BenedictionRegenerateHpBaseAmount_Lv4 { get; set; } = 6f;

    [JsonPropertyName("benedictionDefUpRate_Lv3_")]
    public float BenedictionDefUpRate_Lv3 { get; set; } = 0.09999999f;

    [JsonPropertyName("benedictionDefUpRate_Lv4_")]
    public float BenedictionDefUpRate_Lv4 { get; set; } = 0.2f;

    [JsonPropertyName("benedictionAtkUpRate_Lv4_")]
    public float BenedictionAtkUpRate_Lv4 { get; set; } = 0.2f;

    [JsonPropertyName("benedictionBuffKeepSec_Lv2_")]
    public float BenedictionBuffKeepSec_Lv2 { get; set; } = 30f;

    [JsonPropertyName("benedictionBuffKeepSec_Lv3_")]
    public float BenedictionBuffKeepSec_Lv3 { get; set; } = 30f;

    [JsonPropertyName("benedictionBuffKeepSec_Lv4_")]
    public float BenedictionBuffKeepSec_Lv4 { get; set; } = 30f;

    [JsonPropertyName("benedictionHealLimit_Lv1_")]
    public float BenedictionHealLimit_Lv1 { get; set; } = 10000f;

    [JsonPropertyName("benedictionHealLimit_Lv2_")]
    public float BenedictionHealLimit_Lv2 { get; set; } = 13000f;

    [JsonPropertyName("benedictionHealLimit_Lv3_")]
    public float BenedictionHealLimit_Lv3 { get; set; } = 16000f;

    [JsonPropertyName("benedictionHealLimit_Lv4_")]
    public float BenedictionHealLimit_Lv4 { get; set; } = 20000f;

    [JsonPropertyName("limitBonusGhostNumBias01_")]
    public float LimitBonusGhostNumBias01 { get; set; } = 50f;

    [JsonPropertyName("limitBonusGhostNumBias02_")]
    public float LimitBonusGhostNumBias02 { get; set; } = 100f;

    [JsonPropertyName("limitBonusGhostNumBias03_")]
    public float LimitBonusGhostNumBias03 { get; set; } = 150f;

    [JsonPropertyName("limitBonusGhostNumBias04_")]
    public float LimitBonusGhostNumBias04 { get; set; } = 200f;

    public Pl0700Param()
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
        LimitDamageRate = 0.5f;
        LimitSpecialArtsDamageRate = 0.7f;
        LimitAbilityDamageRate = 0.7f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 14999;
        DamageLimitNormalAttack2 = 4999;
        DamageLimitSpecialAttack = 2499;
        DamageLimitAbility01 = 49999;
        DamageLimitAbility02 = 29999;
        DamageLimitAbility03 = 1;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 5999;
        DamageLimitAbility06 = 14999;
        DamageLimitAbility07 = 1;
        DamageLimitAbility08 = 24999;
        DamageLimitLinkAttack = 24999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 39999;
    }
}
