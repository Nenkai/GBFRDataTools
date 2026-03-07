using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Result;

public class ResultRewardSetRetryInfo : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResultRewardSetRetryInfo);

    [JsonPropertyName("isRetry_")]
    public bool IsRetry { get; set; } = false; // Offset 0x40

    public ResultRewardSetRetryInfo()
    {
    }
}
