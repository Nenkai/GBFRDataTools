using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0002CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0002CounterAction);

    [JsonPropertyName("guardTime_")]
    public float GuardTime { get; set; } = 6f; // Offset 0x40

    [JsonPropertyName("isAutoGuard_")]
    public bool IsAutoGuard { get; set; } = false; // Offset 0x44

    public Em0002CounterAction()
    {
    }
}
