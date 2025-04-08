using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class FlowResult : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FlowResult);

    [JsonPropertyName("fsmLabel_")]
    public string FsmLabel { get; set; } = string.Empty;

    [JsonPropertyName("result_")]
    public int Result { get; set; } = 0;

    [JsonPropertyName("noCheckResult_")]
    public bool NoCheckResult { get; set; } = false;

}
