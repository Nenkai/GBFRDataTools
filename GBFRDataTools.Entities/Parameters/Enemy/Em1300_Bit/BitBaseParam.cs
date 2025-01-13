using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1300_Bit;

public class BitBaseParam : EnemyParameterInfo
{
    [JsonPropertyName("emissiveParamNormal_")]
    public EmissiveParam EmissiveParamNormal { get; set; }

    [JsonPropertyName("emissiveParamOff_")]
    public EmissiveParam EmissiveParamOff { get; set; }

    [JsonPropertyName("emissiveParamBlink_")]
    public EmissiveParam EmissiveParamBlink { get; set; }

    public BitBaseParam()
    {
    }

    public class EmissiveParam
    {
        [JsonPropertyName("sinMode_")]
        public bool SinMode { get; set; } // Offset 0x8

        [JsonPropertyName("emissiveBlinkTime_")]
        public float EmissiveBlinkTime { get; set; } // Offset 0xC

        [JsonPropertyName("emissiveStrength_")]
        public float EmissiveStrength { get; set; } // Offset 0x10

        [JsonPropertyName("emissiveStrengthUpper_")]
        public float EmissiveStrengthUpper { get; set; } // Offset 0x14

        [JsonPropertyName("emissiveStrengthLower_")]
        public float EmissiveStrengthLower { get; set; } // Offset 0x18

        public EmissiveParam()
        {
        }
    }
}
