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

public class Em0200CounterAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200CounterAttackAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.02f; // Offset 0x30

    [JsonPropertyName("signSec_")]
    public float SignSec { get; set; } = 0.5f; // Offset 0x34

    [JsonPropertyName("signHomingSec_")]
    public float SignHomingSec { get; set; } = 0.2f; // Offset 0x38

    public Em0200CounterAttackAction()
    {
    }
}
