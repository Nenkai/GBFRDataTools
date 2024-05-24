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

public class StartTimer : QuestActionComponent
{
    [JsonPropertyName("timerId_")]
    public int TimerId { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName} (id: {TimerId})";
        return str;
    }
}
