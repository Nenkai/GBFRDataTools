using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1001GuardAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1001GuardAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f; 

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.5235988f; 

    [JsonPropertyName("guardCounterHitCount_")]
    public int GuardCounterHitCount { get; set; } = 5; 

    [JsonPropertyName("guardEndTime_")]
    public float GuardEndTime { get; set; } = 4f; 

    [JsonPropertyName("isEndless_")]
    public bool IsEndless { get; set; } = false; 
}