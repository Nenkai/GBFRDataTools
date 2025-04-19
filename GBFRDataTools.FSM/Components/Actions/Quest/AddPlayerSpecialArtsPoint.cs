using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[Description("Adds SBA percentage.")]
public class AddPlayerSpecialArtsPoint : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AddPlayerSpecialArtsPoint);

    [Description("Party Member #1")]
    [JsonPropertyName("val1_")]
    public int Val1 { get; set; } = 0;

    [Description("Party Member #2")]
    [JsonPropertyName("val2_")]
    public int Val2 { get; set; } = 0;

    [Description("Party Member #3")]
    [JsonPropertyName("val3_")]
    public int Val3 { get; set; } = 0;

    [Description("Party Member #4")]
    [JsonPropertyName("val4_")]
    public int Val4 { get; set; } = 0;

    public override string GetCaption()
    {
        return $"SBA: {Val1}%,{Val2}%, {Val3}%, {Val4}%";
    }
}
