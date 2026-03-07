using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Input;

[Description("Always returns false in retail builds (stripped)")]
public class InputKeyDebugCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(InputKeyDebugCondition);

    [JsonPropertyName("targetKeyIndex_")]
    public int TargetKeyIndex { get; set; } = 0; // Offset 0x38

    [JsonPropertyName("isTriggerMode_")]
    public bool IsTriggerMode { get; set; } = false; // Offset 0x3C

    public InputKeyDebugCondition()
    {
    }
}