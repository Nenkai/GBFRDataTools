using GBFRDataTools.FSM.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetGameOverVoice : QuestActionComponent
{
    [JsonPropertyName("voiceIdList_")]
    public ElementArray<string> VoiceIdList { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
