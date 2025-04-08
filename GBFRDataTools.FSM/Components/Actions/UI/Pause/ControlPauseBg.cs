using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class ControlPauseBg : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlPauseBg);

    [JsonPropertyName("type_")]
    public EnumString Type { get; set; } = new();
}
