using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1804TwisterMeandelingMoveAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1804TwisterMeandelingMoveAction);

    [JsonPropertyName("meandelingTime_")]
    public float MeandelingTime { get; set; } = 3.0f;

    [JsonPropertyName("startAmplitude_")]
    public float StartAmplitude { get; set; } = 5.0f;

    [JsonPropertyName("maxAmplitude_")]
    public float MaxAmplitude { get; set; } = 5.0f;

    [JsonPropertyName("period_")]
    public float Period { get; set; } = 1.5f;
}
