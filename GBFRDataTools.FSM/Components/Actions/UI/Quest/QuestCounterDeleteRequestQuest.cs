using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Quest;

public class QuestCounterDeleteRequestQuest : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestCounterDeleteRequestQuest);

    public QuestCounterDeleteRequestQuest()
    {
    }
}
