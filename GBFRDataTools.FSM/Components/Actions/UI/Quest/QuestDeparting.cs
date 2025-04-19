using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Quest;

public class QuestDeparting : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestDeparting);

    [JsonPropertyName("isQuestDeparting_")]
    public bool IsQuestDeparting { get; set; } = false; // Offset 0x30

    public QuestDeparting()
    {
    }
}
