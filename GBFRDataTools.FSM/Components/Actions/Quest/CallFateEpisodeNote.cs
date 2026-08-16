using GBFRDataTools.Entities;

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

[GameSupport(GameVersion.EndlessRagnarok)]
public class CallFateEpisodeNote : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallFateEpisodeNote);

    [JsonPropertyName("fateID_")]
    public uint FateID { get; set; } = 0x887AE0B0; // Hash("")

    [JsonPropertyName("fadeKeep_")]
    public bool FadeKeep { get; set; } = false;
}
