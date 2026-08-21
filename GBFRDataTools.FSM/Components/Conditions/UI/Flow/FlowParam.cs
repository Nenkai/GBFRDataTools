using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Flow;

public class FlowParam : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FlowParam);

    [JsonPropertyName("fsmLabel_")]
    public string? FsmLabel { get; set; } 

    [JsonPropertyName("param_")]
    public int Param { get; set; } = 0; 

}
