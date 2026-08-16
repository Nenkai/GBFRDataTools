using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900SpecialBreakAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900SpecialBreakAction);

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 14.5f;

    [JsonPropertyName("chaosMinWaitTime_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ChaosMinWaitTime { get; set; } = 10.0f;

    [JsonPropertyName("chaosBreakAddTime_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ChaosBreakAddTime { get; set; } = 5.0f;

    [JsonPropertyName("chaosBreakMinWaitTime_")]
    [Obsolete("Not exposed by executable")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ChaosBreakMinWaitTime { get; set; } = 5.0f;
}
