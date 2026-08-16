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
public class SummonHitStopAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonHitStopAction);

    [JsonPropertyName("time_")]
    public int Time { get; set; } = 0;

    [JsonPropertyName("rate_")]
    public float Rate { get; set; } = 0f;

    [JsonPropertyName("wait_")]
    public int Wait { get; set; } = 1;
}
