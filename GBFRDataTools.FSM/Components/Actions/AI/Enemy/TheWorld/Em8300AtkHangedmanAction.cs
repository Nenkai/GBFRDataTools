using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkHangedmanAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkHangedmanAction);

    [JsonPropertyName("warpTime_")]
    public float WarpTime { get; set; } = 0.4f;

    [JsonPropertyName("offsetY_")]
    public float OffsetY { get; set; } = 9.5f;

    [JsonPropertyName("attackTotalTime_")]
    public float AttackTotalTime { get; set; } = 8f;

    [JsonPropertyName("attackTime1_")]
    public float AttackTime1 { get; set; } = 1f;

    [JsonPropertyName("attackTime2_")]
    public float AttackTime2 { get; set; } = 4f;

    [JsonPropertyName("attackTimeFinish_")]
    public float AttackTimeFinish { get; set; } = 7f;

    [JsonPropertyName("attackCount_")]
    public int AttackCount { get; set; } = 3;
}