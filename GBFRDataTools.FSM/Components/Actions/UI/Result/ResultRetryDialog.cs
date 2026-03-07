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
    public string DialogID { get; set; } // Offset 0x30

    [JsonPropertyName("isItemLimitOver_")]
    public bool IsItemLimitOver { get; set; } = false; // Offset 0x50

    [JsonPropertyName("isItemOverRetriedOff_")]
    public bool IsItemOverRetriedOff { get; set; } = false; // Offset 0x51

    [JsonPropertyName("isRetryCountCheck_")]
    public bool IsRetryCountCheck { get; set; } = false; // Offset 0x52

    [JsonPropertyName("isOnline_")]
    public bool IsOnline { get; set; } = false; // Offset 0x53

    [JsonPropertyName("isSetRetry_")]
    public bool IsSetRetry { get; set; } = false; // Offset 0x54

    [JsonPropertyName("isRetry_")]
    public bool IsRetry { get; set; } = false; // Offset 0x55

    [JsonPropertyName("isPlayRetrySe_")]
    public bool IsPlayRetrySe { get; set; } = true; // Offset 0x56

    public ResultRetryDialog()
    {
    }
}
