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

public class AddPlayerSpecialArtsPoint : QuestActionComponent
{
    [JsonPropertyName("val1_")]
    public int Val1 { get; set; }

    [JsonPropertyName("val2_")]
    public int Val2 { get; set; }

    [JsonPropertyName("val3_")]
    public int Val3 { get; set; }

    [JsonPropertyName("val4_")]
    public int Val4 { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
