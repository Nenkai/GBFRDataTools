using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetGameOverVoice : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetGameOverVoice);

    [JsonPropertyName("voiceIdList_")]
    public BindingList<string> VoiceIdList { get; set; } = [];
}
