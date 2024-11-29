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

public class CallTimelineSystemSe : QuestActionComponent
{
    [JsonPropertyName("pattern_")]
    public uint Pattern { get; set; } = 3;

    [JsonPropertyName("signalField_")]
    public BindingList<ulong> SignalField { get; set; } = [];
}
