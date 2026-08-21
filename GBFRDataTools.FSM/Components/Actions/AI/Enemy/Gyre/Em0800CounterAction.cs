using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0800CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0800CounterAction);

    [JsonPropertyName("signTime_")]
    public float SignTime { get; set; } = 4f; 

    [JsonPropertyName("signRadius_")]
    public float SignRadius { get; set; } = 2f; 

    [JsonPropertyName("coreEstId_")]
    public int CoreEstId { get; set; } = 0; 

    [JsonPropertyName("effectScale_")]
    public float EffectScale { get; set; } = 1f; 

    [JsonPropertyName("escapeRate_")]
    public float EscapeRate { get; set; } = 1f; 

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 0f; 
}
