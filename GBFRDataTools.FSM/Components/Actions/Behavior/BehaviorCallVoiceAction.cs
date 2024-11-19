using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class BehaviorCallVoiceAction : ActionComponent
{
    [JsonPropertyName("groupID_")]
    public string GroupID { get; set; }

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; }
}
