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

[Obsolete("Not in the executable")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ShotCreateInholeAreaAction : Em8400ElementCoreCreateShotBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotCreateInholeAreaAction);

    [JsonPropertyName("useShotPos_")]
    public bool UseShotPos { get; set; }

    [JsonPropertyName("useShotRotY_")]
    public bool UseShotRotY { get; set; }

    [JsonPropertyName("pos_")]
    public Vector4 Pos { get; set; }

    [JsonPropertyName("rotY_")]
    public float RotY { get; set; }

    [JsonPropertyName("isCircleShapeType_")]
    public bool IsCircleShapeType { get; set; }

    [JsonPropertyName("size_")]
    public Vector4 Size { get; set; }

    [JsonPropertyName("power_")]
    public int Power { get; set; }

    [JsonPropertyName("time_")]
    public float Time { get; set; }
}
