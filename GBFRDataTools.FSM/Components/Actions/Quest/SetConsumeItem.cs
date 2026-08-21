using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public int Type { get; set; } = 0; 

    [JsonPropertyName("isConsumeAppend_")]
    public bool IsConsumeAppend { get; set; } = true;

    [JsonPropertyName("consumeCounts_")]
    [Editable(false)]
    public BindingList<int> ConsumeCounts { get; set; } = [.. Enumerable.Repeat(0, 4)]; // std::array<int,4>

    public override string? GetCaption()
    {
        return $"Type: {Type}";
    }
}
