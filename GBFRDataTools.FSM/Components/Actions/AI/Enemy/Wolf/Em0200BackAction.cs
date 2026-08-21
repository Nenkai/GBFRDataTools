using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wolf;

public class Em0200BackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200BackAction);

    [JsonPropertyName("checkRunEndDistance_")]
    public float CheckRunEndDistance { get; set; } = 10f; 

    [JsonPropertyName("runHomingAngle_")]
    public float RunHomingAngle { get; set; } = 10f; 

    [JsonPropertyName("targetRotationRad_")]
    public float TargetRotationRad { get; set; } = 50f; 

    [JsonPropertyName("stepCheckAdjustY_")]
    public float StepCheckAdjustY { get; set; } = 5f; 
}
