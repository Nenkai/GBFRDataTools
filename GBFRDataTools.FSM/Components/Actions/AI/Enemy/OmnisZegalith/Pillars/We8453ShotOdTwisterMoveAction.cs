using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.Pillars;

[GameSupport(GameVersion.EndlessRagnarok)]
public class We8453ShotOdTwisterMoveAction : Em1800DragonicTwisterMoveAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(We8453ShotOdTwisterMoveAction);

    public We8453ShotOdTwisterMoveAction()
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
        LenCoefficient = 2f;
        AddAngle = 0.03f;
        MinimumRadius = 4.5f;
        MaximumRadius = 50f;
        FinishSignTime = 2.65f;
    }
}
