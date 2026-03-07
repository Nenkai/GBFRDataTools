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
    public Vector4 TargetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x70

    [JsonPropertyName("staretFrame_")]
    public float StaretFrame { get; set; } = 41f; // Offset 0x80

    [JsonPropertyName("jumpTime_")]
    public float JumpTime { get; set; } = 1f; // Offset 0x84

    [JsonPropertyName("jumpHeight_")]
    public float JumpHeight { get; set; } = 4f; // Offset 0x88

    [JsonPropertyName("transitionFallSpeed_")]
    public float TransitionFallSpeed { get; set; } = 0.1f; // Offset 0x8C

    public Em7300JumpAction()
    {
    }
}
