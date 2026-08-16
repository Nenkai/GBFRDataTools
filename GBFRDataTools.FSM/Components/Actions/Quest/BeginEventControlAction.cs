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

public class BeginEventControlAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BeginEventControlAction);

    [JsonPropertyName("isInGameEventMode_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsInGameEventMode { get; set; } = false;
}
