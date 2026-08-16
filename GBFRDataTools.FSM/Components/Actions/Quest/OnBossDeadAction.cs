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

public class OnBossDeadAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OnBossDeadAction);

    [JsonPropertyName("deadEventFSMName_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public string DeadEventFSMName { get; set; }
}
