using GBFRDataTools.Entities;

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
public class Em8400MovePhaseChangeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400MovePhaseChangeAction);

    [JsonPropertyName("isEnterStage")]
    public bool IsEnterStage { get; set; } = false;

    [JsonPropertyName("alphaFadeTime_")]
    public float AlphaFadeTime { get; set; } = 1.5f;

    [JsonPropertyName("hideIntervalTime_")]
    public float HideIntervalTime { get; set; } = 0.5f;
}

