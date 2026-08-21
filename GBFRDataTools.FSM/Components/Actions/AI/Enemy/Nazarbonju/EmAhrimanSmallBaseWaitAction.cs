using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class EmAhrimanSmallBaseWaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAhrimanSmallBaseWaitAction);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 3f; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 1f; 

    [JsonPropertyName("isLoopEnd_")]
    public bool IsLoopEnd { get; set; } = true; 
}