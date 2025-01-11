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

public class Pl1100Param : PlayerParameterInfo
{
    [JsonPropertyName("eyeEmissiveRate_")]
    public float EyeEmissiveRate { get; set; }

    [JsonPropertyName("fullFaceHelmEyeEmissiveRate_")]
    public float FullFaceHelmEyeEmissiveRate { get; set; }
}
