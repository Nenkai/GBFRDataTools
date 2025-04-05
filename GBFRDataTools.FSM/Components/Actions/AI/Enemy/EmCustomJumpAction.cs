using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmCustomJumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCustomJumpAction);

    [JsonPropertyName("jumpSpeedZX_")]
    public float JumpSpeedZX { get; set; } = 0.07f;

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.07f;

    [JsonPropertyName("motionIdJump_")]
    public string MotionIdJump { get; set; } = "0020";

    [JsonPropertyName("motionIdJumpLoop_")]
    public string MotionIdJumpLoop { get; set; } = "0021";

    [JsonPropertyName("motionIdFall_")]
    public string MotionIdFall { get; set; } = "0022";

    [JsonPropertyName("motionIdFallLoop_")]
    public string MotionIdFallLoop { get; set; } = "0023";

    [JsonPropertyName("motionIdLanding_")]
    public string MotionIdLanding { get; set; } = "0024";

    [JsonPropertyName("isUseLandPos_")]
    public bool IsUseLandPos { get; set; } = false;

    [JsonPropertyName("landPos_")]
    public /* cVec4 */ Vector4 LandPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1.0f;

    [JsonPropertyName("transitionFallSpeed_")]
    public float TransitionFallSpeed { get; set; } = 0.3f;
}
