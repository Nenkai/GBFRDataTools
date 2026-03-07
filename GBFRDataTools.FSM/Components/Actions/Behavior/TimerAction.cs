using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

[Description("Starts a timer that can be checked using ActionEndCondition")]
public class TimerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(TimerAction);

    [JsonPropertyName("waitTimeSeconds_")]
    public float WaitTimeSeconds { get; set; } = 0.0f;

    [JsonPropertyName("randomSeconds_")]
    public float RandomSeconds { get; set; } = 0.0f;

    [JsonPropertyName("isUseBehaviorDeltaTime_")]
    public bool IsUseBehaviorDeltaTime { get; set; } = false;

    public override string GetCaption()
    {
        return $"Wait {WaitTimeSeconds}s";
    }
}
