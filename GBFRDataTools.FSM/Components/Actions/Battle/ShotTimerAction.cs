using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotTimerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotTimerAction);

    [JsonPropertyName("waitTimeSeconds_")]
    public float WaitTimeSeconds { get; set; } = 1.0f;

    [JsonPropertyName("isForceSet_")]
    public bool IsForceSet { get; set; }
}
