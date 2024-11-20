using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIMoveAction : ActionComponent
{
    [JsonPropertyName("type_")]
    public int Type { get; set; }

    [JsonPropertyName("dist_")]
    public float Dist { get; set; }

    [JsonPropertyName("useBlackBoardValue_")]
    public bool UseBlackBoardValue { get; set; }

    [JsonPropertyName("boolName_")]
    public string BoolName { get; set; }

    [JsonPropertyName("isCheckCollision_")]
    public bool IsCheckCollision { get; set; }

    [JsonPropertyName("positionBBName_")]
    public string PositionBBName { get; set; }

    [JsonPropertyName("positionHashValue_")]
    public uint PositionHashValue { get; set; }

    [JsonPropertyName("position_")]
    public cVec4 Position { get; set; }

    [JsonPropertyName("isSetPosition_")]
    public bool IsSetPosition { get; set; }

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
    public bool IsSmoothPass { get; set; }

    [JsonPropertyName("smoothRate_")]
    public float SmoothRate { get; set; }

    [JsonPropertyName("sideLength_")]
    public float SideLength { get; set; }

    [JsonPropertyName("dashLength_")]
    public float DashLength { get; set; }

    [JsonPropertyName("randomLength_")]
    public float RandomLength { get; set; }

    [JsonPropertyName("randomChangeTime_")]
    public float RandomChangeTime { get; set; }

    [JsonPropertyName("randomChangeAddTime_")]
    public float RandomChangeAddTime { get; set; }

    [JsonPropertyName("minMoveTime_")]
    public float MinMoveTime { get; set; }
}
