using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ChangeTargetTaskText : QuestActionComponent
{
    [JsonPropertyName("taskLabel_")]
    public string TaskLabel { get; set; }

    [JsonPropertyName("newTextLabel_")]
    public string NewTextLabel { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}('{TaskLabel}', new: {NewTextLabel})";
        return str;
    }
}
