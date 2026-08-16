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
public class SummonSetRotToCameraAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSetRotToCameraAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0f;

    [JsonPropertyName("turnAngle_")]
    public float TurnAngle { get; set; } = 0f;
}
