using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions;

public class QuestParameterCondition : ConditionComponent
{
    [JsonPropertyName("keyHash_")]
    public uint KeyHash { get; set; }

    [JsonPropertyName("keyString_")]
    public string KeyString { get; set; }

    [JsonPropertyName("checkValue_")]
    public int CheckValue { get; set; }

    [JsonPropertyName("type_")]
    public QuestParameterConditionType Type { get; set; }
}

public enum QuestParameterConditionType
{
    Type0 = 0,
    Type1 = 1,
}
