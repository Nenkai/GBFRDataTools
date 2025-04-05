using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class UnlockUIAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(UnlockUIAction);

    [JsonPropertyName("feature_")]
    public int Feature { get; set; } = 0;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
