using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotMoveOrbitAction : ShotMoveBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotMoveOrbitAction);

    [JsonPropertyName("centerOffset_")]
    public /* cVec4 */ Vector4 CenterOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("centerPartsNo_")]
    public int CenterPartsNo { get; set; } = -1;

    [JsonPropertyName("radiusMax_")]
    public float RadiusMax { get; set; } = -1.0f;

    [JsonPropertyName("radiusSecondMax_")]
    public float RadiusSecondMax { get; set; } = -1.0f;

    [JsonPropertyName("isReverseRot_")]
    public bool IsReverseRot { get; set; } = false;

    public ShotMoveOrbitAction()
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