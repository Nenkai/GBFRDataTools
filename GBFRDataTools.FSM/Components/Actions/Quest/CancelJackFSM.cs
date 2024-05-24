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

public class CancelJackFSM : QuestActionComponent
{
    [JsonPropertyName("isManualPlayer_")]
    public bool IsManualPlayer { get; set; }

    [JsonPropertyName("isVyrn_")]
    public bool IsVyrn { get; set; }

    [JsonPropertyName("isAI_")]
    public bool IsAI { get; set; }

    [JsonPropertyName("isGuest_")]
    public bool IsGuest { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
