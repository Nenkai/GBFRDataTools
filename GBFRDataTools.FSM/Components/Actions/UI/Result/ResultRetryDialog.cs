using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Result;

public class ResultRetryDialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResultRetryDialog);

    [JsonPropertyName("dialogID_")]
    public string? DialogID { get; set; } 

    [JsonPropertyName("isItemLimitOver_")]
    public bool IsItemLimitOver { get; set; } = false; 

    [JsonPropertyName("isItemOverRetriedOff_")]
    public bool IsItemOverRetriedOff { get; set; } = false; 

    [JsonPropertyName("isRetryCountCheck_")]
    public bool IsRetryCountCheck { get; set; } = false; 

    [JsonPropertyName("isOnline_")]
    public bool IsOnline { get; set; } = false; 

    [JsonPropertyName("isSetRetry_")]
    public bool IsSetRetry { get; set; } = false; 

    [JsonPropertyName("isRetry_")]
    public bool IsRetry { get; set; } = false; 

    [JsonPropertyName("isPlayRetrySe_")]
    public bool IsPlayRetrySe { get; set; } = true; 
}
