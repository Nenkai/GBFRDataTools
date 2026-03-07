using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em0500TargetRangeCondition : EmTargetRangeCondition
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500TargetRangeCondition);

    [JsonPropertyName("changeRangeCondition_")]
    public int ChangeRangeCondition { get; set; } = 1; // Offset 0x48

    [JsonPropertyName("changeRange_")]
    public int ChangeRange { get; set; } = 0; // Offset 0x4C

    public Em0500TargetRangeCondition()
    {
    }
}
