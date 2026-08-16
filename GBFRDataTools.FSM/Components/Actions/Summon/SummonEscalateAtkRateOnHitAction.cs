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
public class SummonEscalateAtkRateOnHitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonEscalateAtkRateOnHitAction);

    [JsonPropertyName("collisionHitCountMax_")]
    public int CollisionHitCountMax { get; set; } = 1;

    [JsonPropertyName("escalateAtkRate_")]
    public float EscalateAtkRate { get; set; } = 0f;

    [JsonPropertyName("atkRateLimit_")]
    public float AtkRateLimit { get; set; } = 1f;
}
