using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class EmTargetDirectionCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmTargetDirectionCondition);

    [JsonPropertyName("checkDirection_")]
    public int CheckDirection { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("checkAngle_")]
    public float CheckAngle { get; set; } = 90f; // Offset 0x3C

    public override string GetCaption()
    {
        return $"CheckDirection: {CheckDirection}, Angle: {CheckAngle}°";
    }

    public EmTargetDirectionCondition()
    {
    }
}