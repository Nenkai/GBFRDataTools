using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class UpdateGraphics : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(UpdateGraphics);

    [JsonPropertyName("upperUuid_")]
    public ulong UpperUuid { get; set; } = 0;

    [JsonPropertyName("lowerUuid_")]
    public ulong LowerUuid { get; set; } = 0;

    [JsonPropertyName("priority_")]
    public int Priority { get; set; } = 0;

    [JsonPropertyName("isDistFadeObj_")]
    public bool IsDistFadeObj { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}(priority: {Priority}, isDistFadeObj: {IsDistFadeObj})";
        return str;
    }
}
