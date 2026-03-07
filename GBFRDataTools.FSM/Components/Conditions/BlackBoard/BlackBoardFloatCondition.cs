using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.BlackBoard;

[Description("Returns whether the specified blackboard float variable passes a binary operation.")]
public class BlackBoardFloatCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardFloatCondition);

    [JsonPropertyName("valueName_")]
    public string ValueName { get; set; } = string.Empty;

    [JsonPropertyName("value_")]
    public float Value { get; set; } = 0;

    [JsonPropertyName("operatorType_")]
    public BlackBoardFloatOperatorType OperatorType { get; set; } = BlackBoardFloatOperatorType.LesserEqual;

    public override string GetCaption()
    {
        string operand = OperatorType switch
        {
            BlackBoardFloatOperatorType.Equal => "==",
            BlackBoardFloatOperatorType.Lesser => "<",
            BlackBoardFloatOperatorType.LesserEqual => "<=",
            BlackBoardFloatOperatorType.Greater => ">",
            BlackBoardFloatOperatorType.GreaterEqual => ">=",
            _ => "?",
        };
        return $"{ValueName} {operand} {Value}";
    }
}
