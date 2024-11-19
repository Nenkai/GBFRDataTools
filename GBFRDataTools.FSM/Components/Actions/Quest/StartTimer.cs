using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class StartTimer : QuestActionComponent
{
    [JsonPropertyName("timerId_")]
    public int TimerId { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("isMultiSelect_")]
    public bool IsMultiSelect { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("timerIds_")]
    public BindingList<int> TimerIds { get; set; } 
}
