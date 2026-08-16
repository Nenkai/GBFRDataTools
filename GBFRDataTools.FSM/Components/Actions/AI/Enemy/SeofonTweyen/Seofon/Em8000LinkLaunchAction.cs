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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Seofon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8000LinkLaunchAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8000LinkLaunchAction);

    [JsonPropertyName("waitStartFrame_")]
    public int WaitStartFrame { get; set; } = 40;

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 120f;

    [JsonPropertyName("targetOffsetDist_")]
    public float TargetOffsetDist { get; set; } = 1.75f;
}