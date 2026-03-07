using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.CommandList;

public class IsEndCommandListDialog : ConditionComponent
{
    public override string ComponentName => nameof(IsEndCommandListDialog);

    [JsonPropertyName("includeClose_")]
    public bool IncludeClose { get; set; } = false; // Offset 0x38
}
