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

public class Em7300PointStepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300PointStepAction);

    [JsonPropertyName("stepPosType_")]
    public int StepPosType { get; set; } = 0; // Offset 0x60

    [JsonPropertyName("turnPosType_")]
    public int TurnPosType { get; set; } = 0; // Offset 0x64

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 15f; // Offset 0x68

    [JsonPropertyName("rotY_")]
    public float RotY { get; set; } = 0f; // Offset 0x6C

    [JsonPropertyName("isBreakObject_")]
    public bool IsBreakObject { get; set; } = false; // Offset 0x70

    public Em7300PointStepAction()
    {
    }
}
