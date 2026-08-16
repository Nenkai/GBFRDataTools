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
public class Em8400ShotOrbitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotOrbitAction);

    [JsonPropertyName("angleSpeed_")]
    public float AngleSpeed { get; set; }

    [JsonPropertyName("rotationSec_")]
    public float RotationSec { get; set; }
}