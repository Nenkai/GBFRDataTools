using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

public class ActionEndCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ActionEndCondition);

    [JsonPropertyName("isAllEnd_")]
    public bool IsAllEnd { get; set; } = false;
}
