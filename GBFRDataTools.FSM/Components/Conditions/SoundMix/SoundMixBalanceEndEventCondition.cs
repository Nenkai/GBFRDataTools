using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceEndEventCondition : ConditionComponent
{
    [JsonPropertyName("eventType_")]
    public int EventType { get; set; }

    [JsonPropertyName("checkEventNoList_")]
    public BindingList<int> CheckEventNoList { get; set; }

    [JsonPropertyName("isCheckEventName_")]
    public bool IsCheckEventName { get; set; }
}
