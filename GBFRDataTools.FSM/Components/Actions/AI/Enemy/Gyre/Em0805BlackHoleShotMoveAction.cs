﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0805BlackHoleShotMoveAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0805BlackHoleShotMoveAction);

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 8.5f;

    [JsonPropertyName("isHoming_")]
    public bool IsHoming { get; set; } = false;

    [JsonPropertyName("rotSpeed_")]
    public float RotSpeed { get; set; } = 0.0f;

    [JsonPropertyName("stopDistance_")]
    public float StopDistance { get; set; } = -1.0f;

    [JsonPropertyName("noStopTime_")]
    public float NoStopTime { get; set; } = 0.0f;

    [JsonPropertyName("stopDegree_")]
    public float StopDegree { get; set; } = -1.0f;

    [JsonPropertyName("isStopDistanceAndAngle_")]
    public bool IsStopDistanceAndAngle { get; set; }

    [JsonPropertyName("isHomingOnlyY_")]
    public bool IsHomingOnlyY { get; set; } = false;

    [JsonPropertyName("isCheckRotate_")]
    public bool IsCheckRotate { get; set; } = false;

    [JsonPropertyName("checkLength_")]
    public float CheckLength { get; set; } = 0.6f;

    [JsonPropertyName("checkNum_")]
    public int CheckNum { get; set; } = 3;

    [JsonPropertyName("checkHeight_")]
    public float CheckHeight { get; set; } = 0.5f;

    [JsonPropertyName("checkAdjustHeight_")]
    public float CheckAdjustHeight { get; set; } = 1.0f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 0.0f;

    public Em0805BlackHoleShotMoveAction()
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
