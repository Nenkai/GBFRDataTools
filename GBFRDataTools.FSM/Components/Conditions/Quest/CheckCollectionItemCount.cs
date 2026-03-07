using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckCollectionItemCount : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckCollectionItemCount);

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;
}
