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

public class Pl0700Param : PlayerParameterInfo
{
    [JsonPropertyName("benedictionHealHpBaseAmount_Lv1_")]
    public float BenedictionHealHpBaseAmount_Lv1 { get; set; }

    [JsonPropertyName("benedictionHealHpBaseAmount_Lv2_")]
    public float BenedictionHealHpBaseAmount_Lv2 { get; set; }

    [JsonPropertyName("benedictionHealHpBaseAmount_Lv3_")]
    public float BenedictionHealHpBaseAmount_Lv3 { get; set; }

    [JsonPropertyName("benedictionHealHpBaseAmount_Lv4_")]
    public float BenedictionHealHpBaseAmount_Lv4 { get; set; }

    [JsonPropertyName("benedictionRegenerateHpBaseAmount_Lv2_")]
    public float BenedictionRegenerateHpBaseAmount_Lv2 { get; set; }

    [JsonPropertyName("benedictionRegenerateHpBaseAmount_Lv3_")]
    public float BenedictionRegenerateHpBaseAmount_Lv3 { get; set; }

    [JsonPropertyName("benedictionRegenerateHpBaseAmount_Lv4_")]
    public float BenedictionRegenerateHpBaseAmount_Lv4 { get; set; }

    [JsonPropertyName("benedictionDefUpRate_Lv3_")]
    public float BenedictionDefUpRate_Lv3 { get; set; }

    [JsonPropertyName("benedictionDefUpRate_Lv4_")]
    public float BenedictionDefUpRate_Lv4 { get; set; }

    [JsonPropertyName("benedictionAtkUpRate_Lv4_")]
    public float BenedictionAtkUpRate_Lv4 { get; set; }

    [JsonPropertyName("benedictionBuffKeepSec_Lv2_")]
    public float BenedictionBuffKeepSec_Lv2 { get; set; }

    [JsonPropertyName("benedictionBuffKeepSec_Lv3_")]
    public float BenedictionBuffKeepSec_Lv3 { get; set; }

    [JsonPropertyName("benedictionBuffKeepSec_Lv4_")]
    public float BenedictionBuffKeepSec_Lv4 { get; set; }

    [JsonPropertyName("benedictionHealLimit_Lv1_")]
    public float BenedictionHealLimit_Lv1 { get; set; }

    [JsonPropertyName("benedictionHealLimit_Lv2_")]
    public float BenedictionHealLimit_Lv2 { get; set; }

    [JsonPropertyName("benedictionHealLimit_Lv3_")]
    public float BenedictionHealLimit_Lv3 { get; set; }

    [JsonPropertyName("benedictionHealLimit_Lv4_")]
    public float BenedictionHealLimit_Lv4 { get; set; }

    [JsonPropertyName("limitBonusGhostNumBias01_")]
    public float LimitBonusGhostNumBias01 { get; set; }

    [JsonPropertyName("limitBonusGhostNumBias02_")]
    public float LimitBonusGhostNumBias02 { get; set; }

    [JsonPropertyName("limitBonusGhostNumBias03_")]
    public float LimitBonusGhostNumBias03 { get; set; }

    [JsonPropertyName("limitBonusGhostNumBias04_")]
    public float LimitBonusGhostNumBias04 { get; set; }
}
