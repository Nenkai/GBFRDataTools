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
public class Em8400ShotCreateScaffoldingRockAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotScalingSignAction);

    [JsonPropertyName("useShotPos_")]
    public bool UseShotPos { get; set; }

    [JsonPropertyName("useShotRotY_")]
    public bool UseShotRotY { get; set; }

    [JsonPropertyName("pos_")]
    public Vector4 Pos { get; set; }

    [JsonPropertyName("rotY_")]
    public float RotY { get; set; }

    [JsonPropertyName("shapeType_")]
    public ShapeType ShapeType { get; set; }

    [JsonPropertyName("time_")]
    public int Time { get; set; }
}