using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class We1100StateCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We1100StateCondition);

    [JsonPropertyName("state_")]
    public int State { get; set; } = 0; // Offset 0x38

    public We1100StateCondition()
    {
    }
}

