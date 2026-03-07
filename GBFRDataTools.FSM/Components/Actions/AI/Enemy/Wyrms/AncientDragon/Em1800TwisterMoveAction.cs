using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800TwisterMoveAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800TwisterMoveAction);

    [JsonPropertyName("waitRotationStart_")]
    public float WaitRotationStart { get; set; } = 0.0f;

    [JsonPropertyName("targetDegreeX_")]
    public float TargetDegreeX { get; set; } = 2.0f;

    [JsonPropertyName("targetDegreeY_")]
    public float TargetDegreeY { get; set; } = 0.0f;

    [JsonPropertyName("rotationSecondX_")]
    public float RotationSecondX { get; set; } = 0.0f;

    [JsonPropertyName("rotationSecondY_")]
    public float RotationSecondY { get; set; } = 0.0f;

    [JsonPropertyName("reverseRotationX_")]
    public bool ReverseRotationX { get; set; } = false;

    [JsonPropertyName("reverseRotationY_")]
    public bool ReverseRotationY { get; set; } = false;

    [JsonPropertyName("velocityMaxSecond_")]
    public float VelocityMaxSecond { get; set; } = 0.0f;

    public Em1800TwisterMoveAction()
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
