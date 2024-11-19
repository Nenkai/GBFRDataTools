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
    public OperatorType OperatorType { get; set; }

    [JsonPropertyName("valueNameL_")]
    public string ValueNameL { get; set; }

    [JsonPropertyName("valueNameR_")]
    public string ValueNameR { get; set; }

}
