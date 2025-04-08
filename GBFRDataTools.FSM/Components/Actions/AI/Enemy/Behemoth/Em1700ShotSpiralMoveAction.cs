using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700ShotSpiralMoveAction : ShotMoveBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700ShotSpiralMoveAction);

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 1.0f;

    [JsonPropertyName("initRadius_")]
    public float InitRadius { get; set; } = 5.0f;

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0.1f;

    [JsonPropertyName("addRotY_")]
    public float AddRotY { get; set; } = 0.1f;

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; } = 0.1f;

    [JsonPropertyName("accelerationRotY_")]
    public float AccelerationRotY { get; set; } = 0.1f;

    public Em1700ShotSpiralMoveAction()
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
