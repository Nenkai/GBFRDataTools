using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Components.Actions.BlackBoard;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.BlackBoard;

public class ShotParentBlackBoardIntCondition : ConditionComponent
{
    [JsonPropertyName("intName_")]
    public string IntName { get; set; }

    [JsonPropertyName("value_")]
    public int Value { get; set; }

    [JsonPropertyName("operatorType_")]
    public BlackBoardIntOperatorType OperatorType { get; set; } = BlackBoardIntOperatorType.Equal;
}

