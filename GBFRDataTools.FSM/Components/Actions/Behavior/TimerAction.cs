using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class TimerAction : ActionComponent
{
    [JsonPropertyName("waitTimeSeconds_")]
    public float WaitTimeSeconds { get; set; } = 0.0f;

    [JsonPropertyName("randomSeconds_")]
    public float RandomSeconds { get; set; } = 0.0f;

    [JsonPropertyName("isUseBehaviorDeltaTime_")]
    public bool IsUseBehaviorDeltaTime { get; set; } = false;
}
