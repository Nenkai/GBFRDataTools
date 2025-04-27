using GBFRDataTools.FSM.Components;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

// BT::QuestActionUseFsmBase
public class QuestActionUseFsmBase : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(QuestActionUseFsmBase);

    [JsonPropertyName("fsmDataNo_")]
    public int FsmDataNo { get; set; }

    [JsonPropertyName("fsmProgressHash_")]
    public ulong FsmProgressHash { get; set; }

    public override string ToString()
    {
        return ComponentName;
    }
}
