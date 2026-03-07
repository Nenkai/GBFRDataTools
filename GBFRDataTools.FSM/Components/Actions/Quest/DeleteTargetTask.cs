using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class DeleteTargetTask : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DeleteTargetTask);

    [JsonPropertyName("label_")]
    public string Label { get; set; } = string.Empty;

    public override string GetCaption()
    {
        return Label;
    }
}
