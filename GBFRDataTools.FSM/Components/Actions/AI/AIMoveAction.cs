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
    [Description("Movement type.")]
    public AIMoveActionType Type { get; set; } = AIMoveActionType.MoveType0_ReturnToPlayer;

    [JsonPropertyName("dist_")]
    [Description("Distance to travel.")]
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

public enum AIMoveActionType
{
    // 0xB597EE3
    [Description("Return to Player (Type 0)")]
    MoveType0_ReturnToPlayer = 0,

    /// <summary>
    /// Move towards target using distance
    /// </summary>
    // 0x1B23CF78
    [Description("Towards target (Type 1)")]
    MoveType1_Towards = 1,

    /// <summary>
    /// Move away from target using distance
    /// </summary>
    // 0x12F4D95E
    [Description("Away from target (Type 2)")]
    MoveType2_Away = 2,

    // 0xEAA53141
    [Description("Unknown Type 3")]
    MoveType3 = 3,

    // 0xDE2BB15E (AIMoveAction), 0x8CB68271 (AIBattleWaitAction)
    [Description("Unknown Type 4")]
    MoveType4 = 4
}
