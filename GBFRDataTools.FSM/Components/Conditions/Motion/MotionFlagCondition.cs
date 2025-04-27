using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Motion;

public class MotionFlagCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(MotionFlagCondition);

    [JsonPropertyName("slot_")]
    public int Slot { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0; // Offset 0x3C

    public MotionFlagCondition()
    {
    }
}
