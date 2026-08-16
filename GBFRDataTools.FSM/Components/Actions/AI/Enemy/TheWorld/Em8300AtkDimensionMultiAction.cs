using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkDimensionMultiAction : Em8300AtkDimensionBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkDimensionMultiAction);

    [JsonPropertyName("margeMaxDist_")]
    public float MargeMaxDist { get; set; } = 7.5f;

    [JsonPropertyName("maxDist_")]
    public float MaxDist { get; set; } = 10f;

    [JsonPropertyName("minRadius_")]
    public float MinRadius { get; set; } = 6f;

    [JsonPropertyName("spreadRadius_")]
    public float SpreadRadius { get; set; } = 7.5f;

    public Em8300AtkDimensionMultiAction()
    {
        DimensionType = 0;
    }
}