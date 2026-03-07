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
    public Vector4 RotStartVelocity { get; set; } = new Vector4(0f, 0f, 0f, 0f); // Offset 0x50

    [JsonPropertyName("rotAcceleration_")]
    public Vector4 RotAcceleration { get; set; } = new Vector4(0f, 0f, 0f, 0f); // Offset 0x60

    [JsonPropertyName("rotAccelerateSec_")]
    public float RotAccelerateSec { get; set; } = 0f; // Offset 0x70

    [JsonPropertyName("rotSec_")]
    public float RotSec { get; set; } = 0f; // Offset 0x74

    public Em2400ShotBeamMoveRotateAction()
    {
    }
}
