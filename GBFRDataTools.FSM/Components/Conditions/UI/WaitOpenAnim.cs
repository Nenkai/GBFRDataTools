using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class WaitOpenAnim : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(WaitOpenAnim);

    [JsonPropertyName("view_")]
    public string View { get; set; } // Offset 0x38
}
