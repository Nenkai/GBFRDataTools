using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
[Obsolete("Not exposed by the executable")]
public class Em8400ShotScalingSignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotScalingSignAction);

    [JsonPropertyName("radius_")]
    public float Radius { get; set; }

    [JsonPropertyName("minDitectDist_")]
    public float MinDitectDist { get; set; }

    [JsonPropertyName("signSec_")]
    public float SignSec { get; set; }

    [JsonPropertyName("signSpeed_")]
    public float SignSpeed { get; set; }

    [JsonPropertyName("fixSec_")]
    public float FixSec { get; set; }

    [JsonPropertyName("isHoming_")]
    public bool IsHoming { get; set; }

    [JsonPropertyName("scaleRate_")]
    public float ScaleRate { get; set; }
}