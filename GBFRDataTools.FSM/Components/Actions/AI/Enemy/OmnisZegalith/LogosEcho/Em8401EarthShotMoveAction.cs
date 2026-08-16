using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.LogosEcho;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8401EarthShotMoveAction : ShotMoveHomingAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401EarthShotMoveAction);

    [JsonPropertyName("moveYSpeed_")]
    public float MoveYSpeed { get; set; } = 1f;

    [JsonPropertyName("adjustPosY_")]
    public float AdjustPosY { get; set; } = 2f;

    public Em8401EarthShotMoveAction()
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
        RotSpeed = 0f;
        StopDistance = -1f;
        StopDegree = -1f;
        IsStopDistanceAndAngle = false;
        IsHomingOnlyY = false;
        IsRotateXY = false;
        IsGimbalLockSafety = false;
    }
}
