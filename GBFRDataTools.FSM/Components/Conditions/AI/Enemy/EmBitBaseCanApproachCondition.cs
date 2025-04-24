using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class EmBitBaseCanApproachCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmBitBaseCanApproachCondition);

    [JsonPropertyName("canApproachHeight_")]
    public float CanApproachHeight { get; set; } = 2f; // Offset 0x38

    [JsonPropertyName("canApproachDistance_")]
    public float CanApproachDistance { get; set; } = 16f; // Offset 0x3C

    public EmBitBaseCanApproachCondition()
    {
    }
}
