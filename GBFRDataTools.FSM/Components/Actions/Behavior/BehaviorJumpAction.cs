using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class BehaviorJumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BehaviorJumpAction);

    [JsonPropertyName("landPos_")]
    public Vector4 LandPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("motionIdJump_")]
    public string? MotionIdJump { get; set; } 

    [JsonPropertyName("motionIdFall_")]
    public string? MotionIdFall { get; set; } 

    [JsonPropertyName("motionIdLanding_")]
    public string? MotionIdLanding { get; set; } 

    [JsonPropertyName("jumpSpeedZX_")]
    public float JumpSpeedZX { get; set; } = 0.07f; 

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.07f; 

    [JsonPropertyName("isUseLandPos_")]
    public bool IsUseLandPos { get; set; } = false; 

    [JsonPropertyName("isDisableExFallUntilJumpMove_")]
    public bool IsDisableExFallUntilJumpMove { get; set; } = false;
}
