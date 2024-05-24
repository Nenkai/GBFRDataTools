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

public class UpdateGraphics : QuestActionComponent
{
    [JsonPropertyName("upperUuid_")]
    public ulong UpperUuid { get; set; }

    [JsonPropertyName("lowerUuid_")]
    public ulong LowerUuid { get; set; }

    [JsonPropertyName("priority_")]
    public int Priority { get; set; }

    [JsonPropertyName("isDistFadeObj_")]
    public bool IsDistFadeObj { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}(priority: {Priority}, isDistFadeObj: {IsDistFadeObj})";
        return str;
    }
}
