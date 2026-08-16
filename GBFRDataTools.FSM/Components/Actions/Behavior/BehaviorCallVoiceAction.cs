using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class BehaviorCallVoiceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BehaviorCallVoiceAction);

    [JsonPropertyName("groupID_")]
    public string GroupID { get; set; } = string.Empty;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;

    [JsonPropertyName("delayTime_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float DelayTime { get; set; } = 0f;
}
