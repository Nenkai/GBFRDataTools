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
    public string MotionName { get; set; } // Offset 0x40

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = -1f; // Offset 0x48

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0.1f; // Offset 0x4C

    [JsonPropertyName("effectDelaySecond_")]
    public float EffectDelaySecond { get; set; } = 0f; // Offset 0x50

    [JsonPropertyName("explodeOmenEffectId_")]
    public int ExplodeOmenEffectId { get; set; } = 9000; // Offset 0x54

    public Em0706LandingDeadAction()
    {
    }
}