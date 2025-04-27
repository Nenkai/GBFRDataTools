using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7500DarkVortexCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500DarkVortexCondition);

    [JsonPropertyName("countMax_")]
    public int CountMax { get; set; } = 2; // Offset 0x38

    public Em7500DarkVortexCondition()
    {
    }
}

