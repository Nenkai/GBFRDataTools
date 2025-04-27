using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Trial;

public class StopTrialTimer : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(StopTrialTimer);

    [JsonPropertyName("isStopTrialTimer_")]
    public bool IsStopTrialTimer { get; set; } = false; // Offset 0x30

    public StopTrialTimer()
    {
    }
}