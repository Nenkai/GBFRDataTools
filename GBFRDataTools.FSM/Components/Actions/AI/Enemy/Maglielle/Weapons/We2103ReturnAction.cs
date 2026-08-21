using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2103ReturnAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2103ReturnAction);

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 2f; 

    [JsonPropertyName("delaySec_")]
    public float DelaySec { get; set; } = 0.25f; 

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0; 
}
