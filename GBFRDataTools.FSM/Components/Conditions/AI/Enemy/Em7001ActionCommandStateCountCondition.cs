using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7001ActionCommandStateCountCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001ActionCommandStateCountCondition);

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("operatorType_")]
    public int OperatorType { get; set; } = 0; // Offset 0x3C

    public Em7001ActionCommandStateCountCondition()
    {
    }
}