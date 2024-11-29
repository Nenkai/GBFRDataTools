using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Components.Actions.BlackBoard;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.BlackBoard;

public class ShotParentBlackBoardBoolCondition : ConditionComponent
{
    [JsonPropertyName("boolName_")]
    public string BoolName { get; set; } = string.Empty;
}
