using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.BlackBoard;

[Description("Returns whether the specified blackboard bool variable is true.")]
public class BlackBoardBoolCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardBoolCondition);

    [JsonPropertyName("boolName_")]
    public string BoolName { get; set; } = string.Empty;
}
