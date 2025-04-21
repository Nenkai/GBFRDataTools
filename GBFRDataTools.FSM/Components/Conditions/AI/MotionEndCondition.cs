using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Conditions;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

public class MotionEndCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(MotionEndCondition);

    [JsonPropertyName("motionSlot_")]
    public int MotionSlot { get; set; } = 0;

    [JsonPropertyName("isMotionEndHalfWay_")]
    public bool IsMotionEndHalfWay { get; set; } = false;

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 0;
}
