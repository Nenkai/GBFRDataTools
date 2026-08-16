using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200WaveShotMoveHomingAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200WaveShotMoveHomingAction);

    [JsonPropertyName("rotSpeed_")]
    public float RotSpeed { get; set; } = 0f;

    [JsonPropertyName("stopDistance_")]
    public float StopDistance { get; set; } = -1f;

    [JsonPropertyName("stopDegree_")]
    public float StopDegree { get; set; } = -1f;

    [JsonPropertyName("isStopDistanceAndAngle_")]
    public bool IsStopDistanceAndAngle { get; set; } = false;

    public Em8200WaveShotMoveHomingAction()
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