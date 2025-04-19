using GBFRDataTools.FSM.Components.Actions.UI.Dialog;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Flow;

public class FlowStart : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FlowStart);

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = string.Empty;

    [JsonPropertyName("param_")]
    public int Param { get; set; } = 0;

    public override string GetCaption()
    {
        return FsmName;
    }
}
