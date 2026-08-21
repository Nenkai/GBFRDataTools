using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100StepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100StepAction);

    [JsonPropertyName("selectStepType_")]
    public int SelectStepType { get; set; } = 0; 

    [JsonPropertyName("isNextStep_")]
    public bool IsNextStep { get; set; } = false; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; 

    [JsonPropertyName("motionMovementRate_")]
    public float MotionMovementRate { get; set; } = 2f; 

    [JsonPropertyName("backMotionAngle_")]
    public float BackMotionAngle { get; set; } = 135f; 
}