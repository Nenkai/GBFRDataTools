using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800StepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800StepAction);

    [Description("Whether the step will bring the dragon towards the middle of the map.")]
    [JsonPropertyName("isResetStep_")]
    public bool IsResetStep { get; set; } = false;

    [JsonPropertyName("motionIdNameStepFront_")]
    public string? MotionIdNameStepFront { get; set; } = "0050";

    [JsonPropertyName("motionIdNameStepBack_")]
    public string? MotionIdNameStepBack { get; set; } = "0051";

    [JsonPropertyName("motionIdNameStepLeft_")]
    public string? MotionIdNameStepLeft { get; set; } = "0052";

    [JsonPropertyName("motionIdNameStepRight_")]
    public string? MotionIdNameStepRight { get; set; } = "0053";
}
