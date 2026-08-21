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
    public int MotionSlot { get; set; } = 0; 

    [JsonPropertyName("isMotionEndHalfWay_")]
    public bool IsMotionEndHalfWay { get; set; } = false; 

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 0f; 
}
