using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;
public class ControlDispSyncIcon : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlDispSyncIcon);

    [JsonPropertyName("isDisp_")]
    public bool IsDisp { get; set; } = false; // Offset 0x30

    [JsonPropertyName("closeOnEnd_")]
    public bool CloseOnEnd { get; set; } = false; // Offset 0x31

    public ControlDispSyncIcon()
    {
    }
}
