using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class RemindVoice : QuestActionComponent
{
    [JsonPropertyName("enableAtBattle_")]
    public bool EnableAtBattle { get; set; } = false;

    [JsonPropertyName("zoneObjectId_")]
    public ulong ZoneObjectId { get; set; } = 0;

    [JsonPropertyName("zoneRootId_")]
    public ulong ZoneRootId { get; set; } = 0;

    [JsonPropertyName("voiceHashes_")]
    public BindingList<uint> VoiceHashes { get; set; } = []; // 3 elem

    [JsonPropertyName("voiceNames_")]
    public BindingList<string> VoiceNames { get; set; } = []; // 3 elem

    [JsonPropertyName("intervals_")]
    public BindingList<float> Intervals { get; set; } = []; // 2 elem

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
