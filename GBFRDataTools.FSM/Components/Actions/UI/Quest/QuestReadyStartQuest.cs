using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Quest;

public class QuestReadyStartQuest : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestReadyStartQuest);

    [JsonPropertyName("mode_")]
    public EnumString<QuestReadyStartQuestMode> Mode { get; set; } // Offset 0x30

    public QuestReadyStartQuest()
    {
    }
}

public enum QuestReadyStartQuestMode
{
    Start = 0,
    Retry = 1,
}