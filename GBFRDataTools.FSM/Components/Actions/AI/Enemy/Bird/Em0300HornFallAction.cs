using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Bird;

public class Em0300HornFallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0300HornFallAction);

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 1.5f; 

    [JsonPropertyName("omenTime_")]
    public float OmenTime { get; set; } = 0.5f; 

    [JsonPropertyName("fallPosMul_")]
    public float FallPosMul { get; set; } = 1f; 

    [JsonPropertyName("fallSpeed_")]
    public float FallSpeed { get; set; } = 0.2f; 

    [JsonPropertyName("missStabTime_")]
    public float MissStabTime { get; set; } = 3f; 

    [JsonPropertyName("hitStabTime_")]
    public float HitStabTime { get; set; } = 1f; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; 

    [JsonPropertyName("signRadius_")]
    public float SignRadius { get; set; } = 2.5f; 

    [JsonPropertyName("fallDeadTime_")]
    public float FallDeadTime { get; set; } = 2f; 
}
