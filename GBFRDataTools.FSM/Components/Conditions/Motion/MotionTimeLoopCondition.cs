using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Motion;

[Description("Unknown but animation related.")]
public class MotionTimeLoopCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(MotionTimeLoopCondition);

    [JsonPropertyName("motionSlot_")]
    public int MotionSlot { get; set; } = 0;
}
