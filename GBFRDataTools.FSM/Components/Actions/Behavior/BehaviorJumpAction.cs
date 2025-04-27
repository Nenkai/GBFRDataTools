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
    public Vector4 LandPos { get; set; } = Vector4.UnitW; // Offset 0x40

    [JsonPropertyName("motionIdJump_")]
    public string MotionIdJump { get; set; } // Offset 0x50

    [JsonPropertyName("motionIdFall_")]
    public string MotionIdFall { get; set; } // Offset 0x70

    [JsonPropertyName("motionIdLanding_")]
    public string MotionIdLanding { get; set; } // Offset 0x90

    [JsonPropertyName("jumpSpeedZX_")]
    public float JumpSpeedZX { get; set; } = 0.07f; // Offset 0xB4

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.07f; // Offset 0xB0

    [JsonPropertyName("isUseLandPos_")]
    public bool IsUseLandPos { get; set; } = false; // Offset 0xB8

    [JsonPropertyName("isDisableExFallUntilJumpMove_")]
    public bool IsDisableExFallUntilJumpMove { get; set; } = false; // Offset 0xB9

    public BehaviorJumpAction()
    {
    }
}
