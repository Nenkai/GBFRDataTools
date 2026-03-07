using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7001ActionCommandStateCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001ActionCommandStateCondition);

    [JsonPropertyName("phase_")]
    public int Phase { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("state_")]
    public int State { get; set; } = 0; // Offset 0x40

    [JsonPropertyName("pattern_")]
    public int Pattern { get; set; } = 0; // Offset 0x3C

    public Em7001ActionCommandStateCondition()
    {
    }
}