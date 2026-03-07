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

public class Em0300WaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0300WaitAction);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 3f; // Offset 0x4C

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 1f; // Offset 0x50

    [JsonPropertyName("isLoopEnd_")]
    public bool IsLoopEnd { get; set; } = true; // Offset 0x54

    public Em0300WaitAction()
    {
    }
}
