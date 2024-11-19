using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

public class OpenItemDialog : ActionComponent
{
    [JsonPropertyName("mode_")]
    public EnumString Mode { get; set; }
}
