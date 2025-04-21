using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

[Description("Returns whether any or all actions assigned to a node are complete.")]
public class ActionEndCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ActionEndCondition);

    [JsonPropertyName("isAllEnd_")]
    [Description("Whether to check for all actions rather than any.")]
    public bool IsAllEnd { get; set; } = false;
}
