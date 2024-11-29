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

public class CallTalkEvent : QuestActionComponent
{
    [JsonPropertyName("groupID_")]
    public string GroupID { get; set; } = string.Empty;

    [JsonPropertyName("delay_")]
    public float Delay { get; set; } = 0;

    public override string ToString()
    {
        string str = $"{ComponentName}('{GroupID}'";
        if (Delay != 0)
            str += $", delay: {Delay}";
        str += ')';

        return str;
    }
}
