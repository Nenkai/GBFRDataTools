using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Flow;

public class IsFlowRunning : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsFlowRunning);

    [JsonPropertyName("fsmLabel_")]
    public string FsmLabel { get; set; } // Offset 0x38

    public IsFlowRunning()
    {
    }
}