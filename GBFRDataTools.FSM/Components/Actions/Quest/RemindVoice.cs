using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class RemindVoice : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(RemindVoice);

    [JsonPropertyName("enableAtBattle_")]
    public bool EnableAtBattle { get; set; } = false;

    [JsonPropertyName("zoneObjectId_")]
    public ulong ZoneObjectId { get; set; } = 0;

    [JsonPropertyName("zoneRootId_")]
    public ulong ZoneRootId { get; set; } = 0;

    [JsonPropertyName("voiceHashes_")]
    [Editable(false)]
    public BindingList<uint> VoiceHashes { get; set; } = [.. Enumerable.Repeat(0u, 3)]; // 3 elem

    [JsonPropertyName("voiceNames_")]
    [Editable(false)]
    public BindingList<string?> VoiceNames { get; set; } = [..Enumerable.Repeat(string.Empty, 3)]; // 3 elem

    [JsonPropertyName("intervals_")]
    [Editable(false)]
    public BindingList<float> Intervals { get; set; } = [.. Enumerable.Repeat(0, 2)]; // 2 elem
}
