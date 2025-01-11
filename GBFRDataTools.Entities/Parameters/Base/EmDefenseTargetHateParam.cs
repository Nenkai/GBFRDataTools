using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class EmDefenseTargetHateParam
{
    [JsonPropertyName("maxHateValue_")]
    public float MaxHateValue { get; set; }

    [JsonPropertyName("damageHateDecRate_")]
    public float DamageHateDecRate { get; set; }

    [JsonPropertyName("damageHateIncPerSec_")]
    public float DamageHateIncPerSec { get; set; }
}
