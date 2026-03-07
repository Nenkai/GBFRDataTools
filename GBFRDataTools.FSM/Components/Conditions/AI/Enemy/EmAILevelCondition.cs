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

public class EmAILevelCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAILevelCondition);

    [Description("""
        Level to check for.
        NOTE: Level 6 may have custom handling.
        """)]
    [JsonPropertyName("checkLevel_")]
    public int CheckLevel { get; set; } = 3;

    [JsonPropertyName("operatorType_")]
    public EmAILevelConditionOperatorType OperatorType { get; set; } = EmAILevelConditionOperatorType.Equal;

    public override string GetCaption()
    {
        string opStr = OperatorType switch
        {
            EmAILevelConditionOperatorType.Lesser => "<",
            EmAILevelConditionOperatorType.LesserEqual => "<=",
            EmAILevelConditionOperatorType.Equal => "==",
            EmAILevelConditionOperatorType.GreaterEqual => ">=",
            EmAILevelConditionOperatorType.Greater => ">",
            _ => "?",
        };

        return $"Level {opStr} {CheckLevel}";
    }
}
