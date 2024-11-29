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
    public bool IsManualPlayer { get; set; } = false;

    [JsonPropertyName("isVyrn_")]
    public bool IsVyrn { get; set; } = false;

    [JsonPropertyName("isAI_")]
    public bool IsAI { get; set; } = false;

    [JsonPropertyName("isGuest_")]
    public bool IsGuest { get; set; } = false;
}
