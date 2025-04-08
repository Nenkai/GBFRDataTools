using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetDisableControlUI : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetDisableControlUI);

    [JsonPropertyName("type_")]
    public EnumString Type { get; set; } // Offset 0x30

    [JsonPropertyName("disableControl_")]
    public bool DisableControl { get; set; } = true; // Offset 0x60
}
