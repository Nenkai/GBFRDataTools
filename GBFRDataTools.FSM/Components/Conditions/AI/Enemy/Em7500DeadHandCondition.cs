using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7500DeadHandCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500DeadHandCondition);

    [JsonPropertyName("deadHandCountMax_")]
    public int DeadHandCountMax { get; set; } = 4; // Offset 0x38

    public Em7500DeadHandCondition()
    {
    }
}

