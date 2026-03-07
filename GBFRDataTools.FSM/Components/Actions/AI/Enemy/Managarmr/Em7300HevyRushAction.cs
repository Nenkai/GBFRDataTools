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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300HevyRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300HevyRushAction);

    [JsonPropertyName("startHomingAngle_")]
    public Vector4 StartHomingAngle { get; set; } = new Vector4(1f, 1f, 1f, 1f); // Offset 0x70

    [JsonPropertyName("loopHomingAngle_")]
    public Vector4 LoopHomingAngle { get; set; } = new Vector4(0.1f, 0.1f, 0.3f, 0.3f); // Offset 0x80

    [JsonPropertyName("loopHomingAngleSpped_")]
    public float LoopHomingAngleSpped { get; set; } = 0.01f; // Offset 0x90

    [JsonPropertyName("loopHomingTime_")]
    public Vector4 LoopHomingTime { get; set; } = new Vector4(1f, 1f, -1f, -1f); // Offset 0xA0

    [JsonPropertyName("endAngle_")]
    public float EndAngle { get; set; } = 100f; // Offset 0xB8

    [JsonPropertyName("secondsMinMax_")]
    public Vector2 SecondsMinMax { get; set; } = new Vector2(3f, 10f); // Offset 0xB0

    [JsonPropertyName("rushMotionRate_")]
    public Vector4 RushMotionRate { get; set; } = new Vector4(1f, 1f, 1.2f, 1.2f); // Offset 0xC0

    [JsonPropertyName("rushMotionRateTime_")]
    public float RushMotionRateTime { get; set; } = 2f; // Offset 0xD0

    public Em7300HevyRushAction()
    {
    }
}

