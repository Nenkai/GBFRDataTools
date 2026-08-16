using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200GridBlackSpearsObstacleMoveHomingAction : ShotMoveBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200GridBlackSpearsObstacleMoveHomingAction);

    public Em8200GridBlackSpearsObstacleMoveHomingAction()
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