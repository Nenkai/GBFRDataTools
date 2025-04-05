using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1802MoveBezierAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802MoveBezierAction);

    [JsonPropertyName("maxLength_")]
    public float MaxLength { get; set; } = 30.0f;

    [JsonPropertyName("minLength_")]
    public float MinLength { get; set; } = 20.0f;

    [JsonPropertyName("maxHeight_")]
    public float MaxHeight { get; set; } = 15.0f;

    [JsonPropertyName("minHeight_")]
    public float MinHeight { get; set; } = 7.0f;

    [JsonPropertyName("maxTime_")]
    public float MaxTime { get; set; } = 2.0f;

    [JsonPropertyName("minTime_")]
    public float MinTime { get; set; } = 1.0f;

    [JsonPropertyName("directionalPointMaxMag_")]
    public float DirectionalPointMaxMag { get; set; } = 0.4f;

    [JsonPropertyName("directionalPointMinMag_")]
    public float DirectionalPointMinMag { get; set; } = 0.1f;

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 1.0f;

    [JsonPropertyName("isLengthFixed_")]
    public bool IsLengthFixed { get; set; } = false;

    [JsonPropertyName("isUseMaxLength_")]
    public bool IsUseMaxLength { get; set; } = false;
}
