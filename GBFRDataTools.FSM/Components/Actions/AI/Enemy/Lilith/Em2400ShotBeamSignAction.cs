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

public class Em2400ShotBeamSignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2400ShotBeamSignAction);

    [JsonPropertyName("size_")]
    public Vector4 Size { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x40

    [JsonPropertyName("dispSec_")]
    public float DispSec { get; set; } = 1f; // Offset 0x50

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x60

    public Em2400ShotBeamSignAction()
    {
    }
}
