using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class AIjackFSMAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIjackFSMAction);

    [JsonPropertyName("isAIPlayer_")]
    public bool IsAIPlayer { get; set; } = false;

    [JsonPropertyName("fsmFileName_")]
    public string FsmFileName { get; set; } = string.Empty;

    [JsonPropertyName("isManualPlayer_")]
    public bool IsManualPlayer { get; set; } = false;

    [JsonPropertyName("isVyrn_")]
    public bool IsVyrn { get; set; } = false;

    [JsonPropertyName("isGuestNPC_")]
    public bool IsGuestNPC { get; set; } = false;

    [JsonPropertyName("isCansel_")]
    public bool IsCansel { get; set; } = false;
}
