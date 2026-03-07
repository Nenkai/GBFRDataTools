using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class SetTransformAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetTransformAction);

    [JsonPropertyName("position_")]
    public /* cVec4 */ Vector4 Position { get; set; } = new();

    [JsonPropertyName("rotation_")]
    public /* cVec4 */ Vector4 Rotation { get; set; } = new();
}
