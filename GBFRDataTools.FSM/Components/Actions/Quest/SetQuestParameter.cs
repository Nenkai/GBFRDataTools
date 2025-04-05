using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetQuestParameter : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetQuestParameter);

    [JsonPropertyName("keyHash_")]
    public uint KeyHash { get; set; } = 0;

    [JsonPropertyName("keyString_")]
    public string KeyString { get; set; } = string.Empty;

    [JsonPropertyName("type_")]
    public SetQuestParameterType Type { get; set; } = SetQuestParameterType.Type0;

    [JsonPropertyName("howToSet_")]
    public SetQuestParameterHowToSetType HowToSet { get; set; } = SetQuestParameterHowToSetType.Type0;

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0;

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