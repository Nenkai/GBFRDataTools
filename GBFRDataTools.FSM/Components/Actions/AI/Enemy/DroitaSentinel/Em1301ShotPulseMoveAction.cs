using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.DroitaSentinel;

public class Em1301ShotPulseMoveAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1301ShotPulseMoveAction);

    [JsonPropertyName("pulseAdjustY_")]
    public float PulseAdjustY { get; set; } = 0.05f; // Offset 0x80

    [JsonPropertyName("floorCheckHeightHalf_")]
    public float FloorCheckHeightHalf { get; set; } = 0.2f; // Offset 0x84

    [JsonPropertyName("moveLimitFloorAngle_")]
    public float MoveLimitFloorAngle { get; set; } = 60f; // Offset 0x88

    public Em1301ShotPulseMoveAction()
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
