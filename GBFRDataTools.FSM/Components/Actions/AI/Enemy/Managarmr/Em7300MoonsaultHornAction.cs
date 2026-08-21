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

public class Em7300MoonsaultHornAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300MoonsaultHornAction);

    [JsonPropertyName("startHomingAngle_")]
    public float StartHomingAngle { get; set; } = 4f; 

    [JsonPropertyName("jumpHomingAngle_")]
    public float JumpHomingAngle { get; set; } = 4f; 

    [JsonPropertyName("jumpDistMax_")]
    public float JumpDistMax { get; set; } = 30f; 

    [JsonPropertyName("start3st_")]
    public bool Start3st { get; set; } = false; 

    [JsonPropertyName("start3st_MotionStaretFrame_")]
    public float Start3st_MotionStaretFrame { get; set; } = 25f; 

    [JsonPropertyName("start3st_MotionInterpFrame_")]
    public float Start3st_MotionInterpFrame { get; set; } = 20f; 

    [JsonPropertyName("start3st_MotionRate_")]
    public float Start3st_MotionRate { get; set; } = 0.9f; 

    [JsonPropertyName("start3st_TargetPos_")]
    public Vector4 Start3st_TargetPos { get; set; } = Vector4.UnitW; 
}
