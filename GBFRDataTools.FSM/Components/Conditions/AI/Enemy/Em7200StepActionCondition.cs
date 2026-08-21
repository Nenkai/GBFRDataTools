using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7200StepActionCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7200StepActionCondition);

    [JsonPropertyName("stepType_")]
    public int StepType { get; set; } = 0; 

    [JsonPropertyName("targetType_")]
    public int TargetType { get; set; } = 0; 

    [JsonPropertyName("minStepRate_")]
    public float MinStepRate { get; set; } = 0.6f; 

    [JsonPropertyName("maxStepRate_")]
    public float MaxStepRate { get; set; } = 1.5f; 
}