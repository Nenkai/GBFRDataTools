using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreShotSplineFallAction : Em0500SplineAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreShotSplineFallAction);

    [JsonPropertyName("useInitFallTime_")]
    public bool UseInitFallTime { get; set; } = false;

    [JsonPropertyName("useInitSetTargetPos_")]
    public bool UseInitSetTargetPos { get; set; } = false;

    [JsonPropertyName("initFallTime_")]
    public float InitFallTime { get; set; } = 1f;

    [JsonPropertyName("isLocalPos_")]
    public bool IsLocalPos { get; set; } = false;

    [JsonPropertyName("localTargetPos_")]
    public Vector4 LocalTargetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("targetPos_")]
    public Vector4 TargetPos { get; set; } = Vector4.UnitW;

    public Em8400ElementCoreShotSplineFallAction()
    {
        Time = 1f;
        Height = 10f;
        RotateDirection = false;
        EndTimer = true;
    }
}
