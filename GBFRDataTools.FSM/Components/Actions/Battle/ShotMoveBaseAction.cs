using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotMoveBaseAction : ActionComponent
{
    [JsonPropertyName("velocityBegin_")]
    public float VelocityBegin { get; set; }

    [JsonPropertyName("velocityEnd_")]
    public float VelocityEnd { get; set; }

    [JsonPropertyName("moveSecondMax_")]
    public float MoveSecondMax { get; set; }

    [JsonPropertyName("isGroundFollow_")]
    public bool IsGroundFollow { get; set; }

    [JsonPropertyName("isGroundFollow_MoveEnd_")]
    public bool IsGroundFollow_MoveEnd { get; set; }

    [JsonPropertyName("groundFollowHigh_")]
    public float GroundFollowHigh { get; set; }

    [JsonPropertyName("groundFollowLow_")]
    public float GroundFollowLow { get; set; }

    [JsonPropertyName("groundFollowOffsetY_")]
    public float GroundFollowOffsetY { get; set; }
}
