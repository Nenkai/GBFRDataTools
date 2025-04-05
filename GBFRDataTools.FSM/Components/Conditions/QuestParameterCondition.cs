using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class QuestParameterCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestParameterCondition);

    [JsonPropertyName("keyHash_")]
    public uint KeyHash { get; set; } = 0;

    [JsonPropertyName("keyString_")]
    public string KeyString { get; set; } = string.Empty;

    [JsonPropertyName("checkValue_")]
    public int CheckValue { get; set; } = 0;

    [JsonPropertyName("type_")]
    public QuestParameterConditionType Type { get; set; }
}

public enum QuestParameterConditionType
{
    Type0 = 0,
    Type1 = 1,
}
