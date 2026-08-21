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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800SpecifiedStepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800SpecifiedStepAction);

    [JsonPropertyName("motionIdNameStepFront_")]
    public string? MotionIdNameStepFront { get; set; } = "0050";

    [JsonPropertyName("motionIdNameStepBack_")]
    public string? MotionIdNameStepBack { get; set; } = "0051";

    [JsonPropertyName("motionIdNameStepLeft_")]
    public string? MotionIdNameStepLeft { get; set; } = "0052";

    [JsonPropertyName("motionIdNameStepRight_")]
    public string? MotionIdNameStepRight { get; set; } = "0053";

    [JsonPropertyName("isOverrideHomingFront_")]
    public bool IsOverrideHomingFront { get; set; } = false; 

    [JsonPropertyName("isOverrideHomingBack_")]
    public bool IsOverrideHomingBack { get; set; } = false; 

    [JsonPropertyName("isOverrideHomingLeft_")]
    public bool IsOverrideHomingLeft { get; set; } = false; 

    [JsonPropertyName("isOverrideHomingRight_")]
    public bool IsOverrideHomingRight { get; set; } = false; 

    [JsonPropertyName("overrideHoming_")]
    public float OverrideHoming { get; set; } = 0.5f; 

    [JsonPropertyName("FrontAngle_")]
    public int FrontAngle { get; set; } = 45; 

    [JsonPropertyName("BuckAngle_")]
    public int BuckAngle { get; set; } = 45; 

    [JsonPropertyName("isOverrideAngle_")]
    public bool IsOverrideAngle { get; set; } = false; 
}
