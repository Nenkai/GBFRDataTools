using GBFRDataTools.FSM.Components.Actions.UI.Dialog;

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

public class OverwriteBloomTalk : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OverwriteBloomTalk);

    [JsonPropertyName("npcUniqueIdList_")]
    [Editable(false)]
    public BindingList<ulong> NpcUniqueIdList { get; set; } = [.. Enumerable.Repeat<ulong>(0, 4)]; // cy::PlacementInfo::Values

    [JsonPropertyName("talkId_")]
    public string? TalkId { get; set; }
}
