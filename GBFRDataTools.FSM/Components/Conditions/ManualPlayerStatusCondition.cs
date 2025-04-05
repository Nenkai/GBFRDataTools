using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class ManualPlayerStatusCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ManualPlayerStatusCondition);

    [JsonPropertyName("checkFlag_")]
    public int CheckFlag { get; set; } = 0;
}
