using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckQuestParameter : QuestConditionComponent
{
    [JsonPropertyName("keyHash_")]
    public uint KeyHash { get; set; } = 0;

    [JsonPropertyName("keyString_")]
    public string KeyString { get; set; } = string.Empty;

    [JsonPropertyName("checkValue_")]
    public int CheckValue { get; set; } = 0;

    [JsonPropertyName("type_")]
    public CheckQuestParameterType Type { get; set; } = CheckQuestParameterType.Type0;

    public override string ToString()
    {
        string str = $"{ComponentName}({KeyString}, {CheckValue}, {Type})";
        return str;
    }
}

public enum CheckQuestParameterType
{
    Type0 = 0,
    Type1 = 1
}