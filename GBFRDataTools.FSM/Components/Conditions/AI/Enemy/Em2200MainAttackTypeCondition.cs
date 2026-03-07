using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em2200MainAttackTypeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2200MainAttackTypeCondition);

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0; // Offset 0x38

    public Em2200MainAttackTypeCondition()
    {
    }
}