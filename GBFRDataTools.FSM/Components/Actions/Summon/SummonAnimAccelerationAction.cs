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
public class SummonAnimAccelerationAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonAnimAccelerationAction);

    [JsonPropertyName("rushMotionRate_")]
    public float RushMotionRate { get; set; } = 1f;

    [JsonPropertyName("rushMotionRateTime_")]
    public float RushMotionRateTime { get; set; } = 2f;
}
