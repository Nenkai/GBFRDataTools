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
public class Em2510AtkRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510AtkRushAction);

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 1.0f;

    [JsonPropertyName("stopDist_")]
    public float StopDist { get; set; } = 8.0f;

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; } = 0.5f;

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.1f;
}
