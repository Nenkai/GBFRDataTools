using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.BlackBoard;

[Description("Returns whether the specified blackboard int variable passes a binary operation.")]
public class BlackBoardIntCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardIntCondition);

    [JsonPropertyName("intName_")]
    public string IntName { get; set; } = string.Empty;

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0;

    [JsonPropertyName("operatorType_")]
    public BlackBoardIntOperatorType OperatorType { get; set; } = BlackBoardIntOperatorType.Equal;
}
