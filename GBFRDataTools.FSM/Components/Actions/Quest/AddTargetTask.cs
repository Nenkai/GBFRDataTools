using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class AddTargetTask : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AddTargetTask);

    [JsonPropertyName("label_")]
    public string Label { get; set; } = string.Empty;

    [JsonPropertyName("isAllInMode_")]
    public bool IsAllInMode { get; set; } = false;

    public override string GetCaption()
    {
        string str = $"{Label}";
        if (IsAllInMode)
            str += " (All)";
        return str;
    }
}
