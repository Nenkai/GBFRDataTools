using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Quest;

public class QuestReadyStopAnimation : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestReadyStopAnimation);

    [JsonPropertyName("isStop_")]
    public bool IsStop { get; set; } = true; // Offset 0x30

    public QuestReadyStopAnimation()
    {
    }
}
