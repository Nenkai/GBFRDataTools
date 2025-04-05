using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotSetSoundCallScaleCircleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotSetSoundCallScaleCircleAction);

    [JsonPropertyName("scalingSec_")]
    public float ScalingSec { get; set; } = 1.0f;

    [JsonPropertyName("offsetPos_")]
    public /* cVec4 */ Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("innerRadius_")]
    public float InnerRadius { get; set; } = 0.0f;

    [JsonPropertyName("outerRadius_")]
    public float OuterRadius { get; set; } = 0.0f;

    [JsonPropertyName("scaledInnerRadius_")]
    public float ScaledInnerRadius { get; set; } = 0.0f;

    [JsonPropertyName("scaledOuterRadius_")]
    public float ScaledOuterRadius { get; set; } = 0.0f;
}