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
public class Em2510AtkHeavyRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510AtkHeavyRushAction);

    [JsonPropertyName("rushMinTime_")]
    public float RushMinTime { get; set; } = 0.5f;

    [JsonPropertyName("rushMaxTime_")]
    public float RushMaxTime { get; set; } = 5.0f;

    [JsonPropertyName("rushSpeedMinDist_")]
    public float RushSpeedMinDist { get; set; } = 1.0f;

    [JsonPropertyName("rushSpeedMaxDist_")]
    public float RushSpeedMaxDist { get; set; } = 1.0f;

    [JsonPropertyName("rushMovementRateMin_")]
    public float RushMovementRateMin { get; set; } = 0.5f;

    [JsonPropertyName("rushMovementRateMax_")]
    public float RushMovementRateMax { get; set; } = 1.0f;

    [JsonPropertyName("homingRotRate_")]
    public float HomingRotRate { get; set; } = 0.3f;
}
