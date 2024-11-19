using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmCustomJumpAction : ActionComponent
{
    [JsonPropertyName("jumpSpeedZX_")]
    public float JumpSpeedZX { get; set; }

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; }

    [JsonPropertyName("motionIdJump_")]
    public string MotionIdJump { get; set; }

    [JsonPropertyName("motionIdJumpLoop_")]
    public string MotionIdJumpLoop { get; set; }

    [JsonPropertyName("motionIdFall_")]
    public string MotionIdFall { get; set; }

    [JsonPropertyName("motionIdFallLoop_")]
    public string MotionIdFallLoop { get; set; }

    [JsonPropertyName("motionIdLanding_")]
    public string MotionIdLanding { get; set; }

    [JsonPropertyName("isUseLandPos_")]
    public bool IsUseLandPos { get; set; }

    [JsonPropertyName("landPos_")]
    public cVec4 LandPos { get; set; }

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; }

    [JsonPropertyName("transitionFallSpeed_")]
    public float TransitionFallSpeed { get; set; }
}
