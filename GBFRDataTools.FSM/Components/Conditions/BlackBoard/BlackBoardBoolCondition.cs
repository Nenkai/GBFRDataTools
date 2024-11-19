using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.BlackBoard;

public class BlackBoardBoolCondition : ConditionComponent
{
    [JsonPropertyName("boolName_")]
    public string BoolName { get; set; }
}
