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

public class Em0706LandingDeadAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706LandingDeadAction);

    [JsonPropertyName("motionName_")]
    public string? MotionName { get; set; } = "255a";

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = -1f; 

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0.1f; 

    [JsonPropertyName("effectDelaySecond_")]
    public float EffectDelaySecond { get; set; } = 0f; 

    [JsonPropertyName("explodeOmenEffectId_")]
    public int ExplodeOmenEffectId { get; set; } = 9000; 
}