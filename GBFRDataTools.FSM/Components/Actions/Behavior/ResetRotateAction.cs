using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class ResetRotateAction : ActionComponent
{
    [JsonPropertyName("totalTime_")]
    public float TotalTime { get; set; } = 0.0f;

    [JsonPropertyName("resetY_")]
    public bool ResetY { get; set; } = false;
}
