using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceEndEventCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundMixBalanceEndEventCondition);

    [Description("Cutscene/Event Type")]
    [JsonPropertyName("eventType_")]
    public EventType EventType { get; set; } = EventType.CtEvent;

    [JsonPropertyName("checkEventNoList_")]
    public BindingList<int> CheckEventNoList { get; set; } = [];

    [JsonPropertyName("isCheckEventName_")]
    public bool IsCheckEventName { get; set; } = true;
}
