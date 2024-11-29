using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIMoveAction : ActionComponent
{
    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("dist_")]
    public float Dist { get; set; } = 1.0f;

    [JsonPropertyName("useBlackBoardValue_")]
    public bool UseBlackBoardValue { get; set; } = false;

    // sys::String
    [JsonPropertyName("boolName_")]
    public string BoolName { get; set; } = string.Empty;

    [JsonPropertyName("isCheckCollision_")]
    public bool IsCheckCollision { get; set; } = false;

    // sys::String
    [JsonPropertyName("positionBBName_")]
    public string PositionBBName { get; set; } = "PlayerAI_TargetPoint";

    [JsonPropertyName("positionHashValue_")]
    public uint PositionHashValue { get; set; } = 0;

    [JsonPropertyName("position_")]
    public /* cVec4 */ Vector4 Position { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isSetPosition_")]
    public bool IsSetPosition { get; set; } = false;

    [Obsolete("Not used by the game")]
    [JsonPropertyName("isUseObstacle_")]
    public bool IsSetObstacle { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("obstacleRadius_")]
    public float ObstacleRadius { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("obstacleLength_")]
    public float ObstacleLength { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("obstacleCount_")]
    public int ObstacleCount { get; set; }

    [JsonPropertyName("isSmoothPass_")]
    public bool IsSmoothPass { get; set; } = false;

    [JsonPropertyName("smoothRate_")]
    public float SmoothRate { get; set; } = 1.0f;

    [JsonPropertyName("sideLength_")]
    public float SideLength { get; set; } = 0.0f;

    [JsonPropertyName("dashLength_")]
    public float DashLength { get; set; } = 100000.0f;

    [JsonPropertyName("randomLength_")]
    public float RandomLength { get; set; } = 0.0f;

    [JsonPropertyName("randomChangeTime_")]
    public float RandomChangeTime { get; set; } = 3.0f;

    [JsonPropertyName("randomChangeAddTime_")]
    public float RandomChangeAddTime { get; set; } = 5.0f;

    [JsonPropertyName("minMoveTime_")]
    public float MinMoveTime { get; set; } = 0.0f;
}
