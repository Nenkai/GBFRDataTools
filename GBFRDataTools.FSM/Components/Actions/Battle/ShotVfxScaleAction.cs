using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ShotVfxScaleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotVfxScaleAction);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 1.0f;

    [JsonPropertyName("startScale_")]
    public Vector4 StartScale { get; set; } = Vector4.One;

    [JsonPropertyName("endScale_")]
    public Vector4 EndScale { get; set; } = new Vector4(2f, 2f, 2f, 1f);

    [JsonPropertyName("canEditScaleXYZ_")]
    public bool CanEditScaleXYZ { get; set; } = false;
}
