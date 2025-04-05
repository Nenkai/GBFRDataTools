using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Enemy;

public class Em2000ActionTypeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000ActionTypeCondition);

    [JsonPropertyName("isLongRange_")]
    public bool IsLongRange { get; set; } = false;

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0;
}