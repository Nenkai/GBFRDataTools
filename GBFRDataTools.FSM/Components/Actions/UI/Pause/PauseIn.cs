using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class PauseIn : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PauseIn);

    [JsonPropertyName("callBgm_")]
    public bool CallBgm { get; set; } = false; // Offset 0x30
}
