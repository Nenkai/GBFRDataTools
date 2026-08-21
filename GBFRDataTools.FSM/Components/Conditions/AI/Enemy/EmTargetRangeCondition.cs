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

public class EmTargetRangeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmTargetRangeCondition);

    [JsonPropertyName("operatorType_")]
    public EmTargetRangeConditionOperatorType OperatorType { get; set; } = EmTargetRangeConditionOperatorType.Equals;

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0;

    [JsonPropertyName("isUseRangeXZ_")]
    public bool IsUseRangeXZ { get; set; } = false;

    public override string? GetCaption()
    {
        string op = OperatorType switch
        {
            EmTargetRangeConditionOperatorType.LesserThan => "<",
            EmTargetRangeConditionOperatorType.LesserEqualTo => "<=",
            EmTargetRangeConditionOperatorType.Equals => "==",
            EmTargetRangeConditionOperatorType.GreaterEqualTo => ">=",
            EmTargetRangeConditionOperatorType.GreaterThen => ">",
            _ => "?",
        };

        string str = $"TargetRange {op} {CheckRange}";
        if (IsUseRangeXZ)
            str += " (XZ Range)";
        return str;
    }
}

public enum EmTargetRangeConditionOperatorType
{
    [Description("<")]
    LesserThan = 0,

    [Description("<=")]
    LesserEqualTo = 1,

    [Description("==")]
    Equals = 2,

    [Description(">=")]
    GreaterEqualTo = 3,

    [Description(">")]
    GreaterThen = 4,
}