using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Conditions.UI.Quest;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Result;

public class ResultRetryCountCheck : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResultRetryCountCheck);

    [JsonPropertyName("isOnline_")]
    public bool IsOnline { get; set; } = false; // Offset 0x38

    public ResultRetryCountCheck()
    {
    }
}
