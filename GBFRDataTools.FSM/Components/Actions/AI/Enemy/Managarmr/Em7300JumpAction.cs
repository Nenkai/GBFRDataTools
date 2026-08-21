using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300JumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300JumpAction);

    [JsonPropertyName("targetPos_")]
    public Vector4 TargetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("staretFrame_")]
    public float StaretFrame { get; set; } = 41f; 

    [JsonPropertyName("jumpTime_")]
    public float JumpTime { get; set; } = 1f; 

    [JsonPropertyName("jumpHeight_")]
    public float JumpHeight { get; set; } = 4f; 

    [JsonPropertyName("transitionFallSpeed_")]
    public float TransitionFallSpeed { get; set; } = 0.1f; 
}
