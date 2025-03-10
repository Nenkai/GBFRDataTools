﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceLatestCallEventCondition : ConditionComponent
{
    [JsonPropertyName("eventType_")]
    public int EventType { get; set; } = 1;

    [JsonPropertyName("checkEventNoList_")]
    public BindingList<string> CheckEventNoList { get; set; } = [];

    [JsonPropertyName("isCheckEventName_")]
    public bool IsCheckEventName { get; set; } = true;
}
