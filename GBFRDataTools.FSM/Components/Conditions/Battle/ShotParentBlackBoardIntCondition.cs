using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Battle;

public class ShotParentBlackBoardIntCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotParentBlackBoardIntCondition);

    [JsonPropertyName("intName_")]
    public string IntName { get; set; }

    [JsonPropertyName("value_")]
    public int Value { get; set; }

    [JsonPropertyName("operatorType_")]
    public BlackBoardIntOperatorType OperatorType { get; set; } = BlackBoardIntOperatorType.Equal;
}

