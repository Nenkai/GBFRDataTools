using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lilith;

public class Em2400ShotBeamMoveRotateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2400ShotBeamMoveRotateAction);

    [JsonPropertyName("rotStartVelocity_")]
    public Vector4 RotStartVelocity { get; set; } = Vector4.Zero; 

    [JsonPropertyName("rotAcceleration_")]
    public Vector4 RotAcceleration { get; set; } = Vector4.Zero; 

    [JsonPropertyName("rotAccelerateSec_")]
    public float RotAccelerateSec { get; set; } = 0f; 

    [JsonPropertyName("rotSec_")]
    public float RotSec { get; set; } = 0f; 
}
