using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class ResetRotateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResetRotateAction);

    [JsonPropertyName("totalTime_")]
    public float TotalTime { get; set; } = 0.0f;

    [JsonPropertyName("resetY_")]
    public bool ResetY { get; set; } = false;
}
