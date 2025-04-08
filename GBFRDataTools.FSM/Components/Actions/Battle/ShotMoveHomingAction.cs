using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotMoveHomingAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotMoveHomingAction);

    [JsonPropertyName("rotSpeed_")]
    public float RotSpeed { get; set; } = 0.0f;

    [JsonPropertyName("stopDistance_")]
    public float StopDistance { get; set; } = -1.0f;

    [JsonPropertyName("stopDegree_")]
    public float StopDegree { get; set; } = -1.0f;

    [JsonPropertyName("isStopDistanceAndAngle_")]
    public bool IsStopDistanceAndAngle { get; set; } = false;

    [JsonPropertyName("isHomingOnlyY_")]
    public bool IsHomingOnlyY { get; set; } = false;

    [JsonPropertyName("isRotateXY_")]
    public bool IsRotateXY { get; set; } = false;

    public ShotMoveHomingAction()
    {
        VelocityBegin = 1f;
        VelocityEnd = -1f;
        MoveSecondMax = 2f;
        IsGroundFollow = false;
        IsGroundFollow_MoveEnd = false;
        GroundFollowHigh = 5f;
        GroundFollowLow = -5f;
        GroundFollowOffsetY = 0f;
        GravityScale = 0f;
        IsRotateFall = false;
    }
}
