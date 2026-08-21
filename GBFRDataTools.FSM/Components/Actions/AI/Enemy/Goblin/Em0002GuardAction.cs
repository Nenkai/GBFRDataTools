using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0002GuardAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0002GuardAction);

    [JsonPropertyName("guardTime_")]
    public float GuardTime { get; set; } = 6f; 

    [JsonPropertyName("isAutoGuard_")]
    public bool IsAutoGuard { get; set; } = false; 
}
