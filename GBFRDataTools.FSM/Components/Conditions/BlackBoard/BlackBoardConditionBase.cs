using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.BlackBoard;

public class BlackBoardConditionBase : ConditionComponent
{
    [JsonPropertyName("operatorType_")]
    public int OperatorType { get; set; } = 0;

    [JsonPropertyName("valueNameL_")]
    public string ValueNameL { get; set; } = string.Empty;

    [JsonPropertyName("valueNameR_")]
    public string ValueNameR { get; set; } = string.Empty;
}
