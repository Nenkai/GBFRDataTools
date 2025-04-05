using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckEnemyCost : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckEnemyCost);

    [JsonPropertyName("cost_")]
    public int Cost { get; set; } = 0;
}
