using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em1600StepCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600StepCondition);

    [JsonPropertyName("condIdx_")]
    public int CondIdx { get; set; } = 0; 

    [JsonPropertyName("checkBaseAngle_")]
    public float CheckBaseAngle { get; set; } = 0f; 

    [JsonPropertyName("checkRangeAngle_")]
    public float CheckRangeAngle { get; set; } = 0f; 

    [JsonPropertyName("checkDistance_")]
    public float CheckDistance { get; set; } = 0f; 

    [JsonPropertyName("operatorType_")]
    public int OperatorType { get; set; } = 0; 

    [JsonPropertyName("stepProb_")]
    public float StepProb { get; set; } = 0f; 
}
