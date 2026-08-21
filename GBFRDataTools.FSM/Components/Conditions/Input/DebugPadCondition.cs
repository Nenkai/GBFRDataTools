using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Input;

[Obsolete("Always returns false in retail builds (stripped)")]
public class DebugPadCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DebugPadCondition);

    [JsonPropertyName("inputType_")]
    public uint InputType { get; set; } = 0; 

    [JsonPropertyName("originalPadMapValue_")]
    public uint OriginalPadMapValue { get; set; } = 1; 
}