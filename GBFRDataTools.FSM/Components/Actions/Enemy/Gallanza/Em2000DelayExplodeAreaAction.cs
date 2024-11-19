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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Gallanza;

public class Em2000DelayExplodeAreaAction : ActionComponent
{
    [JsonPropertyName("showMinSec_")]
    public float ShowMinSec { get; set; }

    [JsonPropertyName("showMaxSec_")]
    public float ShowMaxSec { get; set; }

    [JsonPropertyName("minDist_")]
    public float MinDist { get; set; }

    [JsonPropertyName("maxDist_")]
    public float MaxDist { get; set; }
}
