using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0001FireBallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0001FireBallAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; // Offset 0x38

    [JsonPropertyName("escapeRange_")]
    public float EscapeRange { get; set; } = 10f; // Offset 0x3C

    public Em0001FireBallAction()
    {
    }
}

