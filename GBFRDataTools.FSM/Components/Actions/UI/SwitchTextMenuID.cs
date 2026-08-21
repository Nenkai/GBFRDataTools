using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SwitchTextMenuID : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SwitchTextMenuID);

    [JsonPropertyName("srcMenuID_")]
    public string? SrcMenuID { get; set; } 

    [JsonPropertyName("dstMenuID_")]
    public string? DstMenuID { get; set; } 

    [JsonPropertyName("reset_")]
    public bool Reset { get; set; } = false; 

    [JsonPropertyName("endReset_")]
    public bool EndReset { get; set; } = false; 
}
