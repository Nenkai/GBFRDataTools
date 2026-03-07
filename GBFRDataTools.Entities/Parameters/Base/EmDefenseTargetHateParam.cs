using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class EmDefenseTargetHateParam
{
    [JsonPropertyName("maxHateValue_")]
    public float MaxHateValue { get; set; }

    [JsonPropertyName("damageHateDecRate_")]
    public float DamageHateDecRate { get; set; }

    [JsonPropertyName("damageHateIncPerSec_")]
    public float DamageHateIncPerSec { get; set; }
}
