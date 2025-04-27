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
    public float StartHomingAngle { get; set; } = 4f; // Offset 0x7C

    [JsonPropertyName("jumpHomingAngle_")]
    public float JumpHomingAngle { get; set; } = 4f; // Offset 0x80

    [JsonPropertyName("jumpDistMax_")]
    public float JumpDistMax { get; set; } = 30f; // Offset 0x84

    [JsonPropertyName("start3st_")]
    public bool Start3st { get; set; } = false; // Offset 0x88

    [JsonPropertyName("start3st_MotionStaretFrame_")]
    public float Start3st_MotionStaretFrame { get; set; } = 25f; // Offset 0x8C

    [JsonPropertyName("start3st_MotionInterpFrame_")]
    public float Start3st_MotionInterpFrame { get; set; } = 20f; // Offset 0x90

    [JsonPropertyName("start3st_MotionRate_")]
    public float Start3st_MotionRate { get; set; } = 0.9f; // Offset 0xB0

    [JsonPropertyName("start3st_TargetPos_")]
    public Vector4 Start3st_TargetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0xA0

    public Em7300MoonsaultHornAction()
    {
    }
}
