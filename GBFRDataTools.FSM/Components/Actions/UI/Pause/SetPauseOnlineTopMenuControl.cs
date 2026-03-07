using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class SetPauseOnlineTopMenuControl : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetPauseOnlineTopMenuControl);

    [JsonPropertyName("isControl_")]
    public bool IsControl { get; set; } = false; // Offset 0x30

    public SetPauseOnlineTopMenuControl()
    {
    }
}