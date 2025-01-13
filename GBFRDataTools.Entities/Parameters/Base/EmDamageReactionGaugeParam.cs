using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class EmDamageReactionGaugeParam
{
    [JsonPropertyName("min_")]
    public int Min { get; set; }

    [JsonPropertyName("max_")]
    public int Max { get; set; }

    [JsonPropertyName("reduce_")]
    public int Reduce { get; set; }

    [JsonPropertyName("stopSec_")]
    public float StopSec { get; set; }

    [JsonPropertyName("coolTime_")]
    public float CoolTime { get; set; }

    public EmDamageReactionGaugeParam()
    {
    }
}
