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

public class Em1800DragonicTwisterMoveAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800DragonicTwisterMoveAction);

    [JsonPropertyName("lenCoefficient_")]
    public float LenCoefficient { get; set; } = 2.0f;

    [JsonPropertyName("addAngle_")]
    public float AddAngle { get; set; } = 0.03f;

    [JsonPropertyName("minimumRadius_")]
    public float MinimumRadius { get; set; } = 4.5f;

    [JsonPropertyName("maximumRadius_")]
    public float MaximumRadius { get; set; } = 50.0f;

    [JsonPropertyName("finishSignTime_")]
    public float FinishSignTime { get; set; } = 2.65f;

    public Em1800DragonicTwisterMoveAction()
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
