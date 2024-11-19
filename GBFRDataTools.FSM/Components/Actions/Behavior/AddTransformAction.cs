using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class AddTransformAction : ActionComponent
{
    [JsonPropertyName("addPosition_")]
    public cVec4 AddPosition { get; set; }

    [JsonPropertyName("addRotation_")]
    public cVec4 AddRotation { get; set; }

    [JsonPropertyName("slowRatePosition_")]
    public bool SlowRatePosition { get; set; }
}
