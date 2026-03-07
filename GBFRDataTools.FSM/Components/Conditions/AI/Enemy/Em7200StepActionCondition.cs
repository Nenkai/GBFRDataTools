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
    public int StepType { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("targetType_")]
    public int TargetType { get; set; } = 0; // Offset 0x3C

    [JsonPropertyName("minStepRate_")]
    public float MinStepRate { get; set; } = 0.6f; // Offset 0x40

    [JsonPropertyName("maxStepRate_")]
    public float MaxStepRate { get; set; } = 1.5f; // Offset 0x44

    public Em7200StepActionCondition()
    {
    }
}