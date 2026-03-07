using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class DeterminationOfProbability : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DeterminationOfProbability);

    [JsonPropertyName("percent_")]
    public float Percent { get; set; } = 0;
}
