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
public class Em2510ProvocationAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510ProvocationAction);

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 1.5f;

    [JsonPropertyName("targetHomingRate_Start_")]
    public float TargetHomingRate_Start { get; set; } = 0.0f;

    [JsonPropertyName("targetHomingRate_Loop_")]
    public float TargetHomingRate_Loop { get; set; } = 0.0f;

    [JsonPropertyName("targetHomingRate_End_")]
    public float TargetHomingRate_End { get; set; } = 0.0f;
}
