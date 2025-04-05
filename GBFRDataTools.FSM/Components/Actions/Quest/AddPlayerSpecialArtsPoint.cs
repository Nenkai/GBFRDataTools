using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class AddPlayerSpecialArtsPoint : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AddPlayerSpecialArtsPoint);

    [JsonPropertyName("val1_")]
    public int Val1 { get; set; } = 0;

    [JsonPropertyName("val2_")]
    public int Val2 { get; set; } = 0;

    [JsonPropertyName("val3_")]
    public int Val3 { get; set; } = 0;

    [JsonPropertyName("val4_")]
    public int Val4 { get; set; } = 0;
}
