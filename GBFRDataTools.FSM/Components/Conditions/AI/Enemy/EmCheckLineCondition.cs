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

public class EmCheckLineCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCheckLineCondition);

    [JsonPropertyName("checkDireciton_")]
    public int CheckDireciton { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("checkLength_")]
    public float CheckLength { get; set; } = 15f; // Offset 0x3C

    [JsonPropertyName("customAngle_")]
    public float CustomAngle { get; set; } = 0f; // Offset 0x40

    public EmCheckLineCondition()
    {
    }
}