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

public class EmStatueBaseArrowTackleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmStatueBaseArrowTackleAction);

    [JsonPropertyName("turnAngle_")]
    public float TurnAngle { get; set; } = 0.05f; // Offset 0xB0

    [JsonPropertyName("poseLoopSec_")]
    public float PoseLoopSec { get; set; } = 3f; // Offset 0xB4

    [JsonPropertyName("vanishOmenTimeLeft_")]
    public float VanishOmenTimeLeft { get; set; } = 0.1f; // Offset 0xB8

    [JsonPropertyName("poseRotXrate_")]
    public float PoseRotXrate { get; set; } = 0.5f; // Offset 0xBC

    [JsonPropertyName("poseRotXMax_")]
    public float PoseRotXMax { get; set; } = 180f; // Offset 0xC0

    [JsonPropertyName("frontMoveSpeed_")]
    public float FrontMoveSpeed { get; set; } = 3f; // Offset 0xC4

    [JsonPropertyName("tackleTipOffset_")]
    public float TackleTipOffset { get; set; } = 3f; // Offset 0xC8

    [JsonPropertyName("hitChackCapsuleRad_")]
    public float HitChackCapsuleRad { get; set; } = 0.25f; // Offset 0xD0

    [JsonPropertyName("signStartOffset_")]
    public float SignStartOffset { get; set; } = 3f; // Offset 0xCC

    [JsonPropertyName("targetMinDist_")]
    public float TargetMinDist { get; set; } = 2f; // Offset 0xD4

    [JsonPropertyName("targetMaxDist_")]
    public float TargetMaxDist { get; set; } = 40f; // Offset 0xD8

    public EmStatueBaseArrowTackleAction()
    {
    }
}

