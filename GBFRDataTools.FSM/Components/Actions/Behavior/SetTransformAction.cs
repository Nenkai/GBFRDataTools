using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class SetTransformAction : ActionComponent
{
    [JsonPropertyName("position_")]
    public /* cVec4 */ Vector4 Position { get; set; } = new();

    [JsonPropertyName("rotation_")]
    public /* cVec4 */ Vector4 Rotation { get; set; } = new();
}
