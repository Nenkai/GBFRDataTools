using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class BehaviorJumpAction : ActionComponent
{
    [JsonPropertyName("landPos_")]
    public /* cVec4 */ Vector4 LandPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("motionIdJump_")]
    public string MotionIdJump { get; set; } = "0020";

    [JsonPropertyName("motionIdFall_")]
    public string MotionIdFall { get; set; } = "0021";

    [JsonPropertyName("motionIdLanding_")]
    public string MotionIdLanding { get; set; } = "0022";

    [JsonPropertyName("jumpSpeedZX_")]
    public float JumpSpeedZX { get; set; } = 0.07f;

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.07f;

    [JsonPropertyName("isUseLandPos_")]
    public bool IsUseLandPos { get; set; } = false;

    [JsonPropertyName("isDisableExFallUntilJumpMove_")]
    public bool IsDisableExFallUntilJumpMove { get; set; } = false;

}
