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

public class SetStoryLinkAttackLabel : QuestActionComponent
{
    [JsonPropertyName("isReset_")]
    public bool IsReset { get; set; }

    [JsonPropertyName("label_")]
    public string Label { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}:\n";

        return str;
    }
}
