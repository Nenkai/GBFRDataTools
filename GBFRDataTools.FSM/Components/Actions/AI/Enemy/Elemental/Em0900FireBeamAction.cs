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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Elemental;

public class Em0900FireBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0900FireBeamAction);

    [JsonPropertyName("fallGravity_")]
    public float FallGravity { get; set; } = 0.1f; // Offset 0xB0

    [JsonPropertyName("beamShotPosOffset_")]
    public Vector4 BeamShotPosOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0xA0

    [JsonPropertyName("jumpMotionMoveRate_")]
    public float JumpMotionMoveRate { get; set; } = 1.5f; // Offset 0xB4

    [JsonPropertyName("beamMoveDegY_")]
    public float BeamMoveDegY { get; set; } = 0f; // Offset 0xB8

    [JsonPropertyName("beamStartOffset_")]
    public Vector4 BeamStartOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x90

    [JsonPropertyName("beamMoveDist_")]
    public float BeamMoveDist { get; set; } = 8f; // Offset 0xBC

    [JsonPropertyName("backMoveDist_")]
    public float BackMoveDist { get; set; } = 10f; // Offset 0xC0

    [JsonPropertyName("defaultShotSize_")]
    public float DefaultShotSize { get; set; } = 0.5f; // Offset 0xC4

    [JsonPropertyName("defaultShotLandingTime_")]
    public float DefaultShotLandingTime { get; set; } = 0.2f; // Offset 0xC8

    [JsonPropertyName("defaultShotMoveWaitTime_")]
    public float DefaultShotMoveWaitTime { get; set; } = 0.3f; // Offset 0xCC

    [JsonPropertyName("defaultShotMoveTime_")]
    public float DefaultShotMoveTime { get; set; } = 0.3f; // Offset 0xD0

    [JsonPropertyName("defaultSpeedRateAddPower_")]
    public int DefaultSpeedRateAddPower { get; set; } = 0; // Offset 0xD4

    public Em0900FireBeamAction()
    {
    }
}

