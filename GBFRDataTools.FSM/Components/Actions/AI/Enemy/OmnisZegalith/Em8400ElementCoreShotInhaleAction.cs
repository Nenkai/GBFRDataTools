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
public class Em8400ElementCoreShotInhaleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreShotInhaleAction);

    [JsonPropertyName("inhaleSec_")]
    public float InhaleSec { get; set; } = 5f;

    [JsonPropertyName("inhaleInsideParam_")]
    public Vector2 InhaleInsideParam { get; set; } = new Vector2(5f, 3f);

    [JsonPropertyName("inhaleCenterParam_")]
    public Vector2 InhaleCenterParam { get; set; } = new Vector2(12f, 7f);

    [JsonPropertyName("inhaleOutsideParam_")]
    public Vector2 InhaleOutsideParam { get; set; } = new Vector2(15f, 10f);
}