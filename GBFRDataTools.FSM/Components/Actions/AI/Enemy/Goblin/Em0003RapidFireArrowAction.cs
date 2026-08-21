using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0003RapidFireArrowAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0003RapidFireArrowAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; 

    [JsonPropertyName("shotEndRate_")]
    public float ShotEndRate { get; set; } = 1f; 

    [JsonPropertyName("shotEndRateTime_")]
    public float ShotEndRateTime { get; set; } = 300f; 

    [JsonPropertyName("signLength_")]
    public float SignLength { get; set; } = 45f; 
}
