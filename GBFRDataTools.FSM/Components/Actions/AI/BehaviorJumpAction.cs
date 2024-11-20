using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class BehaviorJumpAction : ActionComponent
{
    [JsonPropertyName("landPos_")]
    public cVec4 LandPos { get; set; }

    [JsonPropertyName("motionIdJump_")]
    public string MotionIdJump { get; set; }

    [JsonPropertyName("motionIdFall_")]
    public string MotionIdFall { get; set; }

    [JsonPropertyName("motionIdLanding_")]
    public string MotionIdLanding { get; set; }

    [JsonPropertyName("jumpSpeedZX_")]
    public float JumpSpeedZX { get; set; }

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; }

    [JsonPropertyName("isUseLandPos_")]
    public bool IsUseLandPos { get; set; }

    [JsonPropertyName("isDisableExFallUntilJumpMove_")]
    public bool IsDisableExFallUntilJumpMove { get; set; }

}
