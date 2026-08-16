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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.LogosEcho;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8401DarkShotFallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401DarkShotFallAction);

    [JsonPropertyName("fallSpeed_")]
    public float FallSpeed { get; set; } = 16f;

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();
}
