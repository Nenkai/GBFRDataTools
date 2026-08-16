using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Flow;

public class FlowSleep : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FlowSleep);

    [JsonPropertyName("fsmNames_")]
    public BindingList<string> FsmNames { get; set; } = [];

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;

    [JsonPropertyName("isAutoWakeUp_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsAutoWakeUp { get; set; } = false;
}
