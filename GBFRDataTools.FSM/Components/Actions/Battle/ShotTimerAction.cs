using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotTimerAction : ActionComponent
{
    [JsonPropertyName("waitTimeSeconds_")]
    public float WaitTimeSeconds { get; set; }

    [JsonPropertyName("isForceSet_")]
    public bool IsForceSet { get; set; }
}
