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

public class SetConsumeItem : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetConsumeItem);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0; // Offset 0x48

    [JsonPropertyName("isConsumeAppend_")]
    public bool IsConsumeAppend { get; set; } = true; // Offset 0x4C

    [JsonPropertyName("consumeCounts_")]
    public BindingList<int> ConsumeCounts { get; set; } // Offset 0x50

    public SetConsumeItem()
    {
    }
}
