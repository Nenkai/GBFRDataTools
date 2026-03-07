using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class NPCBehaviorTreeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(NPCBehaviorTreeAction);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 1.0f;
}
