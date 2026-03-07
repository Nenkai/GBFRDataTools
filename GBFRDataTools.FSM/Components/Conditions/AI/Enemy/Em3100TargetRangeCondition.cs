using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em3100TargetRangeCondition : EmTargetRangeCondition
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em3100TargetRangeCondition);

    [JsonPropertyName("isUseDecidedTargetRange_")]
    public bool IsUseDecidedTargetRange { get; set; } = true; // Offset 0x48

    public Em3100TargetRangeCondition()
    {
    }
}