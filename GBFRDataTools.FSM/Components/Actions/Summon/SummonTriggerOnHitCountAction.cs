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
public class SummonTriggerOnHitCountAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonTriggerOnHitCountAction);

    [JsonPropertyName("debuffCategory_")]
    public DebuffCategory DebuffCategory { get; set; } = DebuffCategory.DamageOverTime;

    [JsonPropertyName("status_")]
    [Description("Depends on category.")]
    public DebuffStatus Status { get; set; } = 0;

    [JsonPropertyName("debuff_")]
    [Description("Used if DebuffCategory = Debuff.")]
    public Debuff Debuff { get; set; } = 0;

    [JsonPropertyName("rate_")]
    public float Rate { get; set; } = 0f;

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 0f;

    [JsonPropertyName("hitCount_")]
    public int HitCount { get; set; } = 0;

    [JsonPropertyName("hitInterval_")]
    public float HitInterval { get; set; } = 0f;
}
