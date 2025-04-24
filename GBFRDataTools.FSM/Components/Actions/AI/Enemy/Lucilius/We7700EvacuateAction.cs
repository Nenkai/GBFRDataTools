using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class We7700EvacuateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7700EvacuateAction);

    [JsonPropertyName("waitLen_")]
    public float WaitLen { get; set; } = 1f; // Offset 0x90

    [JsonPropertyName("backLen_")]
    public float BackLen { get; set; } = 10f; // Offset 0x94

    [JsonPropertyName("moveTurnRate_")]
    public float MoveTurnRate { get; set; } = 0.1f; // Offset 0x9C

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0f; // Offset 0x98

    public We7700EvacuateAction()
    {
    }
}
