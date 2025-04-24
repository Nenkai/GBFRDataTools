using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7201PushStormCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201PushStormCondition);

    [JsonPropertyName("isNihira_")]
    public bool IsNihira { get; set; } = true; // Offset 0x38

    [JsonPropertyName("rangeOffset_")]
    public float RangeOffset { get; set; } = 2f; // Offset 0x3C

    [JsonPropertyName("checkAngleDeg_")]
    public float CheckAngleDeg { get; set; } = 20f; // Offset 0x40

    [JsonPropertyName("checkRadiusRate_")]
    public float CheckRadiusRate { get; set; } = 4f; // Offset 0x44

    public Em7201PushStormCondition()
    {
    }
}