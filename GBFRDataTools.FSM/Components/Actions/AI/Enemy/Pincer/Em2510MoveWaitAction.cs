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
public class Em2510MoveWaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510MoveWaitAction);

    [JsonPropertyName("moveTimeRandMin_")]
    public float MoveTimeRandMin { get; set; } = 1.5f;

    [JsonPropertyName("moveTimeRandMax_")]
    public float MoveTimeRandMax { get; set; } = 4.0f;

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1.0f;

    [JsonPropertyName("motionSpeed_")]
    public float MotionSpeed { get; set; } = 1.0f;

    [JsonPropertyName("targetHomingRate_")]
    public float TargetHomingRate { get; set; } = 0.0f;
}
