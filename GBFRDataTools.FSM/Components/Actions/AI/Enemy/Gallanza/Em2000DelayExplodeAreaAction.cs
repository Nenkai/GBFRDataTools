﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Gallanza;

public class Em2000DelayExplodeAreaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000DelayExplodeAreaAction);

    [JsonPropertyName("showMinSec_")]
    public float ShowMinSec { get; set; } = 0.0f;

    [JsonPropertyName("showMaxSec_")]
    public float ShowMaxSec { get; set; } = 0.0f;

    [JsonPropertyName("minDist_")]
    public float MinDist { get; set; } = 0.0f;

    [JsonPropertyName("maxDist_")]
    public float MaxDist { get; set; } = 0.0f;
}
