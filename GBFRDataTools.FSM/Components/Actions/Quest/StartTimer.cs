﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class StartTimer : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(StartTimer);

    [JsonPropertyName("timerId_")]
    public int TimerId { get; set; } = 0;

    [Obsolete("Not used by the game")]
    [JsonPropertyName("isMultiSelect_")]
    public bool IsMultiSelect { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("timerIds_")]
    public BindingList<int> TimerIds { get; set; }

    public override string GetCaption()
    {
        return $"Id: {TimerId}";
    }
}
