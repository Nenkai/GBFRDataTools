using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Motion;

public class MotionEndCondition : ConditionComponent
{
    [JsonPropertyName("motionSlot_")]
    public int MotionSlot { get; set; }

    [JsonPropertyName("isMotionEndHalfWay_")]
    public bool IsMotionEndHalfWay { get; set; }

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; }
}
