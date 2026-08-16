using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Pincer;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em2500MoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2500MoveAction);

    [JsonPropertyName("moveTimeMax_")]
    public float MoveTimeMax { get; set; } = 4.0f;

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1.50f;

    [JsonPropertyName("targetDist_")]
    public float TargetDist { get; set; } = 6.0f;

    [JsonPropertyName("motionSpeed_")]
    public float MotionSpeed { get; set; } = 1.0f;
}
