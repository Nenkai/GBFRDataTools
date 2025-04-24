using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0001EscapeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0001EscapeAction);

    [JsonPropertyName("startTurnRate_")]
    public float StartTurnRate { get; set; } = 1f; // Offset 0x48

    [JsonPropertyName("endTurnRate_")]
    public float EndTurnRate { get; set; } = 1f; // Offset 0x4C

    [JsonPropertyName("escapeRange_")]
    public float EscapeRange { get; set; } = 10f; // Offset 0x50

    public Em0001EscapeAction()
    {
    }
}
