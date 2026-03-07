using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Battle;

public class ShotUserCustomTypeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotUserCustomTypeCondition);

    [JsonPropertyName("checkValue_")]
    public int CheckValue { get; set; } = 0;

    [JsonPropertyName("operatorType_")]
    public ShotUserCustomTypeConditionOperatorType OperatorType { get; set; } = 0;

    [JsonPropertyName("bbIntName_")]
    public string BbIntName { get; set; } = string.Empty;

    [JsonPropertyName("bbHashValue_")]
    public uint BbHashValue { get; set; } = 0;
}
