using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class AddRotationAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AddRotationAction);

    [JsonPropertyName("addRotation_")]
    public /* cVec4 */ Vector4 AddRotation { get; set; } = Vector4.Zero;

    [JsonPropertyName("totalTime_")]
    public float TotalTime { get; set; } = 0.0f;
}