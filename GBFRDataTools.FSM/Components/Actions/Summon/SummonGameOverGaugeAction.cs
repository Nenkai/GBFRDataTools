using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonGameOverGaugeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonGameOverGaugeAction);

    [JsonPropertyName("gameOverGaugeAddPer_")]
    public float GameOverGaugeAddPer { get; set; } = 0f;

    [JsonPropertyName("isAdd_")]
    public bool IsAdd { get; set; } = true;

    [JsonPropertyName("gameOverLerpDuration_")]
    public float GameOverLerpDuration { get; set; } = 1.5f;
}
