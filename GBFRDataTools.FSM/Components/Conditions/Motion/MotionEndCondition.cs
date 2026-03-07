using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Motion;

public class MotionEndCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(MotionEndCondition);

    [JsonPropertyName("motionSlot_")]
    public int MotionSlot { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("isMotionEndHalfWay_")]
    public bool IsMotionEndHalfWay { get; set; } = false; // Offset 0x3C

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 0f; // Offset 0x40

    public MotionEndCondition()
    {
    }
}
