using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.BlackBoard;

[GameSupport(GameVersion.EndlessRagnarok)]
[Description("Returns whether the specified blackboard bool variable is true.")]
public class BlackBoardVectorCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardVectorCondition);

    [JsonPropertyName("valueName_")]
    public string ValueName { get; set; }

    [JsonPropertyName("operatorType_")]
    public BlackBoardFloatOperatorType OperatorType { get; set; } = 0;

    [JsonPropertyName("value_")]
    public float Value { get; set; } = 0f;

    [JsonPropertyName("index_")]
    public VectorIndex Index { get; set; } = VectorIndex.X;

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
        return $"{ValueName}[{Index}] {operand} {Value}";
    }

    public enum VectorIndex
    {
        X,
        Y,
        Z,
        W
    }
}
