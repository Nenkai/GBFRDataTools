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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Elemental;

public class Em0900CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0900CounterAction);

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("loopMotionNumMax_")]
    public int LoopMotionNumMax { get; set; } = 3; 

    [JsonPropertyName("motionMoveRate_")]
    public float MotionMoveRate { get; set; } = 0.5f; 

    [JsonPropertyName("omenSec_")]
    public float OmenSec { get; set; } = 2f; 

    [JsonPropertyName("omenRadius_")]
    public float OmenRadius { get; set; } = 10.1f; 
}
