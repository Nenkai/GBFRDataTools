using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1800CyclonePullAction : ShotMoveStraightAction
{
    [JsonPropertyName("directionCheckTime_")]
    public float DirectionCheckTime { get; set; }

    [JsonPropertyName("cycloneNoWindDistance_")]
    public float CycloneNoWindDistance { get; set; }

    [JsonPropertyName("cycloneShortDistance_")]
    public float CycloneShortDistance { get; set; }

    [JsonPropertyName("cycloneShortPower_")]
    public float CycloneShortPower { get; set; }

}
