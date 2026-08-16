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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Pincer;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em2510MoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510MoveAction);

    [JsonPropertyName("moveType_")]
    public int MoveType { get; set; } = 0;

    [JsonPropertyName("moveTimeMax_")]
    public float MoveTimeMax { get; set; } = 4.0f;

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1.5f;

    [JsonPropertyName("animRate_")]
    public float AnimRate { get; set; } = 1.3f;

    [JsonPropertyName("targetDist_")]
    public float TargetDist { get; set; } = 6.0f;

    [JsonPropertyName("aroundAttackMinTime_")]
    public float AroundAttackMinTime { get; set; } = 1.0f;

    [JsonPropertyName("aroundAttackRate_")]
    public float AroundAttackRate { get; set; } = 0.5f;
}
