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
    public int ScoopScoopingNum { get; set; } = 6; // Offset 0x4C

    [JsonPropertyName("scoopHormingAngleFront_")]
    public Vector2 ScoopHormingAngleFront { get; set; } = new Vector2(2f, 1.5f); // Offset 0x50

    [JsonPropertyName("scoopHormingAngleLR_")]
    public Vector2 ScoopHormingAngleLR { get; set; } = new Vector2(3f, 3f); // Offset 0x58

    [JsonPropertyName("scoopHormingAngleTime_")]
    public Vector2 ScoopHormingAngleTime { get; set; } = new Vector2(2f, 0.5f); // Offset 0x60

    [JsonPropertyName("scoopTurnFrontAngle_")]
    public Vector2 ScoopTurnFrontAngle { get; set; } = new Vector2(180f, 210f); // Offset 0x68

    [JsonPropertyName("maxMotionRate_")]
    public Vector4 MaxMotionRate { get; set; } = new Vector4(1f, 1f, 1.2f, 1.2f); // Offset 0x70

    [JsonPropertyName("maxMotionRateCount_")]
    public int MaxMotionRateCount { get; set; } = 3; // Offset 0x80

    public Em7300OverDrivePowerArtsAction()
    {
    }
}
