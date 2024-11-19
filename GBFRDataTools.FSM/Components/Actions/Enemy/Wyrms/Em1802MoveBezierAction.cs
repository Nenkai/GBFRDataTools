using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1802MoveBezierAction : ActionComponent
{
    [JsonPropertyName("maxLength_")]
    public float MaxLength { get; set; }

    [JsonPropertyName("minLength_")]
    public float MinLength { get; set; }

    [JsonPropertyName("maxHeight_")]
    public float MaxHeight { get; set; }

    [JsonPropertyName("minHeight_")]
    public float MinHeight { get; set; }

    [JsonPropertyName("maxTime_")]
    public float MaxTime { get; set; }

    [JsonPropertyName("minTime_")]
    public float MinTime { get; set; }

    [JsonPropertyName("directionalPointMaxMag_")]
    public float DirectionalPointMaxMag { get; set; }

    [JsonPropertyName("directionalPointMinMag_")]
    public float DirectionalPointMinMag { get; set; }

    [JsonPropertyName("radius_")]
    public float Radius { get; set; }

    [JsonPropertyName("isLengthFixed_")]
    public bool IsLengthFixed { get; set; }

    [JsonPropertyName("isUseMaxLength_")]
    public bool IsUseMaxLength { get; set; }
}
