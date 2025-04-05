using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class EnableEffectEmitter : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EnableEffectEmitter);

    [JsonPropertyName("upperUuid_")]
    public ulong UpperUuid { get; set; } = 0;

    [JsonPropertyName("lowerUuid_")]
    public ulong LowerUuid { get; set; } = 0;

    [JsonPropertyName("enable_")]
    public bool Enable { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
