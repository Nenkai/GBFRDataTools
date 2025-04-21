using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Conditions.Event;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceInAnyEventCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundMixBalanceInAnyEventCondition);

    [Description("Cutscene/Event Type")]
    [JsonPropertyName("eventType_")]
    public EventType EventType { get; set; } = EventType.CtEvent;

    [JsonPropertyName("isCheckEventName_")]
    public bool IsCheckEventName { get; set; } = false;

    [JsonPropertyName("checkEventList_")]
    public BindingList<string> CheckEventList { get; set; } = [];
}
