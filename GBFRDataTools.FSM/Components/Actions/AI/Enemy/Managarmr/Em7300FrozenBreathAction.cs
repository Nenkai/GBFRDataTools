using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300FrozenBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300FrozenBreathAction);

    [JsonPropertyName("startHomingAngle_")]
    public float StartHomingAngle { get; set; } = 0.2f; 

    [JsonPropertyName("loopCount_")]
    public int LoopCount { get; set; } = 1; 

    [JsonPropertyName("shotInterval_")]
    public float ShotInterval { get; set; } = 0.5f; 
}