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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300HevyRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300HevyRushAction);

    [JsonPropertyName("startHomingAngle_")]
    public Vector4 StartHomingAngle { get; set; } = Vector4.One; 

    [JsonPropertyName("loopHomingAngle_")]
    public Vector4 LoopHomingAngle { get; set; } = new Vector4(0.1f, 0.1f, 0.3f, 0.3f); 

    [JsonPropertyName("loopHomingAngleSpped_")]
    public float LoopHomingAngleSpped { get; set; } = 0.01f; 

    [JsonPropertyName("loopHomingTime_")]
    public Vector4 LoopHomingTime { get; set; } = new Vector4(1f, 1f, -1f, -1f); 

    [JsonPropertyName("endAngle_")]
    public float EndAngle { get; set; } = 100f; 

    [JsonPropertyName("secondsMinMax_")]
    public Vector2 SecondsMinMax { get; set; } = new Vector2(3f, 10f); 

    [JsonPropertyName("rushMotionRate_")]
    public Vector4 RushMotionRate { get; set; } = new Vector4(1f, 1f, 1.2f, 1.2f); 

    [JsonPropertyName("rushMotionRateTime_")]
    public float RushMotionRateTime { get; set; } = 2f; 
}
