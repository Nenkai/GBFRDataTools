using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ShotMoveSinAction : ShotMoveBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotMoveSinAction);

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0f;

    [JsonPropertyName("addSin_")]
    public float AddSin { get; set; } = 0f;

    [JsonPropertyName("offsetX_")]
    public float OffsetX { get; set; } = 0f;

    [JsonPropertyName("isInversion_")]
    public bool IsInversion { get; set; } = false;

    public ShotMoveSinAction()
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
