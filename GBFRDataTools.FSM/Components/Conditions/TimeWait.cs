using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

[Description("Waits for the specified amount of time and returns true when elapsed.")]
public class TimeWait : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(TimeWait);

    [Description("Time to wait in seconds.")]
    [JsonPropertyName("time_")]
    public float Time { get; set; } = 0;

    [Description("Fsm label/variable for this timer.")]
    [JsonPropertyName("fsmLabel_")]
    public string FsmLabel { get; set; } = string.Empty;

}