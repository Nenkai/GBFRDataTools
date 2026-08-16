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
public class So9200RagingChainAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So9200RagingChainAction);

    [JsonPropertyName("backSpeed_")]
    public float BackSpeed { get; set; } = 10f;

    [JsonPropertyName("warpDuration_")]
    public float WarpDuration { get; set; } = 0.16f;

    [JsonPropertyName("warpBackOffset_")]
    public float WarpBackOffset { get; set; } = 3f;

    [JsonPropertyName("warpGroundCheckBeginHeight_")]
    public float WarpGroundCheckBeginHeight { get; set; } = 20f;

    [JsonPropertyName("warpGroundCheckEndHeight_")]
    public float WarpGroundCheckEndHeight { get; set; } = -30f;

    [JsonPropertyName("obstacleRaycastYOffset_")]
    public float ObstacleRaycastYOffset { get; set; } = 1f;

    [JsonPropertyName("lookAheadDistance_")]
    public float LookAheadDistance { get; set; } = 10f;

    [JsonPropertyName("lookAtSpeed_")]
    public float LookAtSpeed { get; set; } = 1f;

    [JsonPropertyName("motionDataMoveTotalDist_")]
    public float MotionDataMoveTotalDist { get; set; } = 5.5f;

    [JsonPropertyName("moveEndDist_")]
    public float MoveEndDist { get; set; } = 2f;

    [JsonPropertyName("animMoveRateMax_")]
    public float AnimMoveRateMax { get; set; } = 5f;

    [JsonPropertyName("animMoveRateMin_")]
    public float AnimMoveRateMin { get; set; } = 0.1f;
}
