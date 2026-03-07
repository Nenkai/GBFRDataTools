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
    public int SelectStepType { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("isNextStep_")]
    public bool IsNextStep { get; set; } = false; // Offset 0x3C

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x40

    [JsonPropertyName("motionMovementRate_")]
    public float MotionMovementRate { get; set; } = 2f; // Offset 0x44

    [JsonPropertyName("backMotionAngle_")]
    public float BackMotionAngle { get; set; } = 135f; // Offset 0x48

    public Em2100StepAction()
    {
    }
}