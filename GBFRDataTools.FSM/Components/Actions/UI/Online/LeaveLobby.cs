using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Online;

public class LeaveLobby : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(LeaveLobby);

    [JsonPropertyName("mode_")]
    public EnumString Mode { get; set; } // Offset 0x30

    [JsonPropertyName("isKicked_")]
    public bool IsKicked { get; set; } = false; // Offset 0x60

    public LeaveLobby()
    {
    }
}
