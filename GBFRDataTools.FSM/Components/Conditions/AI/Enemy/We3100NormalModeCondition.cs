using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class We3100NormalModeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We3100NormalModeCondition);

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0; // Offset 0x38

    public We3100NormalModeCondition()
    {
    }
}