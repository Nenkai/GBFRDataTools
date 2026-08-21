using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em1600FlyTransitCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600FlyTransitCondition);

    [JsonPropertyName("otherwiseActionCount_")]
    public int OtherwiseActionCount { get; set; } = 0; 

    [JsonPropertyName("initialExecProb_")]
    public float InitialExecProb { get; set; } = 0f; 

    [JsonPropertyName("addExecProb_")]
    public float AddExecProb { get; set; } = 0f; 
}
