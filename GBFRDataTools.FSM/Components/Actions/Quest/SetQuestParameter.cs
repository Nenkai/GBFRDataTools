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

public class SetQuestParameter : QuestActionComponent
{
    [JsonPropertyName("keyHash_")]
    public uint KeyHash { get; set; }

    [JsonPropertyName("keyString_")]
    public string KeyString { get; set; }

    [JsonPropertyName("type_")]
    public SetQuestParameterType Type { get; set; }

    [JsonPropertyName("howToSet_")]
    public SetQuestParameterHowToSetType HowToSet { get; set; }

    [JsonPropertyName("value_")]
    public int Value { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}('{KeyString}', value: {Value}, type: {Type})";
        //str += $"- HowToSet: {HowToSet}";

        return str;
    }
}

public enum SetQuestParameterType
{
    Type0 = 0,
    Type1 = 1,
}

public enum SetQuestParameterHowToSetType
{
    Type0 = 0,
    Type1 = 1,
}