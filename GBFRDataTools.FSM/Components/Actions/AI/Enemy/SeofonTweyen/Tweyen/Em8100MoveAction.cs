using GBFRDataTools.Entities;

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
public class Em8100MoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100MoveAction);

    [JsonPropertyName("dist_")]
    public float Dist { get; set; } = 10f;

    [JsonPropertyName("maxMoveSec_")]
    public float MaxMoveSec { get; set; } = 3f;

    [JsonPropertyName("moveType_")]
    public int MoveType { get; set; } = 0;

    [JsonPropertyName("backJumpHeight_")]
    public float BackJumpHeight { get; set; } = 5f;

    [JsonPropertyName("backJumpMoveDist_")]
    public float BackJumpMoveDist { get; set; } = 25f;

    [JsonPropertyName("farCheckDist_")]
    public float FarCheckDist { get; set; } = 20f;
}