using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ChangeTargetTask : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeTargetTask);

    [JsonPropertyName("label_")]
    public string Label { get; set; } = string.Empty;
}
