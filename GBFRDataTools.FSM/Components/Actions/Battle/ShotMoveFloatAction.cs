﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotMoveFloatAction : ShotMoveBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotMoveFloatAction);

    [JsonPropertyName("riseHeightMax_")]
    public float RiseHeightMax { get; set; } = 0.0f;

    [JsonPropertyName("strokeHeight_")]
    public float StrokeHeight { get; set; } = 0.0f;

    [JsonPropertyName("isRotateMoveDir_")]
    public bool IsRotateMoveDir { get; set; } = true;

    public ShotMoveFloatAction()
    {
        VelocityBegin = 1f;
        VelocityEnd = -1f;
        MoveSecondMax = 2f;
        IsGroundFollow = false;
        IsGroundFollow_MoveEnd = false;
        GroundFollowHigh = 5f;
        GroundFollowLow = -5f;
        GroundFollowOffsetY = 0f;
    }
}