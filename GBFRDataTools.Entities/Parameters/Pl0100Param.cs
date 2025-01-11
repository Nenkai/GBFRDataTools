using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters;

public class Pl0100Param : PlayerParameterInfo
{
    [JsonPropertyName("classLvResetWaitSec_")]
    public float ClassLvResetWaitSec { get; set; }

    [JsonPropertyName("clearAllRegenerateRateLv1_")]
    public float ClearAllRegenerateRateLv1 { get; set; }

    [JsonPropertyName("clearAllRegenerateRateLv2_")]
    public float ClearAllRegenerateRateLv2 { get; set; }

    [JsonPropertyName("clearAllRegenerateRateLv3_")]
    public float ClearAllRegenerateRateLv3 { get; set; }

    [JsonPropertyName("clearAllRegenerateRateLv4_")]
    public float ClearAllRegenerateRateLv4 { get; set; }

    [JsonPropertyName("clearAllRegenerateSecLv1_")]
    public float ClearAllRegenerateSecLv1 { get; set; }

    [JsonPropertyName("clearAllRegenerateSecLv2_")]
    public float ClearAllRegenerateSecLv2 { get; set; }

    [JsonPropertyName("clearAllRegenerateSecLv3_")]
    public float ClearAllRegenerateSecLv3 { get; set; }

    [JsonPropertyName("clearAllRegenerateSecLv4_")]
    public float ClearAllRegenerateSecLv4 { get; set; }

    [JsonPropertyName("reviveHealHpRateLv1_")]
    public float ReviveHealHpRateLv1 { get; set; }

    [JsonPropertyName("reviveHealHpRateLv2_")]
    public float ReviveHealHpRateLv2 { get; set; }

    [JsonPropertyName("reviveHealHpRateLv3_")]
    public float ReviveHealHpRateLv3 { get; set; }

    [JsonPropertyName("reviveHealHpRateLv4_")]
    public float ReviveHealHpRateLv4 { get; set; }

    [JsonPropertyName("abilityCoolTimeReduceSec_")]
    public float AbilityCoolTimeReduceSec { get; set; }
}
