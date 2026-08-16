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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[Description("Added in Endless Ragnarok")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ShotGroundMovePlasmaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotGroundMovePlasmaAction);

    [JsonPropertyName("moveTimeSec_")]
    public float MoveTimeSec { get; set; } = 1f;

    [JsonPropertyName("waitTimeSec_")]
    public float WaitTimeSec { get; set; } = 1f;

    [JsonPropertyName("moveDistance_")]
    public float MoveDistance { get; set; } = 10f;

    [JsonPropertyName("moveCountLimit_")]
    public int MoveCountLimit { get; set; } = 5;

    [JsonPropertyName("isCurveMoveMode_")]
    public bool IsCurveMoveMode { get; set; } = false;

    [JsonPropertyName("maxCurveAmplitude_")]
    public float MaxCurveAmplitude { get; set; } = 10f;

    [JsonPropertyName("seEventName_")]
    public string SeEventName { get; set; }

    [JsonPropertyName("isSeEventNameCountUp_")]
    public bool IsSeEventNameCountUp { get; set; } = false;

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();
}
