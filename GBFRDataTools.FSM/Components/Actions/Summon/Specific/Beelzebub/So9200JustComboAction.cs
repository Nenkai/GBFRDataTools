using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So9200JustComboAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So9200JustComboAction);

    [JsonPropertyName("startAttackSpeed_")]
    public float StartAttackSpeed { get; set; } = 10f;

    [JsonPropertyName("warpDuration_")]
    public float WarpDuration { get; set; } = 0.16f;

    [JsonPropertyName("lookAheadDistance_")]
    public float LookAheadDistance { get; set; } = 10f;

    [JsonPropertyName("lookAtSpeed_")]
    public float LookAtSpeed { get; set; } = 1f;

    [JsonPropertyName("obstacleRaycastYOffset_")]
    public float ObstacleRaycastYOffset { get; set; } = 1f;

    [JsonPropertyName("successBackwardOffset_")]
    public float SuccessBackwardOffset { get; set; } = 12f;

    [JsonPropertyName("failedBackwardOffset_")]
    public float FailedBackwardOffset { get; set; } = 6f;

    [JsonPropertyName("groundSnapBeginHeight_")]
    public float GroundSnapBeginHeight { get; set; } = 10f;

    [JsonPropertyName("groundSnapEndHeight_")]
    public float GroundSnapEndHeight { get; set; } = -100f;

    [JsonPropertyName("forwardOffsetNoTarget_")]
    public float ForwardOffsetNoTarget { get; set; } = 3f;

    [JsonPropertyName("sideOffsetNoTarget_")]
    public float SideOffsetNoTarget { get; set; } = 3.6f;

    [JsonPropertyName("targetForwardDist_")]
    public float TargetForwardDist { get; set; } = 1.8f;

    [JsonPropertyName("targetSideOffset_")]
    public float TargetSideOffset { get; set; } = 1.2f;

    [JsonPropertyName("targetValidAngle_")]
    public float TargetValidAngle { get; set; } = 120f;

    [JsonPropertyName("cameraOffsetY_")]
    public float CameraOffsetY { get; set; } = 3f;

    [JsonPropertyName("cameraDistance_")]
    public float CameraDistance { get; set; } = 10f;

    [JsonPropertyName("giantEnemyDistance_")]
    public float GiantEnemyDistance { get; set; } = 10f;

    [JsonPropertyName("giantEnemyOffsetY_")]
    public float GiantEnemyOffsetY { get; set; } = 3f;

    [JsonPropertyName("limitWarpHeight_")]
    public float LimitWarpHeight { get; set; } = 5f;
}
