using System;
using System.Collections.Generic;
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
}
