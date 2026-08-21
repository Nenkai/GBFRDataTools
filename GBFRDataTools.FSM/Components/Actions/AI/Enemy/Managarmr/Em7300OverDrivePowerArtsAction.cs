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

public class Em7300OverDrivePowerArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300OverDrivePowerArtsAction);

    [JsonPropertyName("scoopScoopingNum_")]
    public int ScoopScoopingNum { get; set; } = 6; 

    [JsonPropertyName("scoopHormingAngleFront_")]
    public Vector2 ScoopHormingAngleFront { get; set; } = new Vector2(2f, 1.5f); 

    [JsonPropertyName("scoopHormingAngleLR_")]
    public Vector2 ScoopHormingAngleLR { get; set; } = new Vector2(3f, 3f); 

    [JsonPropertyName("scoopHormingAngleTime_")]
    public Vector2 ScoopHormingAngleTime { get; set; } = new Vector2(2f, 0.5f); 

    [JsonPropertyName("scoopTurnFrontAngle_")]
    public Vector2 ScoopTurnFrontAngle { get; set; } = new Vector2(180f, 210f); 

    [JsonPropertyName("maxMotionRate_")]
    public Vector4 MaxMotionRate { get; set; } = new Vector4(1f, 1f, 1.2f, 1.2f); 

    [JsonPropertyName("maxMotionRateCount_")]
    public int MaxMotionRateCount { get; set; } = 3; 
}
