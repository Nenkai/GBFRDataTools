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
    public string ValueName { get; set; }

    [JsonPropertyName("value_")]
    public float Value { get; set; }

    [JsonPropertyName("operatorType_")]
    public OperatorType OperatorType { get; set; }
}
