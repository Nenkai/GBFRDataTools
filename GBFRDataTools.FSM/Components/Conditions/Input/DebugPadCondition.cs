using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Debug;

[Description("Always returns false in retail builds (stripped)")]
public class DebugPadCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DebugPadCondition);

    [JsonPropertyName("inputType_")]
    public uint InputType { get; set; } = 0; // Offset 0x3C

    [JsonPropertyName("originalPadMapValue_")]
    public uint OriginalPadMapValue { get; set; } = 1; // Offset 0x38

    public DebugPadCondition()
    {
    }
}