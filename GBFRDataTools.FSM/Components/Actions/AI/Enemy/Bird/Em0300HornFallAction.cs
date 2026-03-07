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
    public float WaitTime { get; set; } = 1.5f; // Offset 0x84

    [JsonPropertyName("omenTime_")]
    public float OmenTime { get; set; } = 0.5f; // Offset 0x88

    [JsonPropertyName("fallPosMul_")]
    public float FallPosMul { get; set; } = 1f; // Offset 0x8C

    [JsonPropertyName("fallSpeed_")]
    public float FallSpeed { get; set; } = 0.2f; // Offset 0x90

    [JsonPropertyName("missStabTime_")]
    public float MissStabTime { get; set; } = 3f; // Offset 0x94

    [JsonPropertyName("hitStabTime_")]
    public float HitStabTime { get; set; } = 1f; // Offset 0x98

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; // Offset 0x9C

    [JsonPropertyName("signRadius_")]
    public float SignRadius { get; set; } = 2.5f; // Offset 0xA0

    [JsonPropertyName("fallDeadTime_")]
    public float FallDeadTime { get; set; } = 2f; // Offset 0xA4

    public Em0300HornFallAction()
    {
    }
}
