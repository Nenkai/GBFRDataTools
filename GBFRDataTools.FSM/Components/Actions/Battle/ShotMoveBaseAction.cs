using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotMoveBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotMoveBaseAction);

    [JsonPropertyName("velocityBegin_")]
    public float VelocityBegin { get; set; } = 1.0f;

    [JsonPropertyName("velocityEnd_")]
    public float VelocityEnd { get; set; } = -1.0f;

    [JsonPropertyName("moveSecondMax_")]
    public float MoveSecondMax { get; set; } = 2.0f;

    [JsonPropertyName("isGroundFollow_")]
    public bool IsGroundFollow { get; set; } = false;

    [JsonPropertyName("isGroundFollow_MoveEnd_")]
    public bool IsGroundFollow_MoveEnd { get; set; } = false;

    [JsonPropertyName("groundFollowHigh_")]
    public float GroundFollowHigh { get; set; } = 5.0f;

    [JsonPropertyName("groundFollowLow_")]
    public float GroundFollowLow { get; set; } = -5.0f;

    [JsonPropertyName("groundFollowOffsetY_")]
    public float GroundFollowOffsetY { get; set; } = 0.0f;
}
