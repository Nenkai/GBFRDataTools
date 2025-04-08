using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class PauseOut : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PauseOut);

    [JsonPropertyName("callBgm_")]
    public bool CallBgm { get; set; } = false; // Offset 0x30

    [JsonPropertyName("callSe_")]
    public bool CallSe { get; set; } = true; // Offset 0x31
}
