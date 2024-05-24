using GBFRDataTools.FSM.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetPlayerInputLimit : QuestActionComponent
{
    [JsonPropertyName("actionId_")]
    public int ActionId { get; set; }

    [JsonPropertyName("enable_")]
    public bool Enable { get; set; }

    [JsonPropertyName("charaIndex_")]
    public int CharaIndex { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
