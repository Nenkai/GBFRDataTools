﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceInAnyEventCondition : ConditionComponent
{
    [JsonPropertyName("eventType_")]
    public int EventType { get; set; } = 0;

    [JsonPropertyName("isCheckEventName_")]
    public bool IsCheckEventName { get; set; } = false;

    [JsonPropertyName("checkEventList_")]
    public BindingList<string> CheckEventList { get; set; } = [];
}
