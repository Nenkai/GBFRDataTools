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

[Obsolete("Not used/exposed by the executable.")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ShotCreateAttachLaserAction : Em8400ElementCoreShotSplineFallAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkMovePlasmaAction);

    [JsonPropertyName("lightDarkStatus_")]
    public int LightDarkStatus { get; set; }

    [JsonPropertyName("laserSignTime_")]
    public float LaserSignTime { get; set; }

    [JsonPropertyName("laserTime_")]
    public float LaserTime { get; set; }

    [JsonPropertyName("laserStartPos_")]
    public Vector4 LaserStartPos { get; set; }

    [JsonPropertyName("laserEndPos_")]
    public Vector4 LaserEndPos { get; set; }

    [JsonPropertyName("startRotY_")]
    public float StartRotY { get; set; }

    [JsonPropertyName("addRotY_")]
    public float AddRotY { get; set; }
}