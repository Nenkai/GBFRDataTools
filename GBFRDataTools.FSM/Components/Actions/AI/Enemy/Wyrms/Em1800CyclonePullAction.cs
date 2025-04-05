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

public class Em1800CyclonePullAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800CyclonePullAction);

    [JsonPropertyName("directionCheckTime_")]
    public float DirectionCheckTime { get; set; } = 5.0f;

    [JsonPropertyName("cycloneNoWindDistance_")]
    public float CycloneNoWindDistance { get; set; } = 2.0f;

    [JsonPropertyName("cycloneShortDistance_")]
    public float CycloneShortDistance { get; set; } = 6.0f;

    [JsonPropertyName("cycloneShortPower_")]
    public float CycloneShortPower { get; set; } = 0.025f;

}
