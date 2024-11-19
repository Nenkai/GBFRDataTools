
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Player;

public class ShotSetSoundCallScaleCircleAction : ActionComponent
{
    [JsonPropertyName("scalingSec_")]
    public float ScalingSec { get; set; }

    [JsonPropertyName("offsetPos_")]
    public cVec4 OffsetPos { get; set; }

    [JsonPropertyName("innerRadius_")]
    public float InnerRadius { get; set; }

    [JsonPropertyName("outerRadius_")]
    public float OuterRadius { get; set; }

    [JsonPropertyName("scaledInnerRadius_")]
    public float ScaledInnerRadius { get; set; }

    [JsonPropertyName("scaledOuterRadius_")]
    public float ScaledOuterRadius { get; set; }
}