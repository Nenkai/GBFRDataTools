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
public class Em8400DamageBarrierBreakAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400DamageBarrierBreakAction);

    [JsonPropertyName("reactionLoopTimeSec_")]
    public float ReactionLoopTimeSec { get; set; } = 1f;

    [JsonPropertyName("barrierRepairDelayTimeSec_")]
    public float BarrierRepairDelayTimeSec { get; set; } = 4f;

    [JsonPropertyName("isForceBarrierRepair_")]
    public bool IsForceBarrierRepair { get; set; } = true;

    [JsonPropertyName("setBarrierBreakHpPercent_")]
    public float SetBarrierBreakHpPercent { get; set; } = -1f;
}
