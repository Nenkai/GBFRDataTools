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

public class Em0902CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0902CounterAction);

    [JsonPropertyName("shotFreezeGasNum_")]
    public int ShotFreezeGasNum { get; set; } = 8; 

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("loopSec_")]
    public float LoopSec { get; set; } = 1.2f; 

    [JsonPropertyName("motionMoveRate_")]
    public float MotionMoveRate { get; set; } = 0.5f; 

    [JsonPropertyName("isLoopAnimEnd_")]
    public bool IsLoopAnimEnd { get; set; } = false; 

    [JsonPropertyName("signSec_")]
    public float SignSec { get; set; } = 0.5f; 

    [JsonPropertyName("signLength_")]
    public float SignLength { get; set; } = 5f; 

    [JsonPropertyName("loopShowSignSec_")]
    public float LoopShowSignSec { get; set; } = 1.2f; 
}

