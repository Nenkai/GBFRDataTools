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
public class PickTalkEvent : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PickTalkEvent);

    [JsonPropertyName("groupIDs_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public BindingList<string> GroupIDs { get; set; } = [];

    [JsonPropertyName("delay_")]
    public float Delay { get; set; } = 0f;
}
