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
    public string SrcMenuID { get; set; } // Offset 0x30

    [JsonPropertyName("dstMenuID_")]
    public string DstMenuID { get; set; } // Offset 0x50

    [JsonPropertyName("reset_")]
    public bool Reset { get; set; } = false; // Offset 0x70

    [JsonPropertyName("endReset_")]
    public bool EndReset { get; set; } = false; // Offset 0x71

    public SwitchTextMenuID()
    {
    }
}
