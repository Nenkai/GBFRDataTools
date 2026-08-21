using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class EmHpRateCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmHpRateCondition);

    [JsonPropertyName("operatorType_")]
    public EmHpRateConditionOperatorType OperatorType { get; set; } = 0;

    [JsonPropertyName("hpRate_")]
    public float HpRate { get; set; } = 0f; 

    public override string? GetCaption()
    {
        return OperatorType switch
        {
            EmHpRateConditionOperatorType.Equals => $"== {HpRate}%",
            EmHpRateConditionOperatorType.LesserThan => $"Health < {HpRate}%",
            EmHpRateConditionOperatorType.LesserEqualTo => $"Health <= {HpRate}%",
            EmHpRateConditionOperatorType.GreaterThan => $"Health > {HpRate}%",
            EmHpRateConditionOperatorType.GreaterEqualTo => $"Health >= {HpRate}%",
            _ => $"Health ? {HpRate}%"
        };
    }
}

public enum EmHpRateConditionOperatorType
{
    [Description("==")]
    Equals = 0,

    [Description("<")]
    LesserThan = 1,

    [Description("<=")]
    LesserEqualTo = 2,

    [Description(">")]
    GreaterThan = 3,

    [Description(">=")]
    GreaterEqualTo = 4,
}
