using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetOpenSeOnce : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetOpenSeOnce);

    [JsonPropertyName("controllerName_")]
    public string ControllerName { get; set; } // Offset 0x30

    [JsonPropertyName("openSe_")]
    public EnumString OpenSe { get; set; } // Offset 0x80

    [JsonPropertyName("reset_")]
    public bool Reset { get; set; } = false; // Offset 0xB0
}
