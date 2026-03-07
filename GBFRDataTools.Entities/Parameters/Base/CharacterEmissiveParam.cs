using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class CharacterEmissiveParam
{
    [JsonPropertyName("sinMode_")]
    public bool SinMode { get; set; }

    [JsonPropertyName("emissiveBlinkSecond_")]
    public float EmissiveBlinkSecond { get; set; }

    [JsonPropertyName("emissiveBlinkMaxSecond_")]
    public float EmissiveBlinkMaxSecond { get; set; }

    [JsonPropertyName("emissiveBlinkPow_")]
    public int EmissiveBlinkPow { get; set; }

    [JsonPropertyName("emissiveStrengthUpper_")]
    public float EmissiveStrengthUpper { get; set; }

    [JsonPropertyName("emissiveStrengthLower_")]
    public float EmissiveStrengthLower { get; set; }
}
