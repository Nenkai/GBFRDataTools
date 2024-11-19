using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIjackFSMAction : ActionComponent
{
    [JsonPropertyName("isAIPlayer_")]
    public bool IsAIPlayer { get; set; }

    [JsonPropertyName("fsmFileName_")]
    public string FsmFileName { get; set; }

    [JsonPropertyName("isManualPlayer_")]
    public bool IsManualPlayer { get; set; }

    [JsonPropertyName("isVyrn_")]
    public bool IsVyrn { get; set; }

    [JsonPropertyName("isGuestNPC_")]
    public bool IsGuestNPC { get; set; }

    [JsonPropertyName("isCansel_")]
    public bool IsCansel { get; set; }
}
