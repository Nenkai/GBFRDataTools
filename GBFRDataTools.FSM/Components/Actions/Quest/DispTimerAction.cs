using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class DispTimerAction : QuestActionComponent
{
    [JsonPropertyName("enable_")]
    public bool Enable { get; set; }

    [JsonPropertyName("time_")]
    public int Time { get; set; }

    [JsonPropertyName("autoHide_")]
    public bool AutoHide { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}:";
        return str;
    }
}
