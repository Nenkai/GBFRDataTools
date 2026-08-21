using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class Wp0290_RnoCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Wp0290_RnoCondition);

    [JsonPropertyName("checkRno_")]
    public int CheckRno { get; set; } = 0; 

    [JsonPropertyName("isTrigger_")]
    public bool IsTrigger { get; set; } = false; 

    [JsonPropertyName("isActionStartCheck_")]
    public bool IsActionStartCheck { get; set; } = false; 
}