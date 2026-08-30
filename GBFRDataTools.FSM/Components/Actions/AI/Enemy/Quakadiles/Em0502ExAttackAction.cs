using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em0502ExAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0502ExAttackAction);

    [JsonPropertyName("checkDist_")]
    public float CheckDist { get; set; } = 10f;

    [JsonPropertyName("cameraLookAtMoveRate_")]
    public float CameraLookAtMoveRate { get; set; } = 0.1f;

    [JsonPropertyName("geyserStartOffset_")]
    public float GeyserStartOffset { get; set; } = 20f;

    [JsonPropertyName("geyserSpacing_")]
    public float GeyserSpacing { get; set; } = 10f;

    [JsonPropertyName("geyserSpawnLimit_")]
    public int GeyserSpawnLimit { get; set; } = 6;

    [JsonPropertyName("checkFloorDist_")]
    public float CheckFloorDist { get; set; } = 5000f;

    [JsonPropertyName("straightTargetingMinDist_")]
    public float StraightTargetingMinDist { get; set; } = 10f;

    [JsonPropertyName("cameraLookAtOffsetTime_")]
    public float CameraLookAtOffsetTime { get; set; } = 2f;

    [JsonPropertyName("signOffsetY_")]
    public float SignOffsetY { get; set; } = 0f;

    [JsonPropertyName("targetImpactPosOffsetY_")]
    public float TargetImpactPosOffsetY { get; set; } = 1.5f;
}
