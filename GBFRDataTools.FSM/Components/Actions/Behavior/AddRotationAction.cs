using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class AddRotationAction : ActionComponent
{
    [JsonPropertyName("addRotation_")]
    public /* cVec4 */ Vector4 AddRotation { get; set; } = Vector4.Zero;

    [JsonPropertyName("totalTime_")]
    public float TotalTime { get; set; } = 0.0f;
}