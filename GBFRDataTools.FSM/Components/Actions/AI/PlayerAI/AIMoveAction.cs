using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("Moves the AI towards a point, with a variety of behavior types. Simulates player inputs, relying on actions ending to move properly")]
public class AIMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIMoveAction);

    [JsonPropertyName("type_")]
    [Description("""
        Movement type. 
        0: To Player Character
        1: Towards Targeted Point
        2: Towards ~15 Units from Targeted Point
            If too close, will walk away, if too far, will walk towards
            Smaller "Dist" is further from target
        3: Towards Map Origin
        4: Towards Targeted Point at Time of Call
        """)]
    public AIMoveActionType Type { get; set; } = AIMoveActionType.ReturnToPlayer;

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
    [Description("To Player Character (Type 0)")]
    ReturnToPlayer = 0,

    /// <summary>
    /// Move towards target using distance
    /// </summary>
    // 0x1B23CF78
    [Description("Towards Targeted Point (Type 1)")]
    TowardsTargetTracked = 1,

    /// <summary>
    /// Move away from target using distance
    /// </summary>
    // 0x12F4D95E
    [Description("Away from target (Type 2)")]
    MoveType2_Away = 2,

    // 0xEAA53141
    [Description("Towards Map Origin (Type 3)")]
    TowardsMapOrigin = 3,

    // 0xDE2BB15E (AIMoveAction), 0x8CB68271 (AIBattleWaitAction)
    [Description("Towards Targeted Point at Time of Call (Type 4)")]
    TargetPositionAtTimeOfCall = 4
}
