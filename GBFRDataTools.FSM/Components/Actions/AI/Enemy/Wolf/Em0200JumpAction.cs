using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wolf;

public class Em0200JumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200JumpAction);

    [JsonPropertyName("jumpSpeedZX_")]
    public float JumpSpeedZX { get; set; } = 0.07f; // Offset 0x38

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.07f; // Offset 0x34

    public Em0200JumpAction()
    {
    }
}
