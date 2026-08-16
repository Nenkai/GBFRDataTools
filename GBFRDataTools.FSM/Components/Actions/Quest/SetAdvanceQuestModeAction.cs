using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SetAdvanceQuestModeAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetAdvanceQuestModeAction);

    [JsonPropertyName("enable_")]
    public bool Enable { get; set; } = false;

    [JsonPropertyName("mode_")]
    public int Mode { get; set; } = 0;
}
