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
public class SetQuestReadyDialogLimit : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetQuestReadyDialogLimit);

    [JsonPropertyName("isLimit_")]
    public bool IsLimit { get; set; } = false;
}
