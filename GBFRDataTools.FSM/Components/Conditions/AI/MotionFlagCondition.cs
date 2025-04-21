using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

public class MotionFlagCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(MotionFlagCondition);

    [JsonPropertyName("slot_")]
    public int Slot { get; set; } = 0;

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0;
}
