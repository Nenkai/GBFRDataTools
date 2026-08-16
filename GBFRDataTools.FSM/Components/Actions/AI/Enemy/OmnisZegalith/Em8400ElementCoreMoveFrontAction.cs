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

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreMoveFrontAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreMoveFrontAction);

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0f;

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 1f;

    [JsonPropertyName("moveTargetOffset_")]
    public float MoveTargetOffset { get; set; } = 2.5f;

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();

    [JsonPropertyName("useMoveDistanceMax_")]
    public bool UseMoveDistanceMax { get; set; } = false;

    [JsonPropertyName("moveDistanceMax_")]
    public float MoveDistanceMax { get; set; } = 3f;
}
