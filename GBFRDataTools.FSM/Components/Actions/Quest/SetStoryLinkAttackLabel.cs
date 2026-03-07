using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetStoryLinkAttackLabel : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetStoryLinkAttackLabel);

    [JsonPropertyName("isReset_")]
    public bool IsReset { get; set; } = false;

    [JsonPropertyName("label_")]
    public string Label { get; set; } = string.Empty;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
