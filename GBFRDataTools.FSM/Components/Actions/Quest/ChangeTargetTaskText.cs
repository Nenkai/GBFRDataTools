using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ChangeTargetTaskText : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeTargetTaskText);

    [JsonPropertyName("taskLabel_")]
    public string TaskLabel { get; set; } = string.Empty;

    [JsonPropertyName("newTextLabel_")]
    public string NewTextLabel { get; set; } = string.Empty;

    public override string ToString()
    {
        string str = $"{ComponentName}('{TaskLabel}', new: {NewTextLabel})";
        return str;
    }
}
