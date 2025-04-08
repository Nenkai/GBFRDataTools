using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms;

public class Em1804TwisterMeandelingMoveAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1804TwisterMeandelingMoveAction);

    [JsonPropertyName("meandelingTime_")]
    public float MeandelingTime { get; set; } = 3.0f;

    [JsonPropertyName("startAmplitude_")]
    public float StartAmplitude { get; set; } = 5.0f;

    [JsonPropertyName("maxAmplitude_")]
    public float MaxAmplitude { get; set; } = 5.0f;

    [JsonPropertyName("period_")]
    public float Period { get; set; } = 1.5f;

    public Em1804TwisterMeandelingMoveAction()
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
