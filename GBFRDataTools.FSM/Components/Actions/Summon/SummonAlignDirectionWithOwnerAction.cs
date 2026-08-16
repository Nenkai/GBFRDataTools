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
public class SummonAlignDirectionWithOwnerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonAlignDirectionWithOwnerAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.1f;

    [JsonPropertyName("turnAngleMax_")]
    public float TurnAngleMax { get; set; } = 30f;
}
