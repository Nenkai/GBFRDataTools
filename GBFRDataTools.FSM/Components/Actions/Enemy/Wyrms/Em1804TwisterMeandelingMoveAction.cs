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

public class Em1804TwisterMeandelingMoveAction : ShotMoveStraightAction
{
    [JsonPropertyName("meandelingTime_")]
    public float MeandelingTime { get; set; }

    [JsonPropertyName("startAmplitude_")]
    public float StartAmplitude { get; set; }

    [JsonPropertyName("maxAmplitude_")]
    public float MaxAmplitude { get; set; }

    [JsonPropertyName("period_")]
    public float Period { get; set; }
}
