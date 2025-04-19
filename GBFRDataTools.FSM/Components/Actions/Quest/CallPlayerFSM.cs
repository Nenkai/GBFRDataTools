using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallPlayerFSM : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallPlayerFSM);

    [JsonPropertyName("fsmFileName_")]
    public string FsmFileName { get; set; } = string.Empty;

    [JsonPropertyName("isManualPlayer_")]
    public bool IsManualPlayer { get; set; } = false;

    [JsonPropertyName("isVyrn_")]
    public bool IsVyrn { get; set; } = false;

    [JsonPropertyName("isAI_")]
    public bool IsAI { get; set; } = false;

    [JsonPropertyName("isGuest_")]
    public bool IsGuest { get; set; } = false;

    public override string GetCaption()
    {
        string str = FsmFileName;

        if (IsManualPlayer)
            str += " (ManualPlayer)";
        if (IsVyrn)
            str += " (Vyrn)";
        if (IsAI)
            str += " (AI)";
        if (IsGuest)
            str += " (Guest)";

        return str;
    }
}
