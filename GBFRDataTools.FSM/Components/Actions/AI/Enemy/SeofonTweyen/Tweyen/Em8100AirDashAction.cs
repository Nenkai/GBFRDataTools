using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8100AirDashAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100AirDashAction);

    [JsonPropertyName("isCombiSpArtsReadyMove_")]
    public bool IsCombiSpArtsReadyMove { get; set; } = false;

    [JsonPropertyName("riseMoveTimeFrame_")]
    public int RiseMoveTimeFrame { get; set; } = 50;

    [JsonPropertyName("maxMoveTimeSec_")]
    public float MaxMoveTimeSec { get; set; } = 1.5f;

    [JsonPropertyName("moveEndThresholdDist_")]
    public float MoveEndThresholdDist { get; set; } = 1f;

    [JsonPropertyName("gravityPower_")]
    public float GravityPower { get; set; } = 0.001f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1f;

    [JsonPropertyName("riseHeight_")]
    public float RiseHeight { get; set; } = 2f;

    [JsonPropertyName("motionMovementRate_")]
    public float MotionMovementRate { get; set; } = 0.7f;

    [JsonPropertyName("loopMotionMovementRate_")]
    public float LoopMotionMovementRate { get; set; } = 1.45f;

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();
}