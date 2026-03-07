using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0801LaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0801LaserAction);

    [JsonPropertyName("turnAngle_")]
    public float TurnAngle { get; set; } = 8f; // Offset 0x64

    [JsonPropertyName("loopSec_")]
    public float LoopSec { get; set; } = 2f; // Offset 0x68

    [JsonPropertyName("omenSec_")]
    public float OmenSec { get; set; } = 0.5f; // Offset 0x6C

    [JsonPropertyName("signLength_")]
    public float SignLength { get; set; } = 37.5f; // Offset 0x70

    public Em0801LaserAction()
    {
    }
}
