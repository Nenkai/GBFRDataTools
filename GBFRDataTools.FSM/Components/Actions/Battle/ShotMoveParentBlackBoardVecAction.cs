using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ShotMoveParentBlackBoardVecAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotMoveParentBlackBoardVecAction);

    [JsonPropertyName("vecParentBlackBoardKey_")]
    public string VecParentBlackBoardKey { get; set; }

    public ShotMoveParentBlackBoardVecAction()
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
