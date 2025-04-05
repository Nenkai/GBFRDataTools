using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class FlowEnd : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FlowEnd);

    [JsonPropertyName("result_")]
    public int Result { get; set; } = 0;

    [JsonPropertyName("fsmLabel_")]
    public string FsmLabel { get; set; } = string.Empty;
}
