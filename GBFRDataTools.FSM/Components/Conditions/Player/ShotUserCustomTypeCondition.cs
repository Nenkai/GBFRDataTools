using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class ShotUserCustomTypeCondition : ConditionComponent
{
    [JsonPropertyName("checkValue_")]
    public int CheckValue { get; set; }

    [JsonPropertyName("operatorType_")]
    public OperatorType OperatorType { get; set; }

    [JsonPropertyName("bbIntName_")]
    public string BbIntName { get; set; }

    [JsonPropertyName("bbHashValue_")]
    public uint BbHashValue { get; set; }
}