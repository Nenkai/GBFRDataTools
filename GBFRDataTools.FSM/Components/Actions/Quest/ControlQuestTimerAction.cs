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
public class ControlQuestTimerAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlQuestTimerAction);

    [JsonPropertyName("isPauseTimer_")]
    public bool IsPauseTimer { get; set; } = false;
}
