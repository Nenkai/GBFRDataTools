using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Motion;

public class MotionFlagCondition : ConditionComponent
{
    [JsonPropertyName("slot_")]
    public int Slot { get; set; }

    [JsonPropertyName("value_")]
    public int Value { get; set; }
}
