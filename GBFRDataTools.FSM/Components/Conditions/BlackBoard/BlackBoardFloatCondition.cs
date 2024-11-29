using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.BlackBoard;

public class BlackBoardFloatCondition : ConditionComponent
{
    [JsonPropertyName("valueName_")]
    public string ValueName { get; set; } = string.Empty;

    [JsonPropertyName("value_")]
    public float Value { get; set; } = 0;

    [JsonPropertyName("operatorType_")]
    public OperatorType OperatorType { get; set; } = OperatorType.Equal;
}
